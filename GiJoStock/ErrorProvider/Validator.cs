using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace GiJoStock
{
    public class Validator : ErrorProvider
    {
        private readonly List<Rule> rules = new List<Rule>();

        public void AddValidation(MetroTextBox textBox, Expression<Func<MetroTextBox, bool>> expression, string errorMessage)
        {
            this.rules.Add(new Rule(textBox, expression, errorMessage));
        }

        public bool Validate()
        {
            var result = true;

            foreach (var gr in this.rules.GroupBy(x => x.TextBox))
            {
                var errors = new List<string>();

                foreach (Rule rule in gr)
                {
                    var errorMessage = string.Empty;

                    try
                    {
                        var compileFunc = rule.Expression.Compile();
                        if (compileFunc(rule.TextBox))
                        {
                            errorMessage = rule.ErrorMessage;
                            result = false;
                        }
                    }
                    catch (Exception)
                    {
                        errorMessage = rule.ErrorMessage;
                    }

                    if (!string.IsNullOrEmpty(errorMessage))
                        errors.Add(errorMessage);
                }

                var msg = string.Empty;
                if (errors.Count > 1)
                {
                    int index = 1;
                    msg = string.Join(Environment.NewLine, errors.Select(x => $"{index++}: {x}"));
                }
                else if (errors.Count > 0)
                {
                    msg = errors[0];
                }

                this.SetError(gr.Key, msg);
            }

            return result;
        }
    }
}