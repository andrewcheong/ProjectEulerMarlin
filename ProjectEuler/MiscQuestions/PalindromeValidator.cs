using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.MiscQuestions
{
    class PalindromeValidator : QuestionBase
    {
        private readonly string _value;

        public PalindromeValidator(string value)
        {
            _value = value.ToLower();
            Description = string.Format("Is \"{0}\" a palindrome?", _value);
        }

        public override object RunSolution()
        {
            for (int i = 0; i < Math.Ceiling((double)_value.Length / 2); i++)
            {
                if (_value[i] != _value[_value.Length - i - 1])
                    return "No";
            }

            return "Yes";
        }
    }
}
