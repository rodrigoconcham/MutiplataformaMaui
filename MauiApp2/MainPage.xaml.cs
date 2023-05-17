namespace MauiApp2;

public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        //count++;

        //if (count == 1)
        //	CounterBtn.Text = $"Clicked {count} time";
        //else
        //	CounterBtn.Text = $"Clicked {count} times";

        //SemanticScreenReader.Announce(CounterBtn.Text);

        if (DeviceInfo.Current.Platform == DevicePlatform.Android) 
        {

              CounterBtn.Text = $"Hola Mundo Android";

        }


        if (DeviceInfo.Current.Platform == DevicePlatform.WinUI)
        {

            CounterBtn.Text = $"Hola Mundo Windows";


        }


    }
}

