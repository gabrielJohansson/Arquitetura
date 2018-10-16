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
using System.Windows.Shapes;

namespace JogosDeGuerra
{
    /// <summary>
    /// Interaction logic for TelaDeGuerra.xaml
    /// </summary>
    public partial class TelaDeGuerra : Window
    {
        public TelaDeGuerra()
        {
            InitializeComponent();
        }

        public CommandManager ComandManager { get; set; } = new CommandManager();

        public List<ElementosDoExercito> Elementos { get; set; } = new List<ElementosDoExercito>();

        public AbstractFactoryExercito FactoryExercito {get;set;}

        private void ButtonCriarArqueiro_Click(object sender, RoutedEventArgs e)
        {
            Command cmd = new CommandCriarArqueiro(this.FactoryExercito, this.Elementos);

            this.ComandManager.Execute(cmd);
        }

        private void ButtonCriarGuerreiro_Click(object sender, RoutedEventArgs e)
        {
            Command cmd = new CommandCriarGuerreiro(this.FactoryExercito, this.Elementos);

            this.ComandManager.Execute(cmd);

            //Guerreiro guerreiro = FactoryExercito.CriarGuerreiro();
            //this.Elementos.Add(guerreiro);
        }

        private void ButtonCriarCavalaria_Click(object sender, RoutedEventArgs e)
        {

            Command cmd = new CommandCriarCavalaria(this.FactoryExercito, this.Elementos);

            this.ComandManager.Execute(cmd);

        }

        private void ButtonDesfazer_Click(object sender, RoutedEventArgs e)
        {
            ComandManager.Undo();
        }

        private void ButtonRefazer_Click(object sender, RoutedEventArgs e)
        {
            ComandManager.Redo();
        }
    }
}
