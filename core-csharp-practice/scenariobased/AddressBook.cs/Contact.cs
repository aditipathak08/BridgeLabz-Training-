using System;
class Contact
{ 
   private string FirstName{get;set;}
   private string LastName{get;set;}
   private string Address{get;set;}
   private string City{get;set;}
   private string State{get;set;}
   private string Zip{get;set;}
   private string Phone{get;set;}
   private string Email{get;set;}
   public Contact(string firstname,string lastname,string address,string city,string state,string zip,string phone,string email)
   {
    this.FirstName=firstname;
    this.LastName=lastname;
    this.Address=address;
    this.City=city;
    this.State=state;
    this.Zip=zip;
    this.Phone=phone;
    this.Email=email;
   }
   public void Display()
   {
        Console.WriteLine("Name    : " + FirstName + " " + LastName);
        Console.WriteLine("Address : " + Address);
        Console.WriteLine("City    : " + City);
        Console.WriteLine("State   : " + State);
        Console.WriteLine("Zip     : " + Zip);
        Console.WriteLine("Phone   : " + Phone);
        Console.WriteLine("Email   : " + Email);
   }
  public bool Search(string keyword)
{
    keyword = keyword.ToLower();
    if (FirstName.ToLower().Contains(keyword) ||
        LastName.ToLower().Contains(keyword) ||
        Address.ToLower().Contains(keyword) ||
        City.ToLower().Contains(keyword) ||
        State.ToLower().Contains(keyword) ||
        Zip.ToLower().Contains(keyword) ||
        Phone.ToLower().Contains(keyword) ||
        Email.ToLower().Contains(keyword))
    {
        return true; 
    }

    return false; 
}
public void Edit(string keyword)
{
         Console.WriteLine("Edit the Address");
          Address=Console.ReadLine();
           Console.WriteLine("Edit the City");
          City=Console.ReadLine();
           Console.WriteLine("Edit the State");
          State=Console.ReadLine();
           Console.WriteLine("Edit the Zip");
          Zip=Console.ReadLine();
           Console.WriteLine("Edit the Phone");
          Phone=Console.ReadLine();
           Console.WriteLine("Edit the Email");
          Email=Console.ReadLine();

   }
}