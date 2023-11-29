using System;
using System.Windows.Forms;

namespace MVP.Sample.Winform.Views.Person
{
    public partial class PersonForm : Form
    {
        public Models.PersonViewModel Model
        {
            get
            {
                var model = new Models.PersonViewModel() { Name = textBox1.Text };
                return model;
            }
            set
            {
                var model = value as Models.PersonViewModel;
                textBox1.Text = model.Name;
            }
        }

        public EventHandler button1_Click;
        public PersonForm()
        {
            InitializeComponent();
        }
        private void PersonForm_Load(object sender, EventArgs e)
        {
            this.button1.Click += button1_Click;
        }
        

       
    }
}
