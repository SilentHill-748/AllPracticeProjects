using System.Data;
using System.Windows.Forms;

namespace Shop.Forms
{
    public partial class SalesInfoForm : Form
    {
        public SalesInfoForm()
        {
            InitializeComponent();
        }

        public SalesInfoForm(DataTable table) : this()
        {
            salesGrid.DataSource = table;
        }
    }
}
