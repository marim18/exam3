/*------------task2--------------------*/
using System.Text.Json;
namespace Exam3
{
    public class task2
    {
        List<ArrayObject> ListOfArrays = new List<ArrayObject>();
        public void reader()
        {
            try
            {
                string fileJson = File.ReadAllText("arrays.json");

                ArrayObject arrayObject = JsonSerializer.Deserialize<ArrayObject>(fileJson);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error reading JSON file: " + ex.Message);
            }
        }
        public int[] ArrayFlattener()
        {
            int[] FlattArray;
            
            int count = 0; 
            List<int> ListTemporary = new List<int>();
            foreach (ArrayObject jsonArray in ListOfArrays)
            {
                int Lenght = jsonArray.InnsideArrays.Length;
               

                foreach (int i in jsonArray.InnsideArrays)
                {
                    ListTemporary.Add(i);
                }
              
            }  FlattArray = ListTemporary.ToArray();

            return FlattArray;
        }
    }
}
public class ArrayObject
{
     public List<object> Data { get; set; }
    public int[] InnsideArrays { get; set; }

}


/* Left it here to document i tried

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