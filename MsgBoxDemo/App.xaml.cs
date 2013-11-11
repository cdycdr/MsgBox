namespace MsgBoxSamples
{
  using MsgBox;
  using System.Globalization;
  using System.Threading;
  using System.Windows;
  using System.Windows.Threading;

  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    public App()
    {
      ////Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
      ////Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

      ////Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
      ////Thread.CurrentThread.CurrentUICulture = new CultureInfo("de-DE");
    }

    private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
      string message = string.Empty;

      try
      {
        Msg.Show(
            e.Exception, "An unexpected Error occured",
            MsgBoxButtons.OK, MsgBoxImage.Error, MsgBoxResult.NoDefaultButton,
            "http://www.codeproject.com/script/Articles/MemberArticles.aspx?amid=7799028",
            "http://www.codeproject.com/script/Articles/MemberArticles.aspx?amid=7799028",
            "Please click on the link to check if this is a known problem (and report it if not):");
      }
      catch
      {
        MessageBox.Show(message, "Error Report", MessageBoxButton.OK, MessageBoxImage.Error);
      }

      e.Handled = true;
    }

  }
}
