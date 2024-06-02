using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Text;

namespace SlaptazodziuSistema
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            if (File.Exists(FunctionManager.Path))
            {
                FunctionManager.DecryptFile(FunctionManager.Path, FunctionManager.Key);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FunctionManager.EncryptFile(FunctionManager.Path, FunctionManager.Key);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveForm saveForm = new SaveForm();
            saveForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.ShowDialog();
        }
    }
}
