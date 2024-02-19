using System;

namespace HealthRecords
{
    class Patient
    {
        //Properties for patient information along with encapsulation
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; } //Weight in kilograms
        public double Height { get; set; } //Height in centimeters




        //Constructor to initialize patient properties.
        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName ?? "No First Name"; //In case null value is granted, the default value will be displayed
            LastName = lastName ?? "No Last Name"; //In case null value is granted, the default value will be displayed
            Weight = weight;
            Height = height;

        }//Patient




        //Calculates and returns the blood pressure category based on systolic and diastolic values
        public string GetBloodPressureCategory(int systolic, int diastolic)
        {
            //using conditional statementes for determining the blood pressure category
            if (systolic < 120 && diastolic < 80)
            {
                return "Normal";
            }
            else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
            {
                return "Elevated";
            }
            else if (systolic >= 130 && systolic <= 139 || diastolic >= 80 && diastolic <= 89)
            {
                return "High Blood Pressure (Hypertension) Stage 1";
            }
            else if (systolic >= 140 || diastolic >= 90)
            {
                return "High Blood Pressure (Hypertension) Stage 2";
            }
            else if (systolic > 180 || diastolic > 120)
            {
                return "Hypertensive Crisis (consult your doctor immediately)";
            }
            else
            {
                return "oops!!! seems like you have been called by the almighty!";
            }

        }//GetBloodPressureCategory




        // Calculates and returns the Body Mass Index (BMI)
        public double CalculateBMI()
        {
            double heightInMeters = Height / 100; // Converts height to meters for BMI calculation
            return Weight / (heightInMeters * heightInMeters); // BMI formula

        }//CalculateBMI




        //to display patient information, including calculated BMI and blood pressure category
        public void DisplayInfo(int systolic, int diastolic)
        {
            // Retrieves the blood pressure category and calculates BMI
            string bloodPressureCategory = GetBloodPressureCategory(systolic, diastolic);
            double bmi = CalculateBMI();

            // Determines BMI category based on the calculated BMI
            string bmiCategory = bmi < 18.5 ? "Underweight" : bmi < 25 ? "Normal" : "Overweight";

            // Outputs patient information
            Console.WriteLine($"Patient: {FirstName} {LastName}");
            Console.WriteLine($"Weight: {Weight}kg, Height: {Height}cm");
            Console.WriteLine($"Blood Pressure: {bloodPressureCategory}");
            Console.WriteLine($"BMI: {bmi:F2} ({bmiCategory})");//for displaying the value for two decimal places

        }//DisplayInfo

    }//patient

}//namespace
