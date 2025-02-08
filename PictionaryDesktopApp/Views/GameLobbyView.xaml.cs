using System.Windows;

namespace PictionaryDesktopApp.Views
{
    public partial class GameLobbyView : Window
    {
        public GameLobbyView()
        {
            InitializeComponent(); // This links the XAML layout to the code-behind
        }

        private void HostGameButton_Click(object sender, RoutedEventArgs e)
        {
            // Your code to host a game goes here
            MessageBox.Show("Hosting Game...");
        }

        private void JoinGameButton_Click(object sender, RoutedEventArgs e)
        {
            // Your code to join a game goes here
            MessageBox.Show("Joining Game...");
        }
    }
}
