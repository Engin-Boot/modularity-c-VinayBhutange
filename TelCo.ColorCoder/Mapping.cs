using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder{
    partial class Program
    {
         public override  string ToString()
        {
            StringBuilder ReferenceManual = new StringBuilder();
            int n = 1;
            for(int i=0; i < colorMapMajor.Length; i++)
            {
                for(int j=0; j < colorMapMinor.Length; j++)
                {
                    ReferenceManual.Append(n.ToString() + " " + colorMapMajor[i].ToString() + " " + colorMapMinor[j].ToString() );
                    n++;
                }
            }
            return ReferenceManual.ToString();
        }
        
    }
}