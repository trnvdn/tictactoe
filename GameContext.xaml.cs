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

namespace tictactoe
{
    /// <summary>
    /// Логика взаимодействия для GameContext.xaml
    /// </summary>
    public partial class GameContext : Window
    {
        public GameContext()
        {
            InitializeComponent();
            this.WindowStyle = WindowStyle.None;
        }
        private bool player = false;

        public List<int> VALUES = new List<int>() { -1, 2, 3, 4, 5, 6, 7, 8, 9 };

        public string TextValue(bool p)
        {
            return p ? "X" : "О";
        }
        public bool NextPl(bool p)
        {
            return !p;
        }

        public void Check()
        {
            if (VALUES[0] == VALUES[1] && VALUES[0] == VALUES[2] || VALUES[0] == VALUES[3] && VALUES[0] == VALUES[6] || VALUES[0] == VALUES[4] && VALUES[0] == VALUES[8] || VALUES[3] == VALUES[4] && VALUES[3] == VALUES[5] || VALUES[1] == VALUES[4] && VALUES[1] == VALUES[7] || VALUES[2] == VALUES[4] && VALUES[2] == VALUES[6] || VALUES[6] == VALUES[7] && VALUES[6] == VALUES[8] || VALUES[2] == VALUES[5] && VALUES[2] == VALUES[8])
            {
                GameOver go = new GameOver();
                Button1.IsEnabled = false;
                Button2.IsEnabled = false;
                Button3.IsEnabled = false;
                Button4.IsEnabled = false;
                Button5.IsEnabled = false;
                Button6.IsEnabled = false;
                Button7.IsEnabled = false;
                Button8.IsEnabled = false;
                Button9.IsEnabled = false;
                go.Show();
            }

        }
            
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button1.Content = TextValue(player);
            VALUES[0] = player ? 1 : 0;
            player = NextPl(player);
            Button1.IsEnabled = false;
            Check();
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Button2.Content = TextValue(player);
            VALUES[1] = player ? 1 : 0;
            player = NextPl(player);
            Button2.IsEnabled = false;
            Check();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Button3.Content = TextValue(player);
            VALUES[2] = player ? 1 : 0;
            player = NextPl(player);
            Button3.IsEnabled = false;
            Check();
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Button4.Content = TextValue(player);
            VALUES[3] = player ? 1 : 0;
            player = NextPl(player);
            Button4.IsEnabled = false;
            Check();
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Button5.Content = TextValue(player);
            VALUES[4] = player ? 1 : 0;
            player = NextPl(player);
            Button5.IsEnabled = false;
            Check();
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Button6.Content = TextValue(player);
            VALUES[5] = player ? 1 : 0;
            player = NextPl(player);
            Button6.IsEnabled = false;
            Check();
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Button7.Content = TextValue(player);
            VALUES[6] = player ? 1 : 0;
            player = NextPl(player);
            Button7.IsEnabled = false;
            Check();
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            Button8.Content = TextValue(player);
            VALUES[7] = player ? 1 : 0;
            player = NextPl(player);
            Button8.IsEnabled = false;
            Check();
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            Button9.Content = TextValue(player);
            VALUES[8] = player ? 1 : 0;
            player = NextPl(player);
            Button9.IsEnabled = false;
            Check();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
    }


