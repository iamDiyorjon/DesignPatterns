using State.Interfaces;

namespace State.Models;

public class RedLightState : ITrafficLightState
{
    public void ChangeLight(TrafficLightContext context)
    {
        Console.WriteLine("Red Light - Stop!");
        Thread.Sleep(2000);
        context.SetState(new YellowLightState());
    }
}