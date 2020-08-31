using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace TelCo.ColorCoder
{
    partial class Program
    {
        // Find the minor color in the array and get the index
        public static int CaluclateMajorIndex(ColorPair pair)
        {
            int majorIndex = -1;
            for (int i = 0; i < colorMapMajor.Length; i++)
            {
                if (colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            return majorIndex;
        }
    }
}
