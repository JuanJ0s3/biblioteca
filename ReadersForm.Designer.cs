namespace biblioteca
{
    partial class ReadersForm
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
            btnSelect = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            dgvListReaders = new DataGridView();
            txtIdNumber = new TextBox();
            txtPhone = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListReaders).BeginInit();
            SuspendLayout();
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(746, 208);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(113, 29);
            btnSelect.TabIndex = 49;
            btnSelect.Text = "Seleccionar";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(171, 208);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 29);
            btnUpdate.TabIndex = 48;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(11, 208);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 29);
            btnAdd.TabIndex = 47;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvListReaders
            // 
            dgvListReaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListReaders.Location = new Point(11, 257);
            dgvListReaders.Name = "dgvListReaders";
            dgvListReaders.RowHeadersWidth = 51;
            dgvListReaders.Size = new Size(848, 336);
            dgvListReaders.TabIndex = 46;
            // 
            // txtIdNumber
            // 
            txtIdNumber.Location = new Point(196, 150);
            txtIdNumber.Name = "txtIdNumber";
            txtIdNumber.Size = new Size(294, 27);
            txtIdNumber.TabIndex = 45;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(616, 99);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(243, 27);
            txtPhone.TabIndex = 44;
            // 
            // txtName
            // 
            txtName.Location = new Point(196, 99);
            txtName.Name = "txtName";
            txtName.Size = new Size(294, 27);
            txtName.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 157);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 42;
            label5.Text = "Numero identificacion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(532, 106);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 41;
            label4.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 106);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 40;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 19);
            label1.Name = "label1";
            label1.Size = new Size(221, 31);
            label1.TabIndex = 39;
            label1.Text = "Registro de lectores";
            // 
            // btnOut
            // 
            btnOut.Location = new Point(746, 23);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(116, 29);
            btnOut.TabIndex = 50;
            btnOut.Text = "Regresar";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // ReadersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 658);
            Controls.Add(btnOut);
            Controls.Add(btnSelect);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvListReaders);
            Controls.Add(txtIdNumber);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReadersForm";
            Text = "ReadersForm";
            Load += ReadersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListReaders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelect;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvListReaders;
        private TextBox txtIdNumber;
        private TextBox txtPhone;
        private TextBox txtName;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnOut;
    }
}