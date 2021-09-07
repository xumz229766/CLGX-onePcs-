using System.ComponentModel;
using System.Platform.Applications;

namespace desay.Services
{
    /// <summary>
    ///     Exposes the functionality of the shell.
    /// </summary>
    public interface IShellService : INotifyPropertyChanged
    {
        /// <summary>
        ///     Gets the shell view. Use this object as owner when you need to show a modal dialog.
        /// </summary>
        IView ShellView { get; }

        /// <summary>
        ///     Gets or sets the content view which is shown by the shell.
        /// </summary>
        IView ContentView { get; set; }
    }
}