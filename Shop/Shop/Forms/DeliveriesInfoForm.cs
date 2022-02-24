using System.Data;
using System.Windows.Forms;

namespace Shop.Forms
{
    public partial class DeliveriesInfoForm : Form
    {
        public DeliveriesInfoForm()
        {
            InitializeComponent();
        }

        public DeliveriesInfoForm(DataTable table) : this()
        {
            deliveriesGrid.DataSource = table;
        }
    }
}
