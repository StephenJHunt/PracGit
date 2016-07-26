using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThinkLib;

namespace G16h0403_Prac_2_Part_B
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private int Length(string s)
        {
            int length = 0;
            foreach (char c in s)
            {
                length++;
            }
            return length;
        }


        //private string substring(string s, int index, int count)
        //{
        //    string newstr = "";
        //    while (count>indexcount)
        //    {

        //    }
        //    List<string> list = new List<string>();
        //    return newstr;
        //}


        private bool Contains(string s, string subs)
        {
            bool contains = false;
            int length = Length(s);
            int lengthsubs = Length(subs);
            for (int i = 0; i < lengthsubs; i++)
            {
                for (int i2 = 0; i2 < length; i2++)
                {
                    if (s[i2] == subs[i])
                    {
                        contains = true;
                        if (i == lengthsubs-1 && contains)
                        {
                            return true;
                        }
                        break;
                    }
                    contains = false;
                }
            }
            return contains;
        }

        private int IndexOf(string s, string subs)
        {
            if (Contains(s, subs))
            {
                for (int i = 0; i < Length(s); i++)
                {
                    if (s[i] == subs[0])
                    {
                        if (Length(subs) > 1 && s[i+1] == subs[1])
                        {
                            return i;
                        }else if (Length(subs) == 1)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }

        private string InsertSubString(string s, string news, int pos)
        {
            char[] c = new char[Length(s) + Length(news)];
            for (int i = 0; i < pos; i++)
            {
                c[i] = s[i];
            }
            for (int i = 0; i < Length(news); i++)
            {
                c[pos + i] = news[i];
            }
            for (int i = pos+Length(news); i < (Length(s) + Length(news)); i++)
            {
                c[i] = s[i-Length(news)];
            }
            string newstr = new string(c);
            return newstr;
        }

        private string ReplaceSubString(string s, string news, string old)
        {
            string newstr = InsertSubString(s, news, IndexOf(s, old));
            newstr = DeleteSubString(newstr, old);
            return newstr;
        }

        private string DeleteSubString(string s, string subs)
        {
            char[] c = new char[Length(s) - Length(subs)];
            string newstr = "";
            if (Contains(s, subs))
            {
                for (int i = 0; i < IndexOf(s, subs); i++)
                {
                    c[i] = s[i];
                }
                for (int i = IndexOf(s, subs); i < (Length(s) - Length(subs)); i++)
                {
                    c[i] = s[i + Length(subs)];
                }
                newstr = new string(c);
            }
            return newstr;
        }


        private List<string> split (string s, char c)
        {
            List<string> newstr = new List<string>();
            char[] c = new char[]
            return newstr;
        }

        private int StringCompare(string s1, string s2)
        {
            int value = 0;
            return value;
        }


        private string ToLower(string s)
        {
            string lower = "";
            return lower;
        }

        private string ToUpper(string s)
        {
            string upper = "";
            return upper;
        }


        private void InsertSubStrTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(InsertSubString("xxxx", "y", 2), "xxyxx");
            Tester.TestEq(InsertSubString("xxxx", "yy", 2), "xxyyxx");
        }

        private void LengthTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(Length("xxx"), 3);
            Tester.TestEq(Length(""), 0);
        }

        private void ContainsTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(Contains("xxyxx", "y"), true);
            Tester.TestEq(Contains("xxyxx", "yx"), true);
            Tester.TestEq(Contains("xxyxx", "xyx"), true);
        }

        private void IndexOfTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(IndexOf("xxyxx", "y"), 2);
            Tester.TestEq(IndexOf("xxyxx", "xy"), 1);
            Tester.TestEq(IndexOf("xxyxx", "xxy"), 0);
        }

        private void ReplaceSubStringTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(ReplaceSubString("xxyxx", "ooo", "y"), "xxoooxx");
        }

        private void DeleteSubStringTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(DeleteSubString("xxyxx", "y"), "xxxx");
            Tester.TestEq(DeleteSubString("xxyxx", "xyx"), "xx");
        }

        private void StringCompareTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(StringCompare("xxx", "xxx"), 0);
        }

        private void SplitTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(split("x xx xxx", ' '), new List<string> { "x", "xx", "xxx" });
        }

        private void ToLowerTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(ToLower("HeLLo"), "hello");
        }

        private void ToUpperTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(ToUpper("HeLLo"), "HELLO");
        }
    }
}
