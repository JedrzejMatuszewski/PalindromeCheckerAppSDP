namespace PalindromeCheckerApp
{
    public static class PalindromeChecker
    {
        /// <summary>
        /// Function to check if typed text is a palindrome
        /// </summary>
        /// <param name="textToCheck"></param>
        /// <returns>True if typed text is palindrome, otherwise false</returns>
        public static bool Check(string textToCheck)
        {
            if(textToCheck.Length<2)
            {
                return false;
            }

            var mergedText = string.Empty;
            foreach (var item in textToCheck.Split())
            {
                mergedText += item;
            }

            var sizeOfMergedText = mergedText.Length;
            for (int i = 0; i < sizeOfMergedText / 2; i++)
            {
                if (mergedText[i] != mergedText[sizeOfMergedText - 1 - i])
                    return false;
            }
            return true;
        }
    }
}
