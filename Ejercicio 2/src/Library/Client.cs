using System;
using System.Text;

class Client
{
    public String name { get; }
    public String id { get; }
    public String phoneNumber { get; }

    public Boolean isValid { get; } = true;

    public StringBuilder Error { get; } = new StringBuilder("");

    public Client(string name, string id, string phoneNumber)
    {

        if (string.IsNullOrEmpty(name))
        {
            this.Error.Append("Unable to schedule appointment, 'name' is required\n");
            this.isValid = false;
        }

        if (string.IsNullOrEmpty(id))
        {
            this.Error.Append("Unable to schedule appointment, 'id' is required\n");
            this.isValid = false;
        }

        if (string.IsNullOrEmpty(phoneNumber))
        {
            this.Error.Append("Unable to schedule appointment, 'phone number' is required\n");
            this.isValid = false;
        }


        this.name = name;
        this.id = id;
        this.phoneNumber = phoneNumber;
    }
}