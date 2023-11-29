using System;
using System.Windows.Forms;
using MVP.Sample.Winform.Presenters;
using MVP.Sample.Winform.Views.Person;

namespace MVP.Sample.Winform
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //全局异常捕捉
            //设置应用程序处理异常方式：ThreadException处理
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.Automatic);
            Application.ThreadException += Application_ThreadException; //UI线程异常
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException; //多线程异常

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PersonPresenter presenter = new PersonPresenter(new PersonForm());
            Application.Run(presenter.View);
        }

        /// <summary>
        ///UI线程异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            //LogHelper.WriteError(e.Exception, "UI线程全局异常");
            throw e.Exception;
        }
        /// <summary>
        /// 多线程异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var exception = e.ExceptionObject as Exception;
            if (exception != null)
            {
                //LogHelper.WriteError(exception, "非UI线程全局异常");
                throw exception;
            }
        }
    }
}
