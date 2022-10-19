namespace AddressBookAdo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            Console.WriteLine("Choose a option");

            Console.WriteLine("1. Insert contact");
            Console.WriteLine("2. Update contact");
            Console.WriteLine("3. Delete contact");
            Console.WriteLine("4. Retrieve contact");
            Console.WriteLine("5. the size of address book by City and State");
            Console.WriteLine("6. Retrieve enteries sorted alphabetically by Person’s name for a given city");
            int option = Convert.ToInt32(Console.ReadLine());

            ContactModel contact = new ContactModel();
            switch (option)
            {
                case 1:
                    InsertContact insert = new InsertContact();

                    contact.FirstName = "Subodh";
                    contact.LastName = "Nagalwade";
                    contact.Address = "Lakhni";
                    contact.City = "Bhandara";
                    contact.State = "Maharashtra";
                    contact.Zip = 441804;
                    contact.PhoneNumber = 1234567890;
                    contact.Email = "subodh@gmail.com";

                    insert.AddContact(contact);
                    break;

                case 2:
                    EditContact edit = new EditContact();
                    contact.FirstName = "Vaibhav";
                    contact.Address = "pune";
                    contact.City = "pune";
                    contact.Zip = 456661;
                    edit.UpdateContact(contact);
                    break;
                case 3:
                    DeleteContact delete = new DeleteContact();
                    delete.DeleteContactDetails();
                    break;
                case 4:
                    RetrievePerson retrieve = new RetrievePerson();
                    retrieve.RetrievePersonDetails();
                    break;
                case 5:
                    AddressBookSize size = new AddressBookSize();
                    size.SizeOfAddressBookByCity();
                    size.SizeOfAddressBookByState();
                    break;
                case 6:
                    RetrieveEntries entries = new RetrieveEntries();
                    entries.SortedEntries();
                    break;
            }

        }
    }
}