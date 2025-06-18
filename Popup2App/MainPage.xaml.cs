using System.Diagnostics;

using CommunityToolkit.Maui;

namespace Popup2App
{
    using CommunityToolkit.Maui.Extensions;

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Overlay issue

        private async void OnWithOverlayClick(object? sender, EventArgs e)
        {
            var overlay = new BusyOverlay(Application.Current!.Windows[0]);
            overlay.Window.AddOverlay(overlay);

            Debug.WriteLine("** start");
            await this.ShowPopupAsync(new SamplePopup(), new PopupOptions { Shape = null, Shadow = null });
            Debug.WriteLine("** end");

            overlay.Window.RemoveOverlay(overlay);
        }

        private async void OnWithoutOverlayClick(object? sender, EventArgs e)
        {
            Debug.WriteLine("** start");
            await this.ShowPopupAsync(new SamplePopup(), new PopupOptions { Shape = null, Shadow = null });
            Debug.WriteLine("** end");
        }

        // No border issue

        private async void OnNoBorderStyleClick(object? sender, EventArgs e)
        {
            await this.ShowPopupAsync(new NoBorderStylePopup(), new PopupOptions { Shape = null, Shadow = null });
        }

        private async void OnNoBorderPropertyClick(object? sender, EventArgs e)
        {
            await this.ShowPopupAsync(new NoBorderPropertyPopup(), new PopupOptions { Shape = null, Shadow = null });
        }
    }
}

public sealed class BusyOverlay : WindowOverlay
{
    public BusyOverlay(IWindow window)
        : base(window)
    {
        AddWindowElement(new OverlayElement());
        EnableDrawableTouchHandling = true;
    }

    private sealed class OverlayElement : IWindowOverlayElement
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.FillColor = new(255, 0, 0, 128);
            canvas.FillRectangle(dirtyRect);
        }

        public bool Contains(Point point) => true;
    }
}
