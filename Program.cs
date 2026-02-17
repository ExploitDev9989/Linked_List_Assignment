namespace linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            
            HouseManager manager = new HouseManager();
            manager.AddHouse(120, "Pryor St.", "Colonial");
            manager.AddHouse(121, "Swan Dr.", "Ranch");
            manager.AddHouse(122, "Main St", "Ranch");
            manager.AddHouse(123, "Oak St", "Colonial");
            Console.WriteLine("Enter the house number to search: ");
            int number = int.Parse(Console.ReadLine());
            HouseNode found = manager.FindHouseByNumber(number);

            if (found == null)
                Console.WriteLine("House Not Found!");
            else
            {
                Console.WriteLine($" House : { found.HouseNumber} \n Address : {found.Address} \n Type : {found.Type}");
            }
        }
        
    }

}
