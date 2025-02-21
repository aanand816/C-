namespace PersonalExpenseTracker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.ListBox lstExpenses;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnFindExpense;
        private System.Windows.Forms.Button btnFindTodaysExpenses;
        private System.Windows.Forms.Button btnFindThisWeeksExpenses;
        private System.Windows.Forms.Button btnShowAllExpenses;
        private System.Windows.Forms.RichTextBox txtExpenseDetails; // Added RichTextBox

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblDescription = new Label();
            lblAmount = new Label();
            lblDate = new Label();
            txtDescription = new TextBox();
            txtAmount = new TextBox();
            dtpDate = new DateTimePicker();
            btnAddExpense = new Button();
            lstExpenses = new ListBox();
            btnClearFields = new Button();
            btnFindExpense = new Button();
            btnFindTodaysExpenses = new Button();
            btnFindThisWeeksExpenses = new Button();
            btnShowAllExpenses = new Button();
            txtExpenseDetails = new RichTextBox();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(20, 20);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(143, 20);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Expense Description";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(20, 60);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 20);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(20, 100);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(200, 20);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 27);
            txtDescription.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(200, 60);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(200, 27);
            txtAmount.TabIndex = 3;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(200, 100);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 27);
            dtpDate.TabIndex = 5;
            // 
            // btnAddExpense
            // 
            btnAddExpense.Location = new Point(90, 144);
            btnAddExpense.Name = "btnAddExpense";
            btnAddExpense.Size = new Size(100, 30);
            btnAddExpense.TabIndex = 6;
            btnAddExpense.Text = "Add Expense";
            btnAddExpense.UseVisualStyleBackColor = true;
            btnAddExpense.Click += btnAddExpense_Click;
            // 
            // lstExpenses
            // 
            lstExpenses.FormattingEnabled = true;
            lstExpenses.Location = new Point(20, 220);
            lstExpenses.Name = "lstExpenses";
            lstExpenses.Size = new Size(660, 104);
            lstExpenses.TabIndex = 12;
            lstExpenses.SelectedIndexChanged += lstExpenses_SelectedIndexChanged;
            // 
            // btnClearFields
            // 
            btnClearFields.Location = new Point(310, 144);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(100, 30);
            btnClearFields.TabIndex = 7;
            btnClearFields.Text = "Clear Fields";
            btnClearFields.UseVisualStyleBackColor = true;
            btnClearFields.Click += btnClearFields_Click;
            // 
            // btnFindExpense
            // 
            btnFindExpense.Location = new Point(529, 144);
            btnFindExpense.Name = "btnFindExpense";
            btnFindExpense.Size = new Size(100, 30);
            btnFindExpense.TabIndex = 8;
            btnFindExpense.Text = "Find Expense";
            btnFindExpense.UseVisualStyleBackColor = true;
            btnFindExpense.Click += btnFindExpense_Click;
            // 
            // btnFindTodaysExpenses
            // 
            btnFindTodaysExpenses.Location = new Point(20, 180);
            btnFindTodaysExpenses.Name = "btnFindTodaysExpenses";
            btnFindTodaysExpenses.Size = new Size(220, 30);
            btnFindTodaysExpenses.TabIndex = 9;
            btnFindTodaysExpenses.Text = "Find Today's Expenses";
            btnFindTodaysExpenses.UseVisualStyleBackColor = true;
            btnFindTodaysExpenses.Click += btnFindTodaysExpenses_Click;
            // 
            // btnFindThisWeeksExpenses
            // 
            btnFindThisWeeksExpenses.Location = new Point(250, 180);
            btnFindThisWeeksExpenses.Name = "btnFindThisWeeksExpenses";
            btnFindThisWeeksExpenses.Size = new Size(220, 30);
            btnFindThisWeeksExpenses.TabIndex = 10;
            btnFindThisWeeksExpenses.Text = "This Week's Expenses";
            btnFindThisWeeksExpenses.UseVisualStyleBackColor = true;
            btnFindThisWeeksExpenses.Click += btnFindThisWeeksExpenses_Click;
            // 
            // btnShowAllExpenses
            // 
            btnShowAllExpenses.Location = new Point(480, 180);
            btnShowAllExpenses.Name = "btnShowAllExpenses";
            btnShowAllExpenses.Size = new Size(200, 30);
            btnShowAllExpenses.TabIndex = 11;
            btnShowAllExpenses.Text = "Show All Expenses";
            btnShowAllExpenses.UseVisualStyleBackColor = true;
            btnShowAllExpenses.Click += btnShowAllExpenses_Click;
            // 
            // txtExpenseDetails
            // 
            txtExpenseDetails.Location = new Point(20, 350);
            txtExpenseDetails.Name = "txtExpenseDetails";
            txtExpenseDetails.Size = new Size(660, 100);
            txtExpenseDetails.TabIndex = 13;
            txtExpenseDetails.Text = "";
            // 
            // Form1
            // 
            ClientSize = new Size(700, 470);
            Controls.Add(txtExpenseDetails);
            Controls.Add(lstExpenses);
            Controls.Add(btnShowAllExpenses);
            Controls.Add(btnFindThisWeeksExpenses);
            Controls.Add(btnFindTodaysExpenses);
            Controls.Add(btnClearFields);
            Controls.Add(btnFindExpense);
            Controls.Add(btnAddExpense);
            Controls.Add(dtpDate);
            Controls.Add(txtAmount);
            Controls.Add(txtDescription);
            Controls.Add(lblDate);
            Controls.Add(lblAmount);
            Controls.Add(lblDescription);
            Name = "Form1";
            Text = "Personal Expense Tracker";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
