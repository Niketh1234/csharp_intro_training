// string s = Console.ReadLine() ?? "";
// string[] words = s.Split();
// foreach(var item in words)
// {
//     Console.WriteLine(item);
// }
     

     
int [,]marks2 = new int[2,2];
marks2[0,0] = 10;
marks2[0,1] = 20;
marks2[1,0] = 30;
marks2[1,1] = 40;
foreach(int m in marks2){
    Console.Write(m);
}
Console.WriteLine();
Console.WriteLine("*****************************");


int [][]marks1 = new int[2][];
marks1[0] = new int[2];
marks1[1] = new int[2];
marks1[0][0] = 10;
marks1[0][1] = 20;
marks1[1][0] = 30;
marks1[1][1] = 40;
foreach(int []m in marks1){
    for(int i = 0;i<m.Length;i++){
      Console.Write(m[i]);
    }
    Console.WriteLine();
}


int [][]marks  = {new int[] {1,2}, new int[]{3,4}};