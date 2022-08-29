public static class Horse
{
    public static string moveHorse(int[,] field, int x, int y, int size)
    {
        string result = "Begin";
        int preX=0;
        int preY=0;

        //вверх вправо
        if (((x - 2) >= 0) && ((y + 1) < size))
        {
            preX=x;
            preY=y;
            x = x - 2;
            y = y + 1;
        }
        //вверх влево
        else if (((x - 2) > 0) && ((y - 1) > 0))
        {
            preX=x;
            preY=y;
            x = x - 2;
            y = y - 1;
        }
        //вправо вниз
        else if (((x + 1) < size ) && ((y + 2) < size))
        {
            preX=x;
            preY=y;
            x = x - 2;
            y = y - 1;
        }

        return result;
    }
}