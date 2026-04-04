using CustomerAPP.Views.Main;

namespace CustomerAPP
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event EventHandler ClickCustomerRegister;

        private void menuItemCustomer_Click(object sender, EventArgs e)
        {
            ClickCustomerRegister?.Invoke(this, EventArgs.Empty);
        }
    }
}
