int[,] ages =
{
    { 33, 11 },
    { 10, 28 },
    { 28, 21 },
    { 7, 18 },
    { 9, 8 },
    { 34, 44 },
    { 65, 65 },
    { 35, 51 }
};

for (int i = 0; i < ages.GetLength(0); i++)
{
    int age1 = ages[i, 0];
    int age2 = ages[i, 1];

    if (age1 == age2)
    {
        Console.WriteLine("Message 1 Printed");
    }
    else if (age1 > age2)
    {
        if (age1 <= 34)
        {
            if (age2 > 15)
            {
                Console.WriteLine("Message 2 Printed");
            }
            else
            {
                Console.WriteLine("Message 3 Printed");
            }
        }
        else
        {
            Console.WriteLine("Message 4 Printed");
        }
    }
    else
    {
        if (age2 > 18)
        {
            if (age1 < 34)
            {
                Console.WriteLine("Message 5 Printed");
            }
            else if (age2 <= 51)
            {
                Console.WriteLine("Message 6 Printed");
            }
            else
            {
                Console.WriteLine("Message 7 Printed");
            }
        }
        else
        {
            Console.WriteLine("Message 8 Printed");
        }
    }
}