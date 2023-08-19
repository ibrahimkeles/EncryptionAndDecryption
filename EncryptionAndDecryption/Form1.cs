namespace EncryptionAndDecryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to exit ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == result)
                Application.Exit();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string value = txtEncryptDecryptedValue.Text;
            if (!string.IsNullOrEmpty(value))
                txtValues.Text = EncryptionDecrypt›on.Decrypt(value, true);
            else
                MessageBox.Show("Enter a data to be decode", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string value = txtEncryptDecryptedValue.Text;
            if (!string.IsNullOrEmpty(value))
                txtValues.Text = EncryptionDecrypt›on.Encrypt(value, true);
            else
                MessageBox.Show("Enter a data to be encrypted", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEncryptDecryptedValue.Text = "";
            txtValues.Text = "";
        }

        private void txtValues_TextChanged(object sender, EventArgs e)
        {
            if (chxChangeCopy.Checked)
            {
                string value = txtValues.Text;
                if (!string.IsNullOrEmpty(value))
                {
                    Clipboard.SetText(value);
                    MessageBox.Show($"{value} copied");
                }
            }
        }
    }
}