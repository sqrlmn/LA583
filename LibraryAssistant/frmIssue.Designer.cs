namespace LibraryAssistant
{
    partial class frmIssue
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
            this.dgvIssue = new System.Windows.Forms.DataGridView();
            this.btnIssue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssue)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIssue
            // 
            this.dgvIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssue.Location = new System.Drawing.Point(12, 12);
            this.dgvIssue.Name = "dgvIssue";
            this.dgvIssue.RowHeadersWidth = 82;
            this.dgvIssue.RowTemplate.Height = 33;
            this.dgvIssue.Size = new System.Drawing.Size(614, 426);
            this.dgvIssue.TabIndex = 0;
            this.dgvIssue.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvIssue_CellMouseClick);
            // 
            // btnIssue
            // 
            this.btnIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(659, 372);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(129, 66);
            this.btnIssue.TabIndex = 1;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // frmIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.dgvIssue);
            this.Name = "frmIssue";
            this.Text = "Issue Book";
            this.Load += new System.EventHandler(this.frmIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIssue;
        private System.Windows.Forms.Button btnIssue;
    }
}