using System;
using System.Windows.Input;

namespace CpiDataClient.Core.Native;

public class UICommand:IUICommand
{
    public event EventHandler Executed;

    public string Id { get; set; }
    public string Caption { get; set; }
    public ICommand Command { get; set; }
    public bool IsDefault { get; set; }
    public bool IsCancel { get; set; }
    public object Glyph { get; set; }

    public void RaiseExecuted()
    {
        
    }
}