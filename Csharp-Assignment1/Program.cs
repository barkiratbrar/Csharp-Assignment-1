using System;
using HealthRecords;

class Program
{
    static void Main(string[] args)
    {
        // User prompts for patient details
        Console.WriteLine("Enter patient's first name:");
        string firstName = Console.ReadLine() ?? "No First Name";

        Console.WriteLine("Enter patient's last name:");
        string lastName = Console.ReadLine() ?? "No Last Name";

        Console.WriteLine("Enter patient's weight in kg:");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter patient's height in cm:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Instantiating a new Patient object
        Patient patient = new Patient(firstName, lastName, weight, height);

        // User prompts for blood pressure readings
        Console.WriteLine("Enter systolic blood pressure (upper number):");
        int systolic = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter diastolic blood pressure (lower number):");
        int diastolic = Convert.ToInt32(Console.ReadLine());

        // Displaying patient information
        patient.DisplayInfo(systolic, diastolic);

    }//Main

}//program
