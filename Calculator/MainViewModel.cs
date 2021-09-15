using Prism.Mvvm;
using System.Diagnostics;
using Windows.UI.Xaml.Controls;

namespace Calculator
{
    class MainViewModel : BindableBase
    {
        TextBlock currentValueTxt;
        TextBlock calculationTxt;
        CalculatorModel calculator;
        public MainViewModel(TextBlock currentValueTxt, TextBlock calculationTxt)

        {
            this.currentValueTxt = currentValueTxt;
            this.calculationTxt = calculationTxt;
            calculator = new CalculatorModel();
        }

        public void HandleNumberButtonClick(string buttonValue)
        {
            // replace num with default 0 or append to existing calculation value
            if (currentValueTxt.Text.Equals("0"))
            {
                currentValueTxt.Text = buttonValue;
            }
            else if (calculator.LeftValueEntered)
            {
                // initially clears currentValue from leftValue
                if (calculator.FieldCleared == false)
                {
                    currentValueTxt.Text = "";
                    currentValueTxt.Text = buttonValue;
                    calculator.FieldCleared = true;
                } else if (calculator.FieldCleared)
                {
                    currentValueTxt.Text += buttonValue; // append new value to currentValueTxt
                }
            }
            else
            {
                if(currentValueTxt.Text.ToString().Length > 9 && currentValueTxt.Text.ToString().Length < 15)
                {
                    currentValueTxt.FontSize = 32;
                } else if (currentValueTxt.Text.ToString().Length > 15 && currentValueTxt.Text.ToString().Length < 25)
                {
                    currentValueTxt.FontSize = 24;
                }
                currentValueTxt.Text += buttonValue;
            }
        }

        // Handles +,-,*,/,+-,%
        public void HandleOperationButtonClick(string buttonOperationType)
        {
            if (!calculator.LeftValueEntered)
            {
                // set leftvalue to currenttxtblk
                calculator.LeftValue = decimal.Parse(currentValueTxt.Text.ToString());
                calculator.OperationSymbol = buttonOperationType;
                calculator.LeftValueEntered = true;

                // update calculationtxtblk
                calculationTxt.Text = currentValueTxt.Text.ToString() + buttonOperationType.ToString();
            }
            
        }

        // Clears calculator textblocks
        public void HandleACButtonClick()
        {
            if (!currentValueTxt.Text.Equals("0") || !calculationTxt.Text.Equals(""))
            {
                ResetCalculator();
            }
        }

        // Handles calculation when = is clicked
        public void HandleEqualsButtonClick()
        {
            // Need to validate values are valid for division
            if (calculator.OperationSymbol == "÷" && currentValueTxt.Text == "0")
            {
                currentValueTxt.Text = "Cannot divide by zero";
                currentValueTxt.FontSize = 16;
            }
            else if(currentValueTxt.Text == "Cannot divide by zero")
            {
                // reset calculator
                ResetCalculator();
            }
            else
            {
                // set rightValue to new number
                calculator.RightValue = decimal.Parse(currentValueTxt.Text.ToString());
                // set current value to calculate value
                currentValueTxt.Text = calculator.Calculate().ToString();
                // set calculation to whole calculation
                calculationTxt.Text = calculator.ToString();
            }

        }

        public void HandleDecimalButtonClick()
        {
            Debug.WriteLine(".");
        }

        public void ResetCalculator()
        {
            // reset calculator view (MainPage.xaml)
            currentValueTxt.Text = "0";
            currentValueTxt.FontSize = 48;
            calculationTxt.Text = "";

            // Resets calculator model (CalculatorModel.cs)
            calculator.LeftValue = 0;
            calculator.OperationSymbol = "";
            calculator.RightValue = 0;
            calculator.LeftValueEntered = false;
            calculator.FieldCleared = false;

        }
    }
}
