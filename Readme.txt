This project shows the implementation of a custom message box service that is driven by a
service locator interface.

Source:
http://blogsprajeesh.blogspot.de/2009/12/wpf-messagebox-custom-control.html

Service Locator:
http://www.codeproject.com/Articles/70223/Using-a-Service-Locator-to-Work-with-MessageBoxes

The project contains also a user notification component that pops-up user messages similar to extended tool-tips.
This component is based on a Growl Notifications project at Code Project:

http://www.codeproject.com/Articles/499241/Growl-Alike-WPF-Notifications

See http://www.msgbox.codeplex.com for more details.

Change History:

Fixed Issues:

- MsgBoxDemo Project
  Copy statement does not always work if quotes around path are missing

- MsgBox
  Cannot set Owner property to itself
  Added code to ensure that owner of MsgBox dialog can never be the window itself
  (which causes an exception to be thrown and the message box not to be displayed)
