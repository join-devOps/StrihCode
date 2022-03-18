using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace StrihCode
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string GetTimeNow
        {
            get => DateTime.Now.ToString("dd.MM.yyyy");
        }

        private int GetGeneratedFigures()
        {
            Random r = new Random();
            return r.Next(0, 9);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string binaryCode = "101";

            for (int i = 0; i < binaryCode.Length; i++)
            {
                if (binaryCode[i] == '1')
                {
                    Rectangle r = new Rectangle() // отрисовка черного прямоугольника
                    {
                        Stroke = Brushes.Black,
                        StrokeThickness = 2,
                        SnapsToDevicePixels = true,
                        Height = 100
                    };
                    StackPanel_Code.Children.Add(r);
                }
                else
                {
                    Rectangle r = new Rectangle()  // отрисовка белого прямоугольника
                    {
                        Stroke = Brushes.White,
                        StrokeThickness = 2,
                        SnapsToDevicePixels = true,
                        Height = 100
                    };
                    StackPanel_Code.Children.Add(r);  // добавление прямоугольника в нужную StackPanel
                }
            }

            binaryCode = "";
            // определение двоичного кода левой части
            for (int i = 0; i < 4; i++)
            {
                binaryCode += EAN_13.GetLeftL(GetTimeNow[i]);
            }

            StackPanel spLeftCodeAndNumber = new StackPanel() // создание StackPanel для хранения левой части штрих-кода и его числового значения
            {
                Orientation = Orientation.Vertical,
                Height = 100
            };

            StackPanel spLeftCode = new StackPanel()  // создание StackPanel для хранения левой части штрих-кода
            {
                Orientation = Orientation.Horizontal,
            };
            // отрисовка левой части штрих-кода
            for (int i = 0; i < binaryCode.Length; i++)
            {
                if (binaryCode[i] == '1')
                {
                    Rectangle r = new Rectangle() // отрисовка черного прямоугольника
                    {
                        Stroke = Brushes.Black,
                        StrokeThickness = 2,
                        SnapsToDevicePixels = true,
                        Height = 80
                    };
                    spLeftCode.Children.Add(r);
                }
                else
                {
                    Rectangle r = new Rectangle()  // отрисовка белого прямоугольника
                    {
                        Stroke = Brushes.White,
                        StrokeThickness = 2,
                        SnapsToDevicePixels = true,
                        Height = 80
                    };
                    spLeftCode.Children.Add(r);  // добавление прямоугольника в нужную StackPanel
                }
            }

            string leftNumber = " "; // строка для хранения числового значения левой части штрих-кода
            for (int i = 0; i < 4; i++)
            {
                leftNumber += GetTimeNow[i] + " ";

            }
            // отрисовка TextBlock, который будет хранить числовое значение левой чатси штрих-кода
            TextBlock tbLeftNumber = new TextBlock()
            {
                Text = leftNumber,
                FontSize = 16,
                TextAlignment = TextAlignment.Center
            };
            spLeftCodeAndNumber.Children.Add(spLeftCode); // добавление в StackPanel левой части штрих-кода
            spLeftCodeAndNumber.Children.Add(tbLeftNumber);  // добавление в StackPanel числового значения левой части штрих-кода
            StackPanel_Code.Children.Add(spLeftCodeAndNumber);  // добавление StackPanel для хранения левой части штрих-кода и его числового значения в общую StackPanel

            binaryCode = "01010"; // код среднего защитного шаблона
                                  // отрисовка среднего защитного шаблона
            for (int i = 0; i < binaryCode.Length; i++)
            {
                if (binaryCode[i] == '1')
                {
                    Rectangle r = new Rectangle() // отрисовка черного прямоугольника
                    {
                        Stroke = Brushes.Black,
                        StrokeThickness = 2,
                        SnapsToDevicePixels = true,
                        Height = 100
                    };
                    StackPanel_Code.Children.Add(r);
                }
                else
                {
                    Rectangle r = new Rectangle()  // отрисовка белого прямоугольника
                    {
                        Stroke = Brushes.White,
                        StrokeThickness = 2,
                        SnapsToDevicePixels = true,
                        Height = 100
                    };
                    StackPanel_Code.Children.Add(r);  // добавление прямоугольника в нужную StackPanel
                }
            }

            binaryCode = "";
            // определение двоичного кода правой части
            for (int i = 4; i < 8; i++)
            {
                //binaryCode += EAN_13.GetRightR(GetGeneratedFigures);
            }

            StackPanel spRightCodeAndNumber = new StackPanel() // создание StackPanel для хранения правой части штрих-кода и его числового значения
            {
                Orientation = Orientation.Vertical,
                Height = 100
            };

            StackPanel spRightCode = new StackPanel()  // создание StackPanel для хранения правой части штрих-кода
            {
                Orientation = Orientation.Horizontal,
            };
            // отрисовка правой части штрих-кода
            for (int i = 0; i < binaryCode.Length; i++)
            {
                if (binaryCode[i] == '1')
                {
                    Rectangle r = new Rectangle() // отрисовка черного прямоугольника
                    {
                        Stroke = Brushes.Black,
                        StrokeThickness = 2,
                        SnapsToDevicePixels = true,
                        Height = 80
                    };
                    spRightCode.Children.Add(r);
                }
                else
                {
                    Rectangle r = new Rectangle()  // отрисовка белого прямоугольника
                    {
                        Stroke = Brushes.White,
                        StrokeThickness = 2,
                        SnapsToDevicePixels = true,
                        Height = 80
                    };
                    spRightCode.Children.Add(r);  // добавление прямоугольника в нужную StackPanel
                }
            }

            string rightNumber = " "; // строка для хранения числового значения правой части штрих-кода
            for (int i = 4; i < 8; i++)
            {
                //rightNumber += GetGeneratedFigures[i] + " ";

            }
            // отрисовка TextBlock, который будет хранить числовое значение правой части штрих-кода
            TextBlock tbRightNumber = new TextBlock()
            {
                Text = rightNumber,
                FontSize = 16,
                TextAlignment = TextAlignment.Center
            };
            spRightCodeAndNumber.Children.Add(spRightCode);
            spRightCodeAndNumber.Children.Add(tbRightNumber);
            StackPanel_Code.Children.Add(spRightCodeAndNumber);

            binaryCode = "101";
                                 // отрисовка правого защитного шаблона
            for (int i = 0; i < binaryCode.Length; i++)
            {
                if (binaryCode[i] == '1')
                {
                    Rectangle r = new Rectangle()
                    {
                        Stroke = Brushes.Black,
                        StrokeThickness = 2,
                        SnapsToDevicePixels = true,
                        Height = 100
                    };
                    StackPanel_Code.Children.Add(r);
                }
                else
                {
                    Rectangle r = new Rectangle()
                    {
                        Stroke = Brushes.White,
                        StrokeThickness = 2,
                        SnapsToDevicePixels = true,
                        Height = 100
                    };
                    StackPanel_Code.Children.Add(r);
                }
            }
        }
    }
}