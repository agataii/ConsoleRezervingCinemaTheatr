using ConsoleApp6;

internal class Program
{
    private static void Main(string[] args)
    {
        CinemaTheatr cinema = new CinemaTheatr();
        cinema.CinemaPlacePrint();
        Console.WriteLine("Команды:1.Бронировать    2.Выход");
        int a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 1:
                Console.WriteLine("Введите номер места в таком формате: [ряд,место]. Если вы хотите забронировать несколько мест, то через пробел:");
                string n = Console.ReadLine();
                string[] ns = n.Split(' ');
                for (int i = 0; i < ns.Length; i++)
                {
                    string[] placeData = ns[i].Split(',');
                    Console.WriteLine($"Вы выбрали ряд:{placeData[0]}, место:{placeData[1]}");
                }
                Console.WriteLine("Вы все правильно ввели?");
                string b = Console.ReadLine();
                if (b.ToLower() == "да")
                {
                    foreach(string place in ns) 
                    {
                        string[] plaaceData = place.Split(",");
                        cinema.CinemaPlaces[Convert.ToInt32(plaaceData[0]) - 1, Convert.ToInt32(plaaceData[1]) - 1] = 'X';
                    }
                    cinema.CinemaPlacePrint();

                }
                else 
                { 
                    Console.WriteLine("Проверьте еще раз"); }
                break;
            case 2:
                Console.WriteLine();
                break;
            default:
                Console.WriteLine();
                break;
        }
    }
}