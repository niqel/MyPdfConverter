namespace PDFConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.lblUbicacionLeerEn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnGuardarEn = new System.Windows.Forms.Button();
            this.lblUbicacionGuardarEn = new System.Windows.Forms.Label();
            this.txtNombreArchivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAbrirUbicacion = new System.Windows.Forms.Button();
            this.dtgvPages = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPages)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "PDF to";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 59);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(574, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Instrucciones: Presione el boton examinar para seleccionar el archivo PDF a comve" +
    "rtir.";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(646, 94);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(94, 29);
            this.btnExaminar.TabIndex = 3;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // lblUbicacionLeerEn
            // 
            this.lblUbicacionLeerEn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUbicacionLeerEn.ForeColor = System.Drawing.Color.Gray;
            this.lblUbicacionLeerEn.Location = new System.Drawing.Point(166, 126);
            this.lblUbicacionLeerEn.Name = "lblUbicacionLeerEn";
            this.lblUbicacionLeerEn.Size = new System.Drawing.Size(574, 25);
            this.lblUbicacionLeerEn.TabIndex = 4;
            this.lblUbicacionLeerEn.Text = "Ubicación del archivo";
            this.lblUbicacionLeerEn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Seleccione en el control el formato a convertir.";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(579, 258);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(576, 294);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(164, 29);
            this.btnConvertir.TabIndex = 12;
            this.btnConvertir.Text = "Obtener Paginas";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnGuardarEn
            // 
            this.btnGuardarEn.Location = new System.Drawing.Point(646, 154);
            this.btnGuardarEn.Name = "btnGuardarEn";
            this.btnGuardarEn.Size = new System.Drawing.Size(94, 29);
            this.btnGuardarEn.TabIndex = 13;
            this.btnGuardarEn.Text = "Guardar En";
            this.btnGuardarEn.UseVisualStyleBackColor = true;
            this.btnGuardarEn.Click += new System.EventHandler(this.btnGuardarEn_Click);
            // 
            // lblUbicacionGuardarEn
            // 
            this.lblUbicacionGuardarEn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUbicacionGuardarEn.ForeColor = System.Drawing.Color.Gray;
            this.lblUbicacionGuardarEn.Location = new System.Drawing.Point(166, 186);
            this.lblUbicacionGuardarEn.Name = "lblUbicacionGuardarEn";
            this.lblUbicacionGuardarEn.Size = new System.Drawing.Size(574, 25);
            this.lblUbicacionGuardarEn.TabIndex = 14;
            this.lblUbicacionGuardarEn.Text = "Ubicación del archivo";
            this.lblUbicacionGuardarEn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreArchivo
            // 
            this.txtNombreArchivo.Location = new System.Drawing.Point(579, 225);
            this.txtNombreArchivo.Name = "txtNombreArchivo";
            this.txtNombreArchivo.Size = new System.Drawing.Size(161, 27);
            this.txtNombreArchivo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre del nuevo archivo.";
            // 
            // btnAbrirUbicacion
            // 
            this.btnAbrirUbicacion.Location = new System.Drawing.Point(609, 491);
            this.btnAbrirUbicacion.Name = "btnAbrirUbicacion";
            this.btnAbrirUbicacion.Size = new System.Drawing.Size(131, 29);
            this.btnAbrirUbicacion.TabIndex = 17;
            this.btnAbrirUbicacion.Text = "Abrir Ubicacion";
            this.btnAbrirUbicacion.UseVisualStyleBackColor = true;
            this.btnAbrirUbicacion.Click += new System.EventHandler(this.btnAbrirUbicacion_Click);
            // 
            // dtgvPages
            // 
            this.dtgvPages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPages.Location = new System.Drawing.Point(15, 294);
            this.dtgvPages.Name = "dtgvPages";
            this.dtgvPages.RowHeadersWidth = 51;
            this.dtgvPages.RowTemplate.Height = 29;
            this.dtgvPages.Size = new System.Drawing.Size(555, 188);
            this.dtgvPages.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 532);
            this.Controls.Add(this.dtgvPages);
            this.Controls.Add(this.btnAbrirUbicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreArchivo);
            this.Controls.Add(this.lblUbicacionGuardarEn);
            this.Controls.Add(this.btnGuardarEn);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUbicacionLeerEn);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button btnExaminar;
        private Label lblUbicacionLeerEn;
        private Label label4;
        private ComboBox comboBox1;
        private ListBox lstPages;
        private Button btnConvertir;
        private Button btnGuardarEn;
        private Label lblUbicacionGuardarEn;
        private TextBox txtNombreArchivo;
        private Label label3;
        private Button btnAbrirUbicacion;
        private DataGridView dtgvPages;
    }
}