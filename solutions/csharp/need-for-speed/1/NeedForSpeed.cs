class RemoteControlCar
{
    int battery = 100;    
    int speed = 5;
    int batteryDrain = 2;
    int distanceDriven = 0;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return battery < batteryDrain;
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (BatteryDrained() == false) {
            distanceDriven += speed;
            battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    int distance = 800;

    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.BatteryDrained() == false && car.DistanceDriven() < distance) {
            car.Drive();
        }
        return car.DistanceDriven() >= distance;
    }
}
