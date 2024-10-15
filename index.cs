Console.WriteLine("What is your name");
string name = Console.ReadLine();

Console.WriteLine("How old are you?");
int age = Convert.ToInt32(Console.ReadLine());

Menu()

public void Menu()
{
    Console.WriteLine("What form of transport do you use?\n1. Public transpot\n2. Personal Vehicle\n3. Boat");
    string option = Console.ReadLine();

    switch(option)
    {
        case: "1"
            Console.WriteLine("Taxis and Busses are cool.")
            break;
        case: "2"
            Console.WriteLine("I love a mazda.")
            break;
        case: "3"
            Console.WriteLine("Taxis and Busses are cool.")
            break;
        default:
            Console.WriteLine("Wrong selection!")
    }
}