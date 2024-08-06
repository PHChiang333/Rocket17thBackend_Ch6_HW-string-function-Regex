using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace Rocket17thBackend_Ch6_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //字串題目

            //1. 輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。

            //Console.WriteLine("1. 輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin\n");

            //string name;

            //Console.Write("請輸入姓名= ");

            //name = Console.ReadLine();
            //Console.WriteLine("");

            //Console.WriteLine($"Hi~ {name}");

            //Console.ReadKey();

            //----------------------------------------------------------------

            //2. 請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。

            //Console.WriteLine("2. 請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。");

            //string target = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            //string guess;

            //Console.WriteLine("");

            //Console.Write("輸入一個字，看看有沒有在指定字串裡");
            //Console.Write("請輸入一個字= ");
            //guess = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("");
            //bool contains = target.Contains(guess);

            //if (contains)
            //{
            //    Console.WriteLine($"'{guess}' 包含在 '{target}'");
            //}
            //else
            //{
            //    Console.WriteLine($"'{guess}' 不包含在 '{target}'");
            //}

            //Console.ReadKey();

            //----------------------------------------------------------------

            //3.輸入一段字，輸出每個之間多一個 -，如輸入apple ，輸出a - p - p - l - e。

            //Console.WriteLine("3.輸入一段字，輸出每個之間多一個 -，如輸入apple ，輸出a - p - p - l - e。");

            //string str;
            //string insert_words;
            //string str_inserted;

            //Console.WriteLine("輸入一段字，輸出每個之間多一個 -");
            //Console.Write("文字 = ");

            //str = Convert.ToString(Console.ReadLine());

            //insert_words = "-";

            //str_inserted = str;

            //for (int i = 1; i < str_inserted.Length; i += (insert_words.Length+1))
            //{
            //    str_inserted = str_inserted.Insert(i, insert_words);

            //}

            //Console.WriteLine($"每個之間多一個 - : '{str_inserted}'");

            //Console.ReadKey();

            //----------------------------------------------------------------

            //4.輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。

            //Console.WriteLine("4.輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。");

            //string filename_full;
            //string filename_extention;

            //Console.Write("請輸入包含副檔名的檔名(例如 apple.jpg): ");
            //filename_full = Convert.ToString(Console.ReadLine());


            //filename_extention = filename_full.Substring(filename_full.LastIndexOf('.') + 1);

            //Console.WriteLine($"副檔名:{filename_extention}");

            //Console.ReadKey();

            //----------------------------------------------------------------

            //5.輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字。Length Substring()

            //Console.WriteLine("5.輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字。Length Substring()\n");

            //string word;
            //string word_extracted;

            //Console.WriteLine("請輸入單字: ");
            //word = Convert.ToString(Console.ReadLine());

            //if (word.Length <= 5)
            //{
            //    Console.WriteLine("字母數不足，請增加長度");
            //}
            //else
            //{
            //    word_extracted = word.Substring(0,3);
            //    Console.WriteLine($"單字的前3個字母: {word_extracted}");
            //}


            //Console.ReadKey();

            //----------------------------------------------------------------

            //6.輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。Replace()

            //Console.WriteLine("6.輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。Replace()\n");

            //string sentense;
            //string replace_word ="小明";

            //Console.Write("請輸入含有「我」的句子: ");
            //sentense = Convert.ToString(Console.ReadLine());

            //bool IsContains = sentense.Contains("我");

            //if (IsContains)
            //{
            //    sentense = sentense.Replace("我", replace_word);
            //    Console.WriteLine($"句子改寫後= '{sentense}'");
            //}
            //else
            //{
            //    Console.WriteLine("輸入的句子裡沒有「我」");
            //}

            //Console.ReadKey();
            //----------------------------------------------------------------

            //7.輸入一串字，顯示輸入幾個字。Length

            //Console.WriteLine("7.輸入一串字，顯示輸入幾個字。Length\n");

            //string words;
            //int LenOfWords;

            //Console.WriteLine("請輸入一串文字: ");
            //words = Convert.ToString(Console.ReadLine());

            //LenOfWords = words.Length;

            //Console.WriteLine($"\n文字長度為: {LenOfWords}");


            //Console.ReadKey();
            //----------------------------------------------------------------



            //----------------------------------------------------------------
            //字串補充練習題


            //1. 連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。

            //Console.WriteLine("1. 連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。\n");

            //string[] words = new string[10];

            //Console.WriteLine("請輸入10組字");

            //for (int i = 0; i < words.Length; i++) {
            //    words[i] = Convert.ToString(Console.ReadLine());
            //}

            //int count_input=0;

            //for (int i = 0; i < words.Length; i++) { 
            //    if (words[i] != "")
            //    {
            //        count_input++;
            //    }
            //}

            //if (count_input > 0)
            //{
            //    Console.WriteLine("輸入過\n");
            //}
            //else {
            //    Console.WriteLine("沒出現過\n");
            //}

            //Console.ReadKey();
            //----------------------------------------------------------------


            //2. 用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出 Fifa fIfa fiFa fifA

            //Console.WriteLine("2. 用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出 Fifa fIfa fiFa fifA\n");

            //string word;

            //Console.WriteLine("請輸入英文單字: ");
            //word = Convert.ToString(Console.ReadLine());

            //Console.WriteLine();

            ////在n插入大寫
            ////再於n+1處移除小寫來維持長度

            //for (int i = 0; i < word.Length; i++) { 
            //    string lower = word.ToLower();
            //    lower = lower.Insert(i, word[i].ToString().ToUpper()); //插入大寫字母
            //    lower = lower.Remove(i+1,1);//移除小寫字母
            //    Console.WriteLine($"{lower}");
            //}

            //Console.ReadKey();
            //----------------------------------------------------------------

            //3. 輸入時間，顯示幾時幾分，例如輸入11: 30，輸出11點30分。

            //Console.WriteLine("3. 輸入時間，顯示幾時幾分，例如輸入11: 30，輸出11點30分。\n");

            //string time, time_chinese;

            //Console.WriteLine("請輸入時間(格式:HH:MM) :");
            //time = Convert.ToString(Console.ReadLine());

            //string[] time_split = new string[2];
            //time_split=time.Split(':');

            //time_chinese = string.Format("{0}點{1}分", time_split[0], time_split[1]);

            //Console.WriteLine(time_chinese);

            //Console.ReadKey();
            //----------------------------------------------------------------

            //4. 輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出<ul>    < li > Justin<li> < li > Amy<li> < li > David<li> </ ul >

            //Console.WriteLine("4. 輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出<ul>    < li > Justin<li> < li > Amy<li> < li > David<li> </ ul >\n");

            //Console.WriteLine("請輸入清單項目，以 , 分隔");
            //Console.WriteLine("例如 Justin,Amy,David ");
            //Console.Write("輸入區: ");

            //string list_string = Convert.ToString(Console.ReadLine());

            //string[] list = list_string.Split(',');

            //string output;

            //output = "<ul>\n";

            //foreach( string  item in list)
            //{
            //    output += $"\t <li> {item} <li>\n";
            //}

            //output += "</ul>\n";

            //Console.WriteLine(output);

            //Console.ReadKey();
            //----------------------------------------------------------------

            //5.輸入5處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87

            //Console.WriteLine("5.輸入5處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87\n");

            //Console.WriteLine("請輸入5個數字，以 space 分隔，計算總和");
            //Console.WriteLine("例如 11 19 12 25 1 7 12 ");
            //Console.Write("輸入區: ");

            //string numlist_string = Convert.ToString(Console.ReadLine());

            //string[] numlist = numlist_string.Split(' ');

            //double sum = 0;

            //foreach (string num in numlist)
            //{
            //    sum += Convert.ToDouble(num);
            //}

            //Console.WriteLine($"總和是{sum}\n");

            //Console.ReadKey();

            //----------------------------------------------------------------

            //6.輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ

            //Console.WriteLine("6.輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ\n");

            //string words, words_reverse="";

            //Console.Write("請輸入一串文字: ");
            //words = Convert.ToString(Console.ReadLine());

            //char[] chars = words.ToCharArray();

            //Array.Reverse(chars);

            //foreach (char c in chars)
            //{
            //    words_reverse += Convert.ToString(c);
            //}

            //Console.WriteLine($"文字倒著輸出: {words_reverse}");

            //Console.ReadKey();
            //----------------------------------------------------------------
            //----------------------------------------------------------------
            //----------------------------------------------------------------
            //----------------------------------------------------------------
            //----------------------------------------------------------------
            //function 

            //1.寫一個function 可以把一般對話框的文字轉成HTML。> 轉成 & gt; < 轉成 & lt; \r\n 轉成<br> | 轉成 & brvbar; 空白 轉成 &nbsp;

            //Console.WriteLine("1. 寫一個function 可以把一般對話框的文字轉成HTML");

            //string str;

            //str = "___>___轉成___&gt;___" + "\n" +
            //    "___<___轉成___&lt;___" + "\n" +
            //    "___\r\n___轉成___<br>___" + "\n" +
            //    "___|___轉成___&brvbar;___" + "\n" +
            //    "___ ___轉成___&nbsp;___";

            //Console.WriteLine("未經轉換:");
            //Console.WriteLine(str);

            //string html = ConvertToHTML(str);

            //Console.WriteLine("經轉換:");
            //Console.WriteLine(html);

            //Console.ReadKey();
            //----------------------------------------------------------------
            //2.寫一個function，回傳輸入的值是否數字

            //Console.WriteLine("2.寫一個function，回傳輸入的值是否數字");

            //string inputValue;

            //Console.WriteLine("請輸入一個值，判斷是否為數字 ");
            //Console.Write("請輸入: ");
            //inputValue = Console.ReadLine();

            //Console.WriteLine($"輸入值是否為數字: {IsNumber(inputValue)}");

            //Console.ReadKey();
            //----------------------------------------------------------------
            //3.寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式

            //string EmailAdress;

            //Console.WriteLine("請輸入Email: ");
            //Console.WriteLine("格式舉例: _____@____._____");
            //Console.Write("請輸入: ");

            //EmailAdress = Console.ReadLine();

            //Console.WriteLine($"是否符合手機格式: {IsEmail(EmailAdress)}");

            //Console.ReadKey();
            //----------------------------------------------------------------

            //4.寫一個function，回傳輸入的值是否符合手機格式

            //string MobileNumber;

            //Console.WriteLine("請輸入手機: ");
            //Console.WriteLine("格式: 09XX-XXXXXX");
            //Console.Write("請輸入: ");

            //MobileNumber = Console.ReadLine();

            //Console.WriteLine($"是否符合手機格式: {IsMobile(MobileNumber)}");

            //Console.ReadKey();
            //----------------------------------------------------------------

            //5.寫一個function，回傳輸入的值是否符合身分證字號格式

            //Console.WriteLine("5.寫一個function，回傳輸入的值是否符合身分證字號格式");

            //string TaiwanID;

            //Console.WriteLine("請輸入台灣身分證字號: ");
            //Console.WriteLine("格式: 1個英文字母+9個數字");
            //Console.Write("請輸入: ");

            //TaiwanID = Console.ReadLine();

            //Console.WriteLine($"是否為台灣身分證字號: {IsTaiwanID(TaiwanID)}");

            //Console.ReadKey();
            //----------------------------------------------------------------
            //6.寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點

            //Console.WriteLine("6.寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點");

            //string words;
            //int n;

            //Console.Write("請輸入要顯示多少字數:");
            //n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("請輸入文字:");
            //words = Convert.ToString(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine($"經過處理後的文字: {wordHide(n,words)}");

            //Console.ReadKey();
            //----------------------------------------------------------------
            //7.寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式

            //Console.WriteLine("7.寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式");

            //string date;

            //Console.WriteLine("請輸入西曆日期，格式為 YYYY-MM-DD");
            //Console.Write("請輸入日期: ");
            //date = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("轉換成民國年.月.日格式如下:");
            //Console.WriteLine(ConvertToTWNCalendar(date));


            //Console.ReadKey();
            //----------------------------------------------------------------
            // 8.寫一個function，輸入一個日期，把把該日期轉成民國XX年XX月XX日 星期X 格式

            //Console.WriteLine("8.寫一個function，輸入一個日期，把把該日期轉成民國XX年XX月XX日 星期X 格式");

            //string date;

            //Console.WriteLine("請輸入西曆日期，格式為 YYYY-MM-DD");
            //Console.Write("請輸入日期: ");
            //date = Convert.ToString(Console.ReadLine());

            //Console.WriteLine("轉換成民國XX年XX月XX日 星期X 格式如下:");
            //Console.WriteLine(ConvertToTWNCalendarWeekday(date));



            //Console.ReadKey();
            //----------------------------------------------------------------
            //9.寫一個function，回傳輸入的年是否閏年

            //Console.WriteLine("9.寫一個function，回傳輸入的年是否閏年");

            //int year;

            //Console.Write("請輸入西元年:");
            //year = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"西元{year}年是否為閏年: {IsLeapYear(year)}");

            //Console.ReadKey();
            //----------------------------------------------------------------
            // 10.寫一個function，輸入手機號碼，回傳今天運勢(手機運勢算法：用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。)

            //Console.WriteLine(" 10.寫一個function，輸入手機號碼，回傳今天運勢(手機運勢算法：用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。)");

            //string MobileNumber;

            //Console.WriteLine("請輸入手機: ");
            //Console.WriteLine("格式: 09XX-XXXXXX");
            //Console.Write("請輸入: ");

            //MobileNumber = Console.ReadLine();

            //Console.WriteLine("手機運是如下:");

            //Console.WriteLine(MobileLuck(MobileNumber));


            //Console.ReadKey();
            ////----------------------------------------------------------------

        }



        //-----------------------------------------------
        //1.寫一個function 可以把一般對話框的文字轉成HTML。
        //> 轉成 &gt;
        //< 轉成 &lt;
        //\r\n 轉成<br>
        //| 轉成 & brvbar;
        //空白 轉成 &nbsp;


        public static string ConvertToHTML(string html)
        {

            html = html.Replace(">", "$gt;");
            html = html.Replace("<", "&lt;");
            html = html.Replace("\r\n", "<br>");
            html = html.Replace("|", "&brvbar;");
            html = html.Replace(" ", "&nbsp;");

            return html;
        }

        //-----------------------------------------------
        //2.寫一個function，回傳輸入的值是否數字

        public static bool IsNumber(string input)
        {

            bool result = double.TryParse(input, out double inputNumber);

            if (result)
            {
                //Console.WriteLine(inputNumber); //轉換成功的數字  for test
                return true;
            }
            else
            {
                return false;
            }
        }

        //-----------------------------------------------
        //3.寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式

        public static bool IsEmail(string input)
        {
            bool result = false;

            string pattern = @"^([^\.][\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$";

            bool isMatch = Regex.IsMatch(input, pattern);

            if (isMatch)
            {
                Console.WriteLine("格式正確");
                result = true;
                return result;
            }
            else
            {
                Console.WriteLine("格式錯誤");
                return result;
            }
        }
        //-----------------------------------------------
        //4.寫一個function，回傳輸入的值是否符合手機格式

        public static bool IsMobile(string input)
        {
            bool result = false;

            string pattern = @"^[0][9]\d{2}-\d{6}$";

            //確認長度
            if (input.Length != 11)
            {
                Console.WriteLine("輸入長度錯誤");
                return result;
            }
            else
            {
                bool isMatch = Regex.IsMatch(input, pattern);

                if (isMatch)
                {
                    Console.WriteLine("格式正確");
                    result = true;
                    return result;
                }
                else
                {
                    Console.WriteLine("長度正確，但格式錯誤");
                    return result;
                }
            }

        }
        //-----------------------------------------------
        //5.寫一個function，回傳輸入的值是否符合身分證字號格式

        public static bool IsTaiwanID(string input)
        {

            bool result = false;

            string pattern = @"^[A-Z][12]\d{8}$";

            //確認長度
            if (input.Length != 10)
            {
                Console.WriteLine("輸入長度錯誤");
                return result;
            }
            else
            {
                bool isMatch = Regex.IsMatch(input, pattern);

                if (isMatch)
                {
                    Console.WriteLine("格式正確");
                    result = true;
                    return result;
                }
                else
                {
                    Console.WriteLine("長度正確，但格式錯誤");
                    return result;
                }

                //確認格式 

            }
        }

        //-----------------------------------------------
        //6.寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點

        public static string wordHide(int n, string input)
        {
            if (input.Length < n)
            {
                return input;
            }
            else
            {
                return $"{input.Substring(0, n)}...";
            }
        }
        //-----------------------------------------------
        //7.寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式

        public static string ConvertToTWNCalendar(string date)
        {
            string pattern = @"^(\d{4})-(\d{2})-(\d{2})$";

            bool IsMatch = Regex.IsMatch(date, pattern);

            if (IsMatch)
            {
                int year = Convert.ToInt32(date.Substring(0, 4));
                //Console.WriteLine($"西元{year}年");  //測試用
                int month = Convert.ToInt32(date.Substring(5, 2));
                //Console.WriteLine($"{month}年");  //測試用
                int day = Convert.ToInt32(date.Substring(8, 2));
                //Console.WriteLine($"{day}年");  //測試用

                return $"民國{year - 1911}年{month}月{day}日";
            }
            else
            {
                return "日期格式錯誤";
            }
        }


        //-----------------------------------------------
        // 8.寫一個function，輸入一個日期，把把該日期轉成民國XX年XX月XX日 星期X 格式

        public static string ConvertToTWNCalendarWeekday(string date)
        {
            string pattern = @"^(\d{4})-(\d{2})-(\d{2})$";

            bool IsMatch = Regex.IsMatch(date, pattern);

            if (IsMatch)
            {
                int year = Convert.ToInt32(date.Substring(0, 4));
                //Console.WriteLine($"西元{year}年");  //測試用
                int month = Convert.ToInt32(date.Substring(5, 2));
                //Console.WriteLine($"{month}月");  //測試用
                int day = Convert.ToInt32(date.Substring(8, 2));
                //Console.WriteLine($"{day}日");  //測試用

                //weekday計算: 用蔡勒公式 Zellers Kongruenz , Common simplification for the Gregorian calendar 計算星期幾
                //reference: wiki https://en.wikipedia.org/wiki/Zeller%27s_congruence
                if (month < 3)
                {
                    month += 12;
                    year -= 1;
                }

                int weekday = (day + 13 * (month + 1) / 5 + year + year / 4 - year / 100 + year / 400) % 7;
                //蔡勒公式的weekday: h is the day of the week (0 = Saturday, 1 = Sunday, 2 = Monday, ..., 6 = Friday) 
                string[] weekdays = { "六", "日", "一", "二", "三", "四", "五" };
                string weekdayFromDate = weekdays[weekday];

                return $"民國{year - 1911}年{month}月{day}日 星期{weekdayFromDate}";
            }
            else
            {
                return "日期格式錯誤";
            }
        }
        //-----------------------------------------------
        // 9.寫一個function，回傳輸入的年是否閏年

        public static bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if ((year % 100) == 0)
                {
                    if ((year % 400 == 0))
                    {
                        return true; //是400的倍數
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        //-----------------------------------------------
        // 10.寫一個function，輸入手機號碼，回傳今天運勢(手機運勢算法：用你的手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。)

        public static string MobileLuck(string input)
        {
            string pattern = @"^[0][9]\d{2}-\d{6}$";
            if (Regex.IsMatch(input, pattern))
            {
                double mobileNumLast4 = Convert.ToInt32(input.Substring(7, 4));
                Console.WriteLine($"您的手機是{input},後4碼為{mobileNumLast4}");

                double luckyNumber = Math.Floor(((mobileNumLast4 / 80) - Math.Floor(mobileNumLast4 / 80)) * 80);
                //luckyNumber算完會出現小數，無條件捨去取整數
                return $"今年運勢數字為: {luckyNumber}";
            }
            else
            {
                return "手機格式錯誤";
            }
        }
        //-----------------------------------------------
    }
}
