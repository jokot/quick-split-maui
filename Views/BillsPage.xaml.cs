namespace quick_split.Views;

public partial class BillsPage : ContentPage
{
	public BillsPage()
	{
		InitializeComponent();
	}

	private async void OnBillCardTapped(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new DetailsPage());
	}

	private async void OnAddBillTapped(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new AddBillPage());
	}
}