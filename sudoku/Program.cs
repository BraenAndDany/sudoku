
int[,] field=new int[11,11];
int numb = 0, sch=0;
int cube = 0;
Random random = new Random();
for(int i =0;i<11;i++)
{
    for (int j=0;j<11; j++)
    {
        sch= random.Next(10);
        if (i==0)
        {
            field[i,j] = 10;
        }
        else if (j == 0)
        {
            field[i, j] = 10;
        }
        else if (j == 10)
        {
            field[i, j] = 10;
        }
        else if (i == 10)
        {
            field[i, j] = 10;
        }
        else if (j==random.Next(10) && numb<3 && sch<10)
        {
            field[i,j] = random.Next(10);
            for (int f = 0; f < 2;)
            {
                for (int gor = 1; gor < 11; gor++)
                {

                    for (int provV = 1; provV < 11; provV++)
                    {
                        if (field[i, j] == field[gor, provV])
                        {
                            field[i, j] = random.Next(10);
                        }
                        else
                        {
                            f = 2;
                        }
                    }
                }
            }
            for (int f=0;f<2;)
            {
                for (int gor = 1; gor < 11; gor++)
                {

                    for (int provV = 1; provV < 11; provV++)
                    {
                        if (field[i, j] == field[ provV,gor ])
                        {
                            field[i, j] = random.Next(10);
                        }
                        else
                        {
                            f = 2;
                        }
                    }
                }
            }
            numb++;
        }
    }
    numb = 0;
}

for(int i = 0; i < 11;i++)
{
    for (int j=0;j<11;j++)
    {   
        if (field[i,j]==null)
        {

        }
        else if (field[i,j]==10)
        {
            Console.Write("■");
        }
        else 
        {
            Console.Write(field[i,j]);
        }
        Console.Write(" ");
    }
    Console.WriteLine("");
}