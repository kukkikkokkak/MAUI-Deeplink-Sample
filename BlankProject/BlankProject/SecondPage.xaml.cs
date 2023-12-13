namespace BlankProject;

public partial class SecondPage : ContentPage
{
	public SecondPage()
	{
		InitializeComponent();
        Console.WriteLine($"SecondPage: SecondPage {DateTime.Now}");
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
}