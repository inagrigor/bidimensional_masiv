// crearea string C#
// (1) string str = "Hello World!"; //присвоение строкового литерала,  все что в ""
// //str[1] = 'E';
// Console.WriteLine(str[1]);
// Console.WriteLine("Hello, World!");

// (2) char[] ch_array = {'w', 'o', 'r', 'l', 'd'};
// string s2 = new String(сh_array);//создаем строку из символьного массива, string - тип данных, 
// String - конструктор, метод по созданию строки в данном случай

// (3) string s3 = new String('a', 6); cоздание строк из повторяющихся символовб 
// результат строка - "aaaaaa"
//  string GetLettersFromStr(string s)
//  {
//     string letters = "";
//     foreach (char e in s)
//     {
//         if(char.IsAsciiLetter(e) == true)
//         {
//             letters = letters + e;// + применяется к строковому типу данных, осуществляется конкатенация 
//         }
//     }
//     return letters;
//  }
//  string str = Console.ReadLine();
//  string letters = GetLettersFromStr(str);
//  Console.WriteLine(letters);