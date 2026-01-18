namespace RaspberryEmbeddedApp.Devices.Input;

using System;

public interface IInputDevice
{
    event EventHandler<EventArgs<InputKey>> Handle;
}
