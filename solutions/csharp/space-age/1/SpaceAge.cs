public class SpaceAge
{
    int seconds = 0;
    double years = 0;
    
    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
        years = seconds / 31557600.0;
    }

    public double OnEarth()
    {
        return years / 1.0;
    }

    public double OnMercury()
    {
        return years / 0.2408467;
    }

    public double OnVenus()
    {
        return years / 0.61519726;
    }

    public double OnMars()
    {
        return years / 1.8808158;
    }

    public double OnJupiter()
    {
        return years / 11.862615;
    }

    public double OnSaturn()
    {
        return years / 29.447498;
    }

    public double OnUranus()
    {
        return years / 84.016846;
    }

    public double OnNeptune()
    {
        return years / 164.79132;
    }
}