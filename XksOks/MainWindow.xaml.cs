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

namespace XksOks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 9; i++)
            {
                isClicked[i] = false;
                MsgBox.Text = "X pocinje prvi";
                RezultatX.Text = rezX.ToString();
                RezultatO.Text = rezO.ToString();
            }

            
        }
        int rezX = 0;
        int rezO = 0;

        bool X = true;
        bool O = false;

        bool signal = false;
        bool[] isClicked = new bool[9];

        int brojac = 0;
        string[] array = { "0", "0", "0", "0", "0", "0", "0", "0", "0" };

            private void pobjednikX()
            {
            MessageBox.Show("Pobjednik je X", "Pobjednik", MessageBoxButton.OK, MessageBoxImage.Information);
            MsgBox.Text = "Pobjednik je X. Restartujte Igru !";
            rezX++;
            RezultatX.Text = rezX.ToString();
            }

            private void pobjednikO()
            {
                MessageBox.Show("Pobjednik je O", "Pobjednik", MessageBoxButton.OK, MessageBoxImage.Information);
                MsgBox.Text = "Pobjednik je O. Restartujte Igru !";
                rezO++;
                RezultatO.Text = rezO.ToString();

            }
            private void izjednaceno()
            {
                if ((brojac == 9) && !(CheckForWin()))
                {
                    MessageBox.Show("Izjednaceno", "Pobjednik", MessageBoxButton.OK, MessageBoxImage.Information);
                    MsgBox.Text = "Izjednaceno";
                }

            }

            private void Button_Click(object sender, RoutedEventArgs e)
            {
                int button = 0;

                if (signal)
                {
                    return;
                }

                if (isClicked[0])
                {
                    return;
                }

                if (X && (brojac < 9))
                {
                    MsgBox.Text = "Sada je X-ov red !";
                    button1.Content = "X";
                    array[button] = "x";
                    X = false;
                    O = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je O-ov red !";
                    }
                }
                else if (O && (brojac < 9))
                {
                    MsgBox.Text = "Sada je O-ov red !";
                    button1.Content = "O";
                    array[button] = "o";
                    O = false;
                    X = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je X-ov red !";
                    }
                }
                else return;
                brojac++;

                isClicked[0] = true;

                if (CheckForWin())
                {
                    return;
                }

                izjednaceno();
            }

            private void button2_Click(object sender, RoutedEventArgs e)
            {
                int button = 1;

                if (signal)
                {
                    return;
                }
                if (isClicked[1])
                {
                    return;
                }

                if (X && (brojac < 9))
                {
                    MsgBox.Text = "Sada je X-ov red !";
                    button2.Content = "X";
                    array[button] = "x";
                    X = false;
                    O = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je O-ov red !";
                    }
                }
                else if (O && (brojac < 9))
                {
                    MsgBox.Text = "Sada je O-ov red !";
                    button2.Content = "O";
                    array[button] = "o";
                    O = false;
                    X = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je X-ov red !";
                    }
                }
                else return;
                brojac++;
                isClicked[1] = true;

                if (CheckForWin())
                {
                    return;
                }

                izjednaceno();
            }

            private void button3_Click(object sender, RoutedEventArgs e)
            {
                int button = 2;

                if (signal)
                {
                    return;
                }
                if (isClicked[2])
                {
                    return;
                }

                if (X && (brojac < 9))
                {
                    MsgBox.Text = "Sada je X-ov red !";
                    button3.Content = "X";
                    array[button] = "x";
                    X = false;
                    O = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je O-ov red !";
                    }
                }
                else if (O && (brojac < 9))
                {
                    MsgBox.Text = "Sada je O-ov red !";
                    button3.Content = "O";
                    array[button] = "o";
                    O = false;
                    X = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je X-ov red !";
                    }
                }
                else return;
                brojac++;
                isClicked[2] = true;

                if (CheckForWin())
                {
                    return;
                }

                izjednaceno();
            }

            private void button4_Click(object sender, RoutedEventArgs e)
            {
                int button = 3;

                if (signal)
                {
                    return;
                }
                if (isClicked[3])
                {
                    return;
                }

                if (X && (brojac < 9))
                {
                    MsgBox.Text = "Sada je X-ov red !";
                    button4.Content = "X";
                    array[button] = "x";
                    X = false;
                    O = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je O-ov red !";
                    }
                }
                else if (O && (brojac < 9))
                {
                    MsgBox.Text = "Sada je O-ov red !";
                    button4.Content = "O";
                    array[button] = "o";
                    O = false;
                    X = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je X-ov red !";
                    }
                }
                else return;
                brojac++;
                isClicked[3] = true;

                if (CheckForWin())
                {
                    return;
                }

                izjednaceno();
            }

            private void button5_Click(object sender, RoutedEventArgs e)
            {
                int button = 4;

                if (signal)
                {
                    return;
                }
                if (isClicked[4])
                {
                    return;
                }

                if (X && (brojac < 9))
                {
                    MsgBox.Text = "Sada je X-ov red !";
                    button5.Content = "X";
                    array[button] = "x";
                    X = false;
                    O = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je O-ov red !";
                    }
                }
                else if (O && (brojac < 9))
                {
                    MsgBox.Text = "Sada je O-ov red !";
                    button5.Content = "O";
                    array[button] = "o";
                    O = false;
                    X = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je X-ov red !";
                    }
                }
                else return;
                brojac++;
                isClicked[4] = true;

                if (CheckForWin())
                {
                    return;
                }

                izjednaceno();
            }

            private void button6_Click(object sender, RoutedEventArgs e)
            {
                int button = 5;

                if (signal)
                {
                    return;
                }
                if (isClicked[5])
                {
                    return;
                }

                if (X && (brojac < 9))
                {
                    MsgBox.Text = "Sada je X-ov red !";
                    button6.Content = "X";
                    array[button] = "x";
                    X = false;
                    O = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je O-ov red !";
                    }
                }
                else if (O && (brojac < 9))
                {
                    MsgBox.Text = "Sada je O-ov red !";
                    button6.Content = "O";
                    array[button] = "o";
                    O = false;
                    X = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je X-ov red !";
                    }
                }
                else return;
                brojac++;
                isClicked[5] = true;

                if (CheckForWin())
                {
                    return;
                }

                izjednaceno();
            }

            private void button7_Click(object sender, RoutedEventArgs e)
            {
                int button = 6;

                if (signal)
                {
                    return;
                }
                if (isClicked[6])
                {
                    return;
                }

                if (X && (brojac < 9))
                {
                    MsgBox.Text = "Sada je X-ov red !";
                    button7.Content = "X";
                    array[button] = "x";
                    X = false;
                    O = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je O-ov red !";
                    }
                }
                else if (O && (brojac < 9))
                {
                    MsgBox.Text = "Sada je O-ov red !";
                    button7.Content = "O";
                    array[button] = "o";
                    O = false;
                    X = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je X-ov red !";
                    }
                }
                else return;
                brojac++;
                isClicked[6] = true;

                if (CheckForWin())
                {
                    return;
                }

                izjednaceno();
            }

            private void button8_Click(object sender, RoutedEventArgs e)
            {
                int button = 7;

                if (signal)
                {
                    return;
                }
                if (isClicked[7])
                {
                    return;
                }

                if (X && (brojac < 9))
                {
                    MsgBox.Text = "Sada je X-ov red !";
                    button8.Content = "X";
                    array[button] = "x";
                    X = false;
                    O = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je O-ov red !";
                    }
                }
                else if (O && (brojac < 9))
                {
                    MsgBox.Text = "Sada je O-ov red !";
                    button8.Content = "O";
                    array[button] = "o";
                    O = false;
                    X = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je X-ov red !";
                    }
                }
                else return;
                brojac++;
                isClicked[7] = true;

                if (CheckForWin())
                {
                    return;
                }

                izjednaceno();
            }

            private void button9_Click(object sender, RoutedEventArgs e)
            {
                int button = 8;

                if (signal)
                {
                    return;
                }
                if (isClicked[8])
                {
                    return;
                }

                if (X && (brojac < 9))
                {
                    MsgBox.Text = "Sada je X-ov red !";
                    button9.Content = "X";
                    array[button] = "x";
                    X = false;
                    O = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je O-ov red !";
                    }
                }
                else if (O && (brojac < 9))
                {
                    MsgBox.Text = "Sada je O-ov red !";
                    button9.Content = "O";
                    array[button] = "o";
                    O = false;
                    X = true;
                    if (!signal)
                    {
                        MsgBox.Text = "Sada je X-ov red !";
                    }
                }
                else return;
                brojac++;
                isClicked[8] = true;

                if (CheckForWin())
                {
                    return;
                }

                izjednaceno();
            }

            private void button10_Click(object sender, RoutedEventArgs e)
            {
                button1.Content = button2.Content = button3.Content = button4.Content = button5.Content = button6.Content = button7.Content = button8.Content = button9.Content = "";

                for (int i = 0; i < 9; i++)
                {
                    isClicked[i] = false;
                }

                MsgBox.Text = "X pocinje prvi!";
                brojac = 0;
                signal = false;

                X = true;
                O = false;

                for (int i = 0; i < 9; i++)
                {
                    array[i] = "0";
                } 
            }

            private void button11_Click(object sender, RoutedEventArgs e)
            {
                rezX = rezO = 0;
                RezultatX.Text = rezX.ToString();
                RezultatO.Text = rezO.ToString();
                MsgBox.Text = "Rezultatli su resetovani!";
            }
            private bool CheckForWin()
            {
                bool flag = false;

                if ((array[0] == array[1]) && (array[0] == array[2]) && (array[1] == array[2]) && (array[0] == "x"))
                {
                    pobjednikX();
                    flag = true;
                }
                else if ((array[0] == array[1]) && (array[0] == array[2]) && (array[1] == array[2]) && (array[0] == "o"))
                {
                    pobjednikO();
                    flag = true;
                }
                else if ((array[3] == array[4]) && (array[3] == array[5]) && (array[4] == array[5]) && (array[3] == "x"))
                {
                    pobjednikX();
                    flag = true;
                }
                else if ((array[3] == array[4]) && (array[3] == array[5]) && (array[4] == array[5]) && (array[3] == "o"))
                {
                    pobjednikO();
                    flag = true;
                }
                else if ((array[6] == array[7]) && (array[6] == array[8]) && (array[7] == array[8]) && (array[6] == "x"))
                {
                    pobjednikX();
                    flag = true;
                }
                else if ((array[6] == array[7]) && (array[6] == array[8]) && (array[7] == array[8]) && (array[6] == "o"))
                {
                    pobjednikO();
                    flag = true;
                }
                else if ((array[0] == array[3]) && (array[0] == array[6]) && (array[3] == array[6]) && (array[0] == "x"))
                {
                    pobjednikX();
                    flag = true;
                }
                else if ((array[0] == array[3]) && (array[0] == array[6]) && (array[3] == array[6]) && (array[0] == "o"))
                {
                    pobjednikO();
                    flag = true;
                }
                else if ((array[1] == array[4]) && (array[1] == array[7]) && (array[4] == array[7]) && (array[1] == "x"))
                {
                    pobjednikX();
                    flag = true;
                }
                else if ((array[1] == array[4]) && (array[1] == array[7]) && (array[4] == array[7]) && (array[1] == "o"))
                {
                    pobjednikO();
                    flag = true;
                }
                else if ((array[2] == array[5]) && (array[2] == array[8]) && (array[5] == array[8]) && (array[2] == "x"))
                {
                    pobjednikX();
                    flag = true;
                }
                else if ((array[2] == array[5]) && (array[2] == array[8]) && (array[5] == array[8]) && (array[2] == "o"))
                {
                    pobjednikO();
                    flag = true;
                }
                else if ((array[0] == array[4]) && (array[0] == array[8]) && (array[4] == array[8]) && (array[0] == "x"))
                {
                    pobjednikX();
                    flag = true;
                }
                else if ((array[0] == array[4]) && (array[0] == array[8]) && (array[4] == array[8]) && (array[0] == "o"))
                {
                    pobjednikO();
                    flag = true;
                }
                else if ((array[2] == array[4]) && (array[2] == array[6]) && (array[4] == array[6]) && (array[2] == "x"))
                {
                    pobjednikX();
                    flag = true;
                }
                else if ((array[2] == array[4]) && (array[2] == array[6]) && (array[4] == array[6]) && (array[2] == "o"))
                {
                    pobjednikO();
                    flag = true;
                }

                signal = flag;
                return flag;
            }
    }


}
