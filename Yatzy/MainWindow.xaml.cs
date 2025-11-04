using System.CodeDom;
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

namespace Yatzy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private int _playerOneSum;
        private int _playerTwoSum;
        private int _playerThreeSum;
        private int _playerFourSum;

        private List<int> PlayerOneResults;
        private List<int> PlayerTwoResults;
        private List<int> PlayerThreeResults;
        private List<int> PlayerFourResults;


        public MainWindow()
        {
            InitializeComponent();

            UpdateSumPlayerOne();
            UpdateSumPlayerTwo();
            UpdateSumPlayerThree();
            UpdateSumPlayerFour();
        }
        
        private void UpdateSumPlayerOne()
        {
            _playerOneSum = 0;
            PlayerOneResults = new List<int>();

            if (playerOneOnes.Text.Length != 0)
            {
                PlayerOneResults.Add(int.Parse(playerOneOnes.Text));
            }
            if (playerOneTwos.Text.Length != 0)
            {
                PlayerOneResults.Add(int.Parse(playerOneTwos.Text));
            }
            if (playerOneThrees.Text.Length != 0)
            {
                PlayerOneResults.Add(int.Parse(playerOneThrees.Text));
            }
            if (playerOneFours.Text.Length != 0)
            {
                PlayerOneResults.Add(int.Parse(playerOneFours.Text));
            }
            if (playerOneFives.Text.Length != 0)
            {
                PlayerOneResults.Add(int.Parse(playerOneFives.Text));
            }
            if (playerOneSixes.Text.Length != 0)
            {
                PlayerOneResults.Add(int.Parse(playerOneSixes.Text));
            }

            foreach(int i in PlayerOneResults)
            {
                _playerOneSum += i;
            }

            playerOneSum.Content = _playerOneSum;
        }
        private void UpdateSumPlayerTwo()
        {
            _playerTwoSum = 0;
            PlayerTwoResults = new List<int>();

            if (playerTwoOnes.Text.Length != 0)
            {
                PlayerTwoResults.Add(int.Parse(playerTwoOnes.Text));
            }
            if (playerTwoTwos.Text.Length != 0)
            {
                PlayerTwoResults.Add(int.Parse(playerTwoTwos.Text));
            }
            if (playerTwoThrees.Text.Length != 0)
            {
                PlayerTwoResults.Add(int.Parse(playerTwoThrees.Text));
            }
            if (playerTwoFours.Text.Length != 0)
            {
                PlayerTwoResults.Add(int.Parse(playerTwoFours.Text));
            }
            if (playerTwoFives.Text.Length != 0)
            {
                PlayerTwoResults.Add(int.Parse(playerTwoFives.Text));
            }
            if (playerTwoSixes.Text.Length != 0)
            {
                PlayerTwoResults.Add(int.Parse(playerTwoSixes.Text));
            }

            foreach (int i in PlayerTwoResults)
            {
                _playerTwoSum += i;
            }

            playerTwoSum.Content = _playerTwoSum;
        }
        private void UpdateSumPlayerThree()
        {
            _playerThreeSum = 0;
            PlayerThreeResults = new List<int>();

            if (playerThreeOnes.Text.Length != 0)
            {
                PlayerThreeResults.Add(int.Parse(playerThreeOnes.Text));
            }
            if (playerThreeTwos.Text.Length != 0)
            {
                PlayerThreeResults.Add(int.Parse(playerThreeTwos.Text));
            }
            if (playerThreeThrees.Text.Length != 0)
            {
                PlayerThreeResults.Add(int.Parse(playerThreeThrees.Text));
            }
            if (playerThreeFours.Text.Length != 0)
            {
                PlayerThreeResults.Add(int.Parse(playerThreeFours.Text));
            }
            if (playerThreeFives.Text.Length != 0)
            {
                PlayerThreeResults.Add(int.Parse(playerThreeFives.Text));
            }
            if (playerThreeSixes.Text.Length != 0)
            {
                PlayerThreeResults.Add(int.Parse(playerThreeSixes.Text));
            }

            foreach (int i in PlayerThreeResults)
            {
                _playerThreeSum += i;
            }

            playerThreeSum.Content = _playerThreeSum;
        }
        private void UpdateSumPlayerFour()
        {
            _playerFourSum = 0;
            PlayerFourResults = new List<int>();

            if (playerFourOnes.Text.Length != 0)
            {
                PlayerFourResults.Add(int.Parse(playerFourOnes.Text));
            }
            if (playerFourTwos.Text.Length != 0)
            {
                PlayerFourResults.Add(int.Parse(playerFourTwos.Text));
            }
            if (playerFourThrees.Text.Length != 0)
            {
                PlayerFourResults.Add(int.Parse(playerFourThrees.Text));
            }
            if (playerFourFours.Text.Length != 0)
            {
                PlayerFourResults.Add(int.Parse(playerFourFours.Text));
            }
            if (playerFourFives.Text.Length != 0)
            {
                PlayerFourResults.Add(int.Parse(playerFourFives.Text));
            }
            if (playerFourSixes.Text.Length != 0)
            {
                PlayerFourResults.Add(int.Parse(playerFourSixes.Text));
            }

            foreach (int i in PlayerFourResults)
            {
                _playerFourSum += i;
            }

            playerFourSum.Content = _playerFourSum;
        }

        private void CheckBonusPlayerOne()
        {
            if((int)playerOneSum.Content >= 63)
            {
                playerOneBonus.Content = 50;
            }
            else
            {
                playerOneBonus.Content = "x";
            }
        }
        private void CheckBonusPlayerTwo()
        {
            if ((int)playerTwoSum.Content >= 63)
            {
                playerTwoBonus.Content = 50;
            }
            else
            {
                playerTwoBonus.Content = "x";
            }
        }
        private void CheckBonusPlayerThree()
        {
            if ((int)playerThreeSum.Content >= 63)
            {
                playerThreeBonus.Content = 50;
            }
            else
            {
                playerThreeBonus.Content = "x";
            }
        }
        private void CheckBonusPlayerFour()
        {
            if ((int)playerFourSum.Content >= 63)
            {
                playerFourBonus.Content = 50;
            }
            else
            {
                playerFourBonus.Content = "x";
            }
        }
  
        private void SummaButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateSumPlayerOne();
            UpdateSumPlayerTwo();
            UpdateSumPlayerThree();
            UpdateSumPlayerFour();
        }
        private void BonusButton_Click(object sender, RoutedEventArgs e)
        {
            CheckBonusPlayerOne();
            CheckBonusPlayerTwo();
            CheckBonusPlayerThree();
            CheckBonusPlayerFour();
        }
    }
}