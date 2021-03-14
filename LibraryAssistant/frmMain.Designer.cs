namespace LibraryAssistant
{
    partial class frmMain
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
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.lblEditAccount = new System.Windows.Forms.Label();
            this.lblViewCart = new System.Windows.Forms.Label();
            this.lblBookReturn = new System.Windows.Forms.Label();
            this.checkout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.Blue;
            this.lblLogout.Location = new System.Drawing.Point(869, 6);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(72, 25);
            this.lblLogout.TabIndex = 0;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFullname.Location = new System.Drawing.Point(8, 6);
            this.lblFullname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(92, 25);
            this.lblFullname.TabIndex = 1;
            this.lblFullname.Text = "Fullname";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearch.Location = new System.Drawing.Point(57, 94);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(95, 29);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(159, 92);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(613, 34);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.ForeColor = System.Drawing.Color.Red;
            this.lblAccountType.Location = new System.Drawing.Point(8, 32);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(134, 25);
            this.lblAccountType.TabIndex = 5;
            this.lblAccountType.Text = "Account Type";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(775, 82);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 52);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(26, 163);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            this.dgvSearch.RowHeadersWidth = 82;
            this.dgvSearch.RowTemplate.Height = 33;
            this.dgvSearch.Size = new System.Drawing.Size(904, 345);
            this.dgvSearch.TabIndex = 8;
            this.dgvSearch.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearch_CellMouseClick);
            this.dgvSearch.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSearch_CellMouseDoubleClick);
            // 
            // lblEditAccount
            // 
            this.lblEditAccount.AutoSize = true;
            this.lblEditAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditAccount.ForeColor = System.Drawing.Color.Blue;
            this.lblEditAccount.Location = new System.Drawing.Point(8, 58);
            this.lblEditAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditAccount.Name = "lblEditAccount";
            this.lblEditAccount.Size = new System.Drawing.Size(45, 25);
            this.lblEditAccount.TabIndex = 9;
            this.lblEditAccount.Text = "Edit";
            this.lblEditAccount.Click += new System.EventHandler(this.lblEditAccount_Click);
            // 
            // lblViewCart
            // 
            this.lblViewCart.AutoSize = true;
            this.lblViewCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewCart.ForeColor = System.Drawing.Color.Blue;
            this.lblViewCart.Location = new System.Drawing.Point(853, 45);
            this.lblViewCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewCart.Name = "lblViewCart";
            this.lblViewCart.Size = new System.Drawing.Size(88, 25);
            this.lblViewCart.TabIndex = 10;
            this.lblViewCart.Text = "view cart";
            this.lblViewCart.Click += new System.EventHandler(this.lblViewCart_Click);
            // 
            // lblBookReturn
            // 
            this.lblBookReturn.AutoSize = true;
            this.lblBookReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookReturn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBookReturn.Location = new System.Drawing.Point(236, 12);
            this.lblBookReturn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookReturn.Name = "lblBookReturn";
            this.lblBookReturn.Size = new System.Drawing.Size(119, 25);
            this.lblBookReturn.TabIndex = 11;
            this.lblBookReturn.Text = "Book Return";
            this.lblBookReturn.Click += new System.EventHandler(this.lblBookReturn_Click);
            // 
            // checkout
            // 
            this.checkout.AutoSize = true;
            this.checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkout.Location = new System.Drawing.Point(579, 12);
            this.checkout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(91, 25);
            this.checkout.TabIndex = 12;
            this.checkout.Text = "checkout";
            this.checkout.Click += new System.EventHandler(this.checkout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 531);
            this.Controls.Add(this.checkout);
            this.Controls.Add(this.lblBookReturn);
            this.Controls.Add(this.lblViewCart);
            this.Controls.Add(this.lblEditAccount);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.lblLogout);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Library Assistant";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Label lblEditAccount;
        private System.Windows.Forms.Label lblViewCart;
        private System.Windows.Forms.Label lblBookReturn;
        private System.Windows.Forms.Label checkout;
    }
}