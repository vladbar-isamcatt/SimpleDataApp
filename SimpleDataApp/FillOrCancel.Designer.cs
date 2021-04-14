
namespace SimpleDataApp
{
	partial class FillOrCancel
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
			this.labelOrderID = new System.Windows.Forms.Label();
			this.labelDate = new System.Windows.Forms.Label();
			this.txtOrderID = new System.Windows.Forms.TextBox();
			this.btnFindByOrderID = new System.Windows.Forms.Button();
			this.btnCancelOrder = new System.Windows.Forms.Button();
			this.btnFillorder = new System.Windows.Forms.Button();
			this.btnFinishUpdates = new System.Windows.Forms.Button();
			this.dtpFillDate = new System.Windows.Forms.DateTimePicker();
			this.dgvCustomerOrders = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// labelOrderID
			// 
			this.labelOrderID.AutoSize = true;
			this.labelOrderID.Location = new System.Drawing.Point(12, 9);
			this.labelOrderID.Name = "labelOrderID";
			this.labelOrderID.Size = new System.Drawing.Size(134, 15);
			this.labelOrderID.TabIndex = 0;
			this.labelOrderID.Text = "Идентификатор заказа:";
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(12, 46);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(278, 15);
			this.labelDate.TabIndex = 1;
			this.labelDate.Text = "При заполнении заказа укажите дату заполнения";
			// 
			// txtOrderID
			// 
			this.txtOrderID.Location = new System.Drawing.Point(152, 6);
			this.txtOrderID.Name = "txtOrderID";
			this.txtOrderID.Size = new System.Drawing.Size(179, 23);
			this.txtOrderID.TabIndex = 2;
			// 
			// btnFindByOrderID
			// 
			this.btnFindByOrderID.Location = new System.Drawing.Point(337, 6);
			this.btnFindByOrderID.Name = "btnFindByOrderID";
			this.btnFindByOrderID.Size = new System.Drawing.Size(80, 23);
			this.btnFindByOrderID.TabIndex = 3;
			this.btnFindByOrderID.Text = "Найти заказ";
			this.btnFindByOrderID.UseVisualStyleBackColor = true;
			// 
			// btnCancelOrder
			// 
			this.btnCancelOrder.Location = new System.Drawing.Point(12, 233);
			this.btnCancelOrder.Name = "btnCancelOrder";
			this.btnCancelOrder.Size = new System.Drawing.Size(101, 23);
			this.btnCancelOrder.TabIndex = 4;
			this.btnCancelOrder.Text = "Отменить заказ";
			this.btnCancelOrder.UseVisualStyleBackColor = true;
			// 
			// btnFillorder
			// 
			this.btnFillorder.Location = new System.Drawing.Point(119, 233);
			this.btnFillorder.Name = "btnFillorder";
			this.btnFillorder.Size = new System.Drawing.Size(109, 23);
			this.btnFillorder.TabIndex = 5;
			this.btnFillorder.Text = "Заполнить заказ";
			this.btnFillorder.UseVisualStyleBackColor = true;
			// 
			// btnFinishUpdates
			// 
			this.btnFinishUpdates.Location = new System.Drawing.Point(342, 233);
			this.btnFinishUpdates.Name = "btnFinishUpdates";
			this.btnFinishUpdates.Size = new System.Drawing.Size(75, 23);
			this.btnFinishUpdates.TabIndex = 6;
			this.btnFinishUpdates.Text = "Готово";
			this.btnFinishUpdates.UseVisualStyleBackColor = true;
			// 
			// dtpFillDate
			// 
			this.dtpFillDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFillDate.Location = new System.Drawing.Point(296, 40);
			this.dtpFillDate.Name = "dtpFillDate";
			this.dtpFillDate.Size = new System.Drawing.Size(121, 23);
			this.dtpFillDate.TabIndex = 7;
			// 
			// dgvCustomerOrders
			// 
			this.dgvCustomerOrders.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvCustomerOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomerOrders.Location = new System.Drawing.Point(12, 77);
			this.dgvCustomerOrders.Name = "dgvCustomerOrders";
			this.dgvCustomerOrders.ReadOnly = true;
			this.dgvCustomerOrders.RowHeadersVisible = false;
			this.dgvCustomerOrders.RowTemplate.Height = 25;
			this.dgvCustomerOrders.Size = new System.Drawing.Size(405, 150);
			this.dgvCustomerOrders.TabIndex = 8;
			// 
			// FillOrCancel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 268);
			this.Controls.Add(this.dgvCustomerOrders);
			this.Controls.Add(this.dtpFillDate);
			this.Controls.Add(this.btnFinishUpdates);
			this.Controls.Add(this.btnFillorder);
			this.Controls.Add(this.btnCancelOrder);
			this.Controls.Add(this.btnFindByOrderID);
			this.Controls.Add(this.txtOrderID);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.labelOrderID);
			this.Name = "FillOrCancel";
			this.Text = "Заполнение или отмена заказов";
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomerOrders)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelOrderID;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.TextBox txtOrderID;
		private System.Windows.Forms.Button btnFindByOrderID;
		private System.Windows.Forms.Button btnCancelOrder;
		private System.Windows.Forms.Button btnFillorder;
		private System.Windows.Forms.Button btnFinishUpdates;
		private System.Windows.Forms.DateTimePicker dtpFillDate;
		private System.Windows.Forms.DataGridView dgvCustomerOrders;
	}
}