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
            this.btnReserveBook = new System.Windows.Forms.Button();
            this.cbxRating = new System.Windows.Forms.ComboBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblBookISBN = new System.Windows.Forms.Label();
            this.lblBookPages = new System.Windows.Forms.Label();
            this.lblBoothAuthor = new System.Windows.Forms.Label();
            this.lblBookQuantity = new System.Windows.Forms.Label();
            this.lblBookSubject = new System.Windows.Forms.Label();
            this.lblBookRating = new System.Windows.Forms.Label();
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
            // btnReserveBook
            // 
            this.btnReserveBook.Location = new System.Drawing.Point(147, 377);
            this.btnReserveBook.Name = "btnReserveBook";
            this.btnReserveBook.Size = new System.Drawing.Size(249, 56);
            this.btnReserveBook.TabIndex = 12;
            this.btnReserveBook.Text = "Reserve Book";
            this.btnReserveBook.UseVisualStyleBackColor = true;
            this.btnReserveBook.Click += new System.EventHandler(this.btBookReserve_Click);
            // 
            // cbxRating
            // 
            this.cbxRating.FormattingEnabled = true;
            this.cbxRating.Location = new System.Drawing.Point(696, 252);
            this.cbxRating.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxRating.Name = "cbxRating";
            this.cbxRating.Size = new System.Drawing.Size(67, 33);
            this.cbxRating.TabIndex = 13;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(430, 377);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(249, 56);
            this.btnAddToCart.TabIndex = 14;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.addtoCart_Click);
            // 
            // lblBookISBN
            // 
            this.lblBookISBN.AutoSize = true;
            this.lblBookISBN.Location = new System.Drawing.Point(13, 185);
            this.lblBookISBN.Name = "lblBookISBN";
            this.lblBookISBN.Size = new System.Drawing.Size(70, 25);
            this.lblBookISBN.TabIndex = 15;
            this.lblBookISBN.Text = "label2";
            // 
            // lblBookPages
            // 
            this.lblBookPages.AutoSize = true;
            this.lblBookPages.Location = new System.Drawing.Point(125, 185);
            this.lblBookPages.Name = "lblBookPages";
            this.lblBookPages.Size = new System.Drawing.Size(70, 25);
            this.lblBookPages.TabIndex = 16;
            this.lblBookPages.Text = "label2";
            // 
            // lblBoothAuthor
            // 
            this.lblBoothAuthor.AutoSize = true;
            this.lblBoothAuthor.Location = new System.Drawing.Point(264, 185);
            this.lblBoothAuthor.Name = "lblBoothAuthor";
            this.lblBoothAuthor.Size = new System.Drawing.Size(70, 25);
            this.lblBoothAuthor.TabIndex = 17;
            this.lblBoothAuthor.Text = "label2";
            // 
            // lblBookQuantity
            // 
            this.lblBookQuantity.AutoSize = true;
            this.lblBookQuantity.Location = new System.Drawing.Point(407, 185);
            this.lblBookQuantity.Name = "lblBookQuantity";
            this.lblBookQuantity.Size = new System.Drawing.Size(70, 25);
            this.lblBookQuantity.TabIndex = 18;
            this.lblBookQuantity.Text = "label2";
            // 
            // lblBookSubject
            // 
            this.lblBookSubject.AutoSize = true;
            this.lblBookSubject.Location = new System.Drawing.Point(551, 185);
            this.lblBookSubject.Name = "lblBookSubject";
            this.lblBookSubject.Size = new System.Drawing.Size(70, 25);
            this.lblBookSubject.TabIndex = 19;
            this.lblBookSubject.Text = "label2";
            // 
            // lblBookRating
            // 
            this.lblBookRating.AutoSize = true;
            this.lblBookRating.Location = new System.Drawing.Point(692, 185);
            this.lblBookRating.Name = "lblBookRating";
            this.lblBookRating.Size = new System.Drawing.Size(70, 25);
            this.lblBookRating.TabIndex = 20;
            this.lblBookRating.Text = "label2";
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBookRating);
            this.Controls.Add(this.lblBookSubject);
            this.Controls.Add(this.lblBookQuantity);
            this.Controls.Add(this.lblBoothAuthor);
            this.Controls.Add(this.lblBookPages);
            this.Controls.Add(this.lblBookISBN);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.cbxRating);
            this.Controls.Add(this.btnReserveBook);
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
        private System.Windows.Forms.Button btnReserveBook;
        private System.Windows.Forms.ComboBox cbxRating;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblBookISBN;
        private System.Windows.Forms.Label lblBookPages;
        private System.Windows.Forms.Label lblBoothAuthor;
        private System.Windows.Forms.Label lblBookQuantity;
        private System.Windows.Forms.Label lblBookSubject;
        private System.Windows.Forms.Label lblBookRating;
    }
}