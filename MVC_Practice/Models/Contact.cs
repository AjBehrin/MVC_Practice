using System;

public class Contact
{

    public int ID { get; set; }
    public Guid UserID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhonePrimary { get; set; }
    public string PhoneSecondary { get; set; }
    public DateTime Birthday { get; set; }
    public string StreetAddress1 { get; set; }
    public string StreedAddress2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Zip { get; set; }

    public Contact()
    {

    }



}

