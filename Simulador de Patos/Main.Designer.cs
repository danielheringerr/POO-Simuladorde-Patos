namespace SimuladordePatos_UI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            JogoControles = new Panel();
            Sair = new Button();
            nextPato = new Button();
            prevPato = new Button();
            Nadar = new Button();
            Voar = new Button();
            Quack = new Button();
            PatosControle = new Panel();
            PatosDisplay = new PictureBox();
            JogoControles.SuspendLayout();
            PatosControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatosDisplay).BeginInit();
            SuspendLayout();
            // 
            // JogoControles
            // 
            JogoControles.BackColor = Color.FromArgb(30, 30, 30);
            JogoControles.Controls.Add(Sair);
            JogoControles.Controls.Add(nextPato);
            JogoControles.Controls.Add(prevPato);
            JogoControles.Dock = DockStyle.Bottom;
            JogoControles.Location = new Point(0, 358);
            JogoControles.Name = "JogoControles";
            JogoControles.Padding = new Padding(10);
            JogoControles.Size = new Size(334, 103);
            JogoControles.TabIndex = 0;
            JogoControles.Paint += panel1_Paint;
            // 
            // Sair
            // 
            Sair.BackColor = Color.Transparent;
            Sair.Cursor = Cursors.Hand;
            Sair.Image = (Image)resources.GetObject("Sair.Image");
            Sair.Location = new Point(135, 30);
            Sair.Name = "Sair";
            Sair.Size = new Size(60, 60);
            Sair.TabIndex = 3;
            Sair.UseVisualStyleBackColor = false;
            Sair.Click += sair_Click;
            // 
            // nextPato
            // 
            nextPato.Cursor = Cursors.Hand;
            nextPato.Image = (Image)resources.GetObject("nextPato.Image");
            nextPato.Location = new Point(251, 29);
            nextPato.Name = "nextPato";
            nextPato.Size = new Size(60, 60);
            nextPato.TabIndex = 1;
            nextPato.UseVisualStyleBackColor = true;
            nextPato.Click += nextPato_Click;
            // 
            // prevPato
            // 
            prevPato.Cursor = Cursors.Hand;
            prevPato.Image = (Image)resources.GetObject("prevPato.Image");
            prevPato.Location = new Point(22, 29);
            prevPato.Name = "prevPato";
            prevPato.Size = new Size(60, 60);
            prevPato.TabIndex = 0;
            prevPato.UseVisualStyleBackColor = true;
            prevPato.Click += prevPato_Click;
            // 
            // Nadar
            // 
            Nadar.Cursor = Cursors.Hand;
            Nadar.Image = (Image)resources.GetObject("Nadar.Image");
            Nadar.Location = new Point(22, 20);
            Nadar.Name = "Nadar";
            Nadar.Size = new Size(60, 60);
            Nadar.TabIndex = 0;
            Nadar.UseVisualStyleBackColor = true;
            Nadar.Click += Nadar_Click;
            // 
            // Voar
            // 
            Voar.Cursor = Cursors.Hand;
            Voar.Image = (Image)resources.GetObject("Voar.Image");
            Voar.Location = new Point(135, 20);
            Voar.Name = "Voar";
            Voar.Size = new Size(60, 60);
            Voar.TabIndex = 1;
            Voar.UseVisualStyleBackColor = true;
            Voar.Click += Voar_Click;
            // 
            // Quack
            // 
            Quack.Cursor = Cursors.Hand;
            Quack.Image = (Image)resources.GetObject("Quack.Image");
            Quack.Location = new Point(251, 20);
            Quack.Name = "Quack";
            Quack.Size = new Size(60, 60);
            Quack.TabIndex = 2;
            Quack.UseVisualStyleBackColor = true;
            Quack.Click += Quack_Click;
            // 
            // PatosControle
            // 
            PatosControle.BackColor = Color.FromArgb(30, 30, 30);
            PatosControle.Controls.Add(Nadar);
            PatosControle.Controls.Add(Quack);
            PatosControle.Controls.Add(Voar);
            PatosControle.Dock = DockStyle.Bottom;
            PatosControle.Location = new Point(0, 249);
            PatosControle.Name = "PatosControle";
            PatosControle.Size = new Size(334, 109);
            PatosControle.TabIndex = 3;
            PatosControle.Paint += PatosControle_Paint;
            // 
            // PatosDisplay
            // 
            PatosDisplay.BackColor = Color.FromArgb(30, 30, 30);
            PatosDisplay.Dock = DockStyle.Fill;
            PatosDisplay.Location = new Point(0, 0);
            PatosDisplay.Name = "PatosDisplay";
            PatosDisplay.Size = new Size(334, 249);
            PatosDisplay.TabIndex = 4;
            PatosDisplay.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(334, 461);
            Controls.Add(PatosDisplay);
            Controls.Add(PatosControle);
            Controls.Add(JogoControles);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            ShowInTaskbar = false;
            Text = "Simulador de Patos";
            Load += Main_Load;
            JogoControles.ResumeLayout(false);
            PatosControle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PatosDisplay).EndInit();
            ResumeLayout(false);

            // NOVAS FUNCIONALIDADES//
            btnAtivarIA = new Button();
            btnAtivarIA.Cursor = Cursors.Hand;
            btnAtivarIA.Image = (Image)resources.GetObject("btnAtivarIA.Image"); // Caso tenha uma imagem
            btnAtivarIA.Location = new Point(135, 90); // Ajuste de posição conforme seu layout
            btnAtivarIA.Name = "btnAtivarIA";
            btnAtivarIA.Size = new Size(60, 60);
            btnAtivarIA.TabIndex = 3;
            btnAtivarIA.UseVisualStyleBackColor = true;
            btnAtivarIA.Visible = false; // Começa oculto
            btnAtivarIA.Click += btnAtivarIA_Click;
            PatosControle.Controls.Add(btnAtivarIA);
        }

        #endregion

        private Panel JogoControles;
        private Button nextPato;
        private Button prevPato;
        private Button Selecionar;
        private Button Sair;
        private Button Nadar;
        private Button Voar;
        private Button Quack;
        private Panel PatosControle;
        private PictureBox PatosDisplay;
        private Button btnAtivarIA;
    }
}
