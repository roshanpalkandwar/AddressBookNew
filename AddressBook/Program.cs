namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter choice\n1.contact details");
            int opt = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    ContactDatails.Contact();


                    break;
            }
        }
    }
}