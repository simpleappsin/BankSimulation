using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YazilimciKampiOdevi3
{
    class BankManagement
    {

        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Congrats. Customer was added to the system."
                + "\nCustomer info: " +
                $"\nName: {customer.Name}" +
                $"\nAddress: {customer.Address}" +
                $"\nAge: {customer.Age}" +
                $"\nMoney: ${customer.Money}");
        }

        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine("Customer was deleted from the system."
                + "\nCustomer info: " +
                $"\nName: {customer.Name}" +
                $"\nAddress: {customer.Address}" +
                $"\nAge: {customer.Age}" +
                $"\nMoney: ${customer.Money}");
        }

        public void Deposit(Customer customer)
        {
            Console.Write("Please enter the amount of Deposit: $");
            double amount = Convert.ToInt32(Console.ReadLine());
            amount += customer.Money;
            Console.WriteLine("You money was deposited to your account successfully." +
                "Your have amount of: ${0}",amount);
        }

        public void Withdraw(Customer customer)
        {
            Console.Write("Please enter the amount of Withdraw: $");
            double amount = Convert.ToInt32(Console.ReadLine());
            if (amount <= customer.Money && amount > 0)
            {
                customer.Money -= amount;
                Console.WriteLine("You money was withdrawn from your account successfully." +
                    "Your have left amount of: ${0}", customer.Money);
            }
            else
            {
                Console.WriteLine("Something went wrong please check everything and resubmit it.");
            }
        }

    }
}
