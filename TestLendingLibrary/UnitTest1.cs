
using Phil_s_Lending_Library;


namespace TestLendingLibrary
{
    public class UnitTest1
    {
        [Fact]
        public void Test1AddBook()          //Add a Book to your Library
        {
            Library Test1Library = new Library();

            Test1Library.Add("good", "odai", "Qusai", 5);

            Assert.NotEmpty(Test1Library);

        }


        [Fact]
        public void Test2Borrowing()      //Borrowing an existing title returns the Book and remove it
        {
            Library Test2Library = new Library();

            Test2Library.Add("good", "odai", "1", 5);
            Test2Library.Add("no", "adam", "2", 5);
            Test2Library.Add("yse", "mousa", "3", 5);

            Book x = Test2Library.Borrow("no");

            Assert.Equal(2, Test2Library.Count);
            Assert.DoesNotContain(x, Test2Library);
        }



        [Fact]
        public void Test3BorrowingNull()      //Borrowing a missing title returns null
        {
            Library Test3Library = new Library();

            Test3Library.Add("good", "odai", "1", 5);
            Test3Library.Add("no", "adam", "2", 5);
            Test3Library.Add("yse", "mousa", "3", 5);

            Book test = Test3Library.Borrow("ABC");

            Assert.Equal(null, test);

        }

        [Fact]
        public void Test4returned()      //A returned book is once again in the Library

        {
            Library Test4Library = new Library();
            

        Test4Library.Add("good", "odai", "1", 5);
        Test4Library.Add("no", "adam", "2", 5);
        Test4Library.Add("yse", "mousa", "3", 5);

         Book test = Test4Library.Borrow("good");
          Test4Library.Return(test);

            Assert.Equal(3, Test4Library.Count);
            Assert.Contains(test, Test4Library);

        }


        [Fact]
        public void Test5Backpack()      //Pack and Unpack your Backpack
        {
            Backpack<string> Test5Library = new Backpack<string>();

            Test5Library.Pack("Odai");

            string unpack = Test5Library.Unpack(0);

            Assert.Equal(unpack, "Odai");
        }


    }
}