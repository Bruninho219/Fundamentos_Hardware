using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fundamentos_Hardware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResizeMode = System.Windows.ResizeMode.NoResize;
            CarregarImagem();
        }
        public int i = 0;
        public int iMax = 16;
        public int x = 0;

        private void proximo_Click(object sender, RoutedEventArgs e)
        {
            x = 0;
            i++;
            CarregarImagem();
        }

        private void anterior_Click(object sender, RoutedEventArgs e)
        {
            x = 0;
            i--;
            CarregarImagem();
        }

        public void CarregarImagem()
        {
            if(i>=iMax)
            {
                i = iMax;
            }

            if(i<=0)
            {
                i = 0;
            }
            
            imag.Source = new BitmapImage(new Uri("/Img/"+i+".png", UriKind.Relative));
            descricao.Text = desc();
        }

        private void inicio_Click(object sender, RoutedEventArgs e)
        {
            x++;
            if(x>=25)
            {
                descricao.Text = "Instituto Federal de Ciência e Tecnologia Catarinense - Campus Sombrio [19/05/2018]\nProfessor: Armando Mendes Neto\nDesenvolvedor: Bruno Rosa da Silva\nImagens: Joel Boff Teixeira\nAjuda tecnica: Andrey Schwank Machado";
            }
            else
            {
                CarregarImagem();
            }
            i = 0;
            
        }

        private string desc()
        {
            string txt="";

            switch (i)
            {
                case 0:
                    txt = "Trabalho de Hardware\nProfessor: Armando Mendes Neto\nGrupo:\n            Andrey Machado,\n            Bruno Silva,\n            Joel Teixeira.";
                    break;
                case 1:
                    txt = "1- Escolher o gabinete de acordo com o tamanho da placa mãe, verificando os buracos de encaixe.\n(Circulados em vermelho)";
                    break;
                case 2:
                    txt = "2- Abrir o soquete e encaixar o processador de modo correto.\n(Aberto)";
                    break;
                case 3:
                    txt = "2- Abrir o soquete e encaixar o processador de modo correto.\n(Fechado)";
                    break;
                case 4:
                    txt = "3- Encaixar as placas de vídeo e de rede nas entradas AGP e PCI respectivamente.";
                    break;
                case 5:
                    txt = "4- E parafusa-las no suporte...";
                    break;
                case 6:
                    txt = "4- Inserir a memória RAM no slot.";
                    break;
                case 7:
                    txt = "5- Inserir pela parte da frente do gabinete o leitor de DVD e disquete (caso houver).";
                    break;
                case 8:
                    txt = "5- E parafusá-lo...";
                    break;
                case 9:
                    txt = "6- Inserir o HD (Disco Rígido) pelo lado de dentro do gabinete entre as duas repartições, geralmente com a parte dos circuitos para baixo.";
                    break;
                case 10:
                    txt = "7- Colocação do coler nas quatro cavidades sobre o processador.";
                    break;
                case 11:
                    txt = "8- Inserir a fonte do lado do coler.";
                    break;
                case 12:
                    txt = "8- E parafusá-lo...";
                    break;
                case 13:
                    txt = "9- Colocação dos cabos da fonte, sata...";
                    break;
                case 14:
                    txt = "9- ...e flat.";
                    break;
                case 15:
                    txt = "10- Ecaixar a tampa e parafusá-la.\n(FIM!)";
                    break;
                case 16:
                    txt = "Agora que tudo está pronto, até seu totó vai querer jogar com você :)";
                    break;
                default:
                    txt = "Erro desconhecido!";
                    break;
            }
            return txt;
        }
    }
}
