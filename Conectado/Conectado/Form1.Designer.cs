namespace Conectado
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
            this.btnVer = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnCantidad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.mtbDNI = new System.Windows.Forms.MaskedTextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxApe = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.numID = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numID)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(44, 46);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 0;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(44, 75);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 1;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(44, 17);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(75, 23);
            this.btnUltimo.TabIndex = 2;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnCantidad
            // 
            this.btnCantidad.Location = new System.Drawing.Point(44, 107);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(75, 39);
            this.btnCantidad.TabIndex = 3;
            this.btnCantidad.Text = "Cantidad de registro";
            this.btnCantidad.UseVisualStyleBackColor = true;
            this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Id";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(44, 152);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 45);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostrar Primero";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // mtbDNI
            // 
            this.mtbDNI.Location = new System.Drawing.Point(227, 115);
            this.mtbDNI.Mask = "99999999";
            this.mtbDNI.Name = "mtbDNI";
            this.mtbDNI.Size = new System.Drawing.Size(100, 20);
            this.mtbDNI.TabIndex = 11;
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(227, 57);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(100, 20);
            this.tbxNom.TabIndex = 12;
            // 
            // tbxApe
            // 
            this.tbxApe.Location = new System.Drawing.Point(227, 84);
            this.tbxApe.Name = "tbxApe";
            this.tbxApe.Size = new System.Drawing.Size(100, 20);
            this.tbxApe.TabIndex = 13;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(227, 145);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxEmail.TabIndex = 14;
            // 
            // numID
            // 
            this.numID.Location = new System.Drawing.Point(227, 25);
            this.numID.Name = "numID";
            this.numID.Size = new System.Drawing.Size(120, 20);
            this.numID.TabIndex = 15;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(227, 172);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 17;
            this.button1.Text = "Mostrar Ultimo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(44, 251);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(75, 54);
            this.btnMostrarTodos.TabIndex = 18;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 317);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.numID);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxApe);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.mtbDNI);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCantidad);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnVer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clase 1-09/03/2915-Ambiente Conectado";
            ((System.ComponentModel.ISupportInitialize)(this.numID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.MaskedTextBox mtbDNI;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxApe;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.NumericUpDown numID;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMostrarTodos;
    }
}

