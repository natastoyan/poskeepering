using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace roads.blazor.shared.Components
{
    public class WaitIndicatorService: IWaitIndicatorService
    {
        private IDictionary<string, OperationContext> _operations = new Dictionary<string, OperationContext>();
        public async Task RunOperation(Func<IOperationStatus, Task> operation, string contextKey = "")
        {
            contextKey ??= "";
            var operationContext = GetOrAddOperationContext(contextKey);
            var runningOp = new RunningOperation(operationContext);
            operationContext.AddOperation(runningOp);
            try
            {
                await operation(runningOp);
            }
            catch (Exception e)
            {
                Console.Error.Write(e);
                throw; // TODO
            }
            finally
            {
                operationContext.RemoveOperation(runningOp);
            }
        }

        private OperationContext GetOrAddOperationContext(string contextKey)
        {
            lock (_operations)
            {
                if (!_operations.TryGetValue(contextKey, out var operationContext))
                {
                    operationContext = new OperationContext();
                    _operations.Add(contextKey, operationContext);
                }
                return operationContext;
            }
        }

        public void SubscribeToOperationStatusChanged(Func<IOperationStatus, Task> operation,
            string contextKey = "")
        {
            var operationContext = GetOrAddOperationContext(contextKey);
            operationContext.ContextChanged += operation;
            operationContext.OnContextChanged();
        }

        public void UnsubscribeFromOperationStatusChanged(Func<IOperationStatus, Task> operation, string contextKey = "")
        {
            lock (_operations)
            {
                if (_operations.TryGetValue(contextKey, out var operationContext))
                {
                    operationContext.ContextChanged -= operation;
                }
            }
        }

        private class OperationContext
        {
            public IList<RunningOperation> RunningOperations { get; } = new List<RunningOperation>();

            public event Func<IOperationStatus, Task> ContextChanged;

            public void OnContextChanged()
            {
                ContextChanged?.Invoke(RunningOperations.LastOrDefault());
            }

            public void AddOperation(RunningOperation operation)
            {
                lock (this)
                {
                    RunningOperations.Add(operation);
                }
                OnContextChanged();
            }

            public void RemoveOperation(RunningOperation operation)
            {
                lock (this)
                {
                    RunningOperations.Remove(operation);
                }
                OnContextChanged();
            }
        }

        private class RunningOperation : IOperationStatus
        {
            private readonly OperationContext _context;
            private string _message;
            private string _subMessage;

            public RunningOperation(OperationContext context)
            {
                _context = context ?? throw new NullReferenceException();
            }

            public string Message
            {
                get => _message;
                set
                {
                    if (_message != value)
                    {
                        _message = value;
                        _context.OnContextChanged();
                    }
                }
            }

            public string SubMessage
            {
                get => _subMessage;
                set
                {
                    if (_subMessage != value)
                    {
                        _subMessage = value;
                        _context.OnContextChanged();
                    }
                }
            }
        }
    }
}
