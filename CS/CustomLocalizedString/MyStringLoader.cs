using DevExpress.Maui.Core;

namespace CustomLocalizedString;

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