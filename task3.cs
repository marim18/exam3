using System.Text.Json;

class nodes
{
    public int value { get; set; }
    public string? right { get; set; }
    public string? left { get; set; }
    void reader()
{
    var NodeString = File.ReadAllText("nodes.json");
    nodes node = JsonSerializer.Deserialize<nodes>(NodeString);
}


void SummarizeFunction()
{
    int count = 0; //remember to change names
    int count2 = 0;
    int count3 = 0;
    foreach (nodes.value in nodes)
    {
        count += value;
    }
    foreach (innerarray in nodes)
    { //this needs to change
        count2++;
    }
    foreach (nodes node)
    {
        count3++;
    }
    Console.WriteLine($"report: Sum = {count}, depth = {count2}, node = {count3} ");

}
}

