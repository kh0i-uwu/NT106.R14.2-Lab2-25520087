using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab02_Bai03 : Form
    {
        public Lab02_Bai03()
        {
            InitializeComponent();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            StringBuilder sb = new StringBuilder();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                double result = TinhBieuThuc(line);

                sb.AppendLine($"{line} = {result.ToString("0.##", System.Globalization.CultureInfo.InvariantCulture)}");
            }

            rtbContent.Text = sb.ToString();

        }

        private double TinhBieuThuc(string expr)
        {
            while (expr.Contains("("))
            {
                int openIndex = expr.LastIndexOf('(');
                int closeIndex = expr.IndexOf(')', openIndex);

                string subExpr = expr.Substring(openIndex + 1, closeIndex - openIndex - 1);
                double subResult = TinhToanCoBan(subExpr);

                expr = expr.Substring(0, openIndex) + subResult.ToString(System.Globalization.CultureInfo.InvariantCulture) + expr.Substring(closeIndex + 1);
            }

            return TinhToanCoBan(expr);
        }

        private double TinhToanCoBan(string expr)
        {
            expr = expr.Replace(" ", "").Replace("–", "-");

            List<double> numbers = new List<double>();
            List<char> ops = new List<char>();
            string tempNum = "";

            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];

                if (c == '-' && (i == 0 || "+-*/".Contains(expr[i - 1])))
                {
                    tempNum += c;
                }
                else if (char.IsDigit(c) || c == '.')
                {
                    tempNum += c;
                }
                else if ("+-*/".Contains(c))
                {
                    if (!string.IsNullOrEmpty(tempNum))
                    {
                        numbers.Add(double.Parse(tempNum, System.Globalization.CultureInfo.InvariantCulture));
                        tempNum = "";
                    }
                    ops.Add(c);
                }
            }
            if (!string.IsNullOrEmpty(tempNum))
            {
                numbers.Add(double.Parse(tempNum, System.Globalization.CultureInfo.InvariantCulture));
            }

            for (int i = 0; i < ops.Count; i++)
            {
                if (ops[i] == '*' || ops[i] == '/')
                {
                    double res = (ops[i] == '*') ? numbers[i] * numbers[i + 1] : numbers[i] / numbers[i + 1];
                    numbers[i] = res;
                    numbers.RemoveAt(i + 1);
                    ops.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < ops.Count; i++)
            {
                double res = (ops[i] == '+') ? numbers[i] + numbers[i + 1] : numbers[i] - numbers[i + 1];
                numbers[i] = res;
                numbers.RemoveAt(i + 1);
                ops.RemoveAt(i);
                i--;
            }

            return numbers.Count > 0 ? numbers[0] : 0;
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            FileStream fs = new FileStream(sfd.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            string content = rtbContent.Text;
            sw.Write(content);
            sw.Close();
        }
    }
}
