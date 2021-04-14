
namespace SimpleDataApp
{
	partial class Navigation
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelSelectAct = new System.Windows.Forms.Label();
			this.btnGoToAdd = new System.Windows.Forms.Button();
			this.btnGoToFillOrCancel = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelSelectAct
			// 
			this.labelSelectAct.AutoSize = true;
			this.labelSelectAct.Location = new System.Drawing.Point(48, 11);
			this.labelSelectAct.Name = "labelSelectAct";
			this.labelSelectAct.Size = new System.Drawing.Size(113, 15);
			this.labelSelectAct.TabIndex = 0;
			this.labelSelectAct.Text = "Выберите действие";
			this.labelSelectAct.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnGoToAdd
			// 
			this.btnGoToAdd.Location = new System.Drawing.Point(27, 51);
			this.btnGoToAdd.Name = "btnGoToAdd";
			this.btnGoToAdd.Size = new System.Drawing.Size(157, 23);
			this.btnGoToAdd.TabIndex = 1;
			this.btnGoToAdd.Text = "Добавить учетную запись";
			this.btnGoToAdd.UseVisualStyleBackColor = true;
			this.btnGoToAdd.Click += new System.EventHandler(this.btnGoToAdd_Click);
			// 
			// btnGoToFillOrCancel
			// 
			this.btnGoToFillOrCancel.Location = new System.Drawing.Point(12, 112);
			this.btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
			this.btnGoToFillOrCancel.Size = new System.Drawing.Size(185, 23);
			this.btnGoToFillOrCancel.TabIndex = 2;
			this.btnGoToFillOrCancel.Text = "Заполнить или отменить заказ";
			this.btnGoToFillOrCancel.UseVisualStyleBackColor = true;
			this.btnGoToFillOrCancel.Click += new System.EventHandler(this.btnGoToFillOrCancel_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(66, 159);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "Выйти";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Navigation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(207, 191);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnGoToFillOrCancel);
			this.Controls.Add(this.btnGoToAdd);
			this.Controls.Add(this.labelSelectAct);
			this.Name = "Navigation";
			this.Text = "Приветствие";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelSelectAct;
		private System.Windows.Forms.Button btnGoToAdd;
		private System.Windows.Forms.Button btnGoToFillOrCancel;
		private System.Windows.Forms.Button btnExit;
	}
}

