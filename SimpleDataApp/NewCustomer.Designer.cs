
namespace SimpleDataApp
{
	partial class NewCustomer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelAddAccount = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.labelID = new System.Windows.Forms.Label();
			this.labelCreateOrder = new System.Windows.Forms.Label();
			this.labelSumOrder = new System.Windows.Forms.Label();
			this.labelDate = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.txtCustomerID = new System.Windows.Forms.TextBox();
			this.btnCreateAccount = new System.Windows.Forms.Button();
			this.btnPlaceOrder = new System.Windows.Forms.Button();
			this.btnAddFinish = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
			this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
			this.SuspendLayout();
			// 
			// labelAddAccount
			// 
			this.labelAddAccount.AutoSize = true;
			this.labelAddAccount.Location = new System.Drawing.Point(12, 11);
			this.labelAddAccount.Name = "labelAddAccount";
			this.labelAddAccount.Size = new System.Drawing.Size(163, 15);
			this.labelAddAccount.TabIndex = 0;
			this.labelAddAccount.Text = "Добавление учетной записи";
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(12, 49);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(91, 15);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "Имя заказчика:";
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(12, 92);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(144, 15);
			this.labelID.TabIndex = 2;
			this.labelID.Text = "Идентификатор клиента:";
			// 
			// labelCreateOrder
			// 
			this.labelCreateOrder.AutoSize = true;
			this.labelCreateOrder.Location = new System.Drawing.Point(12, 158);
			this.labelCreateOrder.Name = "labelCreateOrder";
			this.labelCreateOrder.Size = new System.Drawing.Size(96, 15);
			this.labelCreateOrder.TabIndex = 3;
			this.labelCreateOrder.Text = "Создание заказа";
			// 
			// labelSumOrder
			// 
			this.labelSumOrder.AutoSize = true;
			this.labelSumOrder.Location = new System.Drawing.Point(12, 195);
			this.labelSumOrder.Name = "labelSumOrder";
			this.labelSumOrder.Size = new System.Drawing.Size(85, 15);
			this.labelSumOrder.TabIndex = 4;
			this.labelSumOrder.Text = "Сумма заказа:";
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(12, 231);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(72, 15);
			this.labelDate.TabIndex = 5;
			this.labelDate.Text = "Дата заказа:";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(109, 41);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(153, 23);
			this.txtCustomerName.TabIndex = 6;
			// 
			// txtCustomerID
			// 
			this.txtCustomerID.Location = new System.Drawing.Point(162, 84);
			this.txtCustomerID.Name = "txtCustomerID";
			this.txtCustomerID.ReadOnly = true;
			this.txtCustomerID.Size = new System.Drawing.Size(100, 23);
			this.txtCustomerID.TabIndex = 7;
			// 
			// btnCreateAccount
			// 
			this.btnCreateAccount.Location = new System.Drawing.Point(281, 84);
			this.btnCreateAccount.Name = "btnCreateAccount";
			this.btnCreateAccount.Size = new System.Drawing.Size(148, 23);
			this.btnCreateAccount.TabIndex = 8;
			this.btnCreateAccount.Text = "Создать учетную запись";
			this.btnCreateAccount.UseVisualStyleBackColor = true;
			// 
			// btnPlaceOrder
			// 
			this.btnPlaceOrder.Location = new System.Drawing.Point(281, 223);
			this.btnPlaceOrder.Name = "btnPlaceOrder";
			this.btnPlaceOrder.Size = new System.Drawing.Size(148, 23);
			this.btnPlaceOrder.TabIndex = 9;
			this.btnPlaceOrder.Text = "Разместить заказ";
			this.btnPlaceOrder.UseVisualStyleBackColor = true;
			// 
			// btnAddFinish
			// 
			this.btnAddFinish.Location = new System.Drawing.Point(12, 288);
			this.btnAddFinish.Name = "btnAddFinish";
			this.btnAddFinish.Size = new System.Drawing.Size(75, 23);
			this.btnAddFinish.TabIndex = 10;
			this.btnAddFinish.Text = "Готово";
			this.btnAddFinish.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(227, 288);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(202, 23);
			this.button4.TabIndex = 11;
			this.button4.Text = "Добавить другую учетную запись";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// numOrderAmount
			// 
			this.numOrderAmount.Location = new System.Drawing.Point(103, 187);
			this.numOrderAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numOrderAmount.Name = "numOrderAmount";
			this.numOrderAmount.Size = new System.Drawing.Size(159, 23);
			this.numOrderAmount.TabIndex = 12;
			// 
			// dtpOrderDate
			// 
			this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpOrderDate.Location = new System.Drawing.Point(90, 223);
			this.dtpOrderDate.Name = "dtpOrderDate";
			this.dtpOrderDate.Size = new System.Drawing.Size(172, 23);
			this.dtpOrderDate.TabIndex = 13;
			// 
			// NewCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 328);
			this.Controls.Add(this.dtpOrderDate);
			this.Controls.Add(this.numOrderAmount);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.btnAddFinish);
			this.Controls.Add(this.btnPlaceOrder);
			this.Controls.Add(this.btnCreateAccount);
			this.Controls.Add(this.txtCustomerID);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.labelSumOrder);
			this.Controls.Add(this.labelCreateOrder);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelAddAccount);
			this.Name = "NewCustomer";
			this.Text = "Новая учетная запись и заказ";
			((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelAddAccount;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label labelCreateOrder;
		private System.Windows.Forms.Label labelSumOrder;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.TextBox txtCustomerID;
		private System.Windows.Forms.Button btnCreateAccount;
		private System.Windows.Forms.Button btnPlaceOrder;
		private System.Windows.Forms.Button btnAddFinish;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.NumericUpDown numOrderAmount;
		private System.Windows.Forms.DateTimePicker dtpOrderDate;
	}
}