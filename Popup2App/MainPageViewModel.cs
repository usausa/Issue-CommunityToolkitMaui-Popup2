using CommunityToolkit.Maui.Extensions;

namespace Popup2App;

using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using System.Windows.Input;

public class MainPageViewModel : ObservableObject
{
    public ICommand DialogCommand { get; }

    public MainPageViewModel()
    {
        DialogCommand = new AsyncRelayCommand(async () =>
        {
            await Application.Current!.Windows[0].Page!.ShowPopupAsync(new SamplePopup(), new PopupOptions { Shape = null, Shadow = null });
        });
    }

}

