using State.Enums;
using State.Models;

public class Program
{
    static void Main(string[] args)
    {
        #region Example 1
        var currentState = StateEnum.Closed;

        currentState = ChangeState(currentState, InputEnum.OpenDoor);
        Console.WriteLine($"Current State: {currentState}");

        currentState = ChangeState(currentState, InputEnum.CloseDoor);
        Console.WriteLine($"Current State: {currentState}");

        currentState = ChangeState(currentState, InputEnum.LockDoor);
        Console.WriteLine($"Current State: {currentState}");

        try
        {
            currentState = ChangeState(currentState, InputEnum.OpenDoor);
            Console.WriteLine($"Current State: {currentState}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
        #endregion

        var trafficLight = new TrafficLightContext(new RedLightState());

        while (true)
        {
            trafficLight.ChangeLight();
        }
    }

    static StateEnum ChangeState(StateEnum currentState, InputEnum input)
    {
        return (currentState, input) switch
        {
            (StateEnum.Closed, InputEnum.OpenDoor) => StateEnum.Open,
            (StateEnum.Open, InputEnum.CloseDoor) => StateEnum.Closed,
            (StateEnum.Closed, InputEnum.LockDoor) => StateEnum.Locked,
            (StateEnum.Locked, InputEnum.UnlockDoor) => StateEnum.Closed,
            _ => throw new InvalidOperationException($"Cannot transition from {currentState} with input {input}")
        };
    }
}
