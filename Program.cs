// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//  void FindCube(int num)
//  {
//      int  current=1;
//      while (current<=num)
//      {
//          Console.WriteLine($"{current} --> {current*current*current}");
//          current++;
//      }
//  }
// Console.WriteLine("Input integer number >1 ");
// int num = Convert.ToInt32(Console.ReadLine());
// FindCube(num);


// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double FindDistance (double xa, double ya, double xb, double yb, double xz, double yz)
//  {
//      return Math.Round(Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb-ya,2) + Math.Pow(xz-yz,2) ),2);
//  }

//  Console.WriteLine("Input coordinate X for first point:");
//  double xa = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("Input coordinate Y for first point:");
//  double ya = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("Input coordinate X for second point:");
//  double xb = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("Input coordinate Y for second point:");
//  double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate X for third point:");
//  double xz = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine("Input coordinate Y for third point:");
//  double yz = Convert.ToDouble(Console.ReadLine());
//  Console.WriteLine($"Distance between our points -> {FindDistance(xa,ya,xb,yb,xz,yz)}");

// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 12821 -> да

//  void Palindrom (int num)
//   {
//       int ed = num%10;
//       int handhousandth = num/10000;
//       int tenthousand = ((num%100)-ed)/10;
//       int des = (num/1000)%10;
//       if (ed == handhousandth && des == tenthousand)

//       {
//          Console.WriteLine ("Palindrom {num}");
//          }
//       else
//       {
//          Console.WriteLine ("It is not Palindrom");
//          }     
//   }
//  Console.WriteLine ("Input five-digit number");
//  int num = Convert.ToInt32(Console.ReadLine());
//  Palindrom (num);
