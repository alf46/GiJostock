using MetroFramework.Controls;
using System;
using System.Linq.Expressions;

namespace GiJoStock
{
    public class Rule
    {
        public Rule(MetroTextBox textBox, Expression<Func<MetroTextBox, bool>> expression, string errorMessage)
        {
            this.TextBox = textBox;
            this.Expression = expression;
            this.ErrorMessage = errorMessage;
        }

        public MetroTextBox TextBox { get; }
        public Expression<Func<MetroTextBox, bool>> Expression { get; }
        public string ErrorMessage { get; }
    }
}