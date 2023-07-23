using Otel_Task;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Hotel hotel = new Hotel("Hotel Californiya", "USA street Liclin", "+12338899799", 10,2,8,3);
        hotel.ShowRoom();
        Console.WriteLine("------------------------------------------");
        hotel.SetCustomer(5);
        Console.WriteLine("------------------------------------------");
        hotel.SetCustomer(2);
        Console.WriteLine("------------------------------------------");
        hotel.SetCustomer(6);
        Console.WriteLine("------------------------------------------");
        hotel.SetCustomer(2);

        Console.ReadLine();
    }
}