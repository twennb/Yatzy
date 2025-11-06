using System.Security.Cryptography.X509Certificates;
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
        // define the threshold for getting bonus points and how many
        private int _bonusThreshold = 63;
        private int _bonusPoints = 50;

        private int previousSum;


        public MainWindow()
        {
            InitializeComponent();

            TextBoxChange();
        }

        private void TextBoxChange()
        {
            starRun.Text = " *";
            messageRun.Text = "You did it wrong";
        }

        private void TextBoxFadeOut(object sender, RoutedEvent e)
        {
            starRun.Text = " *";
            messageRun.Text = "You did it wrong";
        }

        private void TextBoxFadeIn(object sender, RoutedEventArgs e)
        {
            starRun.Text = " *";
            messageRun.Text = "You did it wrong";
        }



        // Define the function that is called by the textbox events
        private void PlayerSumCalc(TextBox sender) // this function takes in a TextBox object, the box that called it
        { 

            if (sender.Text != "") // make sure the sender box isn't empty, if it is do nothing
            {
                if (sender.Name.Contains("First")) // check if player 1 owns the box
                {
                    previousSum = int.Parse(playerOneSum.Content.ToString()); // stores the current sum before adding the new
                    playerOneSum.Content = previousSum + int.Parse(sender.Text); // new sum = old sum plus new value from sender
                    
                    sender.Focusable = false; // make non interactible 


                    if (int.Parse(playerOneSum.Content.ToString()) >= _bonusThreshold) // check if bonus is met
                    {
                        playerOneBonus.Content = _bonusPoints; // show bonus points
                    }
                }
                else if (sender.Name.Contains("Second"))
                {
                    previousSum = int.Parse(playerTwoSum.Content.ToString());
                    playerTwoSum.Content = previousSum + int.Parse(sender.Text);

                    sender.Focusable = false;


                    if (int.Parse(playerTwoSum.Content.ToString()) >= _bonusThreshold)
                    {
                        playerTwoBonus.Content = _bonusPoints;
                    }
                }
                else if (sender.Name.Contains("Third"))
                {
                    previousSum = int.Parse(playerThreeSum.Content.ToString());
                    playerThreeSum.Content = previousSum + int.Parse(sender.Text);

                    sender.Focusable = false;

                    if (int.Parse(playerThreeSum.Content.ToString()) >= _bonusThreshold)
                    {
                        playerThreeBonus.Content = _bonusPoints;
                    }
                }
                else if (sender.Name.Contains("Fourth"))
                {
                    previousSum = int.Parse(playerFourSum.Content.ToString());
                    playerFourSum.Content = previousSum + int.Parse(sender.Text);

                    sender.Focusable = false;

                    if (int.Parse(playerFourSum.Content.ToString()) >= _bonusThreshold)
                    {
                        playerFourBonus.Content = _bonusPoints;
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
                PlayerSumCalc((TextBox)sender); // runs the function to handle everything after user presses Enter in a box
            }
        }

        private void test(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                MessageBox.Show("");
            }
        }
    }
}