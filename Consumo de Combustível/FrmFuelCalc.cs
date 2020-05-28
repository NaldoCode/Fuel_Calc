using System;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace Consumo_de_Combustível
{
    public partial class FrmFuelCalc : Form
    {
        public FrmFuelCalc()
        {
            InitializeComponent();
        }

        private int _x;
        private int _y;
        private bool _mdown;
        private void lblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FrmFuelCalc_Load(object sender, EventArgs e)
        {
            txtModelo.Select();
            HelpCalc hc = new HelpCalc();
            hc.CheckPath(); // Verificar/Criar pasta C:\FuelCalc\

            //User name PC
            lblUser.Text = $"USER: {hc.UserName}"; // Usuário do computador
        }

        private void btnREPORTS_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\FuelCalc\");
            }
            catch (Exception)
            {
                MessageBox.Show("Execute o programa como administrador\n" +
                    "para ativar as funcionalidades.", "NOTIFICAÇÃO! - FuelCalc",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtModelo.Text == "")
                {
                    MessageBox.Show("Insira todas informações.", "NOTIFICAÇÃO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtModelo.Select();
                }
                else if (txtDistancia.Text == "")
                {
                    MessageBox.Show("Insira todas informações.", "NOTIFICAÇÃO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtModelo.Select();
                }
                else if (txtMediaKM.Text == "")
                {
                    MessageBox.Show("Insira todas informações.", "NOTIFICAÇÃO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtModelo.Select();
                }
                else if (txtPreco.Text == "")
                {
                    MessageBox.Show("Insira todas informações.", "NOTIFICAÇÃO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtModelo.Select();
                }
                else if (txtTipo.Text == "")
                {
                    MessageBox.Show("Insira todas informações.", "NOTIFICAÇÃO!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtModelo.Select();
                }
                else
                {
                    HelpCalc hc = new HelpCalc();
                    hc.Modelo = txtModelo.Text;
                    hc.Distancia = double.Parse(txtDistancia.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                    hc.Mediakm = double.Parse(txtMediaKM.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                    hc.Preco = double.Parse(txtPreco.Text.Replace(",", "."), CultureInfo.InvariantCulture);
                    hc.Tipo = txtTipo.Text;
                    hc.HelpFuel();
                    MessageBox.Show("Registrado com sucesso.", "NOTIFICAÇÃO - FuelCalc_Calcular.",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    btnLimpar.PerformClick();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Insira as informações de forma correta.", "NOTIFICAÇÃO! - FuelCalc",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModelo.Select();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtModelo.Clear();
            txtDistancia.Clear();
            txtMediaKM.Clear();
            txtPreco.Clear();
            txtTipo.Clear();
            txtModelo.Select();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FuelCalc é um programa gratuito e fácil de usar,\n" +
                            "sua função é lhe ajudar com relatórios, onde você\n" +
                            "pode visualizar e compartilhar o consumo de seu veículo.\n" +
                            "Além de gratuito, ele não contém anúncios ou coleta de dados.\n" +
                            "Atualmente está em sua versão 1.0,\n" +
                            "disponível para sistemas Windows(Desktop).\n\n\n" +
                            "COMO USAR:\n" +
                            "Modelo - Marca ou nome do veículo;\n" +
                            "Distância - Que irá percorrer;\n" +
                            "Média KM - Quanto seu veículo faz com 1L;\n" +
                            "Preço - Preço do combustível.;\n" +
                            "Tipo - Nome do combustível.\n\n" +
                            "                      Naldo Santos 28-05-2020",
                            "NOTIFICAÇÃO - FuelCalc_HELP.",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _x = e.X;
            _y = e.Y;
            _mdown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mdown)
            {
                SetDesktopLocation(MousePosition.X - _x, MousePosition.Y - _y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _mdown = false;
        }

        #region DEUS SEJA LOUVADO
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DeusSejaLouvado.ForeColor == Color.DimGray)
            {
                DeusSejaLouvado.ForeColor = Color.Gray;
            }
            else if (DeusSejaLouvado.ForeColor == Color.Gray)
            {
                DeusSejaLouvado.ForeColor = Color.DarkGray;
            }
            else if (DeusSejaLouvado.ForeColor == Color.DarkGray)
            {
                DeusSejaLouvado.ForeColor = Color.Silver;
            }
            else if (DeusSejaLouvado.ForeColor == Color.Silver)
            {
                DeusSejaLouvado.ForeColor = Color.LightGray;
            }
            else if (DeusSejaLouvado.ForeColor == Color.LightGray)
            {
                DeusSejaLouvado.ForeColor = Color.Gainsboro;
            }
            else if (DeusSejaLouvado.ForeColor == Color.Gainsboro)
            {
                DeusSejaLouvado.ForeColor = Color.White;
            }
            else if (DeusSejaLouvado.ForeColor == Color.White)
            {
                DeusSejaLouvado.ForeColor = Color.DimGray;
            }
            #endregion
        }
    }

}
