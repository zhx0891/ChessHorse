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
        System.Console.ReadLine();
    }
    public static void meWantToHideIt(int x, int y, int size, int[,] field, int count)
    {
        field[x, y] = 1;
        count++;
        if (count <= size * size)
        {
            showField(field);
            Horse.nextMove(x, y, size, field, count);
        }
    }
    public static void nextMove(int x, int y, int size, int[,] field, int count)
    {

        //вверх вправо
        System.Console.WriteLine($" {x},{y} {count}");
        Horse.showField(field);

        if (((x - 2) >= 0) && ((y + 1) < size))
        {
            if (field[x - 2, y + 1] != 1)
            {
                x = x - 2;
                y = y + 1;
                meWantToHideIt(x, y, size, field, count);
            }
        }
        //вверх влево

        if (((x - 2) > 0) && ((y - 1) > 0))
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
            if (field[x + 2, y + 1] != 1)
            {
                x = x + 1;
                y = y - 2;
                meWantToHideIt(x, y, size, field, count);
            }

        }


    }
}
