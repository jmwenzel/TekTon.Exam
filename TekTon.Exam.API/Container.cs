using System;

namespace TekTon.Exam.API
{
    public class Container
    {
        public int MaxArea(int[] linesHeight)
        {
            var max = 0; 
            var i = 0; 
            var j = linesHeight.Length -1;
            while (j > i)
            {
                // Caculate the min line height
                var minHeight = Math.Min(linesHeight[i], linesHeight[j]);
                // Calculate container width
                var width = j - i;
                // Calculate area (minHeight * width) and update max value if needed
                max = Math.Max(max, minHeight * width);
                
                // Move left pointer to the right if the value is lower
                if (linesHeight[i] < linesHeight[j])
                    i++;
                // if not then move right pointer to the left
                else
                    j--;
            }
            return max;
        }
    }
}
