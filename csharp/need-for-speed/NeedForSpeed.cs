using System;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed;
    private int batteryPercentage;
    private int distance;
    private int batteryDrain;

    public RemoteControlCar(int Speed, int BatteryDrain) {
        this.speed = Speed;
        this.batteryPercentage = 100;
        distance = 0;
        this.batteryDrain = BatteryDrain;
    }

    public bool BatteryDrained() => (this.batteryPercentage - this.batteryDrain) < 0 ? true : false;

    public int DistanceDriven() => this.distance;

    public void Drive() 
    {
        if(!BatteryDrained()) 
        {
            this.distance += speed; 
            this.batteryPercentage -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int distance;

    public RaceTrack(int dst) {
        this.distance = dst;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained()) 
        {
          car.Drive();   
        }

        return car.DistanceDriven() >= this.distance;
    }
}
