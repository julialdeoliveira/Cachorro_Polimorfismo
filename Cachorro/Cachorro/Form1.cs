namespace Cachorro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoldenRetriever golden = new GoldenRetriever();
            MiniPinscher mini = new MiniPinscher();
            double total1 = golden.Comer();
            double total2 = mini.Comer();
            Canil c = new Canil();
            c.AdicionarCachorro(golden);
            c.AdicionarCachorro(mini);
            double total = c.CalcularTotalGasto();

           
        }
        class Canil
        {
            private List<Cachorro> cachorros = new List<Cachorro>();

            public void AdicionarCachorro(Cachorro c)
            {
                cachorros.Add(c);
            }
            public double CalcularTotalGasto()
            {
                double soma = 0;
                for (int i = 0; i < this.cachorros.Count; i++)
                {   //Polimorfismo
                    soma += this.cachorros[i].Comer();
                }
                return soma;

            }
        }
        class Cachorro
        {
            public string Nome { get; set; }
            public string Peso { get; set; }

            public virtual double Comer()
            {
                return 500;
            }
        }
        class GoldenRetriever : Cachorro
        {
            public override double Comer()
            {
                return base.Comer() * 3;
            }
        }
        class MiniPinscher : Cachorro
        {
            public override double Comer()
            {
                return base.Comer() / 2;
            }
        }

    }
}