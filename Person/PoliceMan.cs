class PoliceMan : Person
{
    private string _weapons;
    private int _hoursWorked;
    private double _hourlyWage;
    public PoliceMan(string firstName, string lastName,
    int age, string weapons, int hoursWorked, double hourlyWage)
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
        _hourlyWage = hourlyWage;
        _hoursWorked = hoursWorked;
    }

    public string GetPoliceManInformation()
    {
        return $"Weapons: {_weapons} :: {base.GetPersonInformation()}";
    }
    public override string GetPersonInformation()
    {
        return $"I am a Police Man: Tools: {_weapons} :: {base.GetPersonInformation()}";
    }
    public override double GetPay()
    {
        double pay = _hourlyWage * _hoursWorked;
        if (_hoursWorked > 40)
        {
            // pay -= (_hoursWorked - 40) * _hourlyWage;
            pay += (_hoursWorked - 40) * _hourlyWage * 2;
        }
        return pay;
    } 
}

