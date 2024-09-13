using System;
using System.Text.RegularExpressions;

class Validation {
    static void Main() {
        Console.Write("Enter your mobile number (format: XXXX-XXXXXX): ");
        string mobileNumber = Console.ReadLine();

        // Regular expression pattern for the mobile number format
        string pattern = @"^[98]\d{3}-\d{6}$";

        // Validate the mobile number using Regex
        if (Regex.IsMatch(mobileNumber, pattern)) {
            Console.WriteLine("Mobile number is valid.");
        } else {
            Console.WriteLine("Mobile number is invalid.");
        }
    }
}
