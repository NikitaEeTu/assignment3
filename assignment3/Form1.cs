namespace assignment3
{
    public partial class Form1 : Form
    {

        private double calculateBMI(double height, double weight)
        {
            double BMI = (weight / (Math.Pow(height, 2)))* 703;


            return BMI;
        }
        private String getBMIStatus(double BMI)
        {
            if(BMI >= 18.5 && BMI <= 25)
            {
                return "Optimal";
            }
            else if(BMI < 18.5)
            {
                return "Underweighted";
            }
            else
            {
                return "Overweighted";
            }
        }
        private String[] getOutputString(double BMI, String status)
        {
            String bmiStr = String.Format("BMI: {0:0.00}", BMI);
            String statusStr = String.Format("Status: {0}", status);

            String[] outStrArr = new String[] { bmiStr, statusStr };

            return outStrArr;
        }
        private double checkNumberForDouble(String number)
        {
            try
            {
                double convertedNumber = Double.Parse(number);
                return convertedNumber;
            }
            catch
            {
                return 0.0;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double userWeight = checkNumberForDouble(textBox1.Text);
            double userHeight = checkNumberForDouble(textBox2.Text);

            double BMI = calculateBMI(userHeight, userWeight);
            String status = getBMIStatus(BMI);

            String[] textArr = getOutputString(BMI, status);
            textBox3.Text = "";
            textBox3.AppendText(textArr[0]);
            textBox3.AppendText(Environment.NewLine);
            textBox3.AppendText(textArr[1]);

        }
    }
}