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

        private int _playerOneSum;
        private int _playerTwoSum;
        private int _playerThreeSum;
        private int _playerFourSum;
        private int _bonusThreshold = 63;

        private int previousSum;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayerSumCalc(TextBox sender)
        {
            if(sender.Name.Contains("First"))
            {
                if (sender.Text != "")
                {
                    if (playerOneSum.Content == null)
                    {
                        playerOneSum.Content = _playerOneSum + int.Parse(sender.Text);
                        sender.Focusable = false;

                        if(int.Parse(playerOneSum.Content.ToString()) >= _bonusThreshold)
                        {
                            playerOneBonus.Content = 50;
                        }
                    }
                    else
                    {
                        previousSum = int.Parse(playerOneSum.Content.ToString());
                        playerOneSum.Content = previousSum + int.Parse(sender.Text);
                        sender.Focusable = false;

                        if (int.Parse(playerOneSum.Content.ToString()) >= _bonusThreshold)
                        {
                            playerOneBonus.Content = 50;
                        }
                    }
                }
            }
            else if (sender.Name.Contains("Second"))
            {
                if (playerTwoSum.Content == null)
                {
                    playerTwoSum.Content = _playerTwoSum + int.Parse(sender.Text);
                    sender.Focusable = false;

                    if (int.Parse(playerTwoSum.Content.ToString()) >= _bonusThreshold)
                    {
                        playerTwoBonus.Content = 50;
                    }
                }
                else
                {
                    previousSum = int.Parse(playerTwoSum.Content.ToString());
                    playerTwoSum.Content = previousSum + int.Parse(sender.Text);
                    sender.Focusable = false;

                    if (int.Parse(playerTwoSum.Content.ToString()) >= _bonusThreshold)
                    {
                        playerTwoBonus.Content = 50;
                    }
                }
            }
            else if (sender.Name.Contains("Third"))
            {
                if (playerThreeSum.Content == null)
                {
                    playerThreeSum.Content = _playerThreeSum + int.Parse(sender.Text);
                    sender.Focusable = false;

                    if (int.Parse(playerThreeSum.Content.ToString()) >= _bonusThreshold)
                    {
                        playerThreeBonus.Content = 50;
                    }
                }
                else
                {
                    previousSum = int.Parse(playerThreeSum.Content.ToString());
                    playerThreeSum.Content = previousSum + int.Parse(sender.Text);
                    sender.Focusable = false;

                    if (int.Parse(playerThreeSum.Content.ToString()) >= _bonusThreshold)
                    {
                        playerThreeBonus.Content = 50;
                    }
                }
            }
            else if (sender.Name.Contains("Fourth"))
            {
                if (playerFourSum.Content == null)
                {
                    playerFourSum.Content = _playerFourSum + int.Parse(sender.Text);
                    sender.Focusable = false;

                    if (int.Parse(playerFourSum.Content.ToString()) >= _bonusThreshold)
                    {
                        playerFourBonus.Content = 50;
                    }
                }
                else
                {
                    previousSum = int.Parse(playerFourSum.Content.ToString());
                    playerFourSum.Content = previousSum + int.Parse(sender.Text);
                    sender.Focusable = false;

                    if (int.Parse(playerFourSum.Content.ToString()) >= _bonusThreshold)
                    {
                        playerFourBonus.Content = 50;
                    }
                }
            }
            else
            {
                MessageBox.Show("Somethings real wrong if you see this");
            }
        }

        private void player_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                PlayerSumCalc(((TextBox)sender));
            }
        }
    }
}