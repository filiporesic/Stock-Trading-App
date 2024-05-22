using System;
using System.Windows.Forms;

namespace TrgovanjeDionicama
{
    public partial class TransferForm : Form
    {
        readonly int userId;
        public TransferForm(int userId)
        {
            this.userId = userId;
            InitializeComponent();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;

            ControlBox = false;

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            decimal amount = depositSelector.Value;
            if(amount > 0)
            {
                this.DialogResult = DialogResult.OK;
                WalletService.DepositToWallet(userId, amount);
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            decimal amount = withdrawSelector.Value;
            if(ibanTextBox.Text.Length == 0 && amount > 0)
            {
                MessageBox.Show("Error! Please enter IBAN.");
            }
            else if(amount > 0)
            {
                WalletService.WithdrawToBankAccount(userId, amount);
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
            this.Close();
        }
    }
}
