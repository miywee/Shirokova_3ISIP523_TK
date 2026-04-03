using Avalonia.Controls; // Базовые элементы Avalonia (Window, TextBox и т.д.)
using Avalonia.Interactivity; // Поддержка событий 
using System; // Базовые классы .NET 

namespace Shirokova_3ISIP523_TK;

// Логика взаимодействия для MainWindow.axaml
// Главное окно приложения для работы приложения для подсчета площади фигур
public partial class MainWindow : Window
{
    /// Конструктор окна, загрузка данных
    /// Инициализирует компоненты главного окна приложения
    public MainWindow()
    {
        InitializeComponent();
    }

    // Обработчик нажатия кнопки "Рассчитать"
    // В зависимости от выбранной фигуры (прямоугольник, круг или треугольник) считывает введённые значения, вычисляет площадь и выводит результат
    // Выполняет обработку ошибок ввода
    private void Calculate_Click(object? sender, RoutedEventArgs e)
    {
        try
        {
            if (rectBtn.IsChecked == true)
            {
                double a = Convert.ToDouble(side1.Text);
                double b = Convert.ToDouble(side2.Text);

                double area = a * b;

                result.Text = area.ToString();
            }

            else if (circleBtn.IsChecked == true)
            {
                double r = Convert.ToDouble(radius.Text);

                double area = Math.PI * r * r;

                result.Text = area.ToString();
            }

            else if (triangleBtn.IsChecked == true)
            {
                double a = Convert.ToDouble(side1.Text);
                double b = Convert.ToDouble(side2.Text);
                double c = Convert.ToDouble(side3.Text);

                double p = (a + b + c) / 2;

                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                result.Text = area.ToString("F2");
            }
        }
        catch
        {
            result.Text = "Ошибка ввода";
        }
    }
}