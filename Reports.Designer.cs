namespace biblioteca
{
    partial class Reports
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
            label1 = new Label();
            dgvReports = new DataGridView();
            btnActualState = new Button();
            btnExpirateBooks = new Button();
            btnMoreBorrowings = new Button();
            btnQuery = new Button();
            btnTittle = new Button();
            btnFillCmb = new Button();
            dgvConsult = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbFill = new ComboBox();
            cmbGender = new ComboBox();
            cmbAuthor = new ComboBox();
            btnOut = new Button();
            btnAuthor = new Button();
            btnGender = new Button();
            checkedListBox1 = new CheckedListBox();
            txtFill = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 40);
            label1.Name = "label1";
            label1.Size = new Size(108, 31);
            label1.TabIndex = 12;
            label1.Text = "Reportes";
            // 
            // dgvReports
            // 
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(24, 154);
            dgvReports.Name = "dgvReports";
            dgvReports.RowHeadersWidth = 51;
            dgvReports.Size = new Size(970, 181);
            dgvReports.TabIndex = 13;
            // 
            // btnActualState
            // 
            btnActualState.Location = new Point(14, 99);
            btnActualState.Name = "btnActualState";
            btnActualState.Size = new Size(248, 29);
            btnActualState.TabIndex = 14;
            btnActualState.Text = "Estado actual de la biblioteca";
            btnActualState.UseVisualStyleBackColor = true;
            btnActualState.Click += btnActualState_Click;
            // 
            // btnExpirateBooks
            // 
            btnExpirateBooks.Location = new Point(607, 99);
            btnExpirateBooks.Name = "btnExpirateBooks";
            btnExpirateBooks.Size = new Size(248, 29);
            btnExpirateBooks.TabIndex = 15;
            btnExpirateBooks.Text = "Libros vencidos";
            btnExpirateBooks.UseVisualStyleBackColor = true;
            btnExpirateBooks.Click += btnExpirateBooks_Click;
            // 
            // btnMoreBorrowings
            // 
            btnMoreBorrowings.Location = new Point(302, 99);
            btnMoreBorrowings.Name = "btnMoreBorrowings";
            btnMoreBorrowings.Size = new Size(248, 29);
            btnMoreBorrowings.TabIndex = 16;
            btnMoreBorrowings.Text = "Libros mas prestados";
            btnMoreBorrowings.UseVisualStyleBackColor = true;
            btnMoreBorrowings.Click += button2_Click;
            // 
            // btnQuery
            // 
            btnQuery.Location = new Point(652, 473);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(35, 29);
            btnQuery.TabIndex = 21;
            btnQuery.Text = "Ok";
            btnQuery.UseVisualStyleBackColor = true;
            btnQuery.Click += btnTitle_Click;
            // 
            // btnTittle
            // 
            btnTittle.Location = new Point(24, 417);
            btnTittle.Name = "btnTittle";
            btnTittle.Size = new Size(81, 29);
            btnTittle.TabIndex = 20;
            btnTittle.Text = "Por Titulo";
            btnTittle.UseVisualStyleBackColor = true;
            btnTittle.Click += btnGender_Click;
            // 
            // btnFillCmb
            // 
            btnFillCmb.Location = new Point(293, 469);
            btnFillCmb.Name = "btnFillCmb";
            btnFillCmb.Size = new Size(35, 29);
            btnFillCmb.TabIndex = 19;
            btnFillCmb.Text = "Ok";
            btnFillCmb.UseVisualStyleBackColor = true;
            btnFillCmb.Click += btnAuthor_Click;
            // 
            // dgvConsult
            // 
            dgvConsult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsult.Location = new Point(24, 557);
            dgvConsult.Name = "dgvConsult";
            dgvConsult.RowHeadersWidth = 51;
            dgvConsult.Size = new Size(970, 143);
            dgvConsult.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 375);
            label2.Name = "label2";
            label2.Size = new Size(217, 31);
            label2.TabIndex = 17;
            label2.Text = "Consultas de libros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 502);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 22;
            label3.Text = "Titulo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 522);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 23;
            label4.Text = "Género";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 473);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 24;
            label5.Text = "Autor";
            // 
            // cmbFill
            // 
            cmbFill.FormattingEnabled = true;
            cmbFill.Location = new Point(399, 417);
            cmbFill.Name = "cmbFill";
            cmbFill.Size = new Size(151, 28);
            cmbFill.TabIndex = 25;
            cmbFill.SelectedIndexChanged += cmbFill_SelectedIndexChanged;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(111, 518);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(151, 28);
            cmbGender.TabIndex = 26;
            // 
            // cmbAuthor
            // 
            cmbAuthor.FormattingEnabled = true;
            cmbAuthor.Location = new Point(111, 473);
            cmbAuthor.Name = "cmbAuthor";
            cmbAuthor.Size = new Size(151, 28);
            cmbAuthor.TabIndex = 27;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(883, 28);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(91, 29);
            btnOut.TabIndex = 28;
            btnOut.Text = "Regresar";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // btnAuthor
            // 
            btnAuthor.Location = new Point(148, 418);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Size = new Size(81, 29);
            btnAuthor.TabIndex = 29;
            btnAuthor.Text = "Por Autor";
            btnAuthor.UseVisualStyleBackColor = true;
            btnAuthor.Click += btnAuthor_Click_1;
            // 
            // btnGender
            // 
            btnGender.Location = new Point(264, 417);
            btnGender.Name = "btnGender";
            btnGender.Size = new Size(106, 29);
            btnGender.TabIndex = 30;
            btnGender.Text = "Por Genero";
            btnGender.UseVisualStyleBackColor = true;
            btnGender.Click += btnGender_Click_1;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Titulo", "Autor", "Genero" });
            checkedListBox1.Location = new Point(268, 452);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(150, 114);
            checkedListBox1.TabIndex = 31;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // txtFill
            // 
            txtFill.Location = new Point(503, 473);
            txtFill.Name = "txtFill";
            txtFill.Size = new Size(125, 27);
            txtFill.TabIndex = 32;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 728);
            Controls.Add(txtFill);
            Controls.Add(checkedListBox1);
            Controls.Add(btnGender);
            Controls.Add(btnAuthor);
            Controls.Add(btnOut);
            Controls.Add(cmbAuthor);
            Controls.Add(cmbGender);
            Controls.Add(cmbFill);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnQuery);
            Controls.Add(btnTittle);
            Controls.Add(btnFillCmb);
            Controls.Add(dgvConsult);
            Controls.Add(label2);
            Controls.Add(btnMoreBorrowings);
            Controls.Add(btnExpirateBooks);
            Controls.Add(btnActualState);
            Controls.Add(dgvReports);
            Controls.Add(label1);
            Name = "Reports";
            Text = "Reports";
            Load += Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvReports;
        private Button btnActualState;
        private Button btnExpirateBooks;
        private Button btnMoreBorrowings;
        private Button btnQuery;
        private Button btnTittle;
        private Button btnFillCmb;
        private DataGridView dgvConsult;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbFill;
        private ComboBox cmbGender;
        private ComboBox cmbAuthor;
        private Button btnOut;
        private Button btnAuthor;
        private Button btnGender;
        private CheckedListBox checkedListBox1;
        private TextBox txtFill;
    }
}