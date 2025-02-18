using System;

class RemoteControlCar
{
    private int CarDistance = 0;
    private int BatteryLevel = 100;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {CarDistance} meters";

    public string BatteryDisplay() => BatteryLevel > 0 ? $"Battery at {BatteryLevel}%" : "Battery empty";

    public void Drive()
    {
        if(BatteryLevel <= 0) {
            return;
        }
        
        CarDistance += 20;
        BatteryLevel--;
    }
}
