public static class Darts
{
    public static int Score(double x, double y)
    {
        double distance = Math.Sqrt(x * x + y * y);

        int score = 10;

        if (distance <= 1.0) {
            score = 10;
        }
        else if (distance <= 5.0) {
            score = 5;
        }
        else if (distance <= 10.0){
            score = 1;
        }
        else{
            score = 0;
        }
        return score;
    }
}
