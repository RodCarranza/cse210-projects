using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        do
        {

            Console.Write("Enter number (Type 0 to stop): ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);

            //Adding number to the list if it is not 0

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }

           while (userNumber != 0);

            //Sum
            int sum = 0;
            foreach (int number in numbers) 
            {
                sum += number;

             }

             Console.WriteLine("The sum is: " + sum);

             //Average
             float averageList = ((float)sum) / numbers.Count;
             Console.WriteLine("The average is: " + averageList);

             //Finding the max
             int maxValue = numbers.Max();
             Console.WriteLine("The largest number is: " + maxValue);

    }
}
