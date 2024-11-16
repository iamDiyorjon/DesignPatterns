using State.Models;

namespace State.Interfaces;

public interface ITrafficLightState
{
    void ChangeLight(TrafficLightContext context);
}
