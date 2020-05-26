using System;
namespace GiJoStock
{
    public interface IFormEvents
    {
        event EventHandler<EventArgs> OnAdded;
        event EventHandler<EventArgs> OnUpdate;
    }
}