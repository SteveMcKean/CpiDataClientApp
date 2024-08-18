using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CpiDataClient.Core;
using CpiDataClient.Core.Mvvm;
using Microsoft.Xaml.Behaviors;

namespace CpiDataClient.Modules.Skus.Behaviors;

public class DialogServiceBehavior: Behavior<FrameworkElement>, IDialogService
{
    public static readonly DependencyProperty ShowDialogCommandProperty =
       DependencyProperty.Register(nameof(ShowDialogCommand), typeof(ICommand), typeof(DialogServiceBehavior), new PropertyMetadata(null));

    public static readonly DependencyProperty DialogResultProperty =
        DependencyProperty.Register(nameof(DialogResult), typeof(bool?), typeof(DialogServiceBehavior), new PropertyMetadata(null));

    public static readonly DependencyProperty ViewTemplateProperty =
        DependencyProperty.Register(nameof(ViewTemplate), typeof(DataTemplate), typeof(DialogServiceBehavior), new PropertyMetadata(null));

    public static readonly DependencyProperty DialogStyleProperty =
        DependencyProperty.Register(nameof(DialogStyle), typeof(Style), typeof(DialogServiceBehavior), new PropertyMetadata(null));


    public static readonly DependencyProperty KeyProperty =
        DependencyProperty.Register(nameof(Key), typeof(string), typeof(DialogServiceBehavior), new PropertyMetadata(null));


    public static readonly DependencyProperty DialogButtonsProperty =
        DependencyProperty.Register(nameof(LocalDialogButtons), typeof(LocalDialogButtons), typeof(DialogServiceBehavior), new PropertyMetadata(LocalDialogButtons.OK));


    public ICommand ShowDialogCommand
    {
        get { return (ICommand)GetValue(ShowDialogCommandProperty); }
        set { SetValue(ShowDialogCommandProperty, value); }
    }

    public bool? DialogResult
    {
        get { return (bool?)GetValue(DialogResultProperty); }
        set { SetValue(DialogResultProperty, value); }
    }

    public DataTemplate ViewTemplate
    {
        get { return (DataTemplate)GetValue(ViewTemplateProperty); }
        set { SetValue(ViewTemplateProperty, value); }
    }

    public Style DialogStyle
    {
        get { return (Style)GetValue(DialogStyleProperty); }
        set { SetValue(DialogStyleProperty, value); }
    }
    public string Key
    {
        get { return (string)GetValue(KeyProperty); }
        set { SetValue(KeyProperty, value); }
    }

    public LocalDialogButtons LocalDialogButtons
    {
        get { return (LocalDialogButtons)GetValue(DialogButtonsProperty); }
        set { SetValue(DialogButtonsProperty, value); }
    }
    
    protected override void OnAttached()
    {
        base.OnAttached();
        if (AssociatedObject is FrameworkElement element)
        {
            // Register the service with the DataContext (ViewModel)
            if (element.DataContext is ViewModelBase viewModel)
            {
                viewModel.RegisterService<IDialogService>(Key,this);
            }
        }
    }

    protected override void OnDetaching()
    {
        base.OnDetaching();
        if (ShowDialogCommand != null)
        {
            ShowDialogCommand.CanExecuteChanged -= OnCanExecuteChanged;
        }
    }

    private void OnCanExecuteChanged(object sender, EventArgs e)
    {
        // Handle command's CanExecuteChanged event if needed
    }

    private static void OnCommandChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (e.OldValue is ICommand oldCommand)
        {
            oldCommand.CanExecuteChanged -= ((DialogServiceBehavior)d).OnCanExecuteChanged;
        }

        if (e.NewValue is ICommand newCommand)
        {
            newCommand.CanExecuteChanged += ((DialogServiceBehavior)d).OnCanExecuteChanged;
            ((DialogServiceBehavior)d).AttachCommand(newCommand);
        }
    }

    private void AttachCommand(ICommand command)
    {
       
    }

    private object LoadContent(object viewModel)
    {
        if (ViewTemplate != null)
        {
            var contentPresenter = new ContentPresenter
                {
                    Content = viewModel, // Bind the DataContext here
                    ContentTemplate = ViewTemplate
                };

            return contentPresenter;
            
            // Create a StackPanel to hold the content and the buttons
            //   var stackPanel = new StackPanel
            //       {
            //           HorizontalAlignment = HorizontalAlignment.Center,
            //           VerticalAlignment = VerticalAlignment.Bottom,
            //           Margin = new Thickness(5,5,5,5)
            //       };
            //
            //   // Add the main content to the StackPanel
            //   stackPanel.Children.Add(contentPresenter);
            //
            //   // Add dialog buttons to the StackPanel
            //   var buttonPanel = new StackPanel
            //       {
            //           Orientation = Orientation.Horizontal,
            //           HorizontalAlignment = HorizontalAlignment.Right,
            //           Margin = new Thickness(0, 10, 0, 0)
            //       };
            //
            //   // Add the buttons based on the DialogButtons property
            // // AddDialogButtons(buttonPanel);
            //
            //   // Add the button panel to the main stack panel
            //   stackPanel.Children.Add(buttonPanel);
            //   
            //   return stackPanel;

        }

        return null;
    }

    public bool? ShowDialog(object viewModel)
    {
        EventHandler? closeHandler = null;

        var dialog = new Window
            {
                Title = "Dialog",
                Content = LoadContent(viewModel), // Pass the viewModel to LoadContent
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                Owner = Application.Current.MainWindow,
                DataContext = viewModel // Set the DataContext of the window
            };

        if (DialogStyle != null)
        {
            dialog.Style = DialogStyle;
        }

        closeHandler = (sender, args) =>
            {
                dialog.Closed -= closeHandler;
                if (dialog.DialogResult != null)
                {
                    //callBack?.Invoke(dialog.DialogResult.Value);
                }
            };

        dialog.Closed += closeHandler;
        return dialog.ShowDialog();
        
    }

    private void AddButton(StackPanel panel, string content, bool isDefault, bool isCancel)
    {
        var button = new Button
            {
                Content = content,
                Width = 75,
                Margin = new Thickness(2, 2, 2, 2),
                IsDefault = isDefault,
                IsCancel = isCancel
            };
        
        button.Click += (s, e) =>
            {
                // Find the parent window
                var window = Window.GetWindow(panel);
                if (window != null)
                {
                    // Set the DialogResult based on the button content
                    if (content == "OK" || content == "Yes")
                        window.DialogResult = true;
                    else if (content == "Cancel" || content == "No")
                        window.DialogResult = false;

                    window.Close();
                }
            };

        panel.Children.Add(button);
    }

    private void AddDialogButtons(StackPanel buttonPanel)
    {
        switch (LocalDialogButtons)
        {
            case LocalDialogButtons.OK:
                AddButton(buttonPanel, "OK", true, false);
                break;
            case LocalDialogButtons.OKCancel:
                AddButton(buttonPanel, "OK", true, false);
                AddButton(buttonPanel, "Cancel", false, true);
                break;
            case LocalDialogButtons.YesNo:
                AddButton(buttonPanel, "Yes", true, false);
                AddButton(buttonPanel, "No", false, true);
                break;
        }
    }
}