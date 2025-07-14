namespace quick_split.Views;

public partial class AddBillPage : ContentPage
{
	public AddBillPage()
	{
		InitializeComponent();
	}

	private async void OnAddMemberClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new AddMembersPage());
	}
}