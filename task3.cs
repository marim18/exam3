using System.Text.Json;
namespace Exam3{
class task3
{ public List<nodes> instances = new List<nodes>();
    public void reader()
    {
    string NodeString = File.ReadAllText("nodes.json");
     nodes node = JsonSerializer.Deserialize<nodes>(NodeString);
    instances.Add(node);
    }


    public void SummarizeFunction()
    {
        int Sum = 0;
        int Depth = 0;
        foreach (nodes node in instances)
        {
            Sum += node.value;
            if (node.undernodes.Count > Depth)
            {
                Depth = node.undernodes.Count;
            }

        }
        Console.WriteLine($"report: Sum = {Sum}, depth = {Depth}, node = {instances.Count} ");
    }


}
class nodes
{
    public int value { get; set; }
    public string? right { get; set; }
    public string? left { get; set; }
    public List<nodes> undernodes { get; set; }


}
}
