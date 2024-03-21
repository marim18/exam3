// See https://aka.ms/new-console-template for more information


double SquarifyNumber(double Number)
{

    return Number * Number;
}

double ConvertInchToMm(double Number)
{
    double ConvertionConstant = 25.4;
    return Number * ConvertionConstant;
}

int RootifyNumber(int Number)
{
    for (int i = 0; i < Number; i++) 
    { 
        if(i*i == Number){
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
double CalculateRadiusOfACircle(){
    double answer = 0;
    return answer;
}