namespace Astronomy.Pages;

public partial class AstronomicalBodiesPage : ContentPage
{
    public AstronomicalBodiesPage()
    {
        InitializeComponent();
    }

    private async void OnBodyClicked(object sender, EventArgs e)
    {
        Button button = (Button)sender;
        string bodyName = "";

        if (button == btnSun) bodyName = "sun";
        else if (button == btnMoon) bodyName = "moon";
        else if (button == btnEarth) bodyName = "earth";
        else if (button == btnComet) bodyName = "comet";

        await Shell.Current.GoToAsync($"astronomicalbodydetails?astroName={bodyName}");
    }
}