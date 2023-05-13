namespace laboratorio_5
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
            tabControl1 = new TabControl();
            btn_asignar = new TabPage();
            button1 = new Button();
            mostra_datos = new TextBox();
            in_texto = new Label();
            tabPage2 = new TabPage();
            groupBox2 = new GroupBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            btn_cargar = new Button();
            tabPage1 = new TabPage();
            label6 = new Label();
            resultado = new TextBox();
            columna = new TextBox();
            fila = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btn_obtener = new Button();
            btn_guardar = new Button();
            groupBox3 = new GroupBox();
            f2c2 = new TextBox();
            f2c1 = new TextBox();
            f2c0 = new TextBox();
            f1c2 = new TextBox();
            f1c1 = new TextBox();
            f1c0 = new TextBox();
            f0c2 = new TextBox();
            f0c1 = new TextBox();
            f0c0 = new TextBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            btn_asignar.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(btn_asignar);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(38, 23);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(716, 393);
            tabControl1.TabIndex = 0;
            // 
            // btn_asignar
            // 
            btn_asignar.Controls.Add(button1);
            btn_asignar.Controls.Add(mostra_datos);
            btn_asignar.Controls.Add(in_texto);
            btn_asignar.Location = new Point(4, 29);
            btn_asignar.Name = "btn_asignar";
            btn_asignar.Padding = new Padding(3);
            btn_asignar.Size = new Size(708, 360);
            btn_asignar.TabIndex = 0;
            btn_asignar.Text = "ARRAY ENTERO ";
            btn_asignar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(272, 221);
            button1.Name = "button1";
            button1.Size = new Size(151, 47);
            button1.TabIndex = 2;
            button1.Text = "ASIGNAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // mostra_datos
            // 
            mostra_datos.Location = new Point(243, 158);
            mostra_datos.Name = "mostra_datos";
            mostra_datos.Size = new Size(204, 27);
            mostra_datos.TabIndex = 1;
            // 
            // in_texto
            // 
            in_texto.AutoSize = true;
            in_texto.BackColor = Color.RoyalBlue;
            in_texto.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            in_texto.Location = new Point(306, 88);
            in_texto.Name = "in_texto";
            in_texto.Size = new Size(0, 38);
            in_texto.TabIndex = 0;
            in_texto.Click += in_texto_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(btn_cargar);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(708, 360);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ARRAY STRING";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(301, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 125);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "LISTADO DE NOMBRE ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 57);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(18, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "TAMAÑO DEL VECTOR ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 56);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 0;
            label1.Text = "0";
            // 
            // btn_cargar
            // 
            btn_cargar.Location = new Point(279, 233);
            btn_cargar.Name = "btn_cargar";
            btn_cargar.Size = new Size(152, 38);
            btn_cargar.TabIndex = 0;
            btn_cargar.Text = "CARGAR";
            btn_cargar.UseVisualStyleBackColor = true;
            btn_cargar.Click += btn_cargar_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(resultado);
            tabPage1.Controls.Add(columna);
            tabPage1.Controls.Add(fila);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(btn_obtener);
            tabPage1.Controls.Add(btn_guardar);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(708, 360);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "MATRIZ";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(467, 175);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 9;
            label6.Text = "RESULTADO";
            // 
            // resultado
            // 
            resultado.Location = new Point(450, 213);
            resultado.Name = "resultado";
            resultado.Size = new Size(125, 27);
            resultado.TabIndex = 8;
            // 
            // columna
            // 
            columna.Location = new Point(556, 102);
            columna.Name = "columna";
            columna.Size = new Size(125, 27);
            columna.TabIndex = 7;
            // 
            // fila
            // 
            fila.Location = new Point(345, 102);
            fila.Name = "fila";
            fila.Size = new Size(125, 27);
            fila.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(574, 69);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 5;
            label5.Text = "COLUMNA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 69);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 4;
            label4.Text = "FILA";
            // 
            // btn_obtener
            // 
            btn_obtener.Location = new Point(537, 296);
            btn_obtener.Name = "btn_obtener";
            btn_obtener.Size = new Size(94, 29);
            btn_obtener.TabIndex = 3;
            btn_obtener.Text = "OBTENER";
            btn_obtener.UseVisualStyleBackColor = true;
            btn_obtener.Click += btn_obtener_Click;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(408, 296);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(94, 29);
            btn_guardar.TabIndex = 2;
            btn_guardar.Text = "GUARDAR";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(f2c2);
            groupBox3.Controls.Add(f2c1);
            groupBox3.Controls.Add(f2c0);
            groupBox3.Controls.Add(f1c2);
            groupBox3.Controls.Add(f1c1);
            groupBox3.Controls.Add(f1c0);
            groupBox3.Controls.Add(f0c2);
            groupBox3.Controls.Add(f0c1);
            groupBox3.Controls.Add(f0c0);
            groupBox3.Location = new Point(27, 61);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(263, 264);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Enter += groupBox3_Enter;
            // 
            // f2c2
            // 
            f2c2.BorderStyle = BorderStyle.FixedSingle;
            f2c2.Location = new Point(183, 188);
            f2c2.Multiline = true;
            f2c2.Name = "f2c2";
            f2c2.Size = new Size(51, 41);
            f2c2.TabIndex = 8;
            f2c2.Text = "2,2";
            // 
            // f2c1
            // 
            f2c1.BorderStyle = BorderStyle.FixedSingle;
            f2c1.Location = new Point(108, 188);
            f2c1.Multiline = true;
            f2c1.Name = "f2c1";
            f2c1.Size = new Size(51, 41);
            f2c1.TabIndex = 7;
            f2c1.Text = "2,1";
            // 
            // f2c0
            // 
            f2c0.BorderStyle = BorderStyle.FixedSingle;
            f2c0.Location = new Point(39, 188);
            f2c0.Multiline = true;
            f2c0.Name = "f2c0";
            f2c0.Size = new Size(51, 41);
            f2c0.TabIndex = 6;
            f2c0.Text = "2,0";
            // 
            // f1c2
            // 
            f1c2.BorderStyle = BorderStyle.FixedSingle;
            f1c2.Location = new Point(183, 114);
            f1c2.Multiline = true;
            f1c2.Name = "f1c2";
            f1c2.Size = new Size(51, 41);
            f1c2.TabIndex = 5;
            f1c2.Text = "1,2";
            // 
            // f1c1
            // 
            f1c1.BorderStyle = BorderStyle.FixedSingle;
            f1c1.Location = new Point(108, 114);
            f1c1.Multiline = true;
            f1c1.Name = "f1c1";
            f1c1.Size = new Size(51, 41);
            f1c1.TabIndex = 4;
            f1c1.Text = "1,1";
            // 
            // f1c0
            // 
            f1c0.BorderStyle = BorderStyle.FixedSingle;
            f1c0.Location = new Point(39, 114);
            f1c0.Multiline = true;
            f1c0.Name = "f1c0";
            f1c0.Size = new Size(51, 41);
            f1c0.TabIndex = 3;
            f1c0.Text = "1,0";
            // 
            // f0c2
            // 
            f0c2.BorderStyle = BorderStyle.FixedSingle;
            f0c2.Location = new Point(183, 41);
            f0c2.Multiline = true;
            f0c2.Name = "f0c2";
            f0c2.Size = new Size(51, 41);
            f0c2.TabIndex = 2;
            f0c2.Text = "0,2";
            // 
            // f0c1
            // 
            f0c1.BorderStyle = BorderStyle.FixedSingle;
            f0c1.Location = new Point(108, 41);
            f0c1.Multiline = true;
            f0c1.Name = "f0c1";
            f0c1.Size = new Size(51, 41);
            f0c1.TabIndex = 1;
            f0c1.Text = "0,1";
            // 
            // f0c0
            // 
            f0c0.BorderStyle = BorderStyle.FixedSingle;
            f0c0.Location = new Point(39, 41);
            f0c0.Multiline = true;
            f0c0.Name = "f0c0";
            f0c0.Size = new Size(51, 41);
            f0c0.TabIndex = 0;
            f0c0.Text = "0,0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 25);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 0;
            label3.Text = "MATRIZ 3X3";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            btn_asignar.ResumeLayout(false);
            btn_asignar.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage btn_asignar;
        private Button button1;
        private TextBox mostra_datos;
        private Label in_texto;
        private TabPage tabPage2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btn_cargar;
        private Label label2;
        private Label label1;
        private TabPage tabPage1;
        private GroupBox groupBox3;
        private Label label3;
        private TextBox columna;
        private TextBox fila;
        private Label label5;
        private Label label4;
        private Button btn_obtener;
        private Button btn_guardar;
        private TextBox f2c2;
        private TextBox f2c1;
        private TextBox f2c0;
        private TextBox f1c2;
        private TextBox f1c1;
        private TextBox f1c0;
        private TextBox f0c2;
        private TextBox f0c1;
        private TextBox f0c0;
        private Label label6;
        private TextBox resultado;
    }
}