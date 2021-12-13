using Tool.IService.Model.Blogging;
using Tool.IService.Test;

namespace Tool.Main.Forms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            IBlogService bs = Program.ServiceProvider.GetService(typeof(IBlogService)) as IBlogService;

            List<TestTable> testTables = bs.GetTest();

            this.dataGridView1.DataSource = testTables;
        }
    }
}
