using MVP.Sample.Winform.Models;
using MVP.Sample.Winform.Views.Person;

namespace MVP.Sample.Winform.Presenters
{
    public class PersonPresenter:BasePresenter<PersonForm>
    {
        public PersonPresenter(PersonForm view) : base(view)
        {
        }
        /// <summary>
        /// 初始化器
        /// </summary>
        /// <param name="view">视图</param>
        public override void Initialize(PersonForm view)
        {
            //初始化Model
            this.View.Model = new PersonViewModel() { Name = "Bao, Jianqiang" };
            this.View.button1_Click += delegate
            {
                this.View.Model = new PersonViewModel() { Name = "Jax.Bao" };
            };
        }

    }
}