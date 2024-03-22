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
    double Pi = 3.14159;
    double NoMagicTwo = 2;
    return NoMagicTwo * Pi * Radius;
}
string GreetingsSir(string Name)
{
    string GreetingName = $"Hello there {Name} Fancy seeing you here";
    return GreetingName;
}
/*------------task2--------------------*/
string ArrayFlattener( List<int> Objects)
{ string FlattArray = "";
    int Lenght = Objects.Count;
    for (int i = 0; i < Lenght; i++)
    {
        FlattArray += Objects[i];
    }
    return FlattArray;
}

 List<int> lines = new List<int>();
 using (StreamReader reader = new StreamReader("arrays.json"))
        {
           int line;
            while ((line = int.Parse(reader.ReadLine())) != null)
            {
                lines.Add(line);
            }
        }
   Console.WriteLine($"{ArrayFlattener(lines)}");
    