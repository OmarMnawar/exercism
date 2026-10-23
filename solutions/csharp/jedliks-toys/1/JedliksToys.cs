class RemoteControlCar
{
    double meters = 0;
    int battery = 100;
    
    public static RemoteControlCar Buy() => 
        new RemoteControlCar();

    public string DistanceDisplay()
    {
        return $"Driven {meters} meters";
    }

    public string BatteryDisplay()
    {
        if (battery <= 0)
            return "Battery empty";
        
        return $"Battery at {battery}%";
    }

    public void Drive()
    {
        if (battery <= 0)
            return;
        
        meters += 20;
        battery -= 1;
    }
}
