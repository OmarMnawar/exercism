public static class SquareRoot
{
    public static int Root(int number)
    {
        for (int i = 1; i <= number; i++) {
            int square = i * i;

            if(square == number) {
                return i;
            }
            if (square > number) {
                break;
            }
        }
        
        return 0;
    }
}
