public static class Horse
{
    // public static (bool empCell, int x, int y ) valueCell (int [,] field, int x, int y)
    // {
    //  bool empCell=true;   
    //  return (empCell , x, y);
    // }
    public static void nextMove(int x, int y, int size, int[,] field, int count)
    {
        
        //вверх вправо
        if (((x - 2) >= 0) && ((y + 1) < size))
        {
            if (field[x - 2, y + 1] != 1)
            {
                x = x - 2;
                y = y + 1;
                field[x, y] = 1;
                count++;
                if (count <= size*size)
                {
                showField();    
                Console.ReadLine();
                Horse .nextMove(x,y, size,field,count);
                }
                else
                {
                return 
                }
            }
        }
        //вверх влево
        else if (((x - 2) > 0) && ((y - 1) > 0))
        {
            if (field[x - 2, y - 1] != 1)
            {
                x = x - 2;
                y = y - 1;
                field[x, y] = 1;
                count++;
                Horse .nextMove(x,y, size,field,count);
            }
        }
        //вправо вниз
        if (((x + 1) < size) && ((y + 2) < size))
        {
            if (field[x + 1, y + 2] != 1)
            {
                x = x + 1;
                y = y + 2;
                field[x, y] = 1;
                count++;
                Horse .nextMove(x,y, size,field,count);
            }
        }
        //вправо вверх
        if (((x - 1) <= 0) && ((y + 2) < size))
        {
            if (field[x - 1, y + 2] != 1)
            {
                x = x - 1;
                y = y + 2;
                field[x, y] = 1;
                count++;
                Horse .nextMove(x,y, size,field,count);
            }
        }
        //вниз влево
        if (((x + 2) < size) && ((y - 1) >= 0))
        {
            if (field[x + 2, y - 1] != 1)
            {
                x = x + 2;
                y = y - 1;
                field[x, y] = 1;
                count++;
                Horse .nextMove(x,y, size,field,count);
            }
        }
        //вниз вправо
        if (((x + 2) < size) && ((y + 1) < size))
        {
            if (field[x + 2, y + 1] != 1)
            {
                x = x + 2;
                y = y + 1;
                field[x, y] = 1;
                count++;
                Horse .nextMove(x,y, size,field,count);
            }
        }
        //влево вверх
        if (((x - 1) >= 0) && ((y - 2) >= 0))
        {
            if (field[x - 1, y - 2] != 1)
            {
                x = x - 1;
                y = y - 2;
                field[x, y] = 1;
                count++;
                Horse .nextMove(x,y, size,field,count);
            }
        }
        //влево вниз
        if (((x + 1) < size) && ((y - 2) >= 0))
        {
            if (field[x + 2, y + 1] != 1)
            {
                x = x + 1;
                y = y - 2;
                field[x, y] = 1;
                count++;
                Horse .nextMove(x,y, size,field,count);
            }

        }

        return (x, y);
    }
}