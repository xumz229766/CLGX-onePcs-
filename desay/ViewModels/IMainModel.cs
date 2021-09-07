using System.Platform.Applications;

namespace desay.ViewModels
{
    interface IMainModel
    {
        /// <summary>
        ///     交互界面
        /// </summary>
        IView View { get; }

        /// <summary>
        ///     关闭应用界面
        /// </summary>
        void OnClose();

        /// <summary>
        ///     显示应用界面
        /// </summary>
        void Show();
    }
}
