Console.Write("Mata in ett stort och ett litet tal : ");

string input = Console.ReadLine();

string[] numberString = input.Split(' ');



if(numberString.Length == 2 )
{
    int a = int.Parse(numberString[0]);
    int b = int.Parse(numberString[1]);

    if(a < b)
    {
        Console.WriteLine("Räkna upp från " + a + " till " + b + ":");

        for(int i = a; i <= b; i++)
        {
            Console.WriteLine(i); 
        }
    }
    else if(a > b)
    {
        for(int i = a; i >= b;i--)
        {
            Console.WriteLine(i);
        }
    }
    else
    {
        Console.WriteLine("Talen är lika finns inget att räkna på");
    }

}
else
{
    Console.WriteLine("Fel input, mata in exakt två tal");
}



