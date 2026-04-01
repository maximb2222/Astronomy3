using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Astronomy.Pages;

[QueryProperty(nameof(AstroName), "astroName")]
public partial class AstronomicalBodyPage : ContentPage
{
    private string _astroName;

    public string AstroName
    {
        get => _astroName;
        set
        {
            _astroName = value;
            UpdateUI(value);
        }
    }

    public AstronomicalBodyPage()
    {
        InitializeComponent();
    }

    private void UpdateUI(string astroName)
    {
        switch (astroName?.ToLower())
        {
            case "sun":
                titleLabel.Text = "☀️ Солнце";
                descriptionLabel.Text = "Солнце — звезда, центр Солнечной системы. Это огромный шар из раскалённого газа, который даёт нам свет и тепло.";
                bodyImage.Source = "sun.png";
                break;
            case "moon":
                titleLabel.Text = "🌙 Луна";
                descriptionLabel.Text = "Луна — единственный естественный спутник Земли. Это пятый по величине спутник в Солнечной системе.";
                bodyImage.Source = "moon.png";
                break;
            case "earth":
                titleLabel.Text = "🌍 Земля";
                descriptionLabel.Text = "Земля — третья планета от Солнца. Единственное известное нам место, где существует жизнь.";
                bodyImage.Source = "earth.png";
                break;
            case "comet":
                titleLabel.Text = "☄️ Комета Галлея";
                descriptionLabel.Text = "Комета Галлея — короткопериодическая комета, которая возвращается к Солнцу каждые 75–76 лет.";
                bodyImage.Source = "comet.png";
                break;
            default:
                titleLabel.Text = "Небесное тело";
                descriptionLabel.Text = "Информация отсутствует";
                bodyImage.Source = "question.png";
                break;
        }
    }
}