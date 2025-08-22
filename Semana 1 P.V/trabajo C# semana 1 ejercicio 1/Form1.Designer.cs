namespace Trabajo_Semana_1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btiniciar = new System.Windows.Forms.Button();
            this.ctclave = new System.Windows.Forms.TextBox();
            this.lbclave = new System.Windows.Forms.Label();
            this.ctusuario = new System.Windows.Forms.TextBox();
            this.lbusuario = new System.Windows.Forms.Label();
            this.ctkg = new System.Windows.Forms.TabPage();
            this.ctaltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cjkg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btcalcular = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.contar = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.btclick = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cttemperatura = new System.Windows.Forms.TextBox();
            this.lbtemperatura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seleccionar = new System.Windows.Forms.ComboBox();
            this.btconvertir = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ctkg.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.ctkg);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 360);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btiniciar);
            this.tabPage1.Controls.Add(this.ctclave);
            this.tabPage1.Controls.Add(this.lbclave);
            this.tabPage1.Controls.Add(this.ctusuario);
            this.tabPage1.Controls.Add(this.lbusuario);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(703, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btiniciar
            // 
            this.btiniciar.BackColor = System.Drawing.Color.Silver;
            this.btiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btiniciar.Location = new System.Drawing.Point(157, 236);
            this.btiniciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btiniciar.Name = "btiniciar";
            this.btiniciar.Size = new System.Drawing.Size(242, 47);
            this.btiniciar.TabIndex = 4;
            this.btiniciar.Text = "INICIAR SESIÓN";
            this.btiniciar.UseVisualStyleBackColor = false;
            this.btiniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctclave
            // 
            this.ctclave.Location = new System.Drawing.Point(245, 171);
            this.ctclave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctclave.Name = "ctclave";
            this.ctclave.PasswordChar = '*';
            this.ctclave.Size = new System.Drawing.Size(122, 22);
            this.ctclave.TabIndex = 3;
            // 
            // lbclave
            // 
            this.lbclave.AutoSize = true;
            this.lbclave.BackColor = System.Drawing.Color.Silver;
            this.lbclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbclave.Location = new System.Drawing.Point(83, 162);
            this.lbclave.Name = "lbclave";
            this.lbclave.Size = new System.Drawing.Size(104, 36);
            this.lbclave.TabIndex = 2;
            this.lbclave.Text = "Clave:";
            // 
            // ctusuario
            // 
            this.ctusuario.Location = new System.Drawing.Point(245, 93);
            this.ctusuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctusuario.Name = "ctusuario";
            this.ctusuario.Size = new System.Drawing.Size(122, 22);
            this.ctusuario.TabIndex = 1;
            // 
            // lbusuario
            // 
            this.lbusuario.AutoSize = true;
            this.lbusuario.BackColor = System.Drawing.Color.Silver;
            this.lbusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusuario.Location = new System.Drawing.Point(83, 83);
            this.lbusuario.Name = "lbusuario";
            this.lbusuario.Size = new System.Drawing.Size(135, 36);
            this.lbusuario.TabIndex = 0;
            this.lbusuario.Text = "Usuario:";
            // 
            // ctkg
            // 
            this.ctkg.Controls.Add(this.ctaltura);
            this.ctkg.Controls.Add(this.label1);
            this.ctkg.Controls.Add(this.cjkg);
            this.ctkg.Controls.Add(this.label3);
            this.ctkg.Controls.Add(this.btcalcular);
            this.ctkg.Location = new System.Drawing.Point(4, 25);
            this.ctkg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctkg.Name = "ctkg";
            this.ctkg.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctkg.Size = new System.Drawing.Size(703, 331);
            this.ctkg.TabIndex = 1;
            this.ctkg.Text = "IMC";
            this.ctkg.UseVisualStyleBackColor = true;
            // 
            // ctaltura
            // 
            this.ctaltura.BackColor = System.Drawing.Color.Silver;
            this.ctaltura.Location = new System.Drawing.Point(395, 204);
            this.ctaltura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctaltura.Name = "ctaltura";
            this.ctaltura.Size = new System.Drawing.Size(265, 22);
            this.ctaltura.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese su altura en metros:";
            // 
            // cjkg
            // 
            this.cjkg.BackColor = System.Drawing.Color.Silver;
            this.cjkg.Location = new System.Drawing.Point(395, 96);
            this.cjkg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cjkg.Name = "cjkg";
            this.cjkg.Size = new System.Drawing.Size(213, 22);
            this.cjkg.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese su peso en kg:";
            // 
            // btcalcular
            // 
            this.btcalcular.BackColor = System.Drawing.Color.Silver;
            this.btcalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcalcular.Location = new System.Drawing.Point(245, 249);
            this.btcalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(185, 51);
            this.btcalcular.TabIndex = 5;
            this.btcalcular.Text = "Calcular";
            this.btcalcular.UseVisualStyleBackColor = false;
            this.btcalcular.Click += new System.EventHandler(this.btcalcular_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.contar);
            this.tabPage3.Controls.Add(this.btReset);
            this.tabPage3.Controls.Add(this.btclick);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(703, 331);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Contador";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // contar
            // 
            this.contar.AutoSize = true;
            this.contar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contar.Location = new System.Drawing.Point(304, 52);
            this.contar.Name = "contar";
            this.contar.Size = new System.Drawing.Size(43, 46);
            this.contar.TabIndex = 3;
            this.contar.Text = "0";
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btReset.Location = new System.Drawing.Point(268, 216);
            this.btReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(132, 55);
            this.btReset.TabIndex = 2;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btclick
            // 
            this.btclick.BackColor = System.Drawing.Color.Blue;
            this.btclick.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclick.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btclick.Location = new System.Drawing.Point(268, 128);
            this.btclick.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btclick.Name = "btclick";
            this.btclick.Size = new System.Drawing.Size(122, 55);
            this.btclick.TabIndex = 1;
            this.btclick.Text = "Click";
            this.btclick.UseVisualStyleBackColor = false;
            this.btclick.Click += new System.EventHandler(this.btclick_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cttemperatura);
            this.tabPage4.Controls.Add(this.lbtemperatura);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.seleccionar);
            this.tabPage4.Controls.Add(this.btconvertir);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(703, 331);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Conversor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cttemperatura
            // 
            this.cttemperatura.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cttemperatura.Location = new System.Drawing.Point(217, 157);
            this.cttemperatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cttemperatura.Name = "cttemperatura";
            this.cttemperatura.Size = new System.Drawing.Size(239, 22);
            this.cttemperatura.TabIndex = 8;
            // 
            // lbtemperatura
            // 
            this.lbtemperatura.AutoSize = true;
            this.lbtemperatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtemperatura.Location = new System.Drawing.Point(221, 113);
            this.lbtemperatura.Name = "lbtemperatura";
            this.lbtemperatura.Size = new System.Drawing.Size(222, 25);
            this.lbtemperatura.TabIndex = 7;
            this.lbtemperatura.Text = "Ingrese a la temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "CONVERSOR DE TEMPERATURAS";
            // 
            // seleccionar
            // 
            this.seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionar.FormattingEnabled = true;
            this.seleccionar.Items.AddRange(new object[] {
            "Celsius a Fahrenheit",
            "Fahrenheit a Celsius"});
            this.seleccionar.Location = new System.Drawing.Point(163, 58);
            this.seleccionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(395, 33);
            this.seleccionar.TabIndex = 5;
            this.seleccionar.Text = "Seleccione la temperatura a convertir";
            // 
            // btconvertir
            // 
            this.btconvertir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btconvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btconvertir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btconvertir.Location = new System.Drawing.Point(246, 210);
            this.btconvertir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btconvertir.Name = "btconvertir";
            this.btconvertir.Size = new System.Drawing.Size(187, 38);
            this.btconvertir.TabIndex = 4;
            this.btconvertir.Text = "Convertir";
            this.btconvertir.UseVisualStyleBackColor = false;
            this.btconvertir.Click += new System.EventHandler(this.btconvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Pestañas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ctkg.ResumeLayout(false);
            this.ctkg.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage ctkg;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btiniciar;
        private System.Windows.Forms.TextBox ctclave;
        private System.Windows.Forms.Label lbclave;
        private System.Windows.Forms.TextBox ctusuario;
        private System.Windows.Forms.Label lbusuario;
        private System.Windows.Forms.Button btcalcular;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btclick;
        private System.Windows.Forms.Button btconvertir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cjkg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctaltura;
        private System.Windows.Forms.Label contar;
        private System.Windows.Forms.ComboBox seleccionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbtemperatura;
        private System.Windows.Forms.TextBox cttemperatura;
    }
}

