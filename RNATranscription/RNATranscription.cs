using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            //throw new NotImplementedException("You need to implement this function.");
            String RNA="";
            int len = nucleotide.Length;
            for (int i=0; i<len; i++)
            {
                if(nucleotide[i]=='G')
                {
                    RNA=RNA+"C";
                }
                else if(nucleotide[i]=='C')
                {
                     RNA=RNA+"G";
                }
                else if(nucleotide[i]=='T')
                {
                     RNA=RNA+"A";
                }
                else if(nucleotide[i]=='A')
                {
                     RNA=RNA+"U";
                }
                else if(nucleotide[i]=='U')
                {
                     RNA=RNA+"A";
                }
            }
        return(RNA);
        }
    }
}
