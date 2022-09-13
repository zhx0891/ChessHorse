public static class Horse
{

    public static void showField(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                System.Console.Write($" {arr[i, j]}");
            }
        }
        System.Console.WriteLine();
        
        System.Console.ReadLine();
    }



    public static void meWantToHideIt(int x, int y, int size, int[,] field, int count)
    {
        field[x, y] = 1;
        count++;

        if (count <= size * size)
        {
             showField(field);
             System.Console.WriteLine($"x= {x} y={y} size= {size} count = {count}");
            Horse.nextMove(x, y, size, field, count);
        }
    }













    // public static(int [,] field, int x, int y, bool goodMove,int count) upRight (int x, int y, int[,] field, int count)
    // {
    //     //вверх вправо
    //     bool goodMove = true;
    //     if ((x - 2) >= 0 & (y + 1) < field .GetLength(0)*field.GetLength(1))//проверка существования клетки на поле
    //     {
    //         if (field[x - 2, y + 1] != 1) //проверка клетки на содержимое
    //         {
    //             x = x - 2;
    //             y = y + 1;
    //             field[x, y] = 1;
    //             count++;
    //         }

    //     } 
    //     return (field,x,y,goodMove, count);
    // }

    public static void nextMove(int x, int y, int size, int[,] field, int count)
    {
        //вверх вправо
        int goodX;
        int goodY;

        if ((x - 2) >= 0 & (y + 1) < size)
        {
            if (field[x - 2, y + 1] != 1)
            {
                goodX =x;
                goodY =y;
                x = x - 2;
                y = y + 1;
                meWantToHideIt(x, y, size, field, count);
            }
        }

        //вверх влево
        if (((x - 2) >= 0) && ((y - 1) >= 0))
        {
            if (field[x - 2, y - 1] != 1)
            {
                x = x - 2;
                y = y - 1;
                meWantToHideIt(x, y, size, field, count);
            }
        }

        //вправо вниз
        if (((x + 1) < size) && ((y + 2) < size))
        {
            if (field[x + 1, y + 2] != 1)
            {
                x = x + 1;
                y = y + 2;
                meWantToHideIt(x, y, size, field, count);
            }

        }

        //вправо вверх 
        if (((x - 1) <= 0) && ((y + 2) < size))
        {
            if (field[x - 1, y + 2] != 1)
            {
                x = x - 1;
                y = y + 2;
                meWantToHideIt(x, y, size, field, count);
            }
        }

        //вниз влево
        if (((x + 2) < size) && ((y - 1) >= 0))
        {
            if (field[x + 2, y - 1] != 1)
            {
                x = x + 2;
                y = y - 1;
                meWantToHideIt(x, y, size, field, count);
            }
        }

        //вниз вправо
        if (((x + 2) < size) && ((y + 1) < size))
        {
            if (field[x + 2, y + 1] != 1)
            {
                x = x + 2;
                y = y + 1;
                meWantToHideIt(x, y, size, field, count);
            }
        }

        //влево вверх
        if (((x - 1) >= 0) && ((y - 2) >= 0))
        {
            if (field[x - 1, y - 2] != 1)
            {
                x = x - 1;
                y = y - 2;
                meWantToHideIt(x, y, size, field, count);
            }
        }

        //влево вниз
        if (((x + 1) < size) && ((y - 2) >= 0))
        {
            if (field[x + 1, y - 2] != 1)
            {
                x = x + 1;
                y = y - 2;
                meWantToHideIt(x, y, size, field, count);
            }
        }

        //вверх влево
        if ((x - 2) > 0 & (y - 1) > 0)
        {
            if (field[x - 2, y - 1] != 1)
            {
                x = x - 2;
                y = y - 1;
                meWantToHideIt(x, y, size, field, count);
            }
        }

        //вправо вниз
        if ((x + 1) < size & (y + 2) < size)
        {
            if (field[x + 1, y + 2] != 1)
            {
                x = x + 1;
                y = y + 2;
                meWantToHideIt(x, y, size, field, count);
            }
        }

        //вправо вверх
        if (((x - 1) <= 0) & ((y + 2) < size))
        {
            if (field[x - 1, y + 2] != 1)
            {
                x = x - 1;
                y = y + 2;
                meWantToHideIt(x, y, size, field, count);

            }
        }

        //вниз влево
        if (((x + 2) < size) & ((y - 1) >= 0))
        {
            if (field[x + 2, y - 1] != 1)
            {
                x = x + 2;
                y = y - 1;
                meWantToHideIt(x, y, size, field, count);
            }
        }

        //вниз вправо
        if (((x + 2) < size) & ((y + 1) < size))
        {
            if (field[x + 2, y + 1] != 1)
            {
                x = x + 2;
                y = y + 1;
                meWantToHideIt(x, y, size, field, count);
            }
        }

        //влево вверх
        if (((x - 1) >= 0) & ((y - 2) >= 0))
        {
            if (field[x - 1, y - 2] != 1)
            {
                x = x - 1;
                y = y - 2;
                meWantToHideIt(x, y, size, field, count);
            }
        }

        //влево вниз
        if (((x + 1) < size) & ((y - 2) >= 0))
        {
            if (field[x + 1, y - 2] != 1)
            {
                x = x + 1;
                y = y - 2;
                meWantToHideIt(x, y, size, field, count);
            }
            else
            {
                // System.Console.WriteLine($"x= {x} y={y} size= {size} count = {count}");
                // System.Console.WriteLine(" Ходы закончены");
                // // showField(field);
                x=goodX;
            }
        }



    }



}

