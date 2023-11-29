using System.Windows;

namespace MVP.Sample.WPF.Presenters
{
    /// <summary>
    /// 主持人基类
    /// </summary>
    /// <typeparam name="T">视图类型</typeparam>
    public abstract class BasePresenter<T> where T : Window
    {
        /// <summary>
        /// 视图
        /// </summary>
        public T View { get; set; }
        protected BasePresenter(T view)
        {
            this.View = view;
            Initialize(view);
        }
        /// <summary>
        /// 初始化器
        /// </summary>
        /// <param name="view">视图</param>
        public abstract void Initialize(T view);
    }
}