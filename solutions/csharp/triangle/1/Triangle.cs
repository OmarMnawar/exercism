public static class Triangle
{
    public static bool IsScalene(double side1, double side2, double side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            return false;

        if (side1 + side2 < side3 || side2 + side3 < side1 || side1 + side3 < side2)
            return false;
            
        return side1 != side2 && side2 != side3 && side1 != side3;    
    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            return false;        

        if (side1 == side2 && (side1 + side2) >= side3)
            return true;
        else if (side1 == side3 && (side1 + side3) >= side2)
            return true;
        else if (side3 == side2 && (side3 + side2) >= side1)
            return true;
        else
            return false;
    }

    public static bool IsEquilateral(double side1, double side2, double side3)
    {
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            return false;
        
        return side1 == side2 && side2 == side3;
    }
}