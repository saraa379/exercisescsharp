using NUnit.Framework;
using ConsoleApp32;

namespace Tests
{
    class Tests
    {
        
		[Test]
		public void TestThatSortingWorksOnEmptyLista(){
			var sortedList = Program.Sort(new int[0]);
			Assert.AreEqual(0, sortedList.Length);
	    }
		
		[Test]
		public void TestThatSortedListHasSameLengthAsUnsortedList(){
			var unsortedList = new int[]{1, 4, 5, 1, 2, 3};
			var sortedList = Program.Sort(unsortedList);
			int unsortedListLength = 6;
			int sortedListLength = sortedList.Length;
			Assert.AreEqual(unsortedListLength, sortedListLength);
	    }
		
		[Test]
		public void TestThatSortedListIsActuallySorted(){
			var unsortedList = new int[]{1, 4, 5, 1, 2, 3};
			var expected = new[] {1, 1, 2, 3, 4, 5};
			var sortedList = Program.Sort(unsortedList);
			
			for(int i = 0; i < sortedList.Length; i++){
				if(sortedList[i] != expected[i]){
					Assert.Fail();
					return;
				}
			}
			Assert.Pass();
	    }
    }
}
]                     