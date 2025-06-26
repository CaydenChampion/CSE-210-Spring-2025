class Program
{
    public static void Main(string[] args)
    {
        // Person myPerson = new Person("Bob", "Lemi", 34);
        // Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Betty", "Crocker", 23, "Bat", 65, 73.23);
        // Console.WriteLine(myPoliceMan.GetPersonInformation());
        // Console.WriteLine(myPoliceMan.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 43, " Knife", 500000);
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceMan);

        foreach (Person person in myPeople)
        {
            DisplayPersonInformation(person);
        }
    }
    private static void DisplayPersonInformation(Person person)
    {
        Console.Write(person.GetPersonInformation());
        Console.WriteLine($"Salary: {person.GetPay()}");
    }
}
