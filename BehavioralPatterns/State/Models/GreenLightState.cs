using State.Interfaces;

namespace State.Models;

public class GreenLightState : ITrafficLightState
{
    public void ChangeLight(TrafficLightContext context)
    {
        Console.WriteLine("Green Light - Go!");
        Thread.Sleep(2000);
        context.SetState(new YellowLightState());
    }
}
