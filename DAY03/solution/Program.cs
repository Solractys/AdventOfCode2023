string [] input = File.ReadAllText("input.txt").Split("\n");
foreach (string item in input)
{
    Console.WriteLine(item);
}