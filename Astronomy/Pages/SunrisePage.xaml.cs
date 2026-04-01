namespace Astronomy.Pages;

public partial class SunrisePage : ContentPage
{
    public SunrisePage()
    {
        InitializeComponent();

        // Простая имитация данных
        var random = new Random();
        sunriseLabel.Text = $"{random.Next(5, 8)}:{random.Next(10, 59):D2}";
        sunsetLabel.Text = $"{random.Next(17, 21)}:{random.Next(10, 59):D2}";
    }
}