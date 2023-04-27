using Microsoft.Maui.Controls.Maps;

namespace Maui_IssueMapsGesture;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void btnShowMap_Clicked(object sender, EventArgs e)
    {
        frmMap.IsVisible = true;
        Location location = new Location(35.6803373, 139.7653002);
        map.MoveToRegion(new Microsoft.Maui.Maps.MapSpan(location, 0.01, 0.01));

        map.Pins.Clear();
        Pin pin1 = new Pin() { Label = "Location1", Address = "Address1", Location = new Location(35.67859553179536, 139.768455109454) };
        Pin pin2 = new Pin() { Label = "Location2", Address = "Address2", Location = new Location(35.68093971067266, 139.77164172261325) };
        Pin pin3 = new Pin() { Label = "Location3", Address = "Address3", Location = new Location(35.681349386866465, 139.76990363693324) };
        map.Pins.Add(pin1);
        map.Pins.Add(pin2);
        map.Pins.Add(pin3);
    }
}

