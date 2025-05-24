using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Media;
using Simulador_de_Patos;

namespace SimuladordePatos_UI
{
    public partial class Main : Form
    {

        //Indica o pato atual
        int indiceAtual = 0;

        //Lista que contem os diferentes patos disponíveis 
        List<Duck> patos = new List<Duck>
        {
            new MallardDuck("..//imgs/MallardDuck.png", "..//sounds/MallardDuck.wav"),
            new RedHeadDuck("..//imgs/redHeadDuck.png", "..//sounds/redHeadDuck.wav"),
            new RubberDuck("..//imgs/RubberDuck.png", "..//sounds/rubberDuck.wav"),
            new CyberDuck("..//imgs/CyberDuck.png", "..//sounds/CyberDuck.wav")
        };

        public Main()
        {
            InitializeComponent(); //Carrega todos os componentes do formulário
        }


        // Método para carregar a foto do pato (PNG)
        public void carregarFoto(string caminho)
        {
            string patoAtual = patos[indiceAtual].GetType().Name; //Extrai o nome da classe do pato atual
            string caminhoAbsoluto = Path.Combine(Application.StartupPath, "imgs", patoAtual + ".png");//Cria o caminho absoluto da imagem do pato atual

            if (File.Exists(caminhoAbsoluto) && PatosDisplay != null)
            {
                PatosDisplay.BackgroundImage = Image.FromFile(caminhoAbsoluto);
                PatosDisplay.BackgroundImageLayout = ImageLayout.Zoom;

            }
            else
            {
                MessageBox.Show("Erro ao carregar imagem ou painel não instanciado.");
            }

            btnAtivarIA.Visible = (patos[indiceAtual] is CyberDuck);
        }

        // Método para trocar a foto do pato (PNG)
        public void trocarFoto(string caminho)
        {

            if (File.Exists(caminho) && PatosDisplay != null)
            {
                PatosDisplay.BackgroundImage = Image.FromFile(caminho);
                PatosDisplay.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else
            {
                MessageBox.Show(caminho);
                MessageBox.Show("Erro ao carregar imagem ou painel não instanciado.");
            }
        }


        // Método para carregar o som do pato (MP3)
        public void carregarQuackSound(string caminho)
        {
            string patoAtual = patos[indiceAtual].GetType().Name; //Extrai o nome da classe do pato atual
            string caminhoAbsoluto = Path.Combine(Application.StartupPath, "sounds", patoAtual + ".wav");//Cria o caminho absoluto do som do pato atual

            if (File.Exists(caminho))
            {
                SoundPlayer quackSound = new SoundPlayer(caminhoAbsoluto);
                quackSound.Play();
            }
            else
            {
                MessageBox.Show("Erro ao carregar imagem ou painel não instanciado.");
            }
        }


        // Métodos da Interface
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void nextPato_Click(object sender, EventArgs e)
        {
            if (indiceAtual >= patos.Count - 1)
            {
                indiceAtual = 0;
            }
            else
            {
                indiceAtual++;

            }
            carregarFoto(patos[indiceAtual].fotoPatoPath);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void prevPato_Click(object sender, EventArgs e)
        {
            if (indiceAtual <= 0)
            {
                indiceAtual = patos.Count - 1;
            }
            else
            {
                indiceAtual--;
            }
            carregarFoto(patos[indiceAtual].fotoPatoPath);
        }

        private void TelaPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Patos_Paint(object sender, PaintEventArgs e)
        {

        }


        //Utilizado para executar assim que o formulário iniciar
        private void Main_Load(object sender, EventArgs e)
        {
            carregarFoto(patos[indiceAtual].fotoPatoPath);

        }

        private void Nadar_Click(object sender, EventArgs e)
        {

            string caminhoNado = Path.Combine(Application.StartupPath, "imgs", patos[indiceAtual].GetType().Name + "Nadando.png");
            trocarFoto(caminhoNado);

        }

        //Painel onde serão apresentadas as imagens dos patos
        private void PatosDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Voar_Click(object sender, EventArgs e)
        {
            if (patos[indiceAtual] is IFlyable)
            {
                string caminhoVoo = Path.Combine(Application.StartupPath, "imgs", patos[indiceAtual].GetType().Name + "Voando.png");
                trocarFoto(caminhoVoo);
            }
            else
            {
                playFailSong();
            }
        }

        private void Quack_Click(object sender, EventArgs e)
        {
            string caminhoAbsoluto = Path.Combine(Application.StartupPath, "sounds", patos[indiceAtual].GetType().Name + ".wav");

            if (File.Exists(caminhoAbsoluto))
            {

                SoundPlayer quackSound = new SoundPlayer(caminhoAbsoluto);
                quackSound.Play();

            }
            else
            {
                MessageBox.Show($"{caminhoAbsoluto}");
                MessageBox.Show("Erro ao carregar imagem ou painel não instanciado.");
            }
        }

        private void PatoTela_Click(object sender, EventArgs e)
        {

        }

        private void playFailSong()
        {
            string caminhoAbsoluto = Path.Combine(Application.StartupPath, "sounds", "fail.wav");
            SoundPlayer failSound = new SoundPlayer(caminhoAbsoluto);
            failSound.Play();
        }

        private void PatosControle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAtivarIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IA Ativada! ?? Pronto para processar estratégias de voo e análise de quacks!", "CyberDuck IA");
        }
    }
}
