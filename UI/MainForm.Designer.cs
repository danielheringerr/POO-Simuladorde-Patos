
namespace SimuladorDePatos.UI
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbDuckType;
        private System.Windows.Forms.Button btnCreateDuck;
        private System.Windows.Forms.Button btnFly;
        private System.Windows.Forms.Button btnQuack;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbDuckType = new System.Windows.Forms.ComboBox();
            this.btnCreateDuck = new System.Windows.Forms.Button();
            this.btnFly = new System.Windows.Forms.Button();
            this.btnQuack = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();

            this.SuspendLayout();

            this.cmbDuckType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDuckType.Items.AddRange(new object[] { "Mallard", "Rubber", "Cyber" });
            this.cmbDuckType.Location = new System.Drawing.Point(12, 12);
            this.cmbDuckType.Name = "cmbDuckType";
            this.cmbDuckType.Size = new System.Drawing.Size(200, 21);

            this.btnCreateDuck.Location = new System.Drawing.Point(230, 10);
            this.btnCreateDuck.Text = "Criar Pato";
            this.btnCreateDuck.Click += new System.EventHandler(this.btnCreateDuck_Click);

            this.btnFly.Location = new System.Drawing.Point(12, 50);
            this.btnFly.Text = "Voar";
            this.btnFly.Click += new System.EventHandler(this.btnFly_Click);

            this.btnQuack.Location = new System.Drawing.Point(100, 50);
            this.btnQuack.Text = "Grasnar";
            this.btnQuack.Click += new System.EventHandler(this.btnQuack_Click);

            this.lblStatus.Location = new System.Drawing.Point(12, 90);
            this.lblStatus.Size = new System.Drawing.Size(300, 23);

            this.ClientSize = new System.Drawing.Size(360, 130);
            this.Controls.Add(this.cmbDuckType);
            this.Controls.Add(this.btnCreateDuck);
            this.Controls.Add(this.btnFly);
            this.Controls.Add(this.btnQuack);
            this.Controls.Add(this.lblStatus);
            this.Name = "MainForm";
            this.Text = "Simulador de Patos";

            this.ResumeLayout(false);
        }
    }
}
