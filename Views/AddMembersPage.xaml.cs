namespace quick_split.Views;

public partial class AddMembersPage : ContentPage
{
	public AddMembersPage()
	{
		InitializeComponent();
	}

	private void OnAddMemberClicked(object sender, EventArgs e)
	{
		// TODO: Implement add member functionality
		// This could open a dialog or add the member to the list
	}

	private async void OnSelectMembersClicked(object sender, EventArgs e)
	{
		// TODO: Implement select members functionality
		// This could save the selected members and navigate back
		await Navigation.PopAsync();
	}
}