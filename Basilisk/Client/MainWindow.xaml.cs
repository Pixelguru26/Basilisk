using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Basilisk;

namespace Client
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		bool ChannelsOpen = false;
		bool MembersOpen = false;
		List<Message> Messages;

		public Theme Theme;

		public MainWindow()
		{
			InitializeComponent();
			Channels.Width = new GridLength(0);
			Members.Width = new GridLength(0);
			Messages = new List<Message>();
			Messages.Add(new Message { Name = "Not NuLL", Text = "Test" });
			ChatHistoryBox.ItemsSource = Messages;
		}

		private void ToggleChannels_Click(object sender, RoutedEventArgs e)
		{
			ChannelsOpen = !ChannelsOpen;
			if (ChannelsOpen)
			{
				Channels.Width = new GridLength(1, GridUnitType.Star);
			} else
			{
				Channels.Width = new GridLength(0);
			}
		}

		private void ToggleMembers_Click(object sender, RoutedEventArgs e)
		{
			MembersOpen = !MembersOpen;
			if (MembersOpen)
			{
				Members.Width = new GridLength(3, GridUnitType.Star);
			}
			else
			{
				Members.Width = new GridLength(0);
			}
		}

		private void TextInputBox_PreviewKeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter && !e.KeyboardDevice.IsKeyDown(Key.LeftShift) && !e.KeyboardDevice.IsKeyDown(Key.RightShift))
			{
				SendMessage();
				e.Handled = true;
			}
		}

		private void TextInputBox_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void TextInputBox_PreviewKeyUp(object sender, KeyEventArgs e)
		{
		}

		private ScrollViewer GetScrollViewer(ListBox src)
		{
			// Get the border of the listview (first child of a listview)
			Decorator border = VisualTreeHelper.GetChild(src, 0) as Decorator;
			// Get scrollviewer
			return border.Child as ScrollViewer;
		}
		private void SendMessage(string text = null)
		{
			if (text==null)
			{
				text = TextInputBox.Text;
				TextInputBox.Clear();
			}
			Messages.Add(new Message { Name = "NuLL", Text = text });
			ChatHistoryBox.Items.Refresh();
			GetScrollViewer(ChatHistoryBox).ScrollToEnd();
		}

		private void Window_GotFocus(object sender, RoutedEventArgs e)
		{
			TextInputBox.Focus();
		}

		private void Window_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
		{
			TextInputBox.Focus();
		}

		private void ButtonSendMessage_Click(object sender, RoutedEventArgs e)
		{
			SendMessage();
		}
	}
}
