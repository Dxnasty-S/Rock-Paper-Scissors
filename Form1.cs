using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int rodadas = 3;
        int tempoPorRodada = 6;
        bool fimDeJogo = false;

        string[] listaDeEscolhasDaCPU = { "pedra", "papel", "tesoura", "pedra", "pedra", "tesoura" };

        int numeroAleatorio = 0;

        Random aleatorio = new Random();

        string escolhaDoJogador;
        string escolhaDaCPU;

        int pontosDoJogador;
        int pontosDaCPU;
        public Form1()
        {
            InitializeComponent();

            GameTimer.Enabled = true;
            escolhaDoJogador = "nenhuma";
            txtCronometro.Text = "5";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Atualizar(object sender, EventArgs e)
        {
            tempoPorRodada -= 1;
            txtCronometro.Text = tempoPorRodada.ToString();
            txtRodada.Text = "Rodada: " + rodadas;

            if (tempoPorRodada < 1)
            {
                GameTimer.Enabled = false;
                tempoPorRodada = 6;
                numeroAleatorio = aleatorio.Next(0, listaDeEscolhasDaCPU.Length);

                escolhaDaCPU = listaDeEscolhasDaCPU[numeroAleatorio];

                switch (escolhaDaCPU)
                {
                    case ("pedra"):
                         picComputador.Image = Properties.Resources.rock;
                        break;
                    case ("papel"):
                        picComputador.Image = Properties.Resources.paper;
                        break;
                    case ("tesoura"):
                        picComputador.Image = Properties.Resources.scissors;
                        break;
                    default:
                        break;
                }

                if(rodadas > 0)
                {
                    verificarJogo();
                }

            }
        }

        private void btnPedra_Click(object sender, EventArgs e)
        {
            picJogador.Image = Properties.Resources.rock;
            escolhaDoJogador = "pedra";
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            picJogador.Image = Properties.Resources.paper;
            escolhaDoJogador = "papel";
        }

        private void btnTesoura_Click(object sender, EventArgs e)
        {
            picJogador.Image = Properties.Resources.scissors;
            escolhaDoJogador = "tesoura";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            pontosDoJogador = 0;
            pontosDaCPU = 0;
            rodadas = 3;
            txtPontos.Text = "Jogador: " + pontosDoJogador + " - " + "PC: " + pontosDaCPU;

            escolhaDoJogador = "nenhuma";

            GameTimer.Enabled = true;

            picJogador.Image = Properties.Resources.qq;
            picComputador.Image = Properties.Resources.qq;

            fimDeJogo = false;
        }

        private void verificarJogo()
        {
            if(escolhaDoJogador == "pedra" && escolhaDaCPU == "papel")
            {
                pontosDaCPU++;
                rodadas--;
                MessageBox.Show("Computador Ganha! Papel cobre pedra!");
            }
            else if (escolhaDoJogador == "papel" && escolhaDaCPU == "tesoura")
            {
                pontosDaCPU++;
                rodadas--;
                MessageBox.Show("Computador Ganha! Tesoura corta papel!");
            }
            else if (escolhaDoJogador == "tesoura" && escolhaDaCPU == "pedra")
            {
                pontosDaCPU++;
                rodadas--;
                MessageBox.Show("Computador Ganha! Pedra quebra tesoura!");
            }
            else if (escolhaDoJogador == "pedra" && escolhaDaCPU == "tesoura")
            {
                pontosDoJogador++;
                rodadas--;
                MessageBox.Show("Jogador Ganha! Pedra quebra tesoura!");
            }
            else if (escolhaDoJogador == "papel" && escolhaDaCPU == "pedra")
            {
                pontosDoJogador++;
                rodadas--;
                MessageBox.Show("Jogador Ganha! Papel cobre pedra!");
            }
            else if (escolhaDoJogador == "tesoura" && escolhaDaCPU == "papel")
            {
                pontosDoJogador++;
                rodadas--;
                MessageBox.Show("Jogador Ganha! Tesoura corta papel!");
            }
            else if (escolhaDoJogador == "nenhuma")
            {
                MessageBox.Show("Faça uma escolha!");
            }
            else
            {
                MessageBox.Show("Empate!");
            }

            iniciarProximaRodada();

        }

        private void iniciarProximaRodada()
        {
            if(fimDeJogo == true)
            {
                return;
            }

            txtPontos.Text = "Jogador: " + pontosDoJogador + " - " + "PC: " + pontosDaCPU;
            escolhaDoJogador = "nenhuma";

            GameTimer.Enabled = true;

            picComputador.Image = Properties.Resources.qq;
            picJogador.Image = Properties.Resources.qq;
        }
    }
}
