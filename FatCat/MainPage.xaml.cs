namespace FatCat;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        StartTailLoop();
    }
    public double ax = 0;
    public double ay = 0;
    private bool run = false;
    private async void Food1(object sender, PanUpdatedEventArgs e)
	{
        if(e.StatusType == GestureStatus.Running)
        {
            ay = foodstacklayout.Y + ((View)sender).Y + ((View)sender).TranslationY - fatCat.Y;
            ax = foodstacklayout.X + ((View)sender).X + ((View)sender).TranslationX - fatCat.X;
            if(ay < 200 && ay > 15 && ax < 190 && ax > 18)
            {
                if (!run)
                {
                    ultrahappy.IsVisible = false;
                    angry.IsVisible = false;
                    happy.IsVisible = false;
                    hungry.IsVisible = true;
                }
            }
            else
            {
                if (!run)
                {
                    hungry.IsVisible = false;
                    angry.IsVisible = true;
                }
            }
        }
        else if(ay < 150 && ay > 65 && ax < 140 && ax > 68)
        {
            GetFood();
            ax = 0;
            ay = 0;
        }
        else 
        {
            if (!run)
            {
                ultrahappy.IsVisible = false;
                angry.IsVisible = true;
                happy.IsVisible = false;
                hungry.IsVisible = false;
            }
        }
        ((View)sender).TranslationX = e.TotalX;
        ((View)sender).TranslationY = e.TotalY;
    }
    private async Task GetFood()
    {
        if (!run) 
        {
            run = true;
            hungry.IsVisible = false;
            ultrahappy.IsVisible = true;
            angry.IsVisible = false;
            happy.IsVisible = false;
            await Task.Delay(10000);
            happy.IsVisible = true;
            angry.IsVisible = false;
            ultrahappy.IsVisible = false;
            await Task.Delay(30000);
            happy.IsVisible = false;
            angry.IsVisible = true;
            ultrahappy.IsVisible = false;
            run = false;
        }
    }


    private async void StartTailLoop()
	{
        int count = 0;
        while (true)
		{
            await Task.Delay(100);
            count++;
            if (count == 1)
            {
                tail2.IsVisible = false;
                tail1.IsVisible = true;
            }
            else if (count == 2)
            {
                tail1.IsVisible = false;
                tail2.IsVisible = true;
            }
            else if (count == 3)
            {
                tail2.IsVisible = false;
                tail3.IsVisible = true;
            }
            else if (count == 4)
            {
                tail3.IsVisible = false;
                tail4.IsVisible = true;
            }
            else if (count == 5)
            {
                tail4.IsVisible = false;
                tail5.IsVisible = true;
            }
            else if (count == 6)
            {
                tail5.IsVisible = false;
                tail4.IsVisible = true;
            }
            else if (count == 7)
            {
                tail4.IsVisible = false;
                tail3.IsVisible = true;
            }
            else if (count == 8)
            {
                tail3.IsVisible = false;
                tail2.IsVisible = true;
                count = 0;
            }
        }
	}
}

