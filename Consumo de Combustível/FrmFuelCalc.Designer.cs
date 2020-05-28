namespace Consumo_de_Combustível
{
    partial class FrmFuelCalc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuelCalc));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.txtMediaKM = new System.Windows.Forms.TextBox();
            this.lblMediaKM = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPrecoFuel = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblTipoFuel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeusSejaLouvado = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnREPORTS = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblMinimize);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 20);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(122, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(178, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "FuelCalc - Consumo de Combustível";
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblMinimize.Location = new System.Drawing.Point(381, 3);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(10, 13);
            this.lblMinimize.TabIndex = 11;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblClose.Location = new System.Drawing.Point(397, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(14, 13);
            this.lblClose.TabIndex = 10;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelo:";
            this.toolTip1.SetToolTip(this.label1, "Exemplo: FACTOR 150 - ANO 2020");
            // 
            // txtModelo
            // 
            this.txtModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtModelo.ForeColor = System.Drawing.Color.White;
            this.txtModelo.Location = new System.Drawing.Point(83, 40);
            this.txtModelo.MaxLength = 100;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(320, 13);
            this.txtModelo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtModelo, "Exemplo: FACTOR 150 - ANO 2020");
            // 
            // txtDistancia
            // 
            this.txtDistancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDistancia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDistancia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDistancia.ForeColor = System.Drawing.Color.White;
            this.txtDistancia.Location = new System.Drawing.Point(83, 70);
            this.txtDistancia.MaxLength = 100;
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(100, 13);
            this.txtDistancia.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtDistancia, "Exemplo: 100");
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblDistancia.Location = new System.Drawing.Point(10, 68);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(67, 16);
            this.lblDistancia.TabIndex = 3;
            this.lblDistancia.Text = "Distância:";
            this.toolTip1.SetToolTip(this.lblDistancia, "Exemplo: 100");
            // 
            // txtMediaKM
            // 
            this.txtMediaKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtMediaKM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMediaKM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMediaKM.ForeColor = System.Drawing.Color.White;
            this.txtMediaKM.Location = new System.Drawing.Point(83, 101);
            this.txtMediaKM.MaxLength = 100;
            this.txtMediaKM.Name = "txtMediaKM";
            this.txtMediaKM.Size = new System.Drawing.Size(100, 13);
            this.txtMediaKM.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtMediaKM, "Exemplo: 39");
            // 
            // lblMediaKM
            // 
            this.lblMediaKM.AutoSize = true;
            this.lblMediaKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediaKM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblMediaKM.Location = new System.Drawing.Point(6, 99);
            this.lblMediaKM.Name = "lblMediaKM";
            this.lblMediaKM.Size = new System.Drawing.Size(71, 16);
            this.lblMediaKM.TabIndex = 5;
            this.lblMediaKM.Text = "Média KM:";
            this.toolTip1.SetToolTip(this.lblMediaKM, "Exemplo: 39");
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPreco.ForeColor = System.Drawing.Color.White;
            this.txtPreco.Location = new System.Drawing.Point(83, 132);
            this.txtPreco.MaxLength = 100;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 13);
            this.txtPreco.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtPreco, "Exemplo: 3.80");
            // 
            // lblPrecoFuel
            // 
            this.lblPrecoFuel.AutoSize = true;
            this.lblPrecoFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblPrecoFuel.Location = new System.Drawing.Point(30, 130);
            this.lblPrecoFuel.Name = "lblPrecoFuel";
            this.lblPrecoFuel.Size = new System.Drawing.Size(47, 16);
            this.lblPrecoFuel.TabIndex = 7;
            this.lblPrecoFuel.Text = "Preço:";
            this.toolTip1.SetToolTip(this.lblPrecoFuel, "Exemplo: 3.80");
            // 
            // txtTipo
            // 
            this.txtTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTipo.ForeColor = System.Drawing.Color.White;
            this.txtTipo.Location = new System.Drawing.Point(83, 163);
            this.txtTipo.MaxLength = 100;
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 13);
            this.txtTipo.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtTipo, "Exemplo: GASOLINA");
            // 
            // lblTipoFuel
            // 
            this.lblTipoFuel.AutoSize = true;
            this.lblTipoFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblTipoFuel.Location = new System.Drawing.Point(30, 161);
            this.lblTipoFuel.Name = "lblTipoFuel";
            this.lblTipoFuel.Size = new System.Drawing.Size(39, 16);
            this.lblTipoFuel.TabIndex = 9;
            this.lblTipoFuel.Text = "Tipo:";
            this.toolTip1.SetToolTip(this.lblTipoFuel, "Exemplo: GASOLINA");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.DeusSejaLouvado);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 20);
            this.panel2.TabIndex = 11;
            // 
            // DeusSejaLouvado
            // 
            this.DeusSejaLouvado.AutoSize = true;
            this.DeusSejaLouvado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.DeusSejaLouvado.ForeColor = System.Drawing.Color.DimGray;
            this.DeusSejaLouvado.Location = new System.Drawing.Point(287, 3);
            this.DeusSejaLouvado.Name = "DeusSejaLouvado";
            this.DeusSejaLouvado.Size = new System.Drawing.Size(124, 13);
            this.DeusSejaLouvado.TabIndex = 12;
            this.DeusSejaLouvado.Text = "DEUS SEJA LOUVADO!";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblUser.Location = new System.Drawing.Point(12, 3);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 13);
            this.lblUser.TabIndex = 12;
            this.lblUser.Text = "USER: LOADING...";
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.ForeColor = System.Drawing.Color.DarkGray;
            this.btnCalcular.Location = new System.Drawing.Point(328, 89);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.DarkGray;
            this.btnLimpar.Location = new System.Drawing.Point(328, 118);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnREPORTS
            // 
            this.btnREPORTS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnREPORTS.ForeColor = System.Drawing.Color.DarkGray;
            this.btnREPORTS.Location = new System.Drawing.Point(328, 147);
            this.btnREPORTS.Name = "btnREPORTS";
            this.btnREPORTS.Size = new System.Drawing.Size(75, 23);
            this.btnREPORTS.TabIndex = 8;
            this.btnREPORTS.Text = "REPORTS";
            this.btnREPORTS.UseVisualStyleBackColor = true;
            this.btnREPORTS.Click += new System.EventHandler(this.btnREPORTS_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.DarkGray;
            this.btnHelp.Location = new System.Drawing.Point(328, 176);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "HELP";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmFuelCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(415, 225);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnREPORTS);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblTipoFuel);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPrecoFuel);
            this.Controls.Add(this.txtMediaKM);
            this.Controls.Add(this.lblMediaKM);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFuelCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel Calc - Consumo de Combustível";
            this.Load += new System.EventHandler(this.FrmFuelCalc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txtMediaKM;
        private System.Windows.Forms.Label lblMediaKM;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPrecoFuel;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblTipoFuel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label DeusSejaLouvado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnREPORTS;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Timer timer1;
    }
}