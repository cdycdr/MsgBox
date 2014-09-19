namespace MsgBox
{
	using System;
	using System.Security;

	/// <summary>
	/// Class implements a message box service based on the <seealso cref="IMessage"/>
	/// interface which can be used to reduce implementation specific dependencies
	/// in complex applications.
	/// </summary>
	public class Message : IMessage
	{
		#region fields
		#endregion fields

		#region constructor
		/// <summary>
		/// Class constructor
		/// </summary>
		public Message()
		{
		}
		#endregion constructor

		#region properties
		/// <summary>
		/// Get/set property to determine whether message box can be styled in WPF or not.
		/// </summary>
		MsgBoxStyle IMessage.Style
		{
			get
			{
				return Msg.Style;
			}
			set
			{
				Msg.Style = value;
			}
		}
		#endregion properties

		#region methods
    #region System.MessageBox replacements    
		/// <summary>
		/// Displays a message box that has a message and that returns a result.
		/// </summary>
		/// <param name="messageBoxText">A System.String that specifies the text to display.</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(string messageBoxText)
		{
			return Msg.Show(messageBoxText);
		}

		MsgBoxResult IMessage.Show(string messageBoxText, string caption)
		{
			return Msg.Show(messageBoxText,caption);
		}

		/// <summary>
		/// Displays a message box that has a message and that returns a result.
		/// </summary>
		/// <param name="messageBoxText">A System.String that specifies the text to display.</param>
		/// <param name="caption">A System.String that specifies the title bar caption to display.</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(System.Windows.Window owner, string messageBoxText)
		{
			return Msg.Show(owner,messageBoxText);
		}

		/// <summary>
		/// Displays a message box that has a message, title bar caption, and button; and that returns a result.
		/// </summary>
		/// <param name="messageBoxText">A System.String that specifies the text to display.</param>
		/// <param name="caption">A System.String that specifies the title bar caption to display.</param>
		/// <param name="button">A Msg.MessageBoxButton value that specifies which button or buttons to display.</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		MsgBoxResult IMessage.Show(string messageBoxText, string caption, MsgBoxButtons button)
		{
			return Msg.Show(messageBoxText, caption, button);
		}

		/// <summary>
		/// Displays a message box in front of the specified window.
		/// The message box displays a message and title bar caption; and it returns a result.
		/// </summary>
		/// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
		/// <param name="messageBoxText">A System.String that specifies the text to display.</param>
		/// <param name="caption">A System.String that specifies the title bar caption to display.</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(System.Windows.Window owner, string messageBoxText, string caption)
		{
			return Msg.Show(owner, messageBoxText, caption);
		}

		/// <summary>
		/// Displays a message box that has a message, title bar caption, button, and icon; and that returns a result.
		/// </summary>
		/// <param name="messageBoxText">A System.String that specifies the text to display.</param>
		/// <param name="caption">A System.String that specifies the title bar caption to display.</param>
		/// <param name="button">A Msg.MessageBoxButton value that specifies which button or buttons to display.</param>
		/// <param name="icon">A Msg.MsgBoxImage value that specifies the icon to display.</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(string messageBoxText, string caption, MsgBoxButtons button, MsgBoxImage icon)
		{
			return Msg.Show(messageBoxText, caption, button, icon);
		}

		/// <summary>
		/// Displays a message box in front of the specified window. The message box displays a message,
		/// title bar caption, and button; and it also returns a result.
		/// </summary>
		/// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
		/// <param name="messageBoxText">A System.String that specifies the text to display.</param>
		/// <param name="caption">A System.String that specifies the title bar caption to display.</param>
		/// <param name="button">A Msg.MsgBoxButtons value that specifies which button or buttons to display.</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(System.Windows.Window owner, string messageBoxText, string caption, MsgBoxButtons button)
		{
			return Msg.Show(owner, messageBoxText, caption, button);
		}

		/// <summary>
		/// Displays a message box that has a message, title bar caption, button, and icon;
		/// and that accepts a default message box result and returns a result.
		/// </summary>
		/// <param name="messageBoxText">A System.String that specifies the text to display.</param>
		/// <param name="caption">A System.String that specifies the title bar caption to display.</param>
		/// <param name="button">A Msg.MessageBoxButton value that specifies which button or buttons to display.</param>
		/// <param name="icon">A Msg.MessageBoxImage value that specifies the icon to display.</param>
		/// <param name="defaultResult">A MsgBox.MsgBoxResult value that specifies the default result of the message box.</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(string messageBoxText, string caption, MsgBoxButtons button, MsgBoxImage icon, MsgBoxResult defaultResult)
		{
			return Msg.Show(messageBoxText, caption, button, icon, defaultResult);
		}

		/// <summary>
		/// Displays a message box in front of the specified window. The message box displays
		/// a message, title bar caption, button, and icon; and it also returns a result.
		/// </summary>
		/// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
		/// <param name="messageBoxText">A System.String that specifies the text to display.</param>
		/// <param name="caption">A System.String that specifies the title bar caption to display.</param>
		/// <param name="button">A Msg.MessageBoxButton value that specifies which button or buttons to display.</param>
		/// <param name="icon">A Msg.MessageBoxImage value that specifies the icon to display.</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(System.Windows.Window owner, string messageBoxText, string caption, MsgBoxButtons button, MsgBoxImage icon)
		{
			return Msg.Show(owner, messageBoxText, caption, button, icon);
		}

		/// <summary>
		/// Displays a message box in front of the specified window. The message box displays a message,
		/// title bar caption, button, and icon; and accepts a default message box result and returns a result.
		/// </summary>
		/// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
		/// <param name="messageBoxText">A System.String that specifies the text to display.</param>
		/// <param name="caption">A System.String that specifies the title bar caption to display.</param>
		/// <param name="button">A Msg.MessageBoxButton value that specifies which button or buttons to display.</param>
		/// <param name="icon">A Msg.MessageBoxImage value that specifies the icon to display.</param>
		/// <param name="defaultResult">A MsgBox.MsgBoxResult value that specifies the default result of the message box.</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(System.Windows.Window owner, string messageBoxText, string caption, MsgBoxButtons button, MsgBoxImage icon, MsgBoxResult defaultResult)
		{
			return Msg.Show(owner, messageBoxText, caption, button, icon, defaultResult);
		}
    #endregion System.MessageBox replacements    

    #region custom messagebox methods
    /// <summary>
    /// Display a message box. The message box displays a message, title bar caption, button, and icon.
    /// Further options, such as, link to background information + naviagtion function, and copy button
    /// can be displayed.
    /// 
    /// The mothod accepts a default message box <seealso cref="MsgBoxResult"/> result and returns a result.
    /// </summary>
    /// <param name="messageBoxText"></param>
    /// <param name="caption"></param>
    /// <param name="buttonOption"></param>
    /// <param name="btnDefault"></param>
    /// <param name="helpLink"></param>
    /// <param name="helpLinkTitle"></param>
    /// <param name="helpLabel"></param>
    /// <param name="navigateHelplinkMethod"></param>
    /// <param name="showCopyMessage"></param>
    /// <returns></returns>
    [SecurityCritical]
		MsgBoxResult IMessage.Show(string messageBoxText, string caption, MsgBoxButtons buttonOption, MsgBoxResult btnDefault, object helpLink, string helpLinkTitle, string helpLabel, Func<object, bool> navigateHelplinkMethod, bool showCopyMessage)
		{
			return Msg.Show(messageBoxText, caption, buttonOption, btnDefault, helpLink, helpLinkTitle, helpLabel, navigateHelplinkMethod, showCopyMessage);
		}

		/// <summary>
		/// Displays a message box that has a message, title bar caption, button, and icon;
		/// and that accepts a default message box result and returns a result.
		/// </summary>
		/// <param name="messageBoxText">A System.String that specifies the text to display.</param>
		/// <param name="caption">A System.String that specifies the title bar caption to display.</param>
		/// <param name="button">A Msg.MessageBoxButton value that specifies which button or buttons to display.</param>
		/// <param name="icon">A Msg.MessageBoxImage value that specifies the icon to display.</param>
		/// <param name="defaultResult">A MsgBox.MsgBoxResult value that specifies the default result of the message box.</param>
		/// <param name="helpLink">Determines the address to browsed to when displaying a help link. This parameter can be a URI or string object.</param>
		/// <param name="helpLinkTitle">Determines the text for displaying a help link.
		/// By default the text is the toString() content of the <paramref name="helpLink"/>
		/// but it can also be a different text set here.</param>
		/// <param name="helpLinkLabel">Text label of the displayed hyperlink (if any)</param>
		/// <param name="navigateHelplinkMethod">Method to execute when the user clicked the hyperlink</param>
		/// <param name="showCopyMessage">Show a UI element (e.g. button) that lets the user copy the displayed message into the Windows clipboard</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(string messageBoxText, string caption, MsgBoxButtons button, MsgBoxImage icon, MsgBoxResult defaultResult, object helpLink, string helpLinkTitle, string helpLinkLabel, Func<object, bool> navigateHelplinkMethod, bool showCopyMessage)
		{
			return Msg.Show(messageBoxText, caption, button, icon, defaultResult, helpLink, helpLinkTitle, helpLinkLabel, navigateHelplinkMethod, showCopyMessage);
		}

		/// <summary>
		/// Displays a message box that has a message, title bar caption, button, and icon;
		/// and that accepts a default message box result and returns a result.
		/// </summary>
		/// <param name="messageBoxText">A System.String that specifies the text to display.</param>
		/// <param name="caption">A System.String that specifies the title bar caption to display.</param>
		/// <param name="details">Displays a details section (e.g. expander) where a long message, such as, a stacktrace can be displayed within a scrollviewer.</param>
		/// <param name="button">A Msg.MessageBoxButton value that specifies which button or buttons to display.</param>
		/// <param name="icon">A Msg.MessageBoxImage value that specifies the icon to display.</param>
		/// <param name="defaultResult">A MsgBox.MsgBoxResult value that specifies the default result of the message box.</param>
		/// <param name="helpLink">Determines the address to browsed to when displaying a help link. This parameter can be a URI or string object.</param>
		/// <param name="helpLinkTitle">Determines the text for displaying a help link.
		/// By default the text is the toString() content of the <paramref name="helpLink"/>
		/// but it can also be a different text set here.</param>
		/// <param name="helpLinkLabel">Text label of the displayed hyperlink (if any)</param>
		/// <param name="navigateHelplinkMethod">Method to execute when the user clicked the hyperlink</param>
		/// <param name="showCopyMessage">Show a UI element (e.g. button) that lets the user copy the displayed message into the Windows clipboard</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(string messageBoxText, string caption, string details, MsgBoxButtons button, MsgBoxImage icon, MsgBoxResult defaultResult, object helpLink, string helpLinkTitle, string helpLinkLabel, Func<object, bool> navigateHelplinkMethod, bool showCopyMessage)
		{
			return Msg.Show(messageBoxText, caption, details, button, icon, defaultResult, helpLink, helpLinkTitle, helpLinkLabel, navigateHelplinkMethod, showCopyMessage);
		}

		/// <summary>
		/// Displays a message box that has a message, title bar caption, button, and icon;
		/// and that accepts a default message box result and returns a result.
		/// </summary>
		/// <param name="ex">Exception object (details: stacktrace and messages are displayed in details section)</param>
		/// <param name="caption">A System.String that specifies the title bar caption to display.</param>
		/// <param name="button">A Msg.MessageBoxButton value that specifies which button or buttons to display.</param>
		/// <param name="icon">A Msg.MessageBoxImage value that specifies the icon to display.</param>
		/// <param name="defaultResult">A MsgBox.MsgBoxResult value that specifies the default result of the message box.</param>
		/// <param name="helpLink">Determines the address to browsed to when displaying a help link. This parameter can be a URI or string object.</param>
		/// <param name="helpLinkTitle">Determines the text for displaying a help link.
		/// By default the text is the toString() content of the <paramref name="helpLink"/>
		/// but it can also be a different text set here.</param>
		/// <param name="helpLinkLabel">Text label of the displayed hyperlink (if any)</param>
		/// <param name="navigateHelplinkMethod">Method to execute when the user clicked the hyperlink</param>
		/// <param name="showCopyMessage">Show a UI element (e.g. button) that lets the user copy the displayed message into the Windows clipboard</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(Exception ex, string caption, MsgBoxButtons button, MsgBoxImage icon, MsgBoxResult defaultResult, object helpLink, string helpLinkTitle, string helpLinkLabel, Func<object, bool> navigateHelplinkMethod, bool showCopyMessage)
		{
			return Msg.Show(ex, caption, button, icon, defaultResult, helpLink, helpLinkTitle, helpLinkLabel, navigateHelplinkMethod, showCopyMessage);
		}

		/// <summary>
		/// Displays a message box that has a message, title bar caption, button, and icon;
		/// and that accepts a default message box result and returns a result.
		/// </summary>
		/// <param name="messageBoxText">A System.String that specifies the text to display.</param>
		/// <param name="btnDefault">A MsgBox.MsgBoxResult value that specifies the default result of the message box.</param>
		/// <param name="helpLink">Determines the address to browsed to when displaying a help link. This parameter can be a URI or string object.</param>
		/// <param name="helpLinkTitle">Determines the text for displaying a help link.
		/// By default the text is the toString() content of the <paramref name="helpLink"/>
		/// but it can also be a different text set here.</param>
		/// <param name="helpLinkLabel">Text label of the displayed hyperlink (if any)</param>
		/// <param name="navigateHelplinkMethod">Method to execute when the user clicked the hyperlink</param>
		/// <param name="showCopyMessage">Show a UI element (e.g. button) that lets the user copy the displayed message into the Windows clipboard</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(string messageBoxText, MsgBoxResult btnDefault, object helpLink, string helpLinkTitle, string helpLinkLabel, Func<object, bool> navigateHelplinkMethod, bool showCopyMessage)
		{
			return Msg.Show(messageBoxText, btnDefault, helpLink, helpLinkTitle, helpLinkLabel, navigateHelplinkMethod, showCopyMessage);
		}

		/// <summary>
		/// Displays a message box that has a message, title bar caption, button, and icon;
		/// and that accepts a default message box result and returns a result.
		/// </summary>
		/// <param name="ex">Exception object (details: stacktrace and messages are displayed in details section)</param>
		/// <param name="messageBoxText">A System.String that specifies the details to display.</param>
		/// <param name="caption">A System.String that specifies the title bar caption to display.</param>
		/// <param name="button">A Msg.MessageBoxButton value that specifies which button or buttons to display.</param>
		/// <param name="icon">A Msg.MessageBoxImage value that specifies the icon to display.</param>
		/// <param name="defaultResult">A MsgBox.MsgBoxResult value that specifies the default result of the message box.</param>
		/// <param name="helpLink">Determines the address to browsed to when displaying a help link. This parameter can be a URI or string object.</param>
		/// <param name="helpLinkTitle">Determines the text for displaying a help link.
		/// By default the text is the toString() content of the <paramref name="helpLink"/>
		/// but it can also be a different text set here.</param>
		/// <param name="helpLinkLabel">Text label of the displayed hyperlink (if any)</param>
		/// <param name="navigateHelplinkMethod">Method to execute when the user clicked the hyperlink</param>
		/// <param name="showCopyMessage">Show a UI element (e.g. button) that lets the user copy the displayed message into the Windows clipboard</param>
		/// <returns>A MsgBox.MsgBoxResult value that specifies which message box button is clicked by the user.</returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(Exception ex, string messageBoxText, string caption, MsgBoxButtons button, MsgBoxImage icon, MsgBoxResult defaultResult, object helpLink, string helpLinkTitle, string helpLinkLabel, Func<object, bool> navigateHelplinkMethod, bool showCopyMessage)
		{
			return Msg.Show(ex, messageBoxText, caption, button, icon, defaultResult, helpLink, helpLinkTitle, helpLinkLabel, navigateHelplinkMethod, showCopyMessage);
		}

		/// <summary>
		/// Displays a message box in front of the specified window.
		/// 
		/// The caller can specify with <paramref name="dialogCanCloseViaChrome"/> whether users can close the
		/// message box dialog view via F4 key, esc key or window close (x) button. Use the <paramref name="defaultCloseResult"/>
		/// parameter to define the results being returned if the user is allowed to close the message box via
		/// F4 key, esc key or window close (x) [Window chrome accessibility].
		/// 
		/// The message box displays a message,
		/// title bar caption, button, and icon; and accepts a default message box result and returns a result.
		/// </summary>
		/// <param name="owner"></param>
		/// <param name="messageBoxText"></param>
		/// <param name="caption"></param>
		/// <param name="defaultCloseResult"></param>
		/// <param name="dialogCanCloseViaChrome"></param>
		/// <param name="buttonOption"></param>
		/// <param name="image"></param>
		/// <param name="btnDefault"></param>
		/// <param name="helpLink"></param>
		/// <param name="helpLinkTitle"></param>
		/// <param name="helpLinkLabel"></param>
		/// <param name="navigateHelplinkMethod"></param>
		/// <param name="showCopyMessage"></param>
		/// <returns></returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(System.Windows.Window owner, string messageBoxText, string caption, MsgBoxResult defaultCloseResult, bool dialogCanCloseViaChrome, MsgBoxButtons buttonOption, MsgBoxImage image, MsgBoxResult btnDefault, object helpLink, string helpLinkTitle, string helpLinkLabel, Func<object, bool> navigateHelplinkMethod, bool showCopyMessage)
		{
			return Msg.Show(owner, messageBoxText, caption, defaultCloseResult, dialogCanCloseViaChrome, buttonOption, image, btnDefault, helpLink, helpLinkTitle, helpLinkLabel, navigateHelplinkMethod, showCopyMessage);
		}

		/// <summary>
		/// Displays a message box in front of the current window being shown.
		/// 
		/// The caller can specify with <paramref name="dialogCanCloseViaChrome"/> whether users can close the
		/// message box dialog view via F4 key, esc key or window close (x) button. Use the <paramref name="defaultCloseResult"/>
		/// parameter to define the results being returned if the user is allowed to close the message box via
		/// F4 key, esc key or window close (x) [Window chrome accessibility].
		/// 
		/// The message box can display a message,
		/// a hyperlink, and copy bitton; and accepts a default message box botton and returns a result.
		/// </summary>
		/// <param name="messageBoxText"></param>
		/// <param name="defaultCloseResult"></param>
		/// <param name="dialogCanCloseViaChrome"></param>
		/// <param name="btnDefault"></param>
		/// <param name="helpLink"></param>
		/// <param name="helpLinkTitle"></param>
		/// <param name="helpLabel"></param>
		/// <param name="navigateHelplinkMethod"></param>
		/// <param name="showCopyMessage"></param>
		/// <returns></returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(string messageBoxText, MsgBoxResult defaultCloseResult, bool dialogCanCloseViaChrome, MsgBoxResult btnDefault, object helpLink, string helpLinkTitle, string helpLabel, Func<object, bool> navigateHelplinkMethod, bool showCopyMessage)
		{
			return Msg.Show(messageBoxText, defaultCloseResult, dialogCanCloseViaChrome, btnDefault, helpLink, helpLinkTitle, helpLabel, navigateHelplinkMethod, showCopyMessage);
		}

		/// <summary>
		/// Displays a message box in front of the current window being shown.
		/// 
		/// The caller can specify with <paramref name="dialogCanCloseViaChrome"/> whether users can close the
		/// message box dialog view via F4 key, esc key or window close (x) button. Use the <paramref name="defaultCloseResult"/>
		/// parameter to define the results being returned if the user is allowed to close the message box via
		/// F4 key, esc key or window close (x) [Window chrome accessibility].
		/// 
		/// The message box can display a message, caption,
		/// a hyperlink, and copy bitton; and accepts a default message box botton and returns a result.
		/// </summary>
		/// <param name="messageBoxText"></param>
		/// <param name="caption"></param>
		/// <param name="defaultCloseResult"></param>
		/// <param name="dialogCanCloseViaChrome"></param>
		/// <param name="btnDefault"></param>
		/// <param name="helpLink"></param>
		/// <param name="helpLinkTitle"></param>
		/// <param name="helpLabel"></param>
		/// <param name="navigateHelplinkMethod"></param>
		/// <param name="showCopyMessage"></param>
		/// <returns></returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(string messageBoxText, string caption, MsgBoxResult defaultCloseResult, bool dialogCanCloseViaChrome, MsgBoxResult btnDefault, object helpLink, string helpLinkTitle, string helpLabel, Func<object, bool> navigateHelplinkMethod, bool showCopyMessage)
		{
			return Msg.Show(messageBoxText, caption, defaultCloseResult, dialogCanCloseViaChrome, btnDefault, helpLink, helpLinkTitle, helpLabel, navigateHelplinkMethod, showCopyMessage);
		}

		/// <summary>
		/// Displays a message box in front of the current window being shown.
		/// 
		/// The caller can specify with <paramref name="dialogCanCloseViaChrome"/> whether users can close the
		/// message box dialog view via F4 key, esc key or window close (x) button. Use the <paramref name="defaultCloseResult"/>
		/// parameter to define the results being returned if the user is allowed to close the message box via
		/// F4 key, esc key or window close (x) [Window chrome accessibility].
		/// 
		/// The message box can display a message, caption, custom buttons (yes, no etc...),
		/// a hyperlink, and copy bitton; and accepts a default message box botton and returns a result.
		/// </summary>
		/// <param name="messageBoxText"></param>
		/// <param name="caption"></param>
		/// <param name="buttonOption"></param>
		/// <param name="defaultCloseResult"></param>
		/// <param name="dialogCanCloseViaChrome"></param>
		/// <param name="btnDefault"></param>
		/// <param name="helpLink"></param>
		/// <param name="helpLinkTitle"></param>
		/// <param name="helpLabel"></param>
		/// <param name="navigateHelplinkMethod"></param>
		/// <param name="showCopyMessage"></param>
		/// <returns></returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(string messageBoxText, string caption, MsgBoxButtons buttonOption, MsgBoxResult defaultCloseResult, bool dialogCanCloseViaChrome, MsgBoxResult btnDefault, object helpLink, string helpLinkTitle, string helpLabel, Func<object, bool> navigateHelplinkMethod, bool showCopyMessage)
		{
			return Msg.Show(messageBoxText, caption, buttonOption, defaultCloseResult, dialogCanCloseViaChrome, btnDefault, helpLink, helpLinkTitle, helpLabel, navigateHelplinkMethod, showCopyMessage);
		}

		/// <summary>
		/// Displays a message box in front of the current window being shown.
		/// 
		/// The caller can specify with <paramref name="dialogCanCloseViaChrome"/> whether users can close the
		/// message box dialog view via F4 key, esc key or window close (x) button. Use the <paramref name="defaultCloseResult"/>
		/// parameter to define the results being returned if the user is allowed to close the message box via
		/// F4 key, esc key or window close (x) [Window chrome accessibility].
		/// 
		/// The message box can display a message, caption, custom buttons (yes, no etc...), an image,
		/// a hyperlink, and copy bitton; and accepts a default message box botton and returns a result.
		/// </summary>
		/// <param name="messageBoxText"></param>
		/// <param name="caption"></param>
		/// <param name="buttonOption"></param>
		/// <param name="image"></param>
		/// <param name="defaultCloseResult"></param>
		/// <param name="dialogCanCloseViaChrome"></param>
		/// <param name="btnDefault"></param>
		/// <param name="helpLink"></param>
		/// <param name="helpLinkTitle"></param>
		/// <param name="helpLabel"></param>
		/// <param name="navigateHelplinkMethod"></param>
		/// <param name="showCopyMessage"></param>
		/// <returns></returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(string messageBoxText, string caption, MsgBoxButtons buttonOption, MsgBoxImage image, MsgBoxResult defaultCloseResult, bool dialogCanCloseViaChrome, MsgBoxResult btnDefault, object helpLink, string helpLinkTitle, string helpLabel, Func<object, bool> navigateHelplinkMethod, bool showCopyMessage)
		{
			return Msg.Show(messageBoxText, caption, buttonOption, image, defaultCloseResult, dialogCanCloseViaChrome, btnDefault, helpLink, helpLinkTitle, helpLabel, navigateHelplinkMethod, showCopyMessage);
		}

		/// <summary>
		/// Displays a message box in front of the current window being shown.
		/// 
		/// The caller can specify with <paramref name="dialogCanCloseViaChrome"/> whether users can close the
		/// message box dialog view via F4 key, esc key or window close (x) button. Use the <paramref name="defaultCloseResult"/>
		/// parameter to define the results being returned if the user is allowed to close the message box via
		/// F4 key, esc key or window close (x) [Window chrome accessibility].
		/// 
		/// The message box can display a message, caption, additional details, custom buttons (yes, no etc...), an image,
		/// a hyperlink, and copy bitton; and accepts a default message box botton and returns a result.
		/// </summary>
		/// <param name="messageBoxText"></param>
		/// <param name="caption"></param>
		/// <param name="details"></param>
		/// <param name="buttonOption"></param>
		/// <param name="image"></param>
		/// <param name="defaultCloseResult"></param>
		/// <param name="dialogCanCloseViaChrome"></param>
		/// <param name="btnDefault"></param>
		/// <param name="helpLink"></param>
		/// <param name="helpLinkTitle"></param>
		/// <param name="helpLabel"></param>
		/// <param name="navigateHelplinkMethod"></param>
		/// <param name="showCopyMessage"></param>
		/// <returns></returns>
		[SecurityCritical]
		MsgBoxResult IMessage.Show(string messageBoxText, string caption, string details, MsgBoxButtons buttonOption, MsgBoxImage image, MsgBoxResult defaultCloseResult, bool dialogCanCloseViaChrome, MsgBoxResult btnDefault, object helpLink, string helpLinkTitle, string helpLabel, Func<object, bool> navigateHelplinkMethod, bool showCopyMessage)
		{
			return Msg.Show(messageBoxText, caption, details, buttonOption, image, defaultCloseResult, dialogCanCloseViaChrome, btnDefault, helpLink, helpLinkTitle, helpLabel, navigateHelplinkMethod, showCopyMessage);
		}
		#endregion custom messagebox methods
		#endregion methods
	}
}
