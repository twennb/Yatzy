using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Alternate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Player _playerOne;
        private Player _playerTwo;
        private Player _playerThree;
        private Player _playerFour;
        private Player _playerFive;
        private Player _playerSix;

        public MainWindow()
        {
            InitializeComponent();

            _playerOne = new Player(playerOneOnes.Name, playerOneTwos.Name, playerOneThrees.Name,
                playerOneFours.Name, playerOneFives.Name, playerOneSixes.Name);

        }
    }
}