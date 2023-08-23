namespace Task01;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of employees: ");
        int size = int.Parse(Console.ReadLine());
        Employee[] employees = new Employee[size];

        // Loop through the array and ask the user to enter the data for each employee
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"\n Enter the data for employee {i + 1}");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Gender (0 for Male, 1 for Female): ");
            int genderIndex = int.Parse(Console.ReadLine());

            employees[i] = new Employee(firstName, lastName, salary, address, age, (Gender)genderIndex);

            bool isValid = true;

            if (age < 20)
            {
                Console.WriteLine("Age must be greater than 20.");
                isValid = false;
            }

            if (salary < 900)
            {
                Console.WriteLine("Salary must be greater than 900.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                Console.WriteLine("First name and last name cannot be empty.");
                isValid = false;
            }

            if (!isValid)
            {
                i--;
                continue;
            }
        }

        for (int i = 0; i < size; i++)
        {
            Console.Write($"\n Employee{i + 1}:");
            employees[i].Print();
        }
    }
}
