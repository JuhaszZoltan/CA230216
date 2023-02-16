//Tuple<string, int, int, int> tpl = new Tuple<string, int, int, int>("cica", 10, 20, 30);
//(int, int) _tpl = (20, 30);
//_tpl.Item1 = 40;
//Console.WriteLine(_tpl.Item1 + " " + _tpl.Item2);

(int X, int Y) pozition = (20, 30);

Console.WriteLine(pozition.X);

(string nev, int kor) ember = ("Zoli bácsi", 33);

(string nev, int kor) Adatok(List<object> asd)
{
    return ("Béla", 21);
}

List<int> asd = new List<int>{ 1, 2, 3, 3, 1, };


var ny = asd
    .GroupBy(x => x)
    .ToDictionary(x => x, x => x.Count())
    .Where(x => x.Value == 1)
    .OrderBy(x => x.Key)
    .First().Key.Key;

Console.WriteLine(ny);