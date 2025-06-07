
using System;
using System.Windows.Forms;
using SimuladorDePatos.Models;

namespace SimuladorDePatos.UI
{
    public partial class MainForm : Form
    {
        private Duck currentDuck;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateDuck_Click(object sender, EventArgs e)
        {
            if (cmbDuckType.SelectedItem.ToString() == "Mallard")
                currentDuck = new MallardDuck();
            else if (cmbDuckType.SelectedItem.ToString() == "Rubber")
                currentDuck = new RubberDuck();
            else if (cmbDuckType.SelectedItem.ToString() == "Cyber")
                currentDuck = new CyberDuck();

            lblStatus.Text = "Pato criado: " + currentDuck.GetType().Name;
        }

        private void btnFly_Click(object sender, EventArgs e)
        {
            currentDuck?.PerformFly();
        }

        private void btnQuack_Click(object sender, EventArgs e)
        {
            currentDuck?.PerformQuack();
        }
    }
}
