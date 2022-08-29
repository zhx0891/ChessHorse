public static class Horse
{
    public static (int x, int y) nextMove( int x, int y, int size, int [,] field)
    {
        //вверх вправо
        if (((x - 2) >= 0) && ((y + 1) < size))
        {
            x = x - 2;
            y = y + 1;
            if(field[x,y] != 1)
            {
                field[x,y]=1;
            }
        }
        //вверх влево
        if (((x - 2) > 0) && ((y - 1) > 0))
        {
            x = x - 2;
            y = y - 1;
        }
        //вправо вниз
        if (((x + 1) < size ) && ((y + 2) < size))
        {
            x = x + 1;
            y = y + 2;
        }
        //вправо вверх
        if (((x - 1) <= 0 ) && ((y + 2) < size))
        {
            x = x - 1;
            y = y + 2;
        }
        //вниз влево
        if (((x + 2) < size ) && ((y - 1) >= 0))
        {
            x = x + 2;
            y = y - 1;
        }
        //вниз вправо
        if (((x + 2) < size ) && ((y + 1) < size ))
        {
            x = x + 2;
            y = y + 1;
        }
        //влево вверх
        if (((x - 1) >= 0 ) && ((y - 2) >= 0))
        {
            x = x - 1;
            y = y - 2;
        }
        //влево вниз
        if (((x + 1) < size ) && ((y - 2) >= 0))
        {
            x = x + 1;
            y = y - 2;
        }

        return (x, y);
    }
}