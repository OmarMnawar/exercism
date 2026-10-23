class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int expectedTime)
    {
        return ExpectedMinutesInOven() - expectedTime;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layersOfLasagna)
    {
        return layersOfLasagna * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layersOfLasagna, int timeOfLasagnaPutInOven)
    {
        return timeOfLasagnaPutInOven + PreparationTimeInMinutes(layersOfLasagna);
    }
}
