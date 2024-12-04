namespace CostReductionProgram;

public partial class NamePage : ContentPage
{
	public NamePage()
	{
		InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }
    private void ToEnterNamePageBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new NamePage());
    }
}