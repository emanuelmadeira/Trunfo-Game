using System.Net.NetworkInformation;
using System.Runtime.Intrinsics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Trunfo_Game
{
    public partial class Form1 : Form
    {
        
       private List<Cartajog> cartaJog ;

        public Form1()
        {
            InitializeComponent();
            cartaJog = new List<Cartajog>();
            inicializadorcarta();

        }
        private void inicializadorcarta()
        {
            CartaJog ayrton = new CartaJog();
            ayrton.velocidade = 89;
            ayrton.chute = 72;
            ayrton.passe = 75;
            ayrton.defesa = 82;

            CartaJog rony = new CartaJog();
            rony.velocidade = 89;
            rony.chute = 72;
            rony.passe = 75;
            rony.defesa = 82;
        }
        private void distruibircartas()
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            inicializadorcarta();

        }
    }
}