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


        private char UpperCase(char c)
        {
            switch (c)
            {
                case 'a': return 'A';
                case 'b': return 'B';
                case 'c': return 'C';
                case 'd': return 'D';
                case 'e': return 'E';
                case 'f': return 'F';
                case 'g': return 'G';
                case 'h': return 'H';
                case 'i': return 'I';
                case 'j': return 'J';
                case 'k': return 'K';
                case 'l': return 'L';
                case 'm': return 'M';
                case 'n': return 'N';
                case 'o': return 'O';
                case 'p': return 'P';
                case 'q': return 'Q';
                case 'r': return 'R';
                case 's': return 'S';
                case 't': return 'T';
                case 'u': return 'U';
                case 'v': return 'V';
                case 'w': return 'W';
                case 'x': return 'X';
                case 'y': return 'Y';
                case 'z': return 'Z';
                default: return c;
            }
        }


        private char LowerCase(char c)
        {
            switch (c)
            {
                case 'A': return 'a';
                case 'B': return 'b';
                case 'C': return 'c';
                case 'D': return 'd';
                case 'E': return 'e';
                case 'F': return 'f';
                case 'G': return 'g';
                case 'H': return 'h';
                case 'I': return 'i';
                case 'J': return 'j';
                case 'K': return 'k';
                case 'L': return 'l';
                case 'M': return 'm';
                case 'N': return 'n';
                case 'O': return 'o';
                case 'P': return 'p';
                case 'Q': return 'q';
                case 'R': return 'r';
                case 'S': return 's';
                case 'T': return 't';
                case 'U': return 'u';
                case 'V': return 'v';
                case 'W': return 'w';
                case 'X': return 'x';
                case 'Y': return 'y';
                case 'Z': return 'z';
                default: return c;
            }
        }


        private bool alphabeticallyHigher(char c1, char c2)
        {
            int pos1 = 0;
            switch (c1)
            {
                case 'a': pos1 = 1; break;
                case 'b': pos1 = 2; break;
                case 'c': pos1 = 3; break;
                case 'd': pos1 = 4; break;
                case 'e': pos1 = 5; break;
                case 'f': pos1 = 6; break;
                case 'g': pos1 = 7; break;
                case 'h': pos1 = 8; break;
                case 'i': pos1 = 9; break;
                case 'j': pos1 = 10; break;
                case 'k': pos1 = 11; break;
                case 'l': pos1 = 12; break;
                case 'm': pos1 = 13; break;
                case 'n': pos1 = 14; break;
                case 'o': pos1 = 15; break;
                case 'p': pos1 = 16; break;
                case 'q': pos1 = 17; break;
                case 'r': pos1 = 18; break;
                case 's': pos1 = 19; break;
                case 't': pos1 = 20; break;
                case 'u': pos1 = 21; break;
                case 'v': pos1 = 21; break;
                case 'w': pos1 = 22; break;
                case 'x': pos1 = 23; break;
                case 'y': pos1 = 24; break;
                case 'z': pos1 = 25; break;
                default: return false;
            }
            int pos2 = 0;
            switch (c2)
            {
                case 'a': pos2 = 1; break;
                case 'b': pos2 = 2; break;
                case 'c': pos2 = 3; break;
                case 'd': pos2 = 4; break;
                case 'e': pos2 = 5; break;
                case 'f': pos2 = 6; break;
                case 'g': pos2 = 7; break;
                case 'h': pos2 = 8; break;
                case 'i': pos2 = 9; break;
                case 'j': pos2 = 10; break;
                case 'k': pos2 = 11; break;
                case 'l': pos2 = 12; break;
                case 'm': pos2 = 13; break;
                case 'n': pos2 = 14; break;
                case 'o': pos2 = 15; break;
                case 'p': pos2 = 16; break;
                case 'q': pos2 = 17; break;
                case 'r': pos2 = 18; break;
                case 's': pos2 = 19; break;
                case 't': pos2 = 20; break;
                case 'u': pos2 = 21; break;
                case 'v': pos2 = 21; break;
                case 'w': pos2 = 22; break;
                case 'x': pos2 = 23; break;
                case 'y': pos2 = 24; break;
                case 'z': pos2 = 25; break;
                default: return false;
            }
            if (pos1 < pos2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private string substring(string s, int index, int count)
        {
            char[] charr = new char[count];
            int count2 = 0;
            while ((index + count2) < Length(s) && count > count2)
            {
                charr[count2] = s[index + count2];
                count2++;
            }
            return new string(charr);
        }


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
            string newstr = "";
            int occurences = 0;
            for (int i = 0; i < Length(s); i++)
            {
                if (substring(s, i, Length(old)) == old)
                {
                    occurences++;
                }
            }
            int idx = 0;
            char[] charr = new char[(Length(s) + (Length(news)*occurences)) - (Length(old)*occurences)];
            int strindex = 0;
            int charindex = 0;
            while(strindex<Length(s))
            {
                if (substring(s, idx, Length(old)) == old)
                {
                    for (int i2 = 0; i2 < Length(news); i2++)
                    {
                        charr[charindex] = news[i2];
                        charindex++;
                    }
                    strindex += Length(old);
                    if (Length(old) > 1)
                    {
                        idx += Length(old) - 1;
                    }
                }else
                {
                    charr[charindex] = s[strindex];
                    strindex++;
                    charindex++;
                }
                idx++;
            }
            newstr = new string(charr);
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
            int temp = 0;
            for (int i = 0; i < Length(s); i++)
            {
                if (s[i] == c)
                {
                    newstr.Add(substring(s, temp, i-temp));
                    temp = i+1;
                }
            }
            newstr.Add(substring(s, temp, Length(s)-temp));
            return newstr;
        }

        private int StringCompare(string s1, string s2)
        {
            int value = 0;
            if (s1 == s2)
            {
                return 0;
            }
            foreach (char c in s1)
            {
                foreach (char c2 in s2)
                {
                    if (alphabeticallyHigher(c, c2))
                    {
                        return -1;
                    }
                    else if (alphabeticallyHigher(c2, c))
                    {
                        return 1;
                    }
                }
            }
            return value;
        }


        private string ToLower(string s)
        {
            char[] charr = new char[Length(s)];
            int idx = 0;
            foreach (char c in s)
            {
                charr[idx] = LowerCase(c);
                idx++;
            }
            return new string(charr);
        }

        private string ToUpper(string s)
        {
            char[] charr = new char[Length(s)];
            int idx = 0;
            foreach (char c in s)
            {
                charr[idx] = UpperCase(c);
                idx++;
            }
            return new string(charr);
        }


        private void InsertSubStrTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(InsertSubString("xxxx", "y", 2), "xxyxx");
            Tester.TestEq(InsertSubString("xxxx", "yy", 2), "xxyyxx");
            Tester.TestEq(InsertSubString("xxxx", "yy", 1), "xyyxxx");
            Tester.TestEq(InsertSubString("xxxx", "yy", 3), "xxxyyx");
            Tester.TestEq(InsertSubString("xxxx", "yy", 4), "xxxxyy");
        }

        private void LengthTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(Length("xxx"), 3);
            Tester.TestEq(Length("xxxxxxxxxx"), 10);
            Tester.TestEq(Length("not a string"), 12);
            Tester.TestEq(Length("another test"), 12);
            Tester.TestEq(Length("this works"), 10);
        }

        private void ContainsTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(Contains("xxyxx", "y"), true);
            Tester.TestEq(Contains("xxyxx", "yx"), true);
            Tester.TestEq(Contains("xxyxx", "xyx"), true);
            Tester.TestEq(Contains("xxyxx", "42"), false);
            Tester.TestEq(Contains("xxyxx", "1"), false);
        }

        private void IndexOfTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(IndexOf("xxyxx", "y"), 2);
            Tester.TestEq(IndexOf("xxyxx", "xy"), 1);
            Tester.TestEq(IndexOf("xxyxx", "xxy"), 0);
            Tester.TestEq(IndexOf("xxyxx", "x"), 0);
            Tester.TestEq(IndexOf("xxyxx", "yxx"), 2);
        }

        private void ReplaceSubStringTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(ReplaceSubString("xxyxx", "ooo", "y"), "xxoooxx");
            Tester.TestEq(ReplaceSubString("xxyxx", "ooo", "xyx"), "xooox");
            Tester.TestEq(ReplaceSubString("xxyxxyx", "ooo", "xy"), "xoooxooox");
            Tester.TestEq(ReplaceSubString("xyxxyxxyx", "ooo", "xy"), "oooxoooxooox");
            Tester.TestEq(ReplaceSubString("abcdef", "xyz", "def"), "abcxyz");
        }

        private void DeleteSubStringTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(DeleteSubString("xxyxx", "y"), "xxxx");
            Tester.TestEq(DeleteSubString("xxyxx", "xyx"), "xx");
            Tester.TestEq(DeleteSubString("This Test", "Test"), "This ");
            Tester.TestEq(DeleteSubString("Anonymous is not legion", " not"), "Anonymous is legion");
            Tester.TestEq(DeleteSubString("Cthulu", "th"), "Culu");
        }

        private void StringCompareTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(StringCompare("xxx", "xxx"), 0);
            Tester.TestEq(StringCompare("xax", "xxx"), -1);
            Tester.TestEq(StringCompare("xxx", "xax"), 1);
            Tester.TestEq(StringCompare("xxa", "xxx"), -1);
            Tester.TestEq(StringCompare("xxx", "xxa"), 1);
        }

        private void SplitTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(split("x xx xxx", ' '), new List<string> { "x", "xx", "xxx" });
            Tester.TestEq(split("abcde", 'c'), new List<string> { "ab", "de" });
            Tester.TestEq(split("underscore_is_best_score", '_'), new List<string> { "underscore", "is", "best" , "score" });
            Tester.TestEq(split("why-is-making-tests-so-boring", '-'), new List<string> { "why", "is", "making", "tests", "so", "boring" });
        }

        private void ToLowerTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(ToLower("HeLLo"), "hello");
            Tester.TestEq(ToLower("This IS nOt A TesT"), "this is not a test");
            Tester.TestEq(ToLower("DotA 2 Is NoT a NicE gAmE"), "dota 2 is not a nice game");
            Tester.TestEq(ToLower("ShiGatSu Wa KiMi nO Uso iS tHe beST anImE"), "shigatsu wa kimi no uso is the best anime");
            Tester.TestEq(ToLower("TriGGer wARniNg"), "trigger warning");
            Tester.TestEq(ToLower("MiLHouSe iS nOT a MeME"), "milhouse is not a meme");
        }

        private void ToUpperTest_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(ToUpper("HeLLo"), "HELLO");
            Tester.TestEq(ToUpper("This IS nOt A TesT"), "THIS IS NOT A TEST"); 
            Tester.TestEq(ToUpper("DotA 2 Is NoT a NicE gAmE"), "DOTA 2 IS NOT A NICE GAME");
            Tester.TestEq(ToUpper("ShiGatSu Wa KiMi nO Uso iS tHe beST anImE"), "SHIGATSU WA KIMI NO USO IS THE BEST ANIME");
            Tester.TestEq(ToUpper("TriGGer wARniNg"), "TRIGGER WARNING");
            Tester.TestEq(ToUpper("MiLHouSe iS nOT a MeME"), "MILHOUSE IS NOT A MEME");
        }
    }
}
