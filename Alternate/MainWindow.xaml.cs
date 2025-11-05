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

        // variables to hold each player's sums
        private int _playerOneSum = 0;
        private int _playerTwoSum = 0;
        private int _playerThreeSum = 0;
        private int _playerFourSum = 0;
        // define the threshold for getting bonus points and how many
        private int _bonusThreshold = 63;
        private int _bonusPoints = 50;

        private int previousSum;

        public MainWindow()
        {
            InitializeComponent();
        }

        // Define the function that is called by the textbox events
        private void PlayerSumCalc(TextBox sender) // this function takes in a TextBox object, the box that called it
        {
            if (sender.Text != "") // make sure the sender box isn't empty, if it is do nothing
            {
                if (sender.Name.Contains("First")) // check if player 1 owns the box
                {
                    if (playerOneSum.Content == null) // content is null until the sum is updated for the first time
                    {
                        playerOneSum.Content = _playerOneSum + int.Parse(sender.Text); // add the current sum to the value from the box
                        sender.Focusable = false; // make the box unfocusable so the value cannot be changed

                        if (int.Parse(playerOneSum.Content.ToString()) >= _bonusThreshold) // check if bonus is met
                        {
                            playerOneBonus.Content = _bonusPoints; // show points for bonus
                        }
                    }
                    else // this happens when playerOneSum.Content is not null, meaning every time after the first box
                    {   
                        previousSum = int.Parse(playerOneSum.Content.ToString()); // stores the current sum before adding the new
                        playerOneSum.Content = previousSum + int.Parse(sender.Text); // new sum is previous sum + new box's value
                        sender.Focusable = false; // make non interactible 

                        if (int.Parse(playerOneSum.Content.ToString()) >= _bonusThreshold) // check if bonus is met
                        {
                            playerOneBonus.Content = _bonusPoints; // show bonus points
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
                            playerTwoBonus.Content = _bonusPoints;
                        }
                    }
                    else
                    {
                        previousSum = int.Parse(playerTwoSum.Content.ToString());
                        playerTwoSum.Content = previousSum + int.Parse(sender.Text);
                        sender.Focusable = false;

                        if (int.Parse(playerTwoSum.Content.ToString()) >= _bonusThreshold)
                        {
                            playerTwoBonus.Content = _bonusPoints;
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
                            playerThreeBonus.Content = _bonusPoints;
                        }
                    }
                    else
                    {
                        previousSum = int.Parse(playerThreeSum.Content.ToString());
                        playerThreeSum.Content = previousSum + int.Parse(sender.Text);
                        sender.Focusable = false;

                        if (int.Parse(playerThreeSum.Content.ToString()) >= _bonusThreshold)
                        {
                            playerThreeBonus.Content = _bonusPoints;
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
                            playerFourBonus.Content = _bonusPoints;
                        }
                    }
                    else
                    {
                        previousSum = int.Parse(playerFourSum.Content.ToString());
                        playerFourSum.Content = previousSum + int.Parse(sender.Text);
                        sender.Focusable = false;

                        if (int.Parse(playerFourSum.Content.ToString()) >= _bonusThreshold)
                        {
                            playerFourBonus.Content = _bonusPoints;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Somethings real wrong if you see this");
                }
            }
        }

        private void player_KeyDown(object sender, KeyEventArgs e) // called when a keyboard event is registered by the box
        {
            if (e.Key == Key.Enter) // happens when the user presses Enter
            {
                PlayerSumCalc(((TextBox)sender)); // runs the function to handle everything after user presses Enter in a box
            }
        }
    }
}