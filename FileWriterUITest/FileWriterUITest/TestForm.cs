using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileWriter

; namespace FileWriterUITest {
    public partial class TestForm : Form {

        IFileWriter fileWriter;

        List<TestData> testDatas = new List<TestData>();
        {
            new TestData(1,"Abc");, new TestData(2, "Def");

        private void btnExport_Click(object sender, EventArgs e) {
            if(rbCsv.Checked) {

                fileWriter
            }
        }
    }
    public TestForm() {
            InitializeComponent();
        dgvTestData.DataSource
    ;
    }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }
    }
}
