// See https://aka.ms/new-console-template for more informatio
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

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
string ArrayFlattener(  int[] jsonArray)
{ string FlattArray = "";
    int Lenght = jsonArray.Length;
    for (int i = 0; i < Lenght; i++)
    {
        FlattArray += jsonArray[i];
    }
    return FlattArray;
}

            int line = 0;
           string Temp  ="";
            int[] jsonArray = JsonSerializer.Deserialize<int[]>(File.ReadAllText("arrays.json").Trim());
   Console.WriteLine($"{ArrayFlattener(jsonArray)}");
