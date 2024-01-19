namespace MeuPonto
{
    partial class FrmMeuPonto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeuPonto));
            btnIniciar = new Button();
            lblEntrada = new Label();
            lblSaidaAlmoco = new Label();
            lblEntradaAlmoco = new Label();
            lblSaida = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblHora = new Label();
            dateTimeEntrada1 = new DateTimePicker();
            dateTimeSaida1 = new DateTimePicker();
            dateTimeEntrada2 = new DateTimePicker();
            dateTimeSaida2 = new DateTimePicker();
            notifyIcon1 = new NotifyIcon(components);
            lblConfig = new Label();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = SystemColors.ActiveCaptionText;
            btnIniciar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.ForeColor = Color.CornflowerBlue;
            btnIniciar.Location = new Point(75, 196);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(100, 33);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // lblEntrada
            // 
            lblEntrada.AutoSize = true;
            lblEntrada.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntrada.Location = new Point(23, 84);
            lblEntrada.Name = "lblEntrada";
            lblEntrada.Size = new Size(66, 17);
            lblEntrada.TabIndex = 5;
            lblEntrada.Text = "Entrada1:";
            // 
            // lblSaidaAlmoco
            // 
            lblSaidaAlmoco.AutoSize = true;
            lblSaidaAlmoco.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaidaAlmoco.Location = new Point(23, 142);
            lblSaidaAlmoco.Name = "lblSaidaAlmoco";
            lblSaidaAlmoco.Size = new Size(66, 17);
            lblSaidaAlmoco.TabIndex = 6;
            lblSaidaAlmoco.Text = "Entrada2:";
            // 
            // lblEntradaAlmoco
            // 
            lblEntradaAlmoco.AutoSize = true;
            lblEntradaAlmoco.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEntradaAlmoco.Location = new Point(37, 113);
            lblEntradaAlmoco.Name = "lblEntradaAlmoco";
            lblEntradaAlmoco.Size = new Size(52, 17);
            lblEntradaAlmoco.TabIndex = 7;
            lblEntradaAlmoco.Text = "Saida1:";
            // 
            // lblSaida
            // 
            lblSaida.AutoSize = true;
            lblSaida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaida.Location = new Point(37, 171);
            lblSaida.Name = "lblSaida";
            lblSaida.Size = new Size(52, 17);
            lblSaida.TabIndex = 8;
            lblSaida.Text = "Saida2:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.BackColor = SystemColors.ActiveCaptionText;
            lblHora.BorderStyle = BorderStyle.FixedSingle;
            lblHora.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblHora.ForeColor = Color.CornflowerBlue;
            lblHora.Location = new Point(4, 5);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(233, 61);
            lblHora.TabIndex = 9;
            lblHora.Text = "HH:mm:ss";
            lblHora.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimeEntrada1
            // 
            dateTimeEntrada1.CustomFormat = "HH:mm:ss";
            dateTimeEntrada1.Format = DateTimePickerFormat.Time;
            dateTimeEntrada1.ImeMode = ImeMode.NoControl;
            dateTimeEntrada1.Location = new Point(91, 80);
            dateTimeEntrada1.Name = "dateTimeEntrada1";
            dateTimeEntrada1.ShowUpDown = true;
            dateTimeEntrada1.Size = new Size(82, 23);
            dateTimeEntrada1.TabIndex = 10;
            dateTimeEntrada1.Value = new DateTime(2024, 1, 18, 8, 0, 0, 0);
            dateTimeEntrada1.ValueChanged += dateTimeEntrada1_ValueChanged;
            // 
            // dateTimeSaida1
            // 
            dateTimeSaida1.CustomFormat = "HH:mm:ss";
            dateTimeSaida1.Format = DateTimePickerFormat.Time;
            dateTimeSaida1.Location = new Point(91, 109);
            dateTimeSaida1.Name = "dateTimeSaida1";
            dateTimeSaida1.ShowUpDown = true;
            dateTimeSaida1.Size = new Size(82, 23);
            dateTimeSaida1.TabIndex = 11;
            dateTimeSaida1.Value = new DateTime(2024, 1, 18, 13, 0, 0, 0);
            dateTimeSaida1.ValueChanged += dateTimeSaida1_ValueChanged;
            // 
            // dateTimeEntrada2
            // 
            dateTimeEntrada2.CustomFormat = "HH:mm:ss";
            dateTimeEntrada2.Format = DateTimePickerFormat.Time;
            dateTimeEntrada2.Location = new Point(91, 138);
            dateTimeEntrada2.Name = "dateTimeEntrada2";
            dateTimeEntrada2.ShowUpDown = true;
            dateTimeEntrada2.Size = new Size(82, 23);
            dateTimeEntrada2.TabIndex = 12;
            dateTimeEntrada2.Value = new DateTime(2024, 1, 18, 14, 0, 0, 0);
            dateTimeEntrada2.ValueChanged += dateTimeEntrada2_ValueChanged;
            // 
            // dateTimeSaida2
            // 
            dateTimeSaida2.CustomFormat = "HH:mm:ss";
            dateTimeSaida2.Format = DateTimePickerFormat.Time;
            dateTimeSaida2.Location = new Point(91, 167);
            dateTimeSaida2.Name = "dateTimeSaida2";
            dateTimeSaida2.ShowUpDown = true;
            dateTimeSaida2.Size = new Size(82, 23);
            dateTimeSaida2.TabIndex = 13;
            dateTimeSaida2.Value = new DateTime(2024, 1, 18, 17, 0, 0, 0);
            dateTimeSaida2.ValueChanged += dateTimeSaida2_ValueChanged;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "MeuPonto";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // lblConfig
            // 
            lblConfig.AutoSize = true;
            lblConfig.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfig.Location = new Point(4, 234);
            lblConfig.Name = "lblConfig";
            lblConfig.Size = new Size(45, 17);
            lblConfig.TabIndex = 14;
            lblConfig.Text = "Nome";
            // 
            // FrmMeuPonto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(212, 252);
            Controls.Add(lblConfig);
            Controls.Add(dateTimeSaida2);
            Controls.Add(dateTimeEntrada2);
            Controls.Add(dateTimeSaida1);
            Controls.Add(dateTimeEntrada1);
            Controls.Add(lblHora);
            Controls.Add(lblSaida);
            Controls.Add(lblEntradaAlmoco);
            Controls.Add(lblSaidaAlmoco);
            Controls.Add(lblEntrada);
            Controls.Add(btnIniciar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmMeuPonto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MeuPonto";
            FormClosing += FrmMeuPonto_FormClosing;
            Resize += FrmMeuPonto_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciar;
        private Label lblEntrada;
        private Label lblSaidaAlmoco;
        private Label lblEntradaAlmoco;
        private Label lblSaida;
        private System.Windows.Forms.Timer timer1;
        private Label lblHora;
        private DateTimePicker dateTimeEntrada1;
        private DateTimePicker dateTimeSaida1;
        private DateTimePicker dateTimeEntrada2;
        private DateTimePicker dateTimeSaida2;
        private NotifyIcon notifyIcon1;
        private Label lblConfig;
    }
}
