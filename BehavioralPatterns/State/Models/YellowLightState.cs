using State.Interfaces;

namespace State.Models;

public class YellowLightState : ITrafficLightState
{
    public void ChangeLight(TrafficLightContext context)
    {
        Console.WriteLine("Yellow Light - Caution!");
        Thread.Sleep(2000);
        context.SetState(new GreenLightState());
    }
}
