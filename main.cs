using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {    
    Console.WriteLine(DoesPairSumExists(arr,sum));
  }

   static int[] arr = new []{1,2,3,4,5};
   static int sum = 9;
  
  private static bool DoesPairSumExists(int[] arr, int sum){

    HashSet<int> map = new HashSet<int>();
    
    for(int i = 0; i < arr.Length; i++) {
      map.Add(sum - arr[i]);
    }

    for(int j = 0; j < arr.Length; j++){
      if(map.Contains(arr[j]))
      {
        return true;
      }
    }

    return false;
  }
}



//[1,2,3,4,5] 9 : true
//[1,2,3,4,10] 9 : false