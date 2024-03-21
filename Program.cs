// See https://aka.ms/new-console-template for more information


double SquarifyNumber(double Number)
{

    return Number * Number;
}

double ConvertInchToMm(double Inches)
{
    double ConvertionConstant = 25.4;
    return Inches * ConvertionConstant;
}

int RootifyNumber(int Number)
{
    for (int i = 0; i < Number; i++)
    {
        if (i * i == Number)
        {
            return i;
        }

    }
    Console.WriteLine("Error this function only supports whole numbers something wrong happened");
    return 0;
}
double CubeifyNumber(double Number)
{

    return Number * Number * Number;
}
double CalculateRadiusOfACircle(double Radius)
{
    double pi = 3.14159;
    double NoMagicTwo = 2;
    return NoMagicTwo * pi * Radius;
}
string GreetingsSir(string Name)
{
    string GreetingName = $"Hello there {Name} Fancy seeing you here";
    return GreetingName;
}

string ArrayFlattener(int[] objects)
{ string FlattArray = "";
    int Lenght = objects.Length;
    for (int i = 0; i < Lenght; i++)
    {
        FlattArray += objects[i];
    }
    return FlattArray;
}