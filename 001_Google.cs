using System;
using System.Collections.Generic;

public class P001_Google{
    public static void Main(){
        var lst = new List<int>(){10,15,3,8};
        int k = 17;
        var ans = sumCheck(lst, k);
        Console.WriteLine(ans);
    }

    public static bool sumCheck(List<int> L, int k){
         HashSet<int> SeenNumbers = new HashSet<int>();
         foreach(var x in L){
             if(SeenNumbers.Contains(k-x)){return true;}
            SeenNumbers.Add(x);
         }
         return false;
    }
}