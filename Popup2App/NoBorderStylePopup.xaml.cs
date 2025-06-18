namespace Popup2App;

public partial class NoBorderStylePopup
{
	public NoBorderStylePopup()
	{
		InitializeComponent();
	}

    private async void OnCloseClick(object? sender, EventArgs e)
    {
        await CloseAsync();
    }
}