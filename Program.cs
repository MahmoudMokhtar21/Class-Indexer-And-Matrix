// See https://aka.ms/new-console-template for more information
using ConsoleApp7;
//indexers
Console.WriteLine("Hello, World!");
var ip = new IP(122, 133, 12, 44);
var ip1 = new IP("332.233.662.474");
var ip2 = ip[2];
Console.WriteLine($"Address : {ip.address}");
Console.WriteLine($"Address : {ip1.address}");
Console.WriteLine($"Address : {ip2}");

// soduko array
int[,] inputs = new int[,]{
                 {8,3,5,4,1,6,9,2,7},
                 {2,9,6,8,5,7,4,3,1},
                 {4,1,7,2,9,3,6,5,8},
                 {5,6,9,1,3,4,7,8,2},
                 {1,2,3,6,7,8,5,4,9},
                 {7,4,8,5,2,9,1,6,3},
                 {6,5,2,7,8,1,3,9,4},
                 {9,8,1,3,4,5,2,7,6},
                 {3,7,4,9,6,2,8,1,5}
               };


Console.WriteLine(inputs[5, 5]);
inputs[1, 1] = 4;
Console.WriteLine(inputs[1, 1]);
// var soduko = new Soduko(inputs);
// Console.WriteLine(soduko[3,3]);
// soduko[5, 5] = 6;
// Console.WriteLine(soduko[5, 5]);
