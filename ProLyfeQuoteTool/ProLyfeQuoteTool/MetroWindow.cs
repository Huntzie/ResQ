using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProLyfeQuoteTool
{
	public class MetroWindow : Window
	{
		public static RoutedCommand DragWindow = new RoutedCommand();
		
		public MetroWindow()
		{
			// Insert code required on object creation below this point.
			CommandBindings.Add(new CommandBinding(SystemCommands.CloseWindowCommand, Close_Executed, Close_CanExecute));
			CommandBindings.Add(new CommandBinding(SystemCommands.MinimizeWindowCommand, Minimise_Executed, Minimise_CanExecute));
			CommandBindings.Add(new CommandBinding(SystemCommands.MaximizeWindowCommand, Maximise_Executed, Maximise_CanExecute));
			CommandBindings.Add(new CommandBinding(DragWindow, Drag_Executed, Drag_CanExecute));
			
			MouseGesture dragMouseGesture = new MouseGesture(MouseAction.LeftClick);
			MouseBinding dragMouseBinding = new MouseBinding(DragWindow, dragMouseGesture);
			
			InputBindings.Add(dragMouseBinding);

            AllowsTransparency = true;
            WindowStyle = WindowStyle.None;
		}
		
		public void Close_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			CloseWindow();	
		}
		
		public void Close_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}
		
		private void CloseWindow()
		{
			this.Close();
		}
		
		public void Minimise_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			Minimise();	
		}
		
		public void Minimise_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}
		
		private void Minimise()
		{
			this.WindowState = System.Windows.WindowState.Minimized;
		}
		
		public void Maximise_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			Maximise();	
		}
		
		public void Maximise_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}
		
		private void Maximise()
		{
			if(this.WindowState == System.Windows.WindowState.Normal)
			{
				this.WindowState = System.Windows.WindowState.Maximized;
			}
			else
			{
				this.WindowState = System.Windows.WindowState.Normal;
			}
		}
		
		public void Drag_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			WindowDrag();
		}
		
		public void Drag_CanExecute(object sender, CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = true;
		}
		
		private void WindowDrag()
		{
			DragMove();
		}
	}
}