using Android.Content;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Controls.Platform;
using System.Linq;

namespace DemoWebProjection;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        ContentPanel.Add(new AuthenticatedWebView()
        {
            Source = new UrlWebViewSource()
            {
                Url = "https://www.openstreetmap.org/#map=11/54.7654/56.0625"
            },
            Token = "test"
        });

    }

    private void ContentPage_Loaded(object sender, EventArgs e)
    {
   //     Projection.Source = new UrlWebViewSource()
			//{
			//	Url = "https://www.openstreetmap.org/#map=11/54.7654/56.0625"
			//	//diff route to mobile ver & headers
				
			////Cookies = 
   //     };
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		//Projection.Source = new UrlWebViewSource()
		//{
		//	Url = "#"
		//};
    }


}

public class AuthenticatedWebView : WebView
{
    static AuthenticatedWebView()
    {
        Microsoft.Maui.Handlers.WebViewHandler.Mapper.AppendToMapping(nameof(IWebView.Source), (handler, view) =>
        {
            if (view is AuthenticatedWebView webView)
            {
                var url = webView.Url!;
                var headers = new Dictionary<string, string>
                {
                    ["Authorization"] = $"Bearer {webView.Token}"
                };
                handler.PlatformView.LoadUrl(url, headers);
            }

        });
    }

    public static readonly BindableProperty TokenProperty = BindableProperty.Create("Token", typeof(string), typeof(AuthenticatedWebView), "");

    public string? Token
    {
        get => GetValue(TokenProperty) as string;
        set => SetValue(TokenProperty, value);
    }

    public static readonly BindableProperty UrlProperty = BindableProperty.Create("Url", typeof(string), typeof(AuthenticatedWebView), "");
    public string? Url
    {
        get => GetValue(UrlProperty) as string;
        set => SetValue(UrlProperty, value);
    }
}