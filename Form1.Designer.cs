namespace Interprete_Prolog
{
    partial class Prolog
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageConsultas = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.button_Arbol = new System.Windows.Forms.Button();
            this.button_enter_consulta = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_consulta = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageConsultas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos PL(*.pl)|*.pl";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(48, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 230);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageConsultas);
            this.tabControl1.Location = new System.Drawing.Point(13, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 224);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPageConsultas
            // 
            this.tabPageConsultas.Controls.Add(this.textBox1);
            this.tabPageConsultas.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultas.Name = "tabPageConsultas";
            this.tabPageConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultas.Size = new System.Drawing.Size(707, 198);
            this.tabPageConsultas.TabIndex = 0;
            this.tabPageConsultas.Text = "Consultas";
            this.tabPageConsultas.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(6, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(689, 189);
            this.textBox1.TabIndex = 5;
            // 
            // button_Arbol
            // 
            this.button_Arbol.Location = new System.Drawing.Point(165, 273);
            this.button_Arbol.Name = "button_Arbol";
            this.button_Arbol.Size = new System.Drawing.Size(94, 34);
            this.button_Arbol.TabIndex = 3;
            this.button_Arbol.Text = "Arbol";
            this.button_Arbol.UseVisualStyleBackColor = true;
            this.button_Arbol.Visible = false;
            this.button_Arbol.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_enter_consulta
            // 
            this.button_enter_consulta.Location = new System.Drawing.Point(443, 71);
            this.button_enter_consulta.Name = "button_enter_consulta";
            this.button_enter_consulta.Size = new System.Drawing.Size(60, 23);
            this.button_enter_consulta.TabIndex = 6;
            this.button_enter_consulta.Text = "Enter";
            this.button_enter_consulta.UseVisualStyleBackColor = true;
            this.button_enter_consulta.Click += new System.EventHandler(this.button_enter_consulta_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_consulta);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.button_enter_consulta);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Location = new System.Drawing.Point(52, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(566, 109);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox_consulta
            // 
            this.textBox_consulta.Location = new System.Drawing.Point(49, 37);
            this.textBox_consulta.Name = "textBox_consulta";
            this.textBox_consulta.Size = new System.Drawing.Size(347, 20);
            this.textBox_consulta.TabIndex = 10;
            this.textBox_consulta.TextChanged += new System.EventHandler(this.textBox_consulta_TextChanged);
            this.textBox_consulta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_consulta_KeyDown);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(443, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Forward Chaining";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(443, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Backwards Chaining";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Prolog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_Arbol);
            this.Controls.Add(this.panel1);
            this.Name = "Prolog";
            this.Text = "Prolog";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageConsultas.ResumeLayout(false);
            this.tabPageConsultas.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button button_Arbol;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageConsultas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_enter_consulta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox_consulta;
    }
}

