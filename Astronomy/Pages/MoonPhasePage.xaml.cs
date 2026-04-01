namespace Astronomy.Pages;

public partial class MoonPhasePage : ContentPage
{
    public MoonPhasePage()
    {
        InitializeComponent();

        var phases = new[] { "🌑 Новолуние", "🌒 Молодая луна", "🌓 Первая четверть",
                              "🌔 Прибывающая луна", "🌕 Полнолуние", "🌖 Убывающая луна",
                              "🌗 Последняя четверть", "🌘 Старая луна" };
        var random = new Random();
        moonPhaseLabel.Text = phases[random.Next(phases.Length)];
    }
}