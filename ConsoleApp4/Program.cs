// Prosta aplikacja wykonujace pseudolosowe rzuty wybrana koscia 
;

char choice;

//pusta linia

Random rng = new Random();

do
{
    Console.WriteLine("Jaka koscia chcesz rzucic: ");
    Console.WriteLine("1. K3");
    Console.WriteLine("2. K4");
    Console.WriteLine("3. K6");
    Console.WriteLine("4. K100");
    Console.WriteLine("0. Wyjscie");
    choice = Console.ReadKey(true).KeyChar;
    switch (choice)
    {
        case '1':
            // jesli podano 1
            Console.WriteLine("Wynik rzutu K3: " + rng.Next(1, 3));
            break;
        case '2':
            //jesli podano 2
            Console.WriteLine("Wynik rzutu K3: " + rng.Next(1, 4));
            break;
        case '3':
            //jesli podano 3
            Console.WriteLine("Wynik rzutu K3: " + rng.Next(1, 6));
            break;
        case '4':
            //jesli podano 4
            Console.WriteLine("Wynik rzutu K100: " + rng.Next(1, 100));
            break;
        case '0':
        //jesli podano 0
        Console.WriteLine("wyjscie z hazardu");
            break;

       default:
            //wykona sie jesli zaden wczesniejszy nie psauje
            Console.WriteLine("Podano nieprawidlowa opcje!");
            break;


    }

}
while (choice != '0');

