using System.Linq;

namespace DemoWebProjection;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
        Projection.Source = new UrlWebViewSource()
			{
				Url = "https://www.openstreetmap.org/#map=11/54.7654/56.0625"
				//diff route to mobile ver & headers
				
			//Cookies = 
        };
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Projection.Source = new UrlWebViewSource()
		{
			Url = "#"
		};
    }
}

