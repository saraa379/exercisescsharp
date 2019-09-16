using NUnit.Framework;
using ConsoleApp2;

namespace Tests
{
    class Tests
    {
        
		[Test]
		public void TestNeightbours_HappyDays(){
			var list = new int[]{2, 1, 3, 4};
      int pos = 1;
			var result = Program.IsGreaterThanNeighbours(list, pos);
      Assert.IsFalse(result);
	  }

		[Test]
		public void TestNeighbours_ActualIsGreater_HappyDays(){
			var unsortedList = new int[]{2, 1, 3, 4, 3};
			int pos = 1;
      var result = Program.IsGreaterThanNeighbours(list, pos)
			Assert.IsFalse(result);
	    }

		[Test]
		public void TestNeighboursHasNoNeighBours(){
			var list = new int[]{2, 1};
			var pos = 0;
      var result = Program.IsGreaterThanNeighbours(list, pos)
			Assert.IsFalse(result);


    }
}
]
