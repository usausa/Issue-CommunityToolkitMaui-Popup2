namespace Popup2App;

public partial class SamplePopup
{
	public SamplePopup()
	{
		InitializeComponent();
	}


    private async void OnCloseClick(object? sender, EventArgs e)
    {
        await CloseAsync();
    }
}