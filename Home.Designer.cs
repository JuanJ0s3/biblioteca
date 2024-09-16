namespace biblioteca
{
    partial class Home
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
            label2 = new Label();
            label3 = new Label();
            btnBook = new Button();
            btnUser = new Button();
            btnBorrowing = new Button();
            btnReturn = new Button();
            btnOut = new Button();
            btnReports = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 41);
            label1.TabIndex = 0;
            label1.Text = "Biblioteca Tecoc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 91);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Registros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(285, 91);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 2;
            label3.Text = "Acciones";
            // 
            // btnBook
            // 
            btnBook.Location = new Point(80, 138);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(94, 29);
            btnBook.TabIndex = 3;
            btnBook.Text = "Libros";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // btnUser
            // 
            btnUser.Location = new Point(80, 207);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(94, 29);
            btnUser.TabIndex = 4;
            btnUser.Text = "Lectores";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += btnUser_Click;
            // 
            // btnBorrowing
            // 
            btnBorrowing.Location = new Point(273, 138);
            btnBorrowing.Name = "btnBorrowing";
            btnBorrowing.Size = new Size(94, 29);
            btnBorrowing.TabIndex = 5;
            btnBorrowing.Text = "Prestamo";
            btnBorrowing.UseVisualStyleBackColor = true;
            btnBorrowing.Click += btnBorrowing_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(273, 207);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Devolucion";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(80, 318);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(94, 29);
            btnOut.TabIndex = 7;
            btnOut.Text = "Salir";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // btnReports
            // 
            btnReports.Location = new Point(80, 266);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(94, 29);
            btnReports.TabIndex = 11;
            btnReports.Text = "Reportes";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += button3_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 384);
            Controls.Add(btnReports);
            Controls.Add(btnOut);
            Controls.Add(btnReturn);
            Controls.Add(btnBorrowing);
            Controls.Add(btnUser);
            Controls.Add(btnBook);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Home";
            Text = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBook;
        private Button btnUser;
        private Button btnBorrowing;
        private Button btnReturn;
        private Button btnOut;
        private Button btnReports;
    }
}