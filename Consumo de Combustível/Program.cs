using System;
using System.Windows.Forms;

namespace Consumo_de_Combustível
{
    static class Program
    {
        /// <summary>
        /// https://github.com/NaldoCode/Fuel_Calc
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmFuelCalc());
        }
    }
}
