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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.numOrderAmount = new System.Windows.Forms.NumericUpDown();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAddAnotherAccount = new System.Windows.Forms.Button();
            this.btnAddFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(126, 42);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(138, 19);
            this.txtCustomerName.TabIndex = 0;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(126, 67);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(138, 19);
            this.txtCustomerID.TabIndex = 1;
            // 
            // numOrderAmount
            // 
            this.numOrderAmount.Location = new System.Drawing.Point(126, 113);
            this.numOrderAmount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numOrderAmount.Name = "numOrderAmount";
            this.numOrderAmount.Size = new System.Drawing.Size(138, 19);
            this.numOrderAmount.TabIndex = 2;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(126, 138);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(138, 19);
            this.dtpOrderDate.TabIndex = 3;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(324, 37);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(134, 23);
            this.btnCreateAccount.TabIndex = 4;
            this.btnCreateAccount.Text = "アカウントの作成";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(324, 113);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(134, 23);
            this.btnPlaceOrder.TabIndex = 5;
            this.btnPlaceOrder.Text = "注文する";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // btnAddAnotherAccount
            // 
            this.btnAddAnotherAccount.Location = new System.Drawing.Point(324, 186);
            this.btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            this.btnAddAnotherAccount.Size = new System.Drawing.Size(134, 23);
            this.btnAddAnotherAccount.TabIndex = 6;
            this.btnAddAnotherAccount.Text = "別アカウント追加";
            this.btnAddAnotherAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddFinish
            // 
            this.btnAddFinish.Location = new System.Drawing.Point(126, 185);
            this.btnAddFinish.Name = "btnAddFinish";
            this.btnAddFinish.Size = new System.Drawing.Size(75, 23);
            this.btnAddFinish.TabIndex = 7;
            this.btnAddFinish.Text = "完了";
            this.btnAddFinish.UseVisualStyleBackColor = true;
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 263);
            this.Controls.Add(this.btnAddFinish);
            this.Controls.Add(this.btnAddAnotherAccount);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.numOrderAmount);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "NewCustomer";
            this.Text = "新しいアカウントと注文";
            ((System.ComponentModel.ISupportInitialize)(this.numOrderAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.NumericUpDown numOrderAmount;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnAddAnotherAccount;
        private System.Windows.Forms.Button btnAddFinish;
    }
}