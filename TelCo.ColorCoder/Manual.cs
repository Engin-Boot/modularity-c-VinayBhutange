using System;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using static TelCo.ColorCoder.ColorList;

namespace TelCo.ColorCoder{
    class Manual
    {
         public override  string ToString()
        {
            StringBuilder referenceManual = new StringBuilder();
            int n = 1;
            for(int i=0; i < colorMapMajor.Length; i++)
            {
                string majorColorCode = colorMapMajor[i].ToString();
                for (int j = 0; j < colorMapMinor.Length; j++)
                {
                    string minorColorCode = colorMapMinor[j].ToString();
                    referenceManual.Append(n.ToString() + " ");
                    referenceManual.Append(majorColorCode + " ");
                    referenceManual.AppendLine(minorColorCode);
                    n++;
                }
            }
            return referenceManual.ToString();
        }
        
    }
}
