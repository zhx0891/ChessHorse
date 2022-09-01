public static class Horse
{
    
    public static void showField (int [,] field)
    {
        for (int i = 0; i < field .GetLength(0); i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < field.GetLength(1); j++)
            {
                System.Console.Write(field [i,j] + " ");
            }
        }
    }


    public static void nextMove(int x, int y, int size, int[,] field, int count)
    {
        System.Console.WriteLine($"x= {x} y={y} size= {size} count = {count}");
        showField(field);

        //вверх вправо
        if ((x - 2) >= 0 & (y + 1) < size)
        {
            if (field[x - 2, y + 1] != 1)
            {
                x = x - 2;
                y = y + 1;
                field[x, y] = 1;
                count++;
                if (count < size * size)
                {
                    showField(field);
                    Console.ReadLine();
                    Horse.nextMove(x, y, size, field, count);
                }

            }
            //вверх влево
            System.Console.WriteLine($"x= {x} y={y} size= {size} count = {count}");
            if ((x - 2) > 0 & (y - 1) > 0)
            {
                if (field[x - 2, y - 1] != 1)
                {
                    x = x - 2;
                    y = y - 1;
                    field[x, y] = 1;
                    count++;
                    if (count < size * size)
                    {
                        showField(field);
                        Console.ReadLine();
                        Horse.nextMove(x, y, size, field, count);
                    }
                }
            }
            //вправо вниз
            System.Console.WriteLine($"x= {x} y={y} size= {size} count = {count}");
            if ((x + 1) < size & (y + 2) < size)
            {
                if (field[x + 1, y + 2] != 1)
                {
                    x = x + 1;
                    y = y + 2;
                    field[x, y] = 1;
                    count++;
                    if (count < size * size)
                    {
                        showField(field);
                        Console.ReadLine();
                        Horse.nextMove(x, y, size, field, count);
                    }
                }
            }
            //вправо вверх
            System.Console.WriteLine($"x= {x} y={y} size= {size} count = {count}");
            if (((x - 1) <= 0) & ((y + 2) < size))
            {
                if (field[x - 1, y + 2] != 1)
                {
                    x = x - 1;
                    y = y + 2;
                    field[x, y] = 1;
                    count++;
                    if (count < size * size)
                    {
                        showField(field);
                        Console.ReadLine();
                        Horse.nextMove(x, y, size, field, count);
                    }
                }
            }
            //вниз влево
            System.Console.WriteLine($"x= {x} y={y} size= {size} count = {count}");
            if (((x + 2) < size) & ((y - 1) >= 0))
            {
                if (field[x + 2, y - 1] != 1)
                {
                    x = x + 2;
                    y = y - 1;
                    field[x, y] = 1;
                    count++;
                    if (count < size * size)
                    {
                        showField(field);
                        Console.ReadLine();
                        Horse.nextMove(x, y, size, field, count);
                    }
                }
            }
            //вниз вправо
            System.Console.WriteLine($"x= {x} y={y} size= {size} count = {count}");
            if (((x + 2) < size) & ((y + 1) < size))
            {
                if (field[x + 2, y + 1] != 1)
                {
                    x = x + 2;
                    y = y + 1;
                    field[x, y] = 1;
                    count++;
                    if (count < size * size)
                    {
                        showField(field);
                        Console.ReadLine();
                        Horse.nextMove(x, y, size, field, count);
                    }
                }
            }
            //влево вверх
            System.Console.WriteLine($"x= {x} y={y} size= {size} count = {count}");
            if (((x - 1) >= 0) & ((y - 2) >= 0))
            {
                if (field[x - 1, y - 2] != 1)
                {
                    x = x - 1;
                    y = y - 2;
                    field[x, y] = 1;
                    count++;
                    if (count < size * size)
                    {
                        showField(field);
                        Console.ReadLine();
                        Horse.nextMove(x, y, size, field, count);
                    }
                }
            }
            //влево вниз
            System.Console.WriteLine($"x= {x} y={y} size= {size} count = {count}");
            if (((x + 1) < size) & ((y - 2) >= 0))
            {
                if (field[x + 2, y + 1] != 1)
                {
                    x = x + 1;
                    y = y - 2;
                    field[x, y] = 1;
                    count++;
                    if (count < size * size)
                    {
                        showField(field);
                        Console.ReadLine();
                        Horse.nextMove(x, y, size, field, count);
                    }
                }

            }
            else
            {
                System.Console.WriteLine(" Ходы закончены");
            }

            
        }
    }
} 