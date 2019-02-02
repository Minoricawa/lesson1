using System;

class test{
	static void Main(string[] args){
		Console.WriteLine ("はろー!!");
		 string a,b,c;
		Console.WriteLine ("あなたのお名前を教えてほしいな");
		 a = Console.ReadLine();
		Console.WriteLine ("{0}さんって言うんだ！よろしくね＾＾", a);
		Console.WriteLine ("血液型は何型？");
		 b = Console.ReadLine();
		Console.WriteLine ("{0}かぁ～。確かにっぽいね",b);
		Console.WriteLine ("何色が好き？");
		 c = Console.ReadLine();
		Console.WriteLine ("{0}が好きなのか！意外！",c);
		Console.WriteLine ("血液型は{0}の{1}が好きな{2}さんだね！覚えた！",b,c,a);
	}
}