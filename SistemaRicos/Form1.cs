using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

            private void Form1_Load(object sender, EventArgs e) {

                List<string> refeicao = new List<string>
            {
                "Beringela molho carne",
                "Beringela molho vermelho",
                "Bolo de carne",
                "Carne assada",
                "Carne moída",
                "Contra filé",
                "Contra filé milanesa",
                "Contra filé parmegiana",
                "Costela com lombo",
                "Frango grelhado",
                "Frango milanesa",
                "Frango agridoce",
                "Frango parmegiana",
                "Filé mignon",
                "Isca de fígado",
                "Lasanha",
                "Linguiça churrasco",
                "Linguiça fina",
                "Macarrão bolonhesa",
                "Macarrão almondegas",
                "Macarrão camarão",
                "Nhoque molho vermelho",
                "Nhoque molho carne",
                "Nhoque recheado MV",
                "Nhoque recheado MC",
                "Omelete camarão",
                "Omelete carne seca",
                "Omelete minas",
                "Omelete mussarela",
                "Panqueca camarão",
                "Panqueca frango",
                "Panqueca carne",
                "Peixe milanesa",
                "Picanha suína",
                "Raviolli",
                "Strogonoff de frango",
                "Strogonoff de carne",
                "Salmão",
                "Suíno grelhado",
                "Suíno milanesa",
                "Suíno agridoce",
                "Suíno parmegiana",
                "Tilapia",
                "Truta"
            };

                foreach (string item in refeicao)
                {
                    comboRef.Items.Add(item);
                }

            List<string> bebida = new List<string>
            {
                "Água",
                "Água c/ gás",
                "Ativ plus",
                "Dose",
                "Capirinha limão",
                "Caipirinha frutas",
                "Caipivodka limão",
                "Caipivodka frutas",
                "Cerveja 600ml",
                "Stella 600ml",
                "Heineken 600",
                "Long neck",
                "Long neck heineken",
                "Coca-cola 350ml",
                "Refrigerante 350ml",
                "Refrigerante caçula",
                "Refrigerante 1l",
                "Refrigerante 1,5l",
                "Refrigerante 2l",
                "Mineirinho 350ml",
                "H20, Matte 500ml",
                "Matte, ice-tea, H20 1,5l",
                "Suco only pq",
                "Suco only gr",
                "Suco natural copo",
                "Suco natural jarra",
                "Taça vinho",
                "Vodka (dose)",
                "Red label (dose)",
                "Run (dose)",
                "Tequila (dose)",
                "Campary (dose)",
                "Saque (dose)",
                "Martini (dose)",
                "Contini (dose)",
                "Gin (dose)"
            };

            foreach (string item in bebida)
            {
                ComboBeb.Items.Add(item);
            }
            }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelecionado = comboRef.SelectedItem.ToString();
        }

        private void ComboExtra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBeb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemSelecionado = ComboBeb.SelectedItem.ToString();
        }
    }
}
