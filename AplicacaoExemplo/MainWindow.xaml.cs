using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace AplicacaoExemplo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();
        }

        private bool NumberValidationTextBox(string Text)
        {
            Regex regex = new Regex("[^0-9]+");
           return regex.IsMatch(Text);
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            //this.BtnPrincipal.Content = "Olá";

            if (NumberValidationTextBox(this.txtDiminuidor.Text) && NumberValidationTextBox(this.txtContador.Text))
            {
                this.txtDiminuidor.Text = (Convert.ToInt32(this.txtDiminuidor.Text) - 1).ToString();
              
                this.txtContador.Text = (Convert.ToInt32(this.txtContador.Text) + 1).ToString();              
            }
            else
            {
                this.txtContador.Text = 0.ToString();
                this.txtDiminuidor.Text = 50.ToString();
               
                MessageBox.Show("insira apenas numeros");
            }
          
        }
    }
}
