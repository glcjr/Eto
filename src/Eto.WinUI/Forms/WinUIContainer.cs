using Eto.Drawing;
using Eto.Forms;

namespace Eto.WinUI.Forms
{
	public abstract class WinUIContainer<TControl, TWidget, TCallback> : WinUIFrameworkElement<TControl, TWidget, TCallback>, Container.IHandler
		where TControl : class
		where TWidget : Container
		where TCallback : Container.ICallback
	{
		public Size ClientSize { get; set; }
		public bool RecurseToChildren { get; }
	}
}
