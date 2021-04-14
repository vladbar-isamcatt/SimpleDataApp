using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SimpleDataApp
{
	public partial class NewCustomer : Form
	{
		// Хранение возвращаемых из бд значений.
		private int parsedCustomerID;
		private int orderID;

		public NewCustomer()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Проверяем текстовое поле "Имя" на пустоту.
		/// </summary>
		private bool IsCustomerNameValid()
		{
			if (txtCustomerName.Text == "")
			{
				MessageBox.Show("Пожалуйста, введите имя.");
				return false;
			}
			else
			{
				return true;
			}
		}

		/// <summary>
		/// Проверяем, предоставлены ли ID и сумма заказа.
		/// </summary>
		private bool IsOrderDataValid()
		{
			// Проверяем ID на наличие.
			if (txtCustomerID.Text == "")
			{
				MessageBox.Show("Пожалуйста, создайте учетную запись клиента перед заказом.");
				return false;
			}
			// Проверяяем, что сумма заказа не равна 0
			else if ((numOrderAmount.Value < 1))
			{
				MessageBox.Show("Пожалуйста, укажите сумму заказа.");
				return false;
			}
			else
			{
				// Заказ принят.
				return true;
			}
		}

		/// <summary>
		/// Очищаем данные с формы.
		/// </summary>
		private void ClearForm()
		{
			txtCustomerName.Clear();
			txtCustomerID.Clear();
			dtpOrderDate.Value = DateTime.Now;
			numOrderAmount.Value = 0;
			this.parsedCustomerID = 0;
		}

		private void btnCreateAccount_Click(object sender, EventArgs e)
		{
			if (IsCustomerNameValid())
			{
				// Создаем соединение.
				using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
				{
					// Создаем SqlCommand и определяем как хранимую процедуру.
					using (SqlCommand sqlCommand = new SqlCommand("Sales.uspNewCustomer", connection))
					{
						sqlCommand.CommandType = CommandType.StoredProcedure;

						// Добавляем входной параметр для хранимой процедуры и указываем, что использовать в качестве значения.
						sqlCommand.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 40));
						sqlCommand.Parameters["@CustomerName"].Value = txtCustomerName.Text;

						// Добавить выходной параметр.
						sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
						sqlCommand.Parameters["@CustomerID"].Direction = ParameterDirection.Output;

						try
						{
							connection.Open();

							// Запускаем хранимую процедуру.
							sqlCommand.ExecuteNonQuery();

							// ID клиента - значение ID из БД.
							this.parsedCustomerID = (int)sqlCommand.Parameters["@CustomerID"].Value;

							// Поместить ID клиента в текстовое поле дял чтения.
							this.txtCustomerID.Text = Convert.ToString(parsedCustomerID);
						}
						catch
						{
							MessageBox.Show("ID клиента не был возвращен. Учетная запись не может быть создана.");
						}
						finally
						{
							connection.Close();
						}
					}
				}
			}
		}

		private void btnPlaceOrder_Click(object sender, EventArgs e)
		{
			// Убеждаемся, что входные данные присутствуют.
			if (IsOrderDataValid())
			{
				// Создаем соединение.
				using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
				{
					// Создаем SqlCommand и определяем как хранимую процедуру.
					using (SqlCommand sqlCommand = new SqlCommand("Sales.uspPlaceNewOrder", connection))
					{
						sqlCommand.CommandType = CommandType.StoredProcedure;
						// Добавить входной параметр @CustomerID, полученный от uspNewCustomer.
						sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
						sqlCommand.Parameters["@CustomerID"].Value = this.parsedCustomerID;

						// Добавить входной параметр @OrderDate.
						sqlCommand.Parameters.Add(new SqlParameter("@OrderDate", SqlDbType.DateTime, 8));
						sqlCommand.Parameters["@OrderDate"].Value = dtpOrderDate.Value;

						// Добавить входной параметр @Amount.
						sqlCommand.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Int));
						sqlCommand.Parameters["@Amount"].Value = numOrderAmount.Value;

						// Добавим входной параметр @Status.
						// Для нового всегда O (открыт).
						sqlCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.Char, 1));
						sqlCommand.Parameters["@Status"].Value = "O";

						// Добавляем возвращаемое значение для хранимой процедуры - ID заказа.
						sqlCommand.Parameters.Add(new SqlParameter("@RC", SqlDbType.Int));
						sqlCommand.Parameters["@RC"].Direction = ParameterDirection.ReturnValue;

						try
						{
							// Открываем соединение.
							connection.Open();

							// Запускаем хранимую процедуру.
							sqlCommand.ExecuteNonQuery();

							// Отображаем номер заказа.
							this.orderID = (int)sqlCommand.Parameters["@RC"].Value;
							MessageBox.Show("Номер заказа " + this.orderID + " был представлен.");
						}
						catch
						{
							MessageBox.Show("Заказ не может быть размещен.");
						}
						finally
						{
							connection.Close();
						}
					}
				}
			}
		}

		private void btnAddFinish_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAddAnotherAccount_Click(object sender, EventArgs e)
		{
			this.ClearForm();
		}
	}
}
