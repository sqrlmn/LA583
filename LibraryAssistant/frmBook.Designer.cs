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
            this.lblBookDetails = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addtoCart = new System.Windows.Forms.Button();
            this.lblISBNBook = new System.Windows.Forms.Label();
            this.lblPageCountBook = new System.Windows.Forms.Label();
            this.lblAuthorBook = new System.Windows.Forms.Label();
            this.lblQuantityBook = new System.Windows.Forms.Label();
            this.lblSubjectBook = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBookDetails
            // 
            this.lblBookDetails.AutoSize = true;
            this.lblBookDetails.Location = new System.Drawing.Point(250, 9);
            this.lblBookDetails.Name = "lblBookDetails";
            this.lblBookDetails.Size = new System.Drawing.Size(254, 25);
            this.lblBookDetails.TabIndex = 1;
            this.lblBookDetails.Text = "Book Details/Reservation";
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
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(12, 134);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(60, 25);
            this.lblISBN.TabIndex = 4;
            this.lblISBN.Text = "ISBN";
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(94, 134);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(125, 25);
            this.lblPageCount.TabIndex = 5;
            this.lblPageCount.Text = "Page Count";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(264, 134);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(75, 25);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(402, 134);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(92, 25);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(546, 134);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(84, 25);
            this.lblSubject.TabIndex = 9;
            this.lblSubject.Text = "Subject";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(692, 134);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(74, 25);
            this.lblRating.TabIndex = 10;
            this.lblRating.Text = "Rating";
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
            this.comboBox1.Location = new System.Drawing.Point(696, 195);
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
            // lblISBNBook
            // 
            this.lblISBNBook.AutoSize = true;
            this.lblISBNBook.Location = new System.Drawing.Point(17, 195);
            this.lblISBNBook.Name = "lblISBNBook";
            this.lblISBNBook.Size = new System.Drawing.Size(80, 25);
            this.lblISBNBook.TabIndex = 15;
            this.lblISBNBook.Text = "Default";
            // 
            // lblPageCountBook
            // 
            this.lblPageCountBook.AutoSize = true;
            this.lblPageCountBook.Location = new System.Drawing.Point(99, 195);
            this.lblPageCountBook.Name = "lblPageCountBook";
            this.lblPageCountBook.Size = new System.Drawing.Size(70, 25);
            this.lblPageCountBook.TabIndex = 16;
            this.lblPageCountBook.Text = "label1";
            // 
            // lblAuthorBook
            // 
            this.lblAuthorBook.AutoSize = true;
            this.lblAuthorBook.Location = new System.Drawing.Point(269, 194);
            this.lblAuthorBook.Name = "lblAuthorBook";
            this.lblAuthorBook.Size = new System.Drawing.Size(70, 25);
            this.lblAuthorBook.TabIndex = 17;
            this.lblAuthorBook.Text = "label1";
            // 
            // lblQuantityBook
            // 
            this.lblQuantityBook.AutoSize = true;
            this.lblQuantityBook.Location = new System.Drawing.Point(407, 194);
            this.lblQuantityBook.Name = "lblQuantityBook";
            this.lblQuantityBook.Size = new System.Drawing.Size(70, 25);
            this.lblQuantityBook.TabIndex = 18;
            this.lblQuantityBook.Text = "label1";
            // 
            // lblSubjectBook
            // 
            this.lblSubjectBook.AutoSize = true;
            this.lblSubjectBook.Location = new System.Drawing.Point(551, 193);
            this.lblSubjectBook.Name = "lblSubjectBook";
            this.lblSubjectBook.Size = new System.Drawing.Size(70, 25);
            this.lblSubjectBook.TabIndex = 19;
            this.lblSubjectBook.Text = "label1";
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSubjectBook);
            this.Controls.Add(this.lblQuantityBook);
            this.Controls.Add(this.lblAuthorBook);
            this.Controls.Add(this.lblPageCountBook);
            this.Controls.Add(this.lblISBNBook);
            this.Controls.Add(this.addtoCart);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.lblBookDetails);
            this.Name = "frmBook";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookDetails;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addtoCart;
        private System.Windows.Forms.Label lblISBNBook;
        private System.Windows.Forms.Label lblPageCountBook;
        private System.Windows.Forms.Label lblAuthorBook;
        private System.Windows.Forms.Label lblQuantityBook;
        private System.Windows.Forms.Label lblSubjectBook;
    }
}