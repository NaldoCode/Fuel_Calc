using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Consumo_de_Combustível
{
    class HelpCalc
    {
        public string UserName = Environment.UserName; // Nome do usuário do computador
        private string _path = @"C:\FuelCalc\";
        public string Modelo;
        public double Distancia;
        public double Mediakm;
        public double Preco;
        public string Tipo;
        public void HelpFuel()
        {

            double dm = Distancia / Mediakm;
            double calc = dm * Preco;

            if(Directory.Exists(_path) == true)
            {
                DirectoryInfo dir = new DirectoryInfo(_path);
                int count = dir.GetFiles().Length;

                using (StreamWriter sw = new StreamWriter(_path + Modelo + "_" + count + "_.txt"))
                {
                    sw.WriteLine($"Modelo: {Modelo}");
                    sw.WriteLine($"Distância: {Distancia}KM");
                    sw.WriteLine($"Média KM: {Mediakm}KM");
                    sw.WriteLine($"Preço: $ {Preco.ToString("F2",CultureInfo.InvariantCulture)}");
                    sw.WriteLine($"Tipo: {Tipo}");
                    sw.WriteLine("\n_________________________________________");
                    sw.WriteLine($"\nCalculo: dm = Distância / Média KM\n" +
                                 $"OBS: / é sinal de divisão");
                    sw.WriteLine($"Calculo: dm x Preço");
                    sw.WriteLine("_________________________________________");
                    sw.WriteLine($"\n\nCalculo Final: {calc.ToString("F2",CultureInfo.InvariantCulture)}L");
                    sw.Close();
                }
            }
        }
        public void CheckPath() // Verificar/Criar pasta C:\FuelCalc\
        {
            try
            {
                if (Directory.Exists(_path) != true)
                {
                    Directory.CreateDirectory(_path);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Execute o programa como administrador\n" +
                    "para ativar as funcionalidades.", "NOTIFICAÇÃO! - FuelCalc",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
