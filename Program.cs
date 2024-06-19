internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("nenne eine Zeitzone");

        var Timezone = Console.ReadLine() ?? string.Empty;
        var Now = DateTime.Now;

        var newTime = TimeZoneInfo.ConvertTime(Now, TimeZoneInfo.FindSystemTimeZoneById(Timezone));
        Console.WriteLine($"Wenn es hier {Now} ist, ist es in {Timezone} {newTime}, {Timezone} geht {(Now-newTime).TotalHours} Stunden nach");
    }
}