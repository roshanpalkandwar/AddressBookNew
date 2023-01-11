namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter choice\n1.contact details\n2.add contacts dtails\n3.Edit contact");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    ContactDatails.Contact();
                    break;
                case 2:
                    AddContacts.AddPerson();
                    break;
                case 3:
                    EditContacts.AddBook1();
                    break;
            }
        }
    }
}