namespace MsgBox
{
  /// <summary>
  /// This enumeration describes the possible GUI elements (OK, Cancel, Yes, No button)
  /// that are displayed with the message. Displaying these GUI elements gives the user
  /// a chance to review a message and interact with the system based on the displayed content.
  /// </summary>
  public enum MsgBoxButtons
  {
    /// <summary>
    /// Display Yes and No GUI elements
    /// </summary>
    YesNo,

    /// <summary>
    /// Display Yes, No, and No GUI elements
    /// </summary>
    YesNoCancel,

    /// <summary>
    /// Display OK and Cancel GUI elements
    /// </summary>
    OKCancel,

    /// <summary>
    /// Display OK and Close GUI elements
    /// </summary>
    OKClose,

    /// <summary>
    /// Display OK GUI element
    /// </summary>
    OK,

    /// <summary>
    /// Display Close GUI element
    /// </summary>
    Close
  }
}
