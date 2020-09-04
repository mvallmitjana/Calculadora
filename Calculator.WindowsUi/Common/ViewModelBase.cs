using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.WindowsUi.Common
{
    public class ViewModelBase : ValidatablePropertiesObject, IDisposable
    {
        private bool isBusy;

        public virtual string Code
        {
            get { return GetType().Name; }
        }

        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value, nameof(IsBusy)); }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public event EventHandler CloseRequest;

        public virtual bool CanClose()
        {
            return true;
        }

        protected virtual void OnCloseRequest()
        {
            var handler = CloseRequest;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Close()
        {
            OnCloseRequest();
        }
    }
}
