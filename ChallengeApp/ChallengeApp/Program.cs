string name = "Ewa";
bool Women = true;
int age = 29;

if (Women = true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}

else if (Women = false && name != "Ewa" && age <= 17)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Brak danych w bazie");
}