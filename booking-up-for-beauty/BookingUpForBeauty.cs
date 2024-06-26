using System;
using System.Runtime.InteropServices.JavaScript;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

    public static bool HasPassed(DateTime appointmentDate) => DateTime.Now > appointmentDate;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour is >= 12 and < 18;

    public static string Description(DateTime appointmentDate) => ($"You have an appointment on {appointmentDate:M/d/yyy h:mm:ss tt}.");

    public static DateTime AnniversaryDate() => new(DateTime.Now.Year, 9, 15);
}
