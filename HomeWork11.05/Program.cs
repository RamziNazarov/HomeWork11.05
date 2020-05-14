using System;
using System.Linq;

namespace HomeWork11._05
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world, i am Ramzi";
            var a = string.Join("",str.Select(x=>(x=='e')?'2':(x=='o')?'4':(x=='i')?'3':(x=='u')?'5':(x=='a')?'1':x));
            Console.WriteLine(a);
            var b = string.Join("",a.Select(x => (x == '1') ? 'a' : (x == '2') ? 'e' : (x == '3') ? 'i' : (x == '4') ? 'o' : (x == '5') ? 'u' : x));
            Console.WriteLine(b);
            str = "camelTextTadsfTasdSfadFasdf";
            string s = string.Join("",str.Select(x => (x.ToString() == x.ToString().ToUpper()) ?" " + x.ToString() : x.ToString()));
            Console.WriteLine(s);
            str = "asdf2das2asd412asd-20o12123p";
            int d;
            string result = (str.Contains('*')) ? (int.Parse(string.Join("", str.TakeWhile(x => x != '*').Where(x => int.TryParse(x.ToString(), out d)).ToArray())) * int.Parse(string.Join("", str.SkipWhile(x => x != '*').Where(x => int.TryParse(x.ToString(), out d)).ToArray()))).ToString() :
                (str.Contains('+')) ? (int.Parse(string.Join("", str.TakeWhile(x => x != '+').Where(x => int.TryParse(x.ToString(), out d)).ToArray())) + int.Parse(string.Join("", str.SkipWhile(x => x != '+').Where(x => int.TryParse(x.ToString(), out d)).ToArray()))).ToString() :
                (str.Contains('-')) ? (int.Parse(string.Join("", str.TakeWhile(x => x != '-').Where(x => int.TryParse(x.ToString(), out d)).ToArray())) - int.Parse(string.Join("", str.SkipWhile(x => x != '-').Where(x => int.TryParse(x.ToString(), out d)).ToArray()))).ToString() :
                Math.Round((decimal.Parse(string.Join("", str.TakeWhile(x => x != '/').Where(x => int.TryParse(x.ToString(), out d)).ToArray())) / decimal.Parse(string.Join("", str.SkipWhile(x => x != '/').Where(x => int.TryParse(x.ToString(), out d)).ToArray()))),0).ToString();
                Console.WriteLine(result);
            //короче
            decimal aa = decimal.Parse(string.Join("", str.TakeWhile(x => x != '*' && x != '-' && x != '+' && x !='/').Where(x => int.TryParse(x.ToString(), out d)).ToArray()));
            decimal bb = decimal.Parse(string.Join("", str.SkipWhile(x => x != '*' && x != '-' && x != '+' && x != '/').Where(x => int.TryParse(x.ToString(), out d)).ToArray()));
            string res = (str.Contains('*')) ? (aa * bb).ToString() : (str.Contains('+')) ? (aa + bb).ToString() : (str.Contains('-')) ? (aa - bb).ToString() : Math.Round((aa/bb),0).ToString();
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
