using System;
using System.Windows;
using MVP.Sample.WPF.Presenters;
using MVP.Sample.WPF.Views.Person;
using System.Windows.Threading;

namespace MVP.Sample.WPF
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Current.DispatcherUnhandledException += App_OnDispatcherUnhandledException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;


        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            PersonPresenter presenter = new PersonPresenter(new Window1());
            presenter.View.Show();
        }

        /// <summary>
        /// UI线程抛出全局异常事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void App_OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            //LogHelper.WriteError(e.Exception, "UI线程全局异常");
            e.Handled = true;
            //throw e.Exception;
        }
        /// <summary>
        /// 非UI线程抛出全局异常事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = e.ExceptionObject as Exception;
            if (exception != null)
            {
                //LogHelper.WriteError(exception, "非UI线程全局异常");
                //throw exception;
            }
        }
    }
}
