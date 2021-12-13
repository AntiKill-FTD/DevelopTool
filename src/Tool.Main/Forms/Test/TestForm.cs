using Tool.IService.Test;
using Tool.IService.Test.Model.Blogging;

namespace Tool.Main.Forms.Test
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
