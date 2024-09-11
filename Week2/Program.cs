internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the Company name :");
        string name = Console.ReadLine();

        Console.Write("Enter the Company address :");
        string address = Console.ReadLine();

        Console.Write("Enter the Company Phone Number : ");
        long PhNo = long.Parse(Console.ReadLine());

        Console.Write("Enter the Company Fax number :");
        long FaxNo = long.Parse(Console.ReadLine());

        Console.Write("Enter the Company WebSite :");
        string website = Console.ReadLine();

        Console.Write("Enter the name of the manager :");
        string managername = Console.ReadLine();

        Console.Write("Enter the surname of the manager :");
        string managersurname = Console.ReadLine();

        Console.Write("Enter the phone number of the manager :");
        long managerPhNo = long.Parse(Console.ReadLine());

        Console.WriteLine("The Information of the company is as follows : ");
        Console.WriteLine( "The name of the company is : " + name +" and the address of the company is :" + address );
        Console.Write("The Phone number of the Company is :");
        Console.WriteLine("{0:(###) ### ####}", PhNo);
        Console.Write("The Fax number of the Company is : ");
        Console.WriteLine("{0:(###) ### ####}", FaxNo);
        Console.WriteLine("The Website of the company is : " + website);
        Console.WriteLine("The Manager of the Company is :" + managername + " and his surname is : " + managersurname);
        Console.Write("The Manager phone number is ");
        Console.WriteLine("{0:(###) ### ####}" , managerPhNo);

    }
}