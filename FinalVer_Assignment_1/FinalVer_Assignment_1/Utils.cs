using System;
using System.Text.RegularExpressions;

namespace FinalVer_Assignment_1
{
	public class Utils
	{
		public Utils()
		{
		}

        public static string patientsFormat = "| {0, -20} | {1, -20} | {2, -25} | {3, -10} | {4, -30} ";
        public static string UserDetailsFormat = "| {0, -20} | {1, -25} | {2, -10} | {3, -30} ";
        public static string appointmentDetailsFormat = "| {0, -20} | {1, -20} | {2, -25} ";

        public static bool IsNullOrWhiteSpace(string? prompt)
        {
            return string.IsNullOrWhiteSpace(prompt);
        }

        public static string GetPass(string prompt)
        {
            Console.Write(prompt + ": ");
            return MaskedPassword();
        }

        public static string MaskedPassword()
        {
            string password = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b");
                }
            }
            while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();
            return password;
        }

        public static bool IsValidEmail(string email)
        {
            // Use a regular expression pattern to validate the email format
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            return Regex.IsMatch(email, pattern);
        }

        // Helper method to validate phone numbers using a regular expression
        public static bool IsValidPhoneNumber(string phone)
        {
            // Use a regular expression pattern to validate the phone number format
            string pattern = @"^\d{10}$"; // Assumes a 10-digit phone number
            return Regex.IsMatch(phone, pattern);
        }

        public static string GetNonEmptyString(string prompt)
        {
            string? userInput;
            do
            {
                Console.Write($"{prompt}: ");
                userInput = Console.ReadLine();
                userInput = userInput?.Trim(); // Remove leading and trailing whitespace
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Input cannot be empty or only white space characters.");
                }
            } while (string.IsNullOrWhiteSpace(userInput));

            return userInput;
        }

        public static string GetString(string prompt)
        {
            Console.Write(prompt + ": ");
            return Console.ReadLine() ?? "";
        }

        public static int GetInt(string prompt)
        {
            Console.Write(prompt + ": ");

            try
            {
                string? input = Console.ReadLine();
                if (input != null)
                {
                    return int.Parse(input);
                }
                else
                {
                    return 0;
                }
            }
            catch (FormatException)
            {
                return 0;
            }
        }

        public static void PatientHeader()
        {
            Console.WriteLine("\n| Patient              | Doctor               | Email                     | Phone      | Address                       ");
            Console.WriteLine("+----------------------+----------------------+---------------------------+------------+--------------------------------+");
        }

        public static void UserDetailHeader()
        {
            Console.WriteLine("\n| Name                 | Email                     | Phone      | Address                       ");
            Console.WriteLine("+----------------------+---------------------------+------------+--------------------------------+");
        }

        public static void AppointmentDetailHeader()
        {
            Console.WriteLine("\n| Doctor               | Patient              | Description                       ");
            Console.WriteLine("+----------------------+----------------------+---------------------------------+");
        }

        public static void MenuHeader(string menuTitle)
        {
            int lineLength = 40; // Adjust this based on your desired line length
            string headerLine = "+" + new string('-', lineLength) + "+";

            // Center the static title
            string titleText = "DOTNET Hospital Management System";
            int titlePadding = (lineLength - titleText.Length - 2) / 2;
            string title = "| " + titleText.PadLeft(titlePadding + titleText.Length).PadRight(lineLength - 2) + " |";

            // Center the dynamic menuTitle
            int menuTitlePadding = (lineLength - menuTitle.Length - 2) / 2;
            string titleLine = "| " + menuTitle.PadLeft(menuTitle.Length + menuTitlePadding).PadRight(lineLength - 2) + " |";

            Console.WriteLine(headerLine);
            Console.WriteLine(title);
            Console.WriteLine(headerLine);
            Console.WriteLine(titleLine);
            Console.WriteLine(headerLine);
        }
    }
}

