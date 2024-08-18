using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;

namespace CpiDataClient.Core.Native;

public interface IUICommand
{
    event EventHandler Executed;
    void RaiseExecuted();

}
