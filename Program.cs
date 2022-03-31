using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

int cnum = 0;
int onum = 0;


Dictionary<int, string> words = new Dictionary<int, string>(); 
for(int i = 1;i < 101; i++) {
    words.Add(i, "o");
}
for(int i = 3; i < 101; i++)
{
    foreach (int I in words.Keys)
    {
        if (I % i == 0)
        {
            if (words.ContainsValue("c"))
            {
                words[I] = "o";
            }
            else if (words.ContainsValue("o"))
            {
                words[I] = "c";
            }
        }
    }
 }
foreach (string i in words.Values)
{
    if (words.ContainsValue("o"))
    {
        cnum++;
    }
    else if (words.ContainsValue("c"))
    {
        onum++;
    }
}
