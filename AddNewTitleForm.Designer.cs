namespace Project3
{
    partial class AddNewTitleForm
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
            txtTitle = new TextBox();
            lblTitle = new Label();
            txtCopyrightYear = new TextBox();
            lblCopyrightYear = new Label();
            txtISBN13 = new TextBox();
            lblISBN13 = new Label();
            txtLocation = new TextBox();
            numTotalCopies = new NumericUpDown();
            lblLocation = new Label();
            lblTotalCopies = new Label();
            cmbAuthors = new ComboBox();
            lblAuthors = new Label();
            btnAddTitle = new Button();
            ((System.ComponentModel.ISupportInitialize)numTotalCopies).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(150, 20);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(250, 27);
            txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(20, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(41, 20);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Title:";
            // 
            // txtCopyrightYear
            // 
            txtCopyrightYear.Location = new Point(150, 60);
            txtCopyrightYear.Name = "txtCopyrightYear";
            txtCopyrightYear.Size = new Size(250, 27);
            txtCopyrightYear.TabIndex = 2;            
            // 
            // lblCopyrightYear
            // 
            lblCopyrightYear.AutoSize = true;
            lblCopyrightYear.Location = new Point(20, 63);
            lblCopyrightYear.Name = "lblCopyrightYear";
            lblCopyrightYear.Size = new Size(109, 20);
            lblCopyrightYear.TabIndex = 3;
            lblCopyrightYear.Text = "Copyright Year:";
            // 
            // txtISBN13
            // 
            txtISBN13.Location = new Point(150, 100);
            txtISBN13.Name = "txtISBN13";
            txtISBN13.Size = new Size(250, 27);
            txtISBN13.TabIndex = 4;
            // 
            // lblISBN13
            // 
            lblISBN13.AutoSize = true;
            lblISBN13.Location = new Point(20, 103);
            lblISBN13.Name = "lblISBN13";
            lblISBN13.Size = new Size(60, 20);
            lblISBN13.TabIndex = 5;
            lblISBN13.Text = "ISBN13:";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(150, 140);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(250, 27);
            txtLocation.TabIndex = 6;
            // 
            // numTotalCopies
            // 
            numTotalCopies.Location = new Point(150, 180);
            numTotalCopies.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTotalCopies.Name = "numTotalCopies";
            numTotalCopies.Size = new Size(250, 27);
            numTotalCopies.TabIndex = 8;
            numTotalCopies.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(20, 143);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(69, 20);
            lblLocation.TabIndex = 9;
            lblLocation.Text = "Location:";
            // 
            // lblTotalCopies
            // 
            lblTotalCopies.AutoSize = true;
            lblTotalCopies.Location = new Point(20, 183);
            lblTotalCopies.Name = "lblTotalCopies";
            lblTotalCopies.Size = new Size(94, 20);
            lblTotalCopies.TabIndex = 10;
            lblTotalCopies.Tag = "";
            lblTotalCopies.Text = "Total Copies:";
            // 
            // cmbAuthors
            // 
            cmbAuthors.FormattingEnabled = true;
            cmbAuthors.Location = new Point(150, 220);
            cmbAuthors.Name = "cmbAuthors";
            cmbAuthors.Size = new Size(250, 28);
            cmbAuthors.TabIndex = 11;
            // 
            // lblAuthors
            // 
            lblAuthors.AutoSize = true;
            lblAuthors.Location = new Point(20, 223);
            lblAuthors.Name = "lblAuthors";
            lblAuthors.Size = new Size(63, 20);
            lblAuthors.TabIndex = 12;
            lblAuthors.Text = "Authors:";
            // 
            // btnAddTitle
            // 
            btnAddTitle.Location = new Point(150, 300);
            btnAddTitle.Name = "btnAddTitle";
            btnAddTitle.Size = new Size(100, 40);
            btnAddTitle.TabIndex = 13;
            btnAddTitle.Text = "Add Title";
            btnAddTitle.UseVisualStyleBackColor = true;
            // 
            // AddNewTitleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 353);
            Controls.Add(btnAddTitle);
            Controls.Add(lblAuthors);
            Controls.Add(cmbAuthors);
            Controls.Add(lblTotalCopies);
            Controls.Add(lblLocation);
            Controls.Add(numTotalCopies);
            Controls.Add(txtLocation);
            Controls.Add(lblISBN13);
            Controls.Add(txtISBN13);
            Controls.Add(lblCopyrightYear);
            Controls.Add(txtCopyrightYear);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Name = "AddNewTitleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Book Title (Libraian)";
            ((System.ComponentModel.ISupportInitialize)numTotalCopies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label lblTitle;
        private TextBox txtCopyrightYear;
        private Label lblCopyrightYear;
        private TextBox txtISBN13;
        private Label lblISBN13;
        private TextBox txtLocation;
        private NumericUpDown numTotalCopies;
        private Label lblLocation;
        private Label lblTotalCopies;
        private ComboBox cmbAuthors;
        private Label lblAuthors;
        private Button btnAddTitle;
        
    }
}
