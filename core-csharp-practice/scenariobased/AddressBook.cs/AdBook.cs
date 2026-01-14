class AdBook
{
    private Contact [] contact;
    int count;
    public AdBook()
    {
        contact=new Contact[2];   
        count=0; 
    }
        public void AddContact(Contact NewContact)
        {
            if(count==contact.Length)
            {
                Contact [] arr=new Contact[contact.Length +1]; 
                for(int i=0;i<contact.Length;i++)
                {
                    arr[i]=contact[i];
                }
                contact=arr;
            }
            contact[count]=NewContact;
            count ++;
        }
        public void EditContact(string keyword)
        {
                    for(int i=0; i<count; i++)
        {
            if(contact[i].Search(keyword))
            {
                contact[i].Edit();
                return;         
            }
        }
        Console.WriteLine("Contact not found.");

        }
}