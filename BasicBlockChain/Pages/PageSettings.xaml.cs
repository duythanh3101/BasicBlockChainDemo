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

namespace BasicBlockChain.Pages
{
    /// <summary>
    /// Interaction logic for PageSettings.xaml
    /// </summary>
    public partial class PageSettings : Page
    {
        public PageSettings()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void NumberDifficultValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-3]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string difficulty = string.Empty;
            string reward = string.Empty;

            if (DifficultTextBox.Text != null)
            {
                difficulty = DifficultTextBox.Text.ToString();
            }

            if (RewardTextBox.Text != null)
            {
                reward = RewardTextBox.Text.ToString();
            }

            if (!string.IsNullOrEmpty(difficulty) && !string.IsNullOrEmpty(reward))
            {
                GlobalVariables.Difficulty = int.Parse(difficulty);
                GlobalVariables.Reward = int.Parse(reward);

                notifyLabel.Content = "Save successfully !!!";
            }
            else
            {
                notifyLabel.Content = "Save failed !!!";
            }

        }
    }
}
