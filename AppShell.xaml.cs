using quick_split.Views;

namespace quick_split;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
		Routing.RegisterRoute(nameof(AddBillPage), typeof(AddBillPage));
		Routing.RegisterRoute(nameof(AddMembersPage), typeof(AddMembersPage));
	}
}
