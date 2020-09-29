using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4 {
    public partial class Form1 : Form {

        const int MAX = 50;
        struct tp_pilha {
            public int topo;
            public char[] vetor;
        }
        tp_pilha pilha;

        // Inicialização
        void Inicializa(ref tp_pilha p) {
            p.topo = -1;
            p.vetor = new char[MAX];
        }

        bool EstaVazia(tp_pilha p) {
            return (p.topo == -1);
        }

        bool EstaCheia(tp_pilha p) {
            return (p.topo == MAX - 1);
        }

        void Insere(ref tp_pilha p, char valor) {
            p.vetor[++p.topo] = valor;
        }

        char Remove(ref tp_pilha p) {
            return (p.vetor[p.topo--]);
        }
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void BT_Processa_Click(object sender, EventArgs e) {
            Inicializa(ref pilha);
            String P_original = TB_original.Text;
            String Resultado = "";
            int i, j;
            i = 0;
            char c;
            while (i < P_original.Length) {
                while (i < P_original.Length && P_original[i] != ' ') {
                    c = P_original[i];
                    Insere(ref pilha, c);
                    i++;
                }
                j = 0;
                while (pilha.topo != -1) {
                    c = Remove(ref pilha);
                    Resultado = Resultado + c;
                    j++;
                }
                i++;
                Resultado = Resultado + " ";
            }
            TB_Invertida.Text = Resultado;
        }
    }
}
