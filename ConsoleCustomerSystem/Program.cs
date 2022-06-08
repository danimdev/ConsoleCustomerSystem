List<Customer> customs = new List<Customer>();

bool isQuitting = true;

int id = 1;

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
            case 3:
                EditCustomer();
                break;
            default:
                break;
        }
    }
}

void CreateCustomer()
{
    Console.Write("CustomerName:");
    string customerName = Console.ReadLine();
    Console.Write("CustomerCity:");
    string customerCity = Console.ReadLine();
    Console.Write("CustomerPostalCode:");
    string customerPostalCode = Console.ReadLine();

    customs.Add(new Customer(id, customerName, customerCity, customerPostalCode));
    Console.WriteLine("Created a Customer" + " with ID: " + id);
    ++id;
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
    bool isEditing = true;

    Console.Write("id:");
    int input = Convert.ToInt32(Console.ReadLine());
    
    input -= 1;

    if (customs.Any()) {
        while (isEditing)
        {
            customs[input].ShowDetails();

            Console.WriteLine("What do you want to change?");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. City");
            Console.WriteLine("3. Postal Code");
            Console.WriteLine("4. exit edit menu");

            int switchInput = Convert.ToInt32(Console.ReadLine());

            switch (switchInput)
            {
                case 1:
                    Console.Write("Name:");
                    string newName = Console.ReadLine();
                    customs[input].Name = newName;
                    break;
                case 2:
                    Console.Write("City:");
                    string newCity = Console.ReadLine();
                    customs[input].City = newCity;
                    break;
                case 3:
                    Console.Write("PostalCode:");
                    string newPostalCode = Console.ReadLine();
                    customs[input].PostalCode = newPostalCode;
                    break;
                case 4:
                    isEditing = false;
                    Console.Clear();
                    break;
                default:
                    break;
            }
            Console.Clear();
        }
    }
    else
        Console.WriteLine($"Customer mit id:{input} Gibt es nicht");
}

public class Customer
{
    public int ID;
    public string Name;
    public string City;
    public string PostalCode;

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