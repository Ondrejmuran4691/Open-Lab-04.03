using System;
using System.Collections.Generic;
namespace Open_Lab_04._03
{
    public class StringTools
    {
        
        public string RemoveFirstLast(string original)
        {
            var nie = new List<string>();
            string medzi;
            int i = 0;
            int dlzka = original.Length;
            string final = "";
            if (dlzka < 2)
            {
                final = original;
            }
            else
            {
                foreach (char c in original)
                {
                    medzi = c.ToString();
                    if (i == 0)
                    {

                    }
                    else
                    {
                        if (i == dlzka - 1)
                        {

                        }
                        else
                        {
                            final += medzi;
                        }
                    }
                    i++;
                }
            }
            return final;

        }

    }
}

