using FatCat;
using System.Security.Cryptography;

namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
        StartGame(); 
	}
    public int mouse;
    public int fish;
    public int cupcake;
    public int icecream;
    private void Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
    private async void CountControl(object sender, EventArgs e)
    {
        if(mouse >= 3 || fish >= 3 || cupcake >= 3 || icecream >= 3)
        {
            happy.IsVisible = false;
            ultrahappy.IsVisible = true;
            fatcat.IsVisible = false;
            partycat.IsVisible = true;
            await Task.Delay(1000);
            happy.IsVisible = true;
            ultrahappy.IsVisible = false;
            fatcat.IsVisible = true;
            partycat.IsVisible = false;
        }
    }
    private async void StartGame()
    {
        Random random = new Random();
        int a = 0;
        while (true)
        {
            await Task.Delay(500);
            mouse = 0;
            fish = 0;
            cupcake = 0;
            icecream = 0;
            a = random.Next(1, 4);
            if (a == 1)
            {
                mouse1.IsVisible = true;
                fish1.IsVisible = false;
                cupcake1.IsVisible = false;
                icecream1.IsVisible = false;
                mouse++;

            }
            else if (a == 2)
            {
                mouse1.IsVisible = false;
                fish1.IsVisible = true;
                cupcake1.IsVisible = false;
                icecream1.IsVisible = false;
                fish++;
            }
            else if (a == 3)
            {
                mouse1.IsVisible = false;
                fish1.IsVisible = false;
                cupcake1.IsVisible = true;
                icecream1.IsVisible = false;
                cupcake++;
            }
            else if (a == 4)
            {
                mouse1.IsVisible = false;
                fish1.IsVisible = false;
                cupcake1.IsVisible = false;
                icecream1.IsVisible = true;
                icecream++;
            }
            a = random.Next(1, 4);
            if (a == 1)
            {
                mouse2.IsVisible = true;
                fish2.IsVisible = false;
                cupcake2.IsVisible = false;
                icecream2.IsVisible = false;
                mouse++;

            }
            else if (a == 2)
            {
                mouse2.IsVisible = false;
                fish2.IsVisible = true;
                cupcake2.IsVisible = false;
                icecream2.IsVisible = false;
                fish++;
            }
            else if (a == 3)
            {
                mouse2.IsVisible = false;
                fish2.IsVisible = false;
                cupcake2.IsVisible = true;
                icecream2.IsVisible = false;
                cupcake++;
            }
            else if (a == 4)
            {
                mouse2.IsVisible = false;
                fish2.IsVisible = false;
                cupcake2.IsVisible = false;
                icecream2.IsVisible = true;
                icecream++;
            }
            a = random.Next(1, 4);
            if (a == 1)
            {
                mouse3.IsVisible = true;
                fish3.IsVisible = false;
                cupcake3.IsVisible = false;
                icecream3.IsVisible = false;
                mouse++;

            }
            else if (a == 2)
            {
                mouse3.IsVisible = false;
                fish3.IsVisible = true;
                cupcake3.IsVisible = false;
                icecream3.IsVisible = false;
                fish++;
            }
            else if (a == 3)
            {
                mouse3.IsVisible = false;
                fish3.IsVisible = false;
                cupcake3.IsVisible = true;
                icecream3.IsVisible = false;
                cupcake++;
            }
            else if (a == 4)
            {
                mouse3.IsVisible = false;
                fish3.IsVisible = false;
                cupcake3.IsVisible = false;
                icecream3.IsVisible = true;
                icecream++;
            }
            a = random.Next(1, 4);
            if (a == 1)
            {
                mouse4.IsVisible = true;
                fish4.IsVisible = false;
                cupcake4.IsVisible = false;
                icecream4.IsVisible = false;
                mouse++;

            }
            else if (a == 2)
            {
                mouse4.IsVisible = false;
                fish4.IsVisible = true;
                cupcake4.IsVisible = false;
                icecream4.IsVisible = false;
                fish++;
            }
            else if (a == 3)
            {
                mouse4.IsVisible = false;
                fish4.IsVisible = false;
                cupcake4.IsVisible = true;
                icecream4.IsVisible = false;
                cupcake++;
            }
            else if (a == 4)
            {
                mouse4.IsVisible = false;
                fish4.IsVisible = false;
                cupcake4.IsVisible = false;
                icecream4.IsVisible = true;
                icecream++;
            }
        }
    }
}