using System;
using System.Threading.Tasks;

namespace roads.blazor.shared.Components
{
    public interface IWaitIndicatorService
    {
        Task RunOperation(Func<IOperationStatus, Task> operation, string contextKey = "");

        void SubscribeToOperationStatusChanged(Func<IOperationStatus, Task> operation, string contextKey = "");

        void UnsubscribeFromOperationStatusChanged(Func<IOperationStatus, Task> operation, string contextKey = "");
    }
}
