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

namespace TICTOENOLIK
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int x = 81, y = 61;
        private Button[,] buttons = new Button[3, 3];
        private int player;

        public MainWindow()
        {
            InitializeComponent();
            player = 1;
            label1.Content = "Ход: X игрока";
            for (int i = 0; i < buttons.Length / 3; i++)
            {
                for (int j = 0; j < buttons.Length / 3; j++)
                {

                    buttons[i, j] = new Button();
                }
            }
            
            setButtons();
        }

        private void setButtons()
        {
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    buttons[i, j].Margin = new Thickness(81 + 88 * j, 61 + 108 * i, 0, 0);
                    buttons[i, j].Click += Button1_Click;
                    

                }
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(sender.GetType().GetProperty("Name").GetValue(sender).ToString()); проверял вывод кнопок 
            switch (player)
            { 
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, "X");

                    player = 0;
                    label1.Content = "Ход: O игрока";
                    break;

                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, "O");
                    player = 1;
                    label1.Content = "Ход: X игрока";
                    break;

            }
            sender.GetType().GetProperty("IsEnabled").SetValue (sender, false);
            chekWiner();

        }
        private void chekWiner()
        {
            
            if (button1.Content == button2.Content && button2.Content == button3.Content)
            {
                if(button1.Content!="")
                MessageBox.Show("ВЫ WINNER");
            }
            if (button4.Content == button5.Content && button5.Content == button6.Content)
            {
                if (button4.Content != "")
                    MessageBox.Show("ВЫ WINNER");
            }
            if (button7.Content == button8.Content && button8.Content == button9.Content)
            {
                if (button7.Content != "")
                    MessageBox.Show("ВЫ WINNER");
            }
            if (button1.Content == button4.Content && button4.Content == button7.Content)
            {
                if (button1.Content != "")
                    MessageBox.Show("ВЫ WINNER");
            }
            if (button2.Content == button5.Content && button5.Content == button8.Content)
            {
                if (button2.Content != "")
                    MessageBox.Show("ВЫ WINNER");
            }
            if (button3.Content == button6.Content && button6.Content == button9.Content)
            {
                if (button3.Content != "")
                    MessageBox.Show("ВЫ WINNER");
            }
            if (button1.Content == button5.Content && button5.Content == button9.Content)
            {
                if (button1.Content != "")
                    MessageBox.Show("ВЫ WINNER");
            }
            if (button3.Content == button5.Content && button5.Content == button7.Content)
            {
                if (button3.Content != "")
                    MessageBox.Show("ВЫ WINNER");
            }


        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Content = "";
                    buttons[i, j].IsEnabled =true;
                }
            
            
            }
        }
    }
    

}

