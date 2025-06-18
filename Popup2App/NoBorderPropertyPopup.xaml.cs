namespace Popup2App;

public partial class NoBorderPropertyPopup
{
	public NoBorderPropertyPopup()
	{
		InitializeComponent();
	}

    private async void OnCloseClick(object? sender, EventArgs e)
    {
        await CloseAsync();
    }
}