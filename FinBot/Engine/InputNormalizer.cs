using System.Collections.Generic;
using System.Text;

namespace FinBot.Engine
{
    public interface IInputNormalizer
    {
        string Normalize(string input);
    }

    public class InputNormalizer : IInputNormalizer
    {
        readonly HashSet<char> _invalidCharacters = new HashSet<char> {'\u202B' };

        public string Normalize(string input)
        {
            var stringBuilder = new StringBuilder(input.Length);
            foreach (char character in input)
            {
                if (!_invalidCharacters.Contains(character))
                {
                    stringBuilder.Append(character);
                }
            }
            return stringBuilder.ToString();
        }
    }
}