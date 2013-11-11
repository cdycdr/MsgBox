namespace MsgBox
{
  using System;
  using System.Windows;

  internal interface IMsgBoxService
  {
    #region properties
    /// <summary>
    /// Get/set property to determine whether message box can be styled in WPF or not.
    /// </summary>
    MsgBoxStyle Style
    {
      get; set;
    }
    #endregion properties

    #region methods
    MsgBoxResult Show(string messageBoxText,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool showCopyMessage = false);

    MsgBoxResult Show(string messageBoxText, string caption,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool showCopyMessage = false);

    MsgBoxResult Show(string messageBoxText, string caption,
                      MsgBoxButtons buttonOption,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool showCopyMessage = false);

    MsgBoxResult Show(string messageBoxText, string caption,
                      MsgBoxButtons buttonOption, MsgBoxImage image,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool showCopyMessage = false);

    MsgBoxResult Show(string messageBoxText, string caption,
                      string details,
                      MsgBoxButtons buttonOption, MsgBoxImage image,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool showCopyMessage = false);

    MsgBoxResult Show(Exception exp, string caption,
                      MsgBoxButtons buttonOption, MsgBoxImage image,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool showCopyMessage = false);

    MsgBoxResult Show(Exception exp,
                      string textMessage = "", string caption = "",
                      MsgBoxButtons buttonOption = MsgBoxButtons.OK,
                      MsgBoxImage image = MsgBoxImage.Error,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool enableCopyFunction = false);

    MsgBoxResult Show(Window owner,
                      string messageBoxText, string caption = "", 
                      MsgBoxButtons buttonOption = MsgBoxButtons.OK,
                      MsgBoxImage image = MsgBoxImage.Error,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLinkLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool showCopyMessage = false);

    MsgBoxResult Show(Window owner,
                      string messageBoxText, string caption,
                      MsgBoxResult defaultCloseResult,
                      bool dialogCanCloseViaChrome,
                      MsgBoxButtons buttonOption = MsgBoxButtons.OK,
                      MsgBoxImage image = MsgBoxImage.Error,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLinkLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool showCopyMessage = false);

    MsgBoxResult Show(string messageBoxText,
                      MsgBoxResult defaultCloseResult,
                      bool dialogCanCloseViaChrome,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool showCopyMessage = false);

    MsgBoxResult Show(string messageBoxText, string caption,
                      MsgBoxResult defaultCloseResult,
                      bool dialogCanCloseViaChrome,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool showCopyMessage = false);

    MsgBoxResult Show(string messageBoxText, string caption,
                      MsgBoxButtons buttonOption,
                      MsgBoxResult defaultCloseResult,
                      bool dialogCanCloseViaChrome,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool showCopyMessage = false);

    MsgBoxResult Show(string messageBoxText, string caption,
                      MsgBoxButtons buttonOption, MsgBoxImage image,
                      MsgBoxResult defaultCloseResult,
                      bool dialogCanCloseViaChrome,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool showCopyMessage = false);

    MsgBoxResult Show(string messageBoxText, string caption,
                      string details,
                      MsgBoxButtons buttonOption, MsgBoxImage image,
                      MsgBoxResult defaultCloseResult,
                      bool dialogCanCloseViaChrome,
                      MsgBoxResult btnDefault = MsgBoxResult.None,
                      object helpLink = null,
                      string helpLinkTitle = "",
                      string helpLabel = "",
                      Func<object, bool> navigateHelplinkMethod = null,
                      bool showCopyMessage = false);
    #endregion methods
  }
}
