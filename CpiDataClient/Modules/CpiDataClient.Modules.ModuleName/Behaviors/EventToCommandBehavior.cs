using System;
using System.Windows;
using System.Windows.Input;
using Microsoft.Xaml.Behaviors;

namespace CpiDataClient.Modules.Skus.Behaviors;

public class EventToCommandBehavior: Behavior<UIElement>
{
    public static readonly DependencyProperty EventNameProperty =
        DependencyProperty.Register(nameof(EventName), typeof(string), typeof(EventToCommandBehavior), new PropertyMetadata(null, OnEventNameChanged));

    public static readonly DependencyProperty CommandProperty =
        DependencyProperty.Register(nameof(Command), typeof(ICommand), typeof(EventToCommandBehavior), new PropertyMetadata(null));

    public string EventName
    {
        get => (string)GetValue(EventNameProperty);
        set => SetValue(EventNameProperty, value);
    }

    public ICommand Command
    {
        get => (ICommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }

    protected override void OnAttached()
    {
        base.OnAttached();
        AttachEvent(EventName);
    }

    protected override void OnDetaching()
    {
        base.OnDetaching();
        DetachEvent(EventName);
    }

    private void AttachEvent(string eventName)
    {
        if (AssociatedObject == null || string.IsNullOrEmpty(eventName))
            return;

        var eventInfo = AssociatedObject.GetType().GetEvent(eventName);
        if (eventInfo == null)
            throw new ArgumentException($"Event '{eventName}' not found on object of type '{AssociatedObject.GetType().Name}'.");

        var methodInfo = typeof(EventToCommandBehavior).GetMethod(nameof(OnEventRaised), System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var handler = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, methodInfo);
       
        eventInfo.AddEventHandler(AssociatedObject, handler);
    }

    private void DetachEvent(string eventName)
    {
        if (AssociatedObject == null || string.IsNullOrEmpty(eventName))
            return;

        var eventInfo = AssociatedObject.GetType().GetEvent(eventName);
        if (eventInfo == null)
            return;

        var methodInfo = typeof(EventToCommandBehavior).GetMethod(nameof(OnEventRaised), System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        var handler = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, methodInfo);
        
        eventInfo.RemoveEventHandler(AssociatedObject, handler);
    }

    private void OnEventRaised(object sender, EventArgs e)
    {
        if (Command?.CanExecute(e) == true)
            Command.Execute(e);
    }

    private static void OnEventNameChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var behavior = (EventToCommandBehavior)d;
        if (behavior.AssociatedObject != null)
        {
            behavior.DetachEvent((string)e.OldValue);
            behavior.AttachEvent((string)e.NewValue);
        }
    }
}