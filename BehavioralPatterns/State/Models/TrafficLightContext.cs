using State.Interfaces;

namespace State.Models;

public class TrafficLightContext
{
    private ITrafficLightState _state;

    public TrafficLightContext(ITrafficLightState initialState)
    {
        _state = initialState;
    }

    public void SetState(ITrafficLightState newState)
    {
        _state = newState;
    }

    public void ChangeLight()
    {
        _state.ChangeLight(this);
    }
}
