List<Customer> customs = new List<Customer>();

bool isQuitting = true;

int id = 0;

menu();

void menu()
{
    while (isQuitting)
    {
        Console.WriteLine("1. Create New Customer");
        Console.WriteLine("2. Show Avaible Customer");
        Console.WriteLine("3. Edit Customer");

        int input = Convert.ToInt32(Console.ReadLine());

        switch (input)
        {
            case 1:
                CreateCustomer();
                break;
            case 2:
                ShowAllCustomer();
                break;
            default:
                break;
        }
    }
}

void CreateCustomer()
{
    id++;

    Console.Write("CustomerName:");
    string customerName = Console.ReadLine();
    Console.Write("CustomerCity:");
    string customerCity = Console.ReadLine();
    Console.Write("CustomerPostalCode:");
    string customerPostalCode = Console.ReadLine();

    customs.Add(new Customer(id, customerName, customerCity, customerPostalCode));
    Console.WriteLine("Created a Customer" + " with ID: " + id);
}

void ShowAllCustomer()
{
    foreach (var item in customs)
    {
        if (item != null)
        {
            item.ShowDetails();
        }
    }
}

void EditCustomer()
{

}

public class Customer
{
    int ID;
    string Name;
    string City;
    string PostalCode;

    public Customer(int iD, string name, string city, string postalCode)
    {
        ID = iD;
        Name = name;
        City = city;
        PostalCode = postalCode;
    }

    public void ShowDetails()
    {
        Console.WriteLine("ID: " + ID + " : " + Name + " " + City + " " + PostalCode);
    }
}