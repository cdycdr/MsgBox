namespace MsgBox.View
{
  using System;
  using System.Windows;
  using System.Windows.Input;
  using MsgBox.Internal.ViewModel;
  using UserNotification.View;

  /// <summary>
  /// Interaction logic for MsgBoxDialog.xaml
  /// 
  /// Source: http://www.codeproject.com/Articles/70223/Using-a-Service-Locator-to-Work-with-MessageBoxes
  /// </summary>
  public partial class MsgBoxDialog : NotifyableWindow
  {
    #region fields
    [ThreadStatic]
    private static MsgBoxDialog mMessageBox;
    #endregion fields

    #region constructors
    /// <summary>
    /// Class Constructor
    /// </summary>
    public MsgBoxDialog() : base()
    {
      this.InitializeComponent();

      Window w = MsgBoxDialog.GetOwnerWindow();

      if (w != null)
        this.Owner = w;
    }
    #endregion constructors

    #region methods
    /// <summary>
    /// Display a message box based on a given view model.
    /// </summary>
    /// <param name="viewModel">The viewmodel contains additional
    /// parameters for the message view.</param>
    /// <param name="owner">The message view will be attached to this owning window
    /// of this parameter is non-null, otherwise Application.Current.MainWindow
    /// is being used.</param>
    /// <returns></returns>
    internal static MsgBoxResult Show(MsgBoxViewModel viewModel,
                                      Window owner = null)
    {
      // Construct the message box view and add the viewmodel to it
      MsgBoxDialog.mMessageBox = new MsgBoxDialog() { DataContext = viewModel };

      if (owner == null)
      {
        if (Application.Current != null)
          MsgBoxDialog.mMessageBox.Owner = Application.Current.MainWindow;
      }

      //MsgBoxDialog.mMessageBox.Content = new MsgBoxView() { DataContext = viewModel };
      MsgBoxDialog.mMessageBox.DataContext = viewModel;

      InputGesture g = new KeyGesture(Key.Escape, ModifierKeys.None);
      InputBinding input = new InputBinding(viewModel.CloseCommand, g) { CommandParameter = viewModel.DefaultCloseResult };
      MsgBoxDialog.mMessageBox.InputBindings.Add(input);

      // Add key binding to copy message text via CONTROL-C key gesture
      g = new KeyGesture(Key.C, ModifierKeys.Control);
      input = new InputBinding(viewModel.CopyText, g) { CommandParameter = viewModel.AllToString };
      MsgBoxDialog.mMessageBox.InputBindings.Add(input);

      MsgBoxDialog.mMessageBox.Closing += viewModel.MessageBox_Closing;

      MsgBoxDialog.mMessageBox.ShowDialog();

      return viewModel.Result;
    }

    /// <summary>
    /// Remove the icon from the window chrome to give this window a message box like appearrance.
    /// </summary>
    /// <param name="e"></param>
    protected override void OnSourceInitialized(EventArgs e)
    {
      IconHelper.RemoveIcon(this);
    }

    /// <summary>
    /// Attempt to find the owner window for a message box
    /// </summary>
    /// <returns>Owner Window</returns>
    private static Window GetOwnerWindow()
    {
      Window owner = null;

      if (Application.Current != null)
      {
        foreach (Window w in Application.Current.Windows)
        {
          if (w != null)
          {
            if (w.IsActive)
            {
              owner = w;
              break;
            }
          }
        }
      }

      return owner;
    }
    #endregion methods
  }
}
