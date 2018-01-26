Helper library for managing WPF applications and windows.

### Description

- Save and restore window size, position and state on application exit and start.
- Adds event "Resized". Tiggers once when a window has been resized.
- Adds event "Moved". Triggers once when a window has been moved.


### Instructions
- Add a reference to 'WpfLib.dll'
- Add **xmlns:wpflib="clr-namespace:WpfLib.Windows;assembly=WpfLib"** as a new namespace in your XAML
- Change your Window class to derive from **<wpflib:WindowBase>**


### MainWindow.xaml

```
<wpflib:WindowBase

    x:Class="MyApp.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:local="clr-namespace:SkinEditorWPF"
    xmlns:wpflib="clr-namespace:WpfLib.Windows;assembly=WpfLib"
    mc:Ignorable="d"
    Title="MainWindow" Height="350" Width="525">

</wpflib:WindowBase>
```

### MainWindow.cs
```
namespace MyApp
{
    public partial class MainWindow : WpfLib.Windows.WindowBase
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
```