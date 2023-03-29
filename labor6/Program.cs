using System.Globalization;
using System.Text.RegularExpressions;
using dinamic;

//task1a
//string str = Console.ReadLine();

//Regex regex = new Regex(@"abcd(2023)1{7}0\1");
//MatchCollection matches = regex.Matches(str);
//if (matches.Count > 0) { Console.WriteLine("Такая подстрока есть!"); }
//else { Console.WriteLine("Такой подстроки нет:( "); }



//task1b
//string str=Console.ReadLine();
//str = Regex.Replace(str, "2023", "happynewyear");
//Console.WriteLine(str);
//Regex regexi = new Regex("[0-9]+");
//Massive a = new Massive();
//foreach (Match match in regexi.Matches(str))
//{
//    a.last(Convert.ToInt32(match.Value));
//}
//a.Output();
//int k = 0;
//for(int i=0;i< a.Kol(); i++)
//{
//    k += a.get(i);
//}
//Console.WriteLine(k) ;
//int[] an = new int[2];
//an = a.Max();
//foreach (int i in an) { Console.Write(i+ "\t"); }

//task1c
//string str1 = Console.ReadLine();
//Regex regex1 = new Regex(@"[+-\\d][0-9]+\.?\,?[0-9]+");
//MatchCollection match1 = regex1.Matches(str1);
//for(int i = 0; i < match1.Count; i++)
//{
//    Console.WriteLine(match1[i]);
//}
//str1 = Regex.Replace(str1, @"[+-\\d][0-9]+\.?\,?[0-9]+", "number");
//Console.WriteLine(str1);


//task1d    
//string str = Console.ReadLine();
//Regex regex = new Regex(@"^C:\\\w?[\\\w]*");
//MatchCollection matches = regex.Matches(str);
//if (matches.Count > 0) { Console.WriteLine("Эта строка считается путем к файлу!"); }
//else { Console.WriteLine("Эта строка не считается путем к файлу:( "); }

//task2a
//string[] str = new string[5];
//for(int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine("Введите "+ (i+1)+ " строку: ");
//    str[i] = Console.ReadLine();
//}
//string pattern=(@"\w*cat\s*\w*cat\w*");
//for(int i=0; i < str.Length; i++)
//{
//    if(Regex.IsMatch(str[i],pattern, RegexOptions.IgnoreCase))
//    {
//        Console.WriteLine(str[i]);
//    }
//}


//task2b(1)
//string[] str = new string[5];
//for (int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine("Введите " + (i + 1) + " строку: ");
//    str[i] = Console.ReadLine();
//}
//Regex regex = new Regex(@"\w{10}\w*");
//for(int i=0; i < str.Length; i++)
//{ 
//    str[i]= regex.Replace(str[i], "*");
//}
//for (int j = 0; j < str.Length; j++) { Console.WriteLine(str[j]); }



//task2b(2)  //не получилось
//string[] str = new string[5];
//for (int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine("Введите " + (i + 1) + " строку: ");
//    str[i] = Console.ReadLine();
//}
//Regex regex = new Regex(@"\w{10}\w*");
//Regex r = new Regex("\b[a-zA-Z]");
//for (int i = 0; i < str.Length; i++)
//{
//    str[i] = regex.Replace(str[i], Convert.ToString(str[i][0]));
//}
//for (int j = 0; j < str.Length; j++) { Console.WriteLine(str[j]); }


//task2(c)
//string[] str = new string[5];
//for (int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine("Введите " + (i + 1) + " строку: ");
//    str[i] = Console.ReadLine();
//}
//Regex regex = new Regex(@"(ик\b)");
//for(int i = 0; i < str.Length; i++)
//{
//    str[i] = regex.Replace(str[i], "");
//}
//for(int j = 0; j < str.Length; j++)
//{
//    Console.WriteLine(str[j]+ " ");
//}


//task2(d)
//string[] str = new string[5];
//for (int i = 0; i < str.Length; i++)
//{
//    Console.WriteLine("Введите " + (i + 1) + " строку: ");
//    str[i] = Console.ReadLine();
//}
//string regex = (@"#[ABCDEF0-9]{6}");
//for (int i = 0; i < str.Length; i++)
//{
//    if (Regex.IsMatch(str[i], regex, RegexOptions.IgnoreCase))
//    {
//        Console.WriteLine("является цветов HTML");
//    }
//    else
//        Console.WriteLine("не является цветом HTML");
//}



//task2(e)
string str=Console.ReadLine();
Regex regex = new Regex(@"([a-fA-F0-9]){8}-\1{4}-\1{4}-\1{4}-\1{12}");
if (regex.IsMatch(str))
{
    Console.WriteLine("является строкой GUID");
}
else
    Console.WriteLine("не является строкой GUID");