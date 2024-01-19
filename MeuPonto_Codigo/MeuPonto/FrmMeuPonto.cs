
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace MeuPonto
{
    public partial class FrmMeuPonto : Form
    {
        DateTime? alarmTime1,
            alarmTime2,
            alarmTime3,
            alarmTime4 = null;

        Boolean ativado = false;

    
        public FrmMeuPonto()
        {
            Settings1 settings = new Settings1();
            InitializeComponent();
            TrayMenuContext();
            this.TopMost= true;
            this.lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            this.lblConfig.Text = settings.Configuracao;
            this.dateTimeEntrada1.Text = settings.Entrada1;
            this.dateTimeSaida1.Text = settings.Saida1;
            this.dateTimeEntrada2.Text = settings.Entrada2;
            this.dateTimeSaida2.Text = settings.Saida2;
        }


        private void TrayMenuContext()
        {         

            this.notifyIcon1.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();

            //CRIAR MENU ABRIR NO MENU PERTO DO RELOGIO
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            _ = this.notifyIcon1.ContextMenuStrip.Items.Add("Abrir", Properties.Resources.meuponto1, onClick: MenuAbrir_Click);
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            //CRIAR MENU INFO NO MENU PERTO DO RELOGIO
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            _ = this.notifyIcon1.ContextMenuStrip.Items.Add("Sobre", Properties.Resources.info, onClick: MenuSobre_Click);
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            //CRIAR MENU SAIR NO MENU PERTO DO RELOGIO
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            _ = this.notifyIcon1.ContextMenuStrip.Items.Add("Sair", Properties.Resources.sair, onClick: MenuSair_Click);
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).

        }
        private void MenuSair_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            this.TopMost = true;
            dialog = MessageBox.Show("Deseja realmente sair?", "MeuPonto", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }


        private void MenuSobre_Click(object sender, EventArgs e)
        {

            DialogResult dialog = new DialogResult();
            this.TopMost = true;
            dialog = MessageBox.Show("Este é um software desenvolvido para aprendizado da lingaguem C#. " +
                "\r\nEste tem o intuito de programar os horarios corretos, para que não esqueça de bater o Ponto no horario de trabalho!" +
                "\r\n\r\nVersão:1.0" +
                "\r\nDesenvolvido por: Gustavo H C Campos" +
                "\r\nSite:https://gustavohccampos.github.io/",
                "MeuPonto", MessageBoxButtons.OK,MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("chrome.exe", "https://pt.stackoverflow.com");
                Process.Start("https://gustavohccampos.github.io/");
                Application.Exit();
            }
        }

        private void MenuAbrir_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                this.Show();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
                this.Show();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.ToString("HH:mm:ss");


            if (ativado)
            {
                if (alarmTime1 != null && DateTime.Now.CompareTo(alarmTime1) > 0)
                {
                        alarmTime1 = null;
                        Notificacao("Bater Ponto de Entrada1!");
                        MessageBox.Show("Bater Ponto de Entrada1", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
                else if (alarmTime2 != null && DateTime.Now.CompareTo(alarmTime2) > 0)
                {
                   
                        alarmTime2 = null;
                        Notificacao("Bater Ponto de Saida1!");
                        MessageBox.Show("Bater Ponto de Saida1", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (alarmTime3 != null && DateTime.Now.CompareTo(alarmTime3) > 0)
                {
                    alarmTime3 = null;
                    Notificacao("Bater Ponto de Entrada2!");
                    MessageBox.Show("Bater Ponto de Entrada2", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (alarmTime4 != null && DateTime.Now.CompareTo(alarmTime4) > 0)
                {
                    alarmTime4 = null;
                    Notificacao("Bater Ponto de Saida2!");
                    MessageBox.Show("Bater Ponto de Saida2", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    this.btnIniciar_Click(e, e);
                }


            }


        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            if (ativado == true)
            {
                btnIniciar.Text = "Iniciar";
                lblHora.ForeColor = Color.CornflowerBlue;
                btnIniciar.ForeColor = Color.CornflowerBlue;
                ativado = false;
                alarmTime1 = null;
                alarmTime2 = null;
                alarmTime3 = null;
                alarmTime4 = null;
                dateTimeEntrada1.Enabled = true;
                dateTimeEntrada2.Enabled = true;
                dateTimeSaida1.Enabled = true;
                dateTimeSaida2.Enabled = true;
                Notificacao("MeuPonto Desativado!");
            }
            else if (ativado != true)
            {

                btnIniciar.Text = "Parar";
                lblHora.ForeColor = Color.Yellow;
                btnIniciar.ForeColor = Color.Yellow; ;

                ativado = true;
                alarmTime1 = dateTimeEntrada1.Value.Date + dateTimeEntrada1.Value.TimeOfDay;
                alarmTime2 = dateTimeSaida1.Value.Date + dateTimeSaida1.Value.TimeOfDay;
                alarmTime3 = dateTimeEntrada2.Value.Date + dateTimeEntrada2.Value.TimeOfDay;
                alarmTime4 = dateTimeSaida2.Value.Date + dateTimeSaida2.Value.TimeOfDay;
                dateTimeEntrada1.Enabled = false;
                dateTimeEntrada2.Enabled = false;
                dateTimeSaida1.Enabled = false;
                dateTimeSaida2.Enabled = false;
                Notificacao("MeuPonto Ativado!");
            }


        }

        private void dateTimeEntrada1_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.SendWait("{Right}");
        }

        private void dateTimeSaida1_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.SendWait("{Right}");
        }

        private void dateTimeEntrada2_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.SendWait("{Right}");
        }

        private void dateTimeSaida2_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.SendWait("{Right}");
        }

        private void FrmMeuPonto_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)

            {
                this.Hide();
                notifyIcon1.Visible = true;

            }
        }

      

        private void Notificacao(String mensagem)
        {
            notifyIcon1.ShowBalloonTip(5000, "MeuPonto", mensagem, ToolTipIcon.Warning);

        }

        private void FrmMeuPonto_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = true; // Cancelar o fechamento do form
            this.Hide(); // Ocultar o form
                         // use this.WindowState = FormWindowState.Minimized; para minimizar
            notifyIcon1.Visible = true; // Mostrar o notify icon
        }


  
    }
}


