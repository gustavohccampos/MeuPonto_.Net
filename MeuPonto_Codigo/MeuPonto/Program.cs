using System.Diagnostics;

namespace MeuPonto
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var processo = System.Diagnostics.Process.GetCurrentProcess();
            var jaEstaRodando = System.Diagnostics.Process.GetProcessesByName(processo.ProcessName).Any(p => p.Id != processo.Id);
            // C#
            if (jaEstaRodando)
            {
                MessageBox.Show("Aplicação MeuPonto já está rodando! Verifique no icone de Notificações!");
                return;
            }
            else {
                ApplicationConfiguration.Initialize();
                Application.Run(new FrmMeuPonto());

            }





        }
    }
}