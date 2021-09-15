
using System.Diagnostics;

namespace Calculator
{
    public class CalculatorModel
    {

        public CalculatorModel()
        {

        }

        decimal leftValue;
        string operationSymbol;
        decimal rightValue;
        bool leftValueEntered = false;
        bool fieldCleared = false;

        public decimal LeftValue { get => leftValue; set => leftValue = value; }
        public string OperationSymbol { get => operationSymbol; set => operationSymbol = value; }
        public decimal RightValue { get => rightValue; set => rightValue = value; }
        public bool LeftValueEntered { get => leftValueEntered; set => leftValueEntered = value; }
        public bool FieldCleared { get => fieldCleared; set => fieldCleared = value; }


        public decimal Calculate()
        {
            if (operationSymbol.Equals("+"))
            {
                return leftValue + rightValue;
            }
            else if (operationSymbol.Equals("-"))
            {
                return leftValue - rightValue;
            }
            else if (operationSymbol.Equals("*"))
            {
                return leftValue * rightValue;
            }
            else
            {
                return leftValue / rightValue;
            }
        }

        public override string ToString()
        {
            return leftValue.ToString() + operationSymbol.ToString() + rightValue.ToString() + "=";
        }

    }

    
}
