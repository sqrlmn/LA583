namespace LibraryAssistant
{
    partial class frmBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblISBNBook = new System.Windows.Forms.Label();
            this.lblPageCountBook = new System.Windows.Forms.Label();
            this.lblAuthorBook = new System.Windows.Forms.Label();
            this.lblQuantityBook = new System.Windows.Forms.Label();
            this.lblSubjectBook = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addtoCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Details/Reservation";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(250, 64);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(53, 25);
            this.lblBookTitle.TabIndex = 3;
            this.lblBookTitle.Text = "Title";
            // 
            // lblISBNBook
            // 
            this.lblISBNBook.AutoSize = true;
            this.lblISBNBook.Location = new System.Drawing.Point(12, 134);
            this.lblISBNBook.Name = "lblISBNBook";
            this.lblISBNBook.Size = new System.Drawing.Size(60, 25);
            this.lblISBNBook.TabIndex = 4;
            this.lblISBNBook.Text = "ISBN";
            // 
            // lblPageCountBook
            // 
            this.lblPageCountBook.AutoSize = true;
            this.lblPageCountBook.Location = new System.Drawing.Point(94, 134);
            this.lblPageCountBook.Name = "lblPageCountBook";
            this.lblPageCountBook.Size = new System.Drawing.Size(125, 25);
            this.lblPageCountBook.TabIndex = 5;
            this.lblPageCountBook.Text = "Page Count";
            // 
            // lblAuthorBook
            // 
            this.lblAuthorBook.AutoSize = true;
            this.lblAuthorBook.Location = new System.Drawing.Point(264, 134);
            this.lblAuthorBook.Name = "lblAuthorBook";
            this.lblAuthorBook.Size = new System.Drawing.Size(75, 25);
            this.lblAuthorBook.TabIndex = 6;
            this.lblAuthorBook.Text = "Author";
            // 
            // lblQuantityBook
            // 
            this.lblQuantityBook.AutoSize = true;
            this.lblQuantityBook.Location = new System.Drawing.Point(402, 134);
            this.lblQuantityBook.Name = "lblQuantityBook";
            this.lblQuantityBook.Size = new System.Drawing.Size(92, 25);
            this.lblQuantityBook.TabIndex = 7;
            this.lblQuantityBook.Text = "Quantity";
            // 
            // lblSubjectBook
            // 
            this.lblSubjectBook.AutoSize = true;
            this.lblSubjectBook.Location = new System.Drawing.Point(546, 134);
            this.lblSubjectBook.Name = "lblSubjectBook";
            this.lblSubjectBook.Size = new System.Drawing.Size(84, 25);
            this.lblSubjectBook.TabIndex = 9;
            this.lblSubjectBook.Text = "Subject";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(692, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Rating";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 56);
            this.button1.TabIndex = 12;
            this.button1.Text = "Reserve Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(696, 252);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 33);
            this.comboBox1.TabIndex = 13;
            // 
            // addtoCart
            // 
            this.addtoCart.Location = new System.Drawing.Point(430, 377);
            this.addtoCart.Name = "addtoCart";
            this.addtoCart.Size = new System.Drawing.Size(249, 56);
            this.addtoCart.TabIndex = 14;
            this.addtoCart.Text = "Add to Cart";
            this.addtoCart.UseVisualStyleBackColor = true;
            this.addtoCart.Click += new System.EventHandler(this.addtoCart_Click);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addtoCart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSubjectBook);
            this.Controls.Add(this.lblQuantityBook);
            this.Controls.Add(this.lblAuthorBook);
            this.Controls.Add(this.lblPageCountBook);
            this.Controls.Add(this.lblISBNBook);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.label1);
            this.Name = "frmBook";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblISBNBook;
        private System.Windows.Forms.Label lblPageCountBook;
        private System.Windows.Forms.Label lblAuthorBook;
        private System.Windows.Forms.Label lblQuantityBook;
        private System.Windows.Forms.Label lblSubjectBook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addtoCart;
    }
}