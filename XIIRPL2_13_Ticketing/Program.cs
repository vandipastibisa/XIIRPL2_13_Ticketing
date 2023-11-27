using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using XIIRPL2_13_Ticketing.MasterForm;

namespace XIIRPL2_13_Ticketing
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // FormLogin FormLogin = new FormLogin();
            //FormLogin.Show();
            //FormMasterBandara bandara = new FormMasterBandara();
            //bandara.Show();


            //FormMasterMaskapai maskapai = new FormMasterMaskapai();
            //maskapai.Show();
            //FormMasterKodePromo kodepromo = new FormMasterKodePromo();
            //kodepromo.Show();
            FormMasterJadwalPenerbangan jadwalpenerbangan = new FormMasterJadwalPenerbangan();
            jadwalpenerbangan.Show();


            Application.Run();
        }
    }
}
