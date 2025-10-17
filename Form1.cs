namespace ExceptionHandling
{
    /// <summary>
    /// Exceoption handling example.
    /// Look at the commit history to see different versions of handling exceptions (they are listed as examples).
    /// </summary>

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void divide()
        {
            int num1, num2, result;
            try
            {
                num1 = Int32.Parse(Num1Input.Text);
            }
            catch (FormatException)
            {
                ResultBox.Text = "Invalid Entry1";
                return;
            }
            try
            { 
                num2 = Int32.Parse(Num2Input.Text);
            }
            catch (FormatException)
            {
                ResultBox.Text = "Invalid Entry2";
                return;
            }
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                ResultBox.Text = "Cannot divide by zero";
                System.InvalidOperationException ex = new System.InvalidOperationException("you tried to divide " + num1 + " by " + num2);
                throw ex;
               
            }
            result = num1 / num2;
            ResultBox.Text = result.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                divide();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("An error occured "+ex.Message);
            }
            
        }

       
    }
}
