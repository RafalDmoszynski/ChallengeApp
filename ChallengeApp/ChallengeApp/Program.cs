var name = "Ewa";
bool woman = true;
var age = 29;

if (woman == true)
{
    if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33.");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat.");
    }
    else
    {
        Console.WriteLine("Twoja płęć to kobieta, pozostałe dane niezgodne.");
    }
}
else
{
    if (!woman && age < 18)
    {
        Console.WriteLine("Niepełnoletni Mężczyzna.");
    }
    else
    {
        Console.WriteLine("Error - wprowadź nowe dane !");
    }
}

