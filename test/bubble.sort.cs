using System;

namespace Exercises108
{
    public class Exercises108
    {
        static void Main()
        {
            var l = new int[]{5, 6, 7, 2, 3, 6, 4};
			var sortedLista = Sort(1);
			
			for(int i = 0; i < sorteradLista.Length; i++){
				Sort(sortedLista);
			}
			
			Console.WriteLine(sorteradLista);
			Console.ReadLine();

        }
		
		static int[] Sort(int[] list){
			bool swappedAny = false;
			while(swappedAny){
				swappedAny = false;
				for(int i = 0; i < list.Length - 1; i++){
					if(list[i] > list[i+1]){
						var temp = list[i];
						list[i] = list[i+1];
						list[i+1] = temp;
						swappedAny = true;
					}
				}
		    }
			//list[3] = 0;
			//return new int[1];  //list
			return list;
			
		}
		
		static static int[] Sort(int[] v){
			
			return new int[v.Length];
			
		}
    }
}
]