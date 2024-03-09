namespace Lab4Calculator
{
    public partial class MainPage : ContentPage
    {
        public string action = "";
        public double firstNumber = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void clearButton_Clicked(object sender, EventArgs e)
        {
           calculatorBody.Text = "0";
        }

        private void flipSignButton_Clicked(object sender, EventArgs e)
        {
                double currentValue = Double.Parse(calculatorBody.Text);
                if (currentValue > 0)
                {
                    double doubleCurrent = currentValue * 2;
                    currentValue = currentValue - doubleCurrent;
                }
                else if (currentValue < 0)
                {
                    double doubleCurrent = currentValue * 2;
                    currentValue = currentValue - doubleCurrent;
                }
                calculatorBody.Text = currentValue.ToString();
        }

        private void percentButton_Clicked(object sender, EventArgs e)
        {
            double currentValue = Double.Parse(calculatorBody.Text)/100;
            calculatorBody.Text = currentValue.ToString();
        }
         
        private void divideButton_Clicked(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(calculatorBody.Text);
            divideButton.BackgroundColor = (Colors.White);
            divideButton.TextColor = (Colors.Orange);
            multiplicationButton.BackgroundColor = (Colors.Orange);
            multiplicationButton.TextColor = (Colors.White);
            additionButton.BackgroundColor = (Colors.Orange);
            additionButton.TextColor = (Colors.White);
            subtractionButton.BackgroundColor = (Colors.Orange);
            subtractionButton.TextColor = (Colors.White);
            action = "divide";
            calculatorBody.Text = "0";
        }

        private void sevenButton_Clicked(object sender, EventArgs e)
        {
            string current = (calculatorBody.Text + "7");
            calculatorBody.Text = current;
        }

        private void eightButton_Clicked(object sender, EventArgs e)
        {
            string current = (calculatorBody.Text + "8");
            calculatorBody.Text = current;
        }

        private void nineButton_Clicked(object sender, EventArgs e)
        {
            string current = (calculatorBody.Text + "9");
            calculatorBody.Text = current;
        }

        private void multiplicationButton_Clicked(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(calculatorBody.Text);
            multiplicationButton.BackgroundColor = (Colors.White);
            multiplicationButton.TextColor = (Colors.Orange);
            divideButton.BackgroundColor = (Colors.Orange);
            divideButton.TextColor = (Colors.White);
            additionButton.BackgroundColor = (Colors.Orange);
            additionButton.TextColor = (Colors.White);
            subtractionButton.BackgroundColor = (Colors.Orange);
            subtractionButton.TextColor = (Colors.White);
            action = "multiply";
            calculatorBody.Text = "0";
        }

        private void fourButton_Clicked(object sender, EventArgs e)
        {
            string current = (calculatorBody.Text + "4");
            calculatorBody.Text = current;
        }

        private void fiveButton_Clicked(object sender, EventArgs e)
        {
            string current = (calculatorBody.Text + "5");
            calculatorBody.Text = current;
        }

        private void sixButton_Clicked(object sender, EventArgs e)
        {
            string current = (calculatorBody.Text + "6");
            calculatorBody.Text = current;
        }

        private void subtractionButton_Clicked(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(calculatorBody.Text);
            subtractionButton.BackgroundColor = (Colors.White);
            subtractionButton.TextColor = (Colors.Orange);
            multiplicationButton.BackgroundColor = (Colors.Orange);
            multiplicationButton.TextColor = (Colors.White);
            additionButton.BackgroundColor = (Colors.Orange);
            additionButton.TextColor = (Colors.White);
            divideButton.BackgroundColor = (Colors.Orange);
            divideButton.TextColor = (Colors.White);
            action = "subtract";
            calculatorBody.Text = "0";
        }

        private void oneButton_Clicked(object sender, EventArgs e)
        {
            string current = (calculatorBody.Text + "1");
            calculatorBody.Text = current;
        }

        private void twoButton_Clicked(object sender, EventArgs e)
        {
            string current = (calculatorBody.Text + "2");
            calculatorBody.Text = current;
        }

        private void threeButton_Clicked(object sender, EventArgs e)
        {
            string current = (calculatorBody.Text + "3");
            calculatorBody.Text = current;
        }

        private void additionButton_Clicked(object sender, EventArgs e)
        {
            firstNumber = Double.Parse(calculatorBody.Text);
            additionButton.BackgroundColor = (Colors.White);
            additionButton.TextColor = (Colors.Orange);
            multiplicationButton.BackgroundColor = (Colors.Orange);
            multiplicationButton.TextColor = (Colors.White);
            divideButton.BackgroundColor = (Colors.Orange);
            divideButton.TextColor = (Colors.White);
            subtractionButton.BackgroundColor = (Colors.Orange);
            subtractionButton.TextColor = (Colors.White);
            action = "add";
            calculatorBody.Text = "0";
        }

        private void zeroButton_Clicked(object sender, EventArgs e)
        {
            string current = (calculatorBody.Text + "0");
            calculatorBody.Text = current;
        }

        private void decimalPointButton_Clicked(object sender, EventArgs e)
        {
            if ((calculatorBody.Text).Contains("."))
            {

            }
            else
            {
                string current = (calculatorBody.Text + ".");
                calculatorBody.Text = current;
            }
        }

        private void equalsButton_Clicked(object sender, EventArgs e)
        {
            double secondNumber = Double.Parse(calculatorBody.Text);
            if (action.Equals("add"))
            {
                calculatorBody.Text = ((firstNumber + secondNumber).ToString());
            }
            else if (action.Equals("subtract"))
            {
                calculatorBody.Text = ((firstNumber - secondNumber).ToString());
            }
            else if (action.Equals("multiply"))
            {
                calculatorBody.Text = ((firstNumber * secondNumber).ToString());
            }
            else if (action.Equals("divide"))
            {
                if (secondNumber == 0)
                {
                    calculatorBody.Text = ("ERROR");
                }
                else
                {
                    calculatorBody.Text = ((firstNumber / secondNumber).ToString());
                }
            }
            divideButton.BackgroundColor = (Colors.Orange);
            divideButton.TextColor = (Colors.White);
            multiplicationButton.BackgroundColor = (Colors.Orange);
            multiplicationButton.TextColor = (Colors.White);
            additionButton.BackgroundColor = (Colors.Orange);
            additionButton.TextColor = (Colors.White);
            subtractionButton.BackgroundColor = (Colors.Orange);
            subtractionButton.TextColor = (Colors.White);
        }
    }

}
