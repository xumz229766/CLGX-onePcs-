namespace Common.Applications.Services
{
    /// <summary>
    ///     Responsible for the application lifecycle.
    /// </summary>
    public interface IApplicationController
    {
        /// <summary>
        ///     初始化
        /// </summary>
        void Initialize();

        /// <summary>
        ///     运行
        /// </summary>
        void Run();

        /// <summary>
        ///     关闭
        /// </summary>
        void Shutdown();
    }
}