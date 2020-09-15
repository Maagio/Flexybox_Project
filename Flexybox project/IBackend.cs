using System.Collections.Generic;

namespace Flexybox_project
{
    public interface IBackend
    {
        string ReverseString (string s);
        bool IsPalindrome (string s);
        IEnumerable<int> MissingElements(int[] arr);
        int[] LowToHigh (int[] arr);
    }
}