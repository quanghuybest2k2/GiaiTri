using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToanRoiRac.DTO
{
    public class Lab1
    {
        private int[] S;
        private int n;

        public Lab1()
        {
            this.S = new int[] { 1, 2, 3 };
            this.n = S.Length;
        }

        public void choice(int choice)
        {
            if (choice == 0) // xuat truc tiep
            {
                string s = "";
                for (int i = 0; i < (1 << n); i++)
                {
                    s += "{ ";
                    for (int j = 0; j < n; j++)
                    {
                        if ((i & (1 << j)) > 0)
                        {
                            s += S[j] + " ";
                        }
                    }
                    s += "}\n";
                }
                MessageBox.Show(s);
            }
            else if (choice == 1) // xuat file trong folder \\bin\\debug
            {
                StreamWriter writer = new StreamWriter("result.txt");
                for (int i = 0; i < (1 << n); i++)
                {
                    writer.Write("{ ");
                    for (int j = 0; j < n; j++)
                    {
                        if ((i & (1 << j)) > 0)
                        {
                            writer.Write(S[j] + " ");
                        }
                    }
                    writer.Write("}\n");
                }
                writer.Close();
                MessageBox.Show("Kết quả đã được xuất vào bin\\Debug\\result.txt");
            }
        }
    }
}
