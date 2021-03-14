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
            this.btBookReserve = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addtoCart = new System.Windows.Forms.Button();
            this.lblBookISBN = new System.Windows.Forms.Label();
            this.lblBookPages = new System.Windows.Forms.Label();
            this.lblBoothAuthor = new System.Windows.Forms.Label();
            this.lblBookQuantity = new System.Windows.Forms.Label();
            this.lblBookSubject = new System.Windows.Forms.Label();
            this.lblBookRating = new System.Windows.Forms.Label();
            this.ratebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Details/Reservation";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(167, 41);
            this.lblBookTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(35, 17);
            this.lblBookTitle.TabIndex = 3;
            this.lblBookTitle.Text = "Title";
            // 
            // lblISBNBook
            // 
            this.lblISBNBook.AutoSize = true;
            this.lblISBNBook.Location = new System.Drawing.Point(8, 86);
            this.lblISBNBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISBNBook.Name = "lblISBNBook";
            this.lblISBNBook.Size = new System.Drawing.Size(39, 17);
            this.lblISBNBook.TabIndex = 4;
            this.lblISBNBook.Text = "ISBN";
            // 
            // lblPageCountBook
            // 
            this.lblPageCountBook.AutoSize = true;
            this.lblPageCountBook.Location = new System.Drawing.Point(63, 86);
            this.lblPageCountBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPageCountBook.Name = "lblPageCountBook";
            this.lblPageCountBook.Size = new System.Drawing.Size(82, 17);
            this.lblPageCountBook.TabIndex = 5;
            this.lblPageCountBook.Text = "Page Count";
            // 
            // lblAuthorBook
            // 
            this.lblAuthorBook.AutoSize = true;
            this.lblAuthorBook.Location = new System.Drawing.Point(176, 86);
            this.lblAuthorBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthorBook.Name = "lblAuthorBook";
            this.lblAuthorBook.Size = new System.Drawing.Size(50, 17);
            this.lblAuthorBook.TabIndex = 6;
            this.lblAuthorBook.Text = "Author";
            // 
            // lblQuantityBook
            // 
            this.lblQuantityBook.AutoSize = true;
            this.lblQuantityBook.Location = new System.Drawing.Point(268, 86);
            this.lblQuantityBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantityBook.Name = "lblQuantityBook";
            this.lblQuantityBook.Size = new System.Drawing.Size(61, 17);
            this.lblQuantityBook.TabIndex = 7;
            this.lblQuantityBook.Text = "Quantity";
            // 
            // lblSubjectBook
            // 
            this.lblSubjectBook.AutoSize = true;
            this.lblSubjectBook.Location = new System.Drawing.Point(364, 86);
            this.lblSubjectBook.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubjectBook.Name = "lblSubjectBook";
            this.lblSubjectBook.Size = new System.Drawing.Size(55, 17);
            this.lblSubjectBook.TabIndex = 9;
            this.lblSubjectBook.Text = "Subject";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 86);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Rating";
            // 
            // btBookReserve
            // 
            this.btBookReserve.Location = new System.Drawing.Point(98, 241);
            this.btBookReserve.Margin = new System.Windows.Forms.Padding(2);
            this.btBookReserve.Name = "btBookReserve";
            this.btBookReserve.Size = new System.Drawing.Size(166, 36);
            this.btBookReserve.TabIndex = 12;
            this.btBookReserve.Text = "Reserve Book";
            this.btBookReserve.UseVisualStyleBackColor = true;
            this.btBookReserve.Click += new System.EventHandler(this.btBookReserve_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(373, 174);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(46, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // addtoCart
            // 
            this.addtoCart.Location = new System.Drawing.Point(287, 241);
            this.addtoCart.Margin = new System.Windows.Forms.Padding(2);
            this.addtoCart.Name = "addtoCart";
            this.addtoCart.Size = new System.Drawing.Size(166, 36);
            this.addtoCart.TabIndex = 14;
            this.addtoCart.Text = "Add to Cart";
            this.addtoCart.UseVisualStyleBackColor = true;
            this.addtoCart.Click += new System.EventHandler(this.addtoCart_Click);
            // 
            // lblBookISBN
            // 
            this.lblBookISBN.AutoSize = true;
            this.lblBookISBN.Location = new System.Drawing.Point(9, 118);
            this.lblBookISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookISBN.Name = "lblBookISBN";
            this.lblBookISBN.Size = new System.Drawing.Size(46, 17);
            this.lblBookISBN.TabIndex = 15;
            this.lblBookISBN.Text = "label2";
            // 
            // lblBookPages
            // 
            this.lblBookPages.AutoSize = true;
            this.lblBookPages.Location = new System.Drawing.Point(83, 118);
            this.lblBookPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookPages.Name = "lblBookPages";
            this.lblBookPages.Size = new System.Drawing.Size(46, 17);
            this.lblBookPages.TabIndex = 16;
            this.lblBookPages.Text = "label2";
            // 
            // lblBoothAuthor
            // 
            this.lblBoothAuthor.AutoSize = true;
            this.lblBoothAuthor.Location = new System.Drawing.Point(176, 118);
            this.lblBoothAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBoothAuthor.Name = "lblBoothAuthor";
            this.lblBoothAuthor.Size = new System.Drawing.Size(46, 17);
            this.lblBoothAuthor.TabIndex = 17;
            this.lblBoothAuthor.Text = "label2";
            // 
            // lblBookQuantity
            // 
            this.lblBookQuantity.AutoSize = true;
            this.lblBookQuantity.Location = new System.Drawing.Point(271, 118);
            this.lblBookQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookQuantity.Name = "lblBookQuantity";
            this.lblBookQuantity.Size = new System.Drawing.Size(46, 17);
            this.lblBookQuantity.TabIndex = 18;
            this.lblBookQuantity.Text = "label2";
            // 
            // lblBookSubject
            // 
            this.lblBookSubject.AutoSize = true;
            this.lblBookSubject.Location = new System.Drawing.Point(367, 118);
            this.lblBookSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookSubject.Name = "lblBookSubject";
            this.lblBookSubject.Size = new System.Drawing.Size(46, 17);
            this.lblBookSubject.TabIndex = 19;
            this.lblBookSubject.Text = "label2";
            // 
            // lblBookRating
            // 
            this.lblBookRating.AutoSize = true;
            this.lblBookRating.Location = new System.Drawing.Point(461, 118);
            this.lblBookRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookRating.Name = "lblBookRating";
            this.lblBookRating.Size = new System.Drawing.Size(46, 17);
            this.lblBookRating.TabIndex = 20;
            this.lblBookRating.Text = "label2";
            // 
            // ratebtn
            // 
            this.ratebtn.Location = new System.Drawing.Point(435, 174);
            this.ratebtn.Name = "ratebtn";
            this.ratebtn.Size = new System.Drawing.Size(75, 23);
            this.ratebtn.TabIndex = 21;
            this.ratebtn.Text = "Rate";
            this.ratebtn.UseVisualStyleBackColor = true;
            this.ratebtn.Click += new System.EventHandler(this.ratebtn_Click_1);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 288);
            this.Controls.Add(this.ratebtn);
            this.Controls.Add(this.lblBookRating);
            this.Controls.Add(this.lblBookSubject);
            this.Controls.Add(this.lblBookQuantity);
            this.Controls.Add(this.lblBoothAuthor);
            this.Controls.Add(this.lblBookPages);
            this.Controls.Add(this.lblBookISBN);
            this.Controls.Add(this.addtoCart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btBookReserve);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblSubjectBook);
            this.Controls.Add(this.lblQuantityBook);
            this.Controls.Add(this.lblAuthorBook);
            this.Controls.Add(this.lblPageCountBook);
            this.Controls.Add(this.lblISBNBook);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btBookReserve;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addtoCart;
        private System.Windows.Forms.Label lblBookISBN;
        private System.Windows.Forms.Label lblBookPages;
        private System.Windows.Forms.Label lblBoothAuthor;
        private System.Windows.Forms.Label lblBookQuantity;
        private System.Windows.Forms.Label lblBookSubject;
        private System.Windows.Forms.Label lblBookRating;
        private System.Windows.Forms.Button ratebtn;
    }
}