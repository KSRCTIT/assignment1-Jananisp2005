using System;

class Person {
    public string name;
    public int age;
    public float weight;

    // Method to print person details
    public void PrintPerson() {
        Console.WriteLine("Name: " + name);    // Fixed string concatenation
        Console.WriteLine("Age: " + age);      // Fixed string concatenation
        Console.WriteLine("Weight: " + weight + " kg");  // Added space before "kg"
    }
}

class PersonData {
    static void Main(string[] args) {
        Person person1 = new Person();

        // Setting values for the person object
        person1.name = "Kannan";
        person1.age = 19;
        person1.weight = 58;

        // Print person details
        person1.PrintPerson();
    }
}
