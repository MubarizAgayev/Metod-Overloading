// See https://aka.ms/new-console-template for more information
//int a = 7;
//int b = a;
//b = 9;
//Console.WriteLine(a);
//Console.WriteLine(b);


//int[] arr = { 3, 6, 8, 9 };
//int[] arr2= arr;
//arr2[2] = 20;
//Console.WriteLine(arr[2]);
//Console.WriteLine(arr2[2]);


//int n = 7;
//Test(n);
//Console.WriteLine(n);
//static void Test(int n)
//{
//    n = 30;
//    Console.WriteLine(n);
//}


//int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
//Test2(arr);
//Console.WriteLine(arr[0]);
//    static void Test2(int[] arr)
//{
//    arr[0] = 45;
//    Console.WriteLine(arr[0]);
//}



//int n = 7;
//Test(ref n);
//Console.WriteLine(n);
//static void Test(ref int n)
//{
//    n = 56;
//    Console.WriteLine(n);
//}



//int n;
//Test(out n);
//Console.WriteLine(n);
//static void Test(out int n)
//{
//    n = 78;
//    Console.WriteLine(n);
//}


//string name = "Mubariz";
//    string name1=name;
//name1 = "Ceyhun";
//Console.WriteLine(name);
//Console.WriteLine(name1);





//string address= "Nesimi";
//int result = address.Length;
//Console.WriteLine(result);
//Console.WriteLine(address.StartsWith("N"));
//Console.WriteLine(address.EndsWith("i"));
//if (address.EndsWith("i"))
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}
//if(address.Contains("r"))
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}


//var res = address.Split(",");
//foreach(var item in res)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine(address.ToLower());

//address = "Mubariz";
//Console.WriteLine(address.ToUpper());

//string address = "roya";
//var letter = address[0].ToString().ToUpper();
//var arr = address.ToCharArray();
//arr[0] = char.Parse(letter);
//string result = "";
//foreach(var item in arr)
//{
//    result += item;
//}
//Console.WriteLine(result);


//string name="Mubariz";
//Console.WriteLine(name.ToUpper());
//Console.WriteLine(name.Substring(1));
//Console.WriteLine(name.Trim());
//if (!string.IsNullOrEmpty(name))
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}



// parametr olaraq string  qebul eden metod yazmalisiniz.Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin.

//Changing("Mubariz");
//static void Changing(string name)
//{
//    string result = "";
//    for(int i = name.Length - 1; i >= 0; i--)
//    {
//        result += name[i];
//    }
//    Console.WriteLine(result);
//}