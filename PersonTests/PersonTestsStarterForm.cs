namespace PersonTests
{
    /// <summary>
    /// Form to start the tests.
    /// </summary>
    public partial class PersonTestsStarterForm : Form
    {
        private int passedTests;
        private int failedTests;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonTestsStarterForm"/> class.
        /// </summary>
        public PersonTestsStarterForm()
        {
            this.InitializeComponent();
        }

        private void RunTestsButton_Click(object sender, EventArgs e)
        {
            this.passedTests = 0;

            // Add feature tests here
            this.passedTests += this.TestDisplay();
            this.passedTests += this.TestCompare();
            this.passedTests += this.TestPrint();
            this.passedTests += this.TestReset();

            MessageBox.Show(this.passedTests.ToString() + " of 4 tests passed!");
        }
    }
}