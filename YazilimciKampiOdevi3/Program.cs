using YazilimciKampiOdevi3;

Customer customer1 = new Customer();
customer1.Id = 1;
customer1.Name = "Engin";
customer1.Address = "Turkey";
customer1.Age = 30;
customer1.Money = 80000.00;

Customer customer2 = new Customer();
customer2.Id = 2;
customer2.Name = "Mustafa";
customer2.Address = "Turkey";
customer2.Age = 28;
customer2.Money = 88000.00;

Customer[] customers = new Customer[]
{
    customer1,
    customer2
};

// Display all the customers in the system

foreach(Customer customer in customers)
{
    Console.WriteLine($"ID: {customer.Id}");
    Console.WriteLine($"Name: {customer.Name}");
    Console.WriteLine($"Address: {customer.Address}");
    Console.WriteLine($"Age: {customer.Age}");
    Console.WriteLine("----------------------------------------");
}


BankManagement management = new BankManagement();

// To add a customer to the system
management.AddCustomer(customer1);

//// To remove the customer from the system
//management.RemoveCustomer(customer2);

//// To Deposit Money to the account
//management.Deposit(customer1);

//// To Withdraw Money from the account
//management.Withdraw(customer2);