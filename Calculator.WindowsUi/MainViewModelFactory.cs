using Calculator.Common;
using System;
using Calculator.WindowsUi.Common;

namespace Calculator.WindowsUi
{
    public class MainViewModelFactory
    {
        private readonly IServiceContainer container;

        public static MainViewModelFactory Current { get; private set; }
        public static void CreateCurrent(IServiceContainer container)
        {
            Current = new MainViewModelFactory(container);
        }

        private MainViewModelFactory(IServiceContainer container)
        {
            if (container == null)
            {
                throw new ArgumentNullException("container");
            }
            this.container = container;
        }

        public T Get<T>() where T : ViewModelBase
        {
            return container.GetInstance<T>();
        }

        public ViewModelBase Get(Type typeOfViewModel)
        {
            return (ViewModelBase)container.GetInstance(typeOfViewModel);
        }
    }
}
