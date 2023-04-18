using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;


            Client client = new Client(name, id, phoneNumber);
            Doctor doctor = new Doctor(doctorName);
            Appointment appointment = new Appointment(date, appoinmentPlace);

            if (!client.isValid)
            {
                stringBuilder.Append(client.Error);
                isValid = false;
            }
           
            if (!doctor.isValid)
            {
                stringBuilder.Append(doctor.Error);
                isValid = false;
            }

            if (!appointment.isValid)
            {
                stringBuilder.Append(appointment.Error);
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}