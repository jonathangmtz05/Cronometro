namespace Cronometro
{
    partial class Form1
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
            lblcronos = new Label();
            tmrCronos = new System.Windows.Forms.Timer(components);
            butIniciar = new Button();
            butDetener = new Button();
            butReinicio = new Button();
            SuspendLayout();
            // 
            // lblcronos
            // 
            lblcronos.AutoSize = true;
            lblcronos.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcronos.Location = new Point(16, 9);
            lblcronos.Name = "lblcronos";
            lblcronos.Size = new Size(358, 93);
            lblcronos.TabIndex = 0;
            lblcronos.Text = "00:00:00";
            // 
            // tmrCronos
            // 
            tmrCronos.Interval = 1000;
            tmrCronos.Tick += tmrCronos_Tick;
            // 
            // butIniciar
            // 
            butIniciar.BackColor = SystemColors.ActiveCaption;
            butIniciar.Location = new Point(16, 203);
            butIniciar.Name = "butIniciar";
            butIniciar.Size = new Size(94, 29);
            butIniciar.TabIndex = 1;
            butIniciar.Text = "Iniciar";
            butIniciar.UseVisualStyleBackColor = false;
            butIniciar.Click += butIniciar_Click;
            // 
            // butDetener
            // 
            butDetener.BackColor = SystemColors.ActiveCaption;
            butDetener.Location = new Point(132, 203);
            butDetener.Name = "butDetener";
            butDetener.Size = new Size(94, 29);
            butDetener.TabIndex = 2;
            butDetener.Text = "Detener";
            butDetener.UseVisualStyleBackColor = false;
            butDetener.UseWaitCursor = true;
            butDetener.Click += butDetener_Click;
            // 
            // butReinicio
            // 
            butReinicio.BackColor = SystemColors.ActiveCaption;
            butReinicio.Location = new Point(245, 203);
            butReinicio.Name = "butReinicio";
            butReinicio.Size = new Size(94, 29);
            butReinicio.TabIndex = 3;
            butReinicio.Text = "Reiniciar";
            butReinicio.UseVisualStyleBackColor = false;
            butReinicio.Click += butReinicio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(372, 354);
            Controls.Add(butReinicio);
            Controls.Add(butDetener);
            Controls.Add(butIniciar);
            Controls.Add(lblcronos);
            Name = "Form1";
            Text = "Cronometro";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcronos;
        private System.Windows.Forms.Timer tmrCronos;
        private Button butIniciar;
        private Button butDetener;
        private Button butReinicio;
    }
}
