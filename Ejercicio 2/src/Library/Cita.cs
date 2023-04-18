using System;
using System.Text;

class Appointment
{
    public DateTime date { get; }
    public string place { get; }

    public Boolean isValid { get; } = true;

    public StringBuilder Error { get; } = new StringBuilder("");


    public Appointment(DateTime date, string place)
    {
        if (string.IsNullOrEmpty(place))
        {
            Error.Append("Unable to schedule appointment, 'appoinment place' is required\n");
            isValid = false;
        }

        this.date = date;
        this.place = place;
    }


}