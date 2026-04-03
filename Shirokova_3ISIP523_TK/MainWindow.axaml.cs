using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace Shirokova_3ISIP523_TK;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

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