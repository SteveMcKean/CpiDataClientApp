using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

namespace CpiDataClient.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32.dll")]
        private static extern bool InsertMenu(IntPtr hMenu, int wPosition, uint uFlags, uint uIDNewItem, string lpNewItem);

        public const int MF_BYPOSITION = 0x400;
        public const int MF_SEPARATOR = 0x800;
        public const int ITEMONEID = 1000;
        public const int ITEMTWOID = 1001;

        public const int WM_SYSCOMMAND = 0x112;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var windowHandle = new WindowInteropHelper(this).Handle;
            var source = HwndSource.FromHwnd(windowHandle);

            var systemMenuHandle = GetSystemMenu(windowHandle, false);

            InsertMenu(systemMenuHandle, 5, MF_BYPOSITION | MF_SEPARATOR, 0, string.Empty);
            InsertMenu(systemMenuHandle, 6, MF_BYPOSITION , ITEMONEID, "Item 1");
            InsertMenu(systemMenuHandle, 7, MF_BYPOSITION, ITEMTWOID, "Item 2");
            
            source.AddHook(WindProcess);
        }

        private IntPtr WindProcess(IntPtr hwnd, int msg, IntPtr wparam, IntPtr lparam, ref bool handled)
        {
            
            if(msg == WM_SYSCOMMAND)
            {
                switch (wparam.ToInt32())
                {
                    case ITEMONEID:
                        MessageBox.Show("Item 1 clicked");
                        handled = true;
                        break;
                    
                    case ITEMTWOID:
                        MessageBox.Show("Item 2 clicked");
                        handled = true;

                        break;
                }
            }
            
            return IntPtr.Zero;
            
        }
        
    }
}
