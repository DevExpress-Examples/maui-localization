namespace CustomLocalizedString;
using DevExpress.Maui.Core;

public partial class App : Application
{
    public class MyStringLoader : Localizer.IStringLoader
    {
        public bool TryGetString(string key, out string value)
        {
            if (key == "SchedulerStringId.AppointmentEdit_NewAppointmentTitle")
            {
                value = "Nueva Cita";
                return true;
            }
            value = null;
            return false;
        }
    }
    public App()
    {
        Localizer.StringLoader = new MyStringLoader();
        InitializeComponent();

		MainPage = new AppShell();
	}
}

