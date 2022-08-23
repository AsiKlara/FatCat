namespace FatCat;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        StartTailLoop();
        MoodLoop();
	}
    public int a = 0;

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        a = 1;
        ultrahappy.IsVisible = true;
        angry.IsVisible = false;
        happy.IsVisible = false;
        await Task.Delay(10000);
        a = 0;
	}
    private async void MoodLoop()
    {
        int i = 0;
        while (true)
        {
            await Task.Delay(5000);
            i++;
            if (i > 6 && a == 0)
            {
                happy.IsVisible = false;
                angry.IsVisible = true;
                ultrahappy.IsVisible = false;
            }
            else if (a == 1)
            {
                ultrahappy.IsVisible = true;
                angry.IsVisible = false;
                happy.IsVisible = false;
                i = 0;
            }
            else
            {
                ultrahappy.IsVisible = false;
                angry.IsVisible = false;
                happy.IsVisible = true;
            }
        }
    }

	private async void StartTailLoop()
	{
        int count = 0;
        while (true)
		{
            await Task.Delay(100);
            count++;
            if (count % 8 == 1)
            {
                tail2.IsVisible = false;
                tail1.IsVisible = true;
            }
            else if (count % 8 == 2)
            {
                tail1.IsVisible = false;
                tail2.IsVisible = true;
            }
            else if (count % 8 == 3)
            {
                tail2.IsVisible = false;
                tail3.IsVisible = true;
            }
            else if (count % 8 == 4)
            {
                tail3.IsVisible = false;
                tail4.IsVisible = true;
            }
            else if (count % 8 == 5)
            {
                tail4.IsVisible = false;
                tail5.IsVisible = true;
            }
            else if (count % 8 == 6)
            {
                tail5.IsVisible = false;
                tail4.IsVisible = true;
            }
            else if (count % 8 == 7)
            {
                tail4.IsVisible = false;
                tail3.IsVisible = true;
            }
            else if (count % 8 == 0)
            {
                tail3.IsVisible = false;
                tail2.IsVisible = true;
            }
        }
	}
}

