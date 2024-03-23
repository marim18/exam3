/*------------task2--------------------*/
using System.Text.Json;
namespace Exam3{
class task2{
    public List<ArrayObject> ListOfArrays = new List<ArrayObject>();
    public void reader() //need this to make an array to put in arrayflattener when my brain recovers
    {
    string FileJson = File.ReadAllText("arrays.json");
    ArrayObject a = JsonSerializer.Deserialize<ArrayObject>(FileJson);
    ListOfArrays.Add(a);
    }
public int[] ArrayFlattener( int[] jsonArray) 
{ int [] FlattArray;
    int Lenght = jsonArray.Length;
    int count = 0;
    List<int> ListTemporary = new List<int>();
   foreach (int i in jsonArray){
    ListTemporary.Add(i);
   }
   FlattArray = ListTemporary.ToArray();

    return FlattArray;
} } }
class ArrayObject{
    int[] InnsideArrays {get;set;}

}


/*

            int line = 0;
           string Temp  ="";
            var arrays = JsonSerializer.Deserialize<int[]>(File.ReadAllText("arrays.json").Trim());
   Console.WriteLine($"{ArrayFlattener(jsonArray)}");


class array1{
    foreach array in arrays{
    int[] jsonArray = array.Jsonar}
}

 using (StreamReader reader = new StreamReader("../exam3/arrays.json"))
        {
           int line;
            while ((line = int.Parse(reader.ReadLine())) != null)
            {
                lines.Add(line);
            }
            

        }

 //var fileContent = JsonSerializer.Deserialize<int[]>(File.steamreade("arrays.json"));
 List<int> lines = new List<int>();
  using (StreamReader reader = new StreamReader("arrays.json"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
            }
        }
        Console.WriteLine($"{lines}");*/