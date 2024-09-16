namespace biblioteca
{
    partial class Books
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbState = new ComboBox();
            txtTitle = new TextBox();
            txtGender = new TextBox();
            txtAuthor = new TextBox();
            dgvListBooks = new DataGridView();
            bookControllerBindingSource = new BindingSource(components);
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSelect = new Button();
            btnOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookControllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(309, 29);
            label1.Name = "label1";
            label1.Size = new Size(176, 31);
            label1.TabIndex = 0;
            label1.Text = "Registrar libros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 1;
            label2.Text = "Titulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 167);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(405, 116);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 3;
            label4.Text = "Genero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 167);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Autor";
            // 
            // cmbState
            // 
            cmbState.FormattingEnabled = true;
            cmbState.Location = new Point(503, 164);
            cmbState.Name = "cmbState";
            cmbState.Size = new Size(243, 28);
            cmbState.TabIndex = 5;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(86, 109);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(294, 27);
            txtTitle.TabIndex = 6;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(503, 109);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(243, 27);
            txtGender.TabIndex = 7;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(86, 160);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(294, 27);
            txtAuthor.TabIndex = 8;
            // 
            // dgvListBooks
            // 
            dgvListBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListBooks.Location = new Point(12, 267);
            dgvListBooks.Name = "dgvListBooks";
            dgvListBooks.RowHeadersWidth = 51;
            dgvListBooks.Size = new Size(798, 336);
            dgvListBooks.TabIndex = 9;
            dgvListBooks.CellContentClick += dgvListBooks_CellContentClick;
            // 
            // bookControllerBindingSource
            // 
            bookControllerBindingSource.DataSource = typeof(Controllers.BookController);
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 218);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(320, 218);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(172, 218);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(697, 218);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(113, 29);
            btnSelect.TabIndex = 13;
            btnSelect.Text = "Seleccionar";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(691, 29);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(119, 29);
            btnOut.TabIndex = 14;
            btnOut.Text = "Regresar";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 615);
            Controls.Add(btnOut);
            Controls.Add(btnSelect);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvListBooks);
            Controls.Add(txtAuthor);
            Controls.Add(txtGender);
            Controls.Add(txtTitle);
            Controls.Add(cmbState);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Books";
            Text = "Books";
            Load += Books_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookControllerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbState;
        private TextBox txtTitle;
        private TextBox txtGender;
        private TextBox txtAuthor;
        private DataGridView dgvListBooks;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSelect;
        private Button btnOut;
        private BindingSource bookControllerBindingSource;
    }
}