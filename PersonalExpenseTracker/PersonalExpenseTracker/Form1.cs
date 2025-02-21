using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace PersonalExpenseTracker
{
    public partial class Form1 : Form
    {
        private List<Expense> expenses = new List<Expense>(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Personal Expense Tracker";
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text) || string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please fill all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Expense newExpense = new Expense
            {
                Description = txtDescription.Text,
                Amount = amount,
                Date = dtpDate.Value
            };

            expenses.Add(newExpense);
            lstExpenses.Items.Add($"{newExpense.Date.ToShortDateString()} - {newExpense.Description} - ${newExpense.Amount}");

            ClearFields();
        }

        // Method for clearing the input fields
        private void btnClearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtDescription.Text = "";
            txtAmount.Text = "";
            dtpDate.Value = DateTime.Now;
        }

        // Method to find expense for a perticular date
        private void btnFindExpense_Click(object sender, EventArgs e)
        {
            var selectedDate = dtpDate.Value.Date;
            var foundExpenses = expenses.Where(exp => exp.Date.Date == selectedDate).ToList();

            lstExpenses.Items.Clear();
            foreach (var expense in foundExpenses)
            {
                lstExpenses.Items.Add($"{expense.Date.ToShortDateString()} - {expense.Description} - ${expense.Amount}");
            }
        }

        // Method to display expense of today's date
        private void btnFindTodaysExpenses_Click(object sender, EventArgs e)
        {
            var todaysExpenses = expenses.Where(exp => exp.Date.Date == DateTime.Today).ToList();

            lstExpenses.Items.Clear();
            foreach (var expense in todaysExpenses)
            {
                lstExpenses.Items.Add($"{expense.Date.ToShortDateString()} - {expense.Description} - ${expense.Amount}");
            }
        }

        // Method to display this week's expenses
        private void btnFindThisWeeksExpenses_Click(object sender, EventArgs e)
        {
            var startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
            var endOfWeek = startOfWeek.AddDays(7);

            var weekExpenses = expenses.Where(exp => exp.Date.Date >= startOfWeek.Date && exp.Date.Date <= endOfWeek.Date).ToList();

            lstExpenses.Items.Clear();
            foreach (var expense in weekExpenses)
            {
                lstExpenses.Items.Add($"{expense.Date.ToShortDateString()} - {expense.Description} - ${expense.Amount}");
            }
        }

        // Method to display all expenses
        private void btnShowAllExpenses_Click(object sender, EventArgs e)
        {
            lstExpenses.Items.Clear();
            foreach (var expense in expenses)
            {
                lstExpenses.Items.Add($"{expense.Date.ToShortDateString()} - {expense.Description} - ${expense.Amount}");
            }
        }

        // Display detailed information about selected expense
        private void lstExpenses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstExpenses.SelectedItem != null)
            {
                string selectedExpense = lstExpenses.SelectedItem.ToString();
                var expense = expenses.FirstOrDefault(exp =>
                    $"{exp.Date.ToShortDateString()} - {exp.Description} - ${exp.Amount}" == selectedExpense);

                if (expense != null)
                {
                    txtExpenseDetails.Text = $"Description: {expense.Description}\n" +
                                             $"Amount: ${expense.Amount}\n" +
                                             $"Date: {expense.Date.ToShortDateString()}";
                }
            }
        }
    }

    // Expense model
    public class Expense
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
