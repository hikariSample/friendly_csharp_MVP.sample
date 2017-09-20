using Microsoft.Practices.Prism.Commands;
using MVP.Sample.WPF.Models;
using MVP.Sample.WPF.Views.Person;

namespace MVP.Sample.WPF.Presenters
{
    public class PersonPresenter:BasePresenter<Window1>
    {
        public PersonPresenter(Window1 view) : base(view)
        {
        }
        public override void Initialize(Window1 view)
        {
            //初始化Model
            this.View.Model = new PersonViewModel()
            {
                Name = "Bao, Jianqiang",
                ClickCommand = new DelegateCommand<object>(OnClick, arg => true)
            };
        }
        private void OnClick(object obj)
        {
            this.View.Model.Name = "Jax.Bao";
        }


        
    }
}