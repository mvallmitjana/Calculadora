using System;
using System.Collections.Generic;
using System.Drawing;
namespace Calculator.WindowsUi.Common
{
    public interface ICommandText : ICommand
    {
        string Text { get; }
        Color ForeColor { get; }
        Color BackgroundColor { get; }
    }
}
