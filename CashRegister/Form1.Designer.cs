
namespace CashRegister
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.booksLabel = new System.Windows.Forms.Label();
            this.journalsLabel = new System.Windows.Forms.Label();
            this.bookmarksLabel = new System.Windows.Forms.Label();
            this.calculatetotalButton = new System.Windows.Forms.Button();
            this.booksInput = new System.Windows.Forms.TextBox();
            this.journalsInput = new System.Windows.Forms.TextBox();
            this.bookmarksInput = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.paidLabel = new System.Windows.Forms.Label();
            this.paidInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receipt1Output = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.receipt2Output = new System.Windows.Forms.Label();
            this.receipt3Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Plum;
            this.titleLabel.Font = new System.Drawing.Font("Malgun Gothic", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1099, 74);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "the cool book store!";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booksLabel
            // 
            this.booksLabel.AutoSize = true;
            this.booksLabel.BackColor = System.Drawing.Color.Transparent;
            this.booksLabel.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksLabel.ForeColor = System.Drawing.Color.Plum;
            this.booksLabel.Location = new System.Drawing.Point(22, 100);
            this.booksLabel.Name = "booksLabel";
            this.booksLabel.Size = new System.Drawing.Size(249, 38);
            this.booksLabel.TabIndex = 1;
            this.booksLabel.Text = "number of books";
            this.booksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // journalsLabel
            // 
            this.journalsLabel.AutoSize = true;
            this.journalsLabel.BackColor = System.Drawing.Color.Transparent;
            this.journalsLabel.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.journalsLabel.ForeColor = System.Drawing.Color.Plum;
            this.journalsLabel.Location = new System.Drawing.Point(22, 215);
            this.journalsLabel.Name = "journalsLabel";
            this.journalsLabel.Size = new System.Drawing.Size(274, 38);
            this.journalsLabel.TabIndex = 3;
            this.journalsLabel.Text = "number of journals";
            this.journalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookmarksLabel
            // 
            this.bookmarksLabel.AutoSize = true;
            this.bookmarksLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookmarksLabel.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookmarksLabel.ForeColor = System.Drawing.Color.Plum;
            this.bookmarksLabel.Location = new System.Drawing.Point(22, 159);
            this.bookmarksLabel.Name = "bookmarksLabel";
            this.bookmarksLabel.Size = new System.Drawing.Size(317, 38);
            this.bookmarksLabel.TabIndex = 4;
            this.bookmarksLabel.Text = "number of bookmarks";
            this.bookmarksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatetotalButton
            // 
            this.calculatetotalButton.BackColor = System.Drawing.Color.White;
            this.calculatetotalButton.FlatAppearance.BorderSize = 3;
            this.calculatetotalButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.calculatetotalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculatetotalButton.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatetotalButton.ForeColor = System.Drawing.Color.Plum;
            this.calculatetotalButton.Location = new System.Drawing.Point(29, 279);
            this.calculatetotalButton.Name = "calculatetotalButton";
            this.calculatetotalButton.Size = new System.Drawing.Size(447, 55);
            this.calculatetotalButton.TabIndex = 5;
            this.calculatetotalButton.Text = "CALCULATE TOTAL";
            this.calculatetotalButton.UseVisualStyleBackColor = false;
            this.calculatetotalButton.Click += new System.EventHandler(this.calculatetotalButton_Click);
            // 
            // booksInput
            // 
            this.booksInput.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksInput.Location = new System.Drawing.Point(376, 97);
            this.booksInput.Name = "booksInput";
            this.booksInput.Size = new System.Drawing.Size(100, 45);
            this.booksInput.TabIndex = 6;
            // 
            // journalsInput
            // 
            this.journalsInput.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journalsInput.Location = new System.Drawing.Point(376, 156);
            this.journalsInput.Name = "journalsInput";
            this.journalsInput.Size = new System.Drawing.Size(100, 45);
            this.journalsInput.TabIndex = 7;
            // 
            // bookmarksInput
            // 
            this.bookmarksInput.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookmarksInput.Location = new System.Drawing.Point(376, 212);
            this.bookmarksInput.Name = "bookmarksInput";
            this.bookmarksInput.Size = new System.Drawing.Size(100, 45);
            this.bookmarksInput.TabIndex = 8;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Plum;
            this.totalLabel.Location = new System.Drawing.Point(22, 461);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(79, 38);
            this.totalLabel.TabIndex = 9;
            this.totalLabel.Text = "total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxLabel.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.Plum;
            this.taxLabel.Location = new System.Drawing.Point(22, 408);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(58, 38);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "tax";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.subtotalLabel.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.Plum;
            this.subtotalLabel.Location = new System.Drawing.Point(22, 357);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(127, 38);
            this.subtotalLabel.TabIndex = 11;
            this.subtotalLabel.Text = "subtotal";
            this.subtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividerLabel
            // 
            this.dividerLabel.BackColor = System.Drawing.Color.Plum;
            this.dividerLabel.Location = new System.Drawing.Point(25, 514);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(451, 10);
            this.dividerLabel.TabIndex = 12;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.Transparent;
            this.totalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutput.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.ForeColor = System.Drawing.Color.Plum;
            this.totalOutput.Location = new System.Drawing.Point(349, 461);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(127, 38);
            this.totalOutput.TabIndex = 13;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Transparent;
            this.taxOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxOutput.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.ForeColor = System.Drawing.Color.Plum;
            this.taxOutput.Location = new System.Drawing.Point(349, 408);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(127, 38);
            this.taxOutput.TabIndex = 14;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.BackColor = System.Drawing.Color.Transparent;
            this.subtotalOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotalOutput.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.ForeColor = System.Drawing.Color.Plum;
            this.subtotalOutput.Location = new System.Drawing.Point(349, 357);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(127, 38);
            this.subtotalOutput.TabIndex = 15;
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // paidLabel
            // 
            this.paidLabel.AutoSize = true;
            this.paidLabel.BackColor = System.Drawing.Color.Transparent;
            this.paidLabel.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidLabel.ForeColor = System.Drawing.Color.Plum;
            this.paidLabel.Location = new System.Drawing.Point(22, 542);
            this.paidLabel.Name = "paidLabel";
            this.paidLabel.Size = new System.Drawing.Size(189, 38);
            this.paidLabel.TabIndex = 16;
            this.paidLabel.Text = "amount paid";
            this.paidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paidInput
            // 
            this.paidInput.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidInput.Location = new System.Drawing.Point(349, 539);
            this.paidInput.Name = "paidInput";
            this.paidInput.Size = new System.Drawing.Size(127, 45);
            this.paidInput.TabIndex = 17;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.White;
            this.changeButton.FlatAppearance.BorderSize = 3;
            this.changeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.Plum;
            this.changeButton.Location = new System.Drawing.Point(29, 600);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(447, 55);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "CALCULATE CHANGE";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.Plum;
            this.changeLabel.Location = new System.Drawing.Point(22, 677);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(113, 38);
            this.changeLabel.TabIndex = 19;
            this.changeLabel.Text = "change";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.Transparent;
            this.changeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.changeOutput.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.ForeColor = System.Drawing.Color.Plum;
            this.changeOutput.Location = new System.Drawing.Point(349, 677);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(127, 38);
            this.changeOutput.TabIndex = 20;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.White;
            this.receiptButton.FlatAppearance.BorderSize = 3;
            this.receiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.Color.Plum;
            this.receiptButton.Location = new System.Drawing.Point(29, 736);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(447, 83);
            this.receiptButton.TabIndex = 21;
            this.receiptButton.Text = "PRINT RECEIPT";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // receipt1Output
            // 
            this.receipt1Output.BackColor = System.Drawing.Color.White;
            this.receipt1Output.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt1Output.Location = new System.Drawing.Point(514, 97);
            this.receipt1Output.Name = "receipt1Output";
            this.receipt1Output.Size = new System.Drawing.Size(435, 458);
            this.receipt1Output.TabIndex = 22;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.FlatAppearance.BorderSize = 3;
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.resetButton.Location = new System.Drawing.Point(519, 736);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(547, 83);
            this.resetButton.TabIndex = 23;
            this.resetButton.Text = "NEW ORDER";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // receipt2Output
            // 
            this.receipt2Output.BackColor = System.Drawing.Color.White;
            this.receipt2Output.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt2Output.Location = new System.Drawing.Point(945, 97);
            this.receipt2Output.Name = "receipt2Output";
            this.receipt2Output.Size = new System.Drawing.Size(121, 458);
            this.receipt2Output.TabIndex = 24;
            this.receipt2Output.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receipt3Output
            // 
            this.receipt3Output.BackColor = System.Drawing.Color.White;
            this.receipt3Output.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt3Output.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.receipt3Output.Location = new System.Drawing.Point(514, 555);
            this.receipt3Output.Name = "receipt3Output";
            this.receipt3Output.Size = new System.Drawing.Size(552, 160);
            this.receipt3Output.TabIndex = 25;
            this.receipt3Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1098, 844);
            this.Controls.Add(this.receipt3Output);
            this.Controls.Add(this.receipt2Output);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.receipt1Output);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.paidInput);
            this.Controls.Add(this.paidLabel);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.dividerLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.bookmarksInput);
            this.Controls.Add(this.journalsInput);
            this.Controls.Add(this.booksInput);
            this.Controls.Add(this.calculatetotalButton);
            this.Controls.Add(this.bookmarksLabel);
            this.Controls.Add(this.journalsLabel);
            this.Controls.Add(this.booksLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Book Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label booksLabel;
        private System.Windows.Forms.Label journalsLabel;
        private System.Windows.Forms.Label bookmarksLabel;
        private System.Windows.Forms.Button calculatetotalButton;
        private System.Windows.Forms.TextBox booksInput;
        private System.Windows.Forms.TextBox journalsInput;
        private System.Windows.Forms.TextBox bookmarksInput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label paidLabel;
        private System.Windows.Forms.TextBox paidInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receipt1Output;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label receipt2Output;
        private System.Windows.Forms.Label receipt3Output;
    }
}

