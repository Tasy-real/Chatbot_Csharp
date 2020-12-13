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
using AIMLbot;

namespace Chatbot
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void response_Click(object sender, RoutedEventArgs e)
        {
            Bot Cp = new Bot();
            Cp.loadSettings();
            Cp.loadAIMLFromFiles();
            Cp.isAcceptingUserInput = false;

            User myUser = new User("User",Cp);
            Cp.isAcceptingUserInput = true;

            Request r = new Request(UserInput.Text, myUser, Cp);
            Result res = Cp.Chat(r);
            BotOutput.Text = "Bot: " + res.Output; 

        }
    }
}
