using System.Collections;
using System.Linq;
using System.Text;

namespace Components
{
    public class Test4String
    {
        public string StringCounterAsStackApproach(string stringToCount)
        {
            if (string.IsNullOrWhiteSpace(stringToCount))
                return string.Empty;

            int count = 0;
            char previousChar = '\n';
            
            var result = new StringBuilder();
            var stack = new Stack(stringToCount.ToArray());
            
            while (stack.Count > 0)
            {
                var currentChar = (char)stack.Pop();

                if (previousChar != currentChar) {
                    if (count > 0) {
                        result.Append($"{(count > 1 ? count.ToString() : "")}{previousChar}");
                    }
                    count = 1;
                    previousChar = currentChar;                    
                }
                else
                    count++;                
            }

            result.Append($"{(count > 1 ? count.ToString() : "")}{previousChar}");

            return result.ToString();
        }

        public string StringCounterAsLinqApproach(string stringToCount)
        {
            return string.Empty;
        }
    }
}