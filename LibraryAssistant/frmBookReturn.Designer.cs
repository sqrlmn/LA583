namespace LibraryAssistant
{
    partial class frmBookReturn
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.txtbISBN = new System.Windows.Forms.TextBox();
            this.btnConfirmReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 69);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(258, 37);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Enter Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter ISBN:";
            // 
            // txtbUsername
            // 
            this.txtbUsername.Location = new System.Drawing.Point(298, 74);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(435, 31);
            this.txtbUsername.TabIndex = 2;
            this.txtbUsername.TextChanged += new System.EventHandler(this.txtbUsername_TextChanged);
            // 
            // txtbISBN
            // 
            this.txtbISBN.Location = new System.Drawing.Point(298, 149);
            this.txtbISBN.Name = "txtbISBN";
            this.txtbISBN.Size = new System.Drawing.Size(435, 31);
            this.txtbISBN.TabIndex = 3;
            this.txtbISBN.TextChanged += new System.EventHandler(this.txtbISBN_TextChanged);
            // 
            // btnConfirmReturn
            // 
            this.btnConfirmReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmReturn.Location = new System.Drawing.Point(298, 269);
            this.btnConfirmReturn.Name = "btnConfirmReturn";
            this.btnConfirmReturn.Size = new System.Drawing.Size(195, 88);
            this.btnConfirmReturn.TabIndex = 4;
            this.btnConfirmReturn.Text = "Confirm Return";
            this.btnConfirmReturn.UseVisualStyleBackColor = true;
            this.btnConfirmReturn.Click += new System.EventHandler(this.btnConfirmReturn_Click);
            // 
            // frmBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmReturn);
            this.Controls.Add(this.txtbISBN);
            this.Controls.Add(this.txtbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUsername);
            this.Name = "frmBookReturn";
            this.Text = "frmBookReturn";
            this.Load += new System.EventHandler(this.frmBookReturn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.TextBox txtbISBN;
        private System.Windows.Forms.Button btnConfirmReturn;
    }
}