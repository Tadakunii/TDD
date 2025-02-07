using Exercice01;
using Exercice02;

namespace Exercice02Test
{
    [TestClass]
    public sealed class FibTest
    {
        private Fib? _fibTest;


        [TestCleanup]
        public void TearDown()
        {
            _fibTest = null;
        }

        [TestMethod]
        public void WhenGetFibIsNotNull()
        {
            _fibTest = new Fib(1);
            List<int> listResult = new List<int>();

            listResult = _fibTest.GetFibSeries();
            Assert.IsNotNull(listResult[0]);
        }
        [TestMethod]
        public void WhenRangeIs1AndContains0()
        {
            _fibTest = new Fib(1);
            List<int> listResult = new List<int>();
            List<int> listCompar = new List<int>() { 0 };

            listResult = _fibTest.GetFibSeries();
            CollectionAssert.AreEqual(listCompar, listResult);
        }
        [TestMethod]
        public void WhenRangeIs6AndContain3()
        {
            _fibTest = new Fib(6);
            List<int> listResult = new List<int>();
            listResult = _fibTest.GetFibSeries();
            Assert.IsTrue(listResult.Contains(3));
        }
        [TestMethod]
        public void WhenRangeIs6AndContain6Element()
        {
            _fibTest = new Fib(6);
            List<int> listResult = new List<int>();
            listResult = _fibTest.GetFibSeries();
            Assert.AreEqual(6,listResult.Count);
        }
        [TestMethod]
        public void WhenRangeIs6AndDontContain4()
        {
            _fibTest = new Fib(6);
            List<int> listResult = new List<int>();
            listResult = _fibTest.GetFibSeries();
            Assert.IsFalse(listResult.Contains(4));
        }
        [TestMethod]
        public void WhenRangeIs6AndOrderAsc()
        {
            _fibTest = new Fib(6);
            List<int> listResult = new List<int>();
            listResult = _fibTest.GetFibSeries();
            List<int> ListOrderAsc = listResult.OrderBy(x => x).ToList();
            CollectionAssert.AreEqual(ListOrderAsc, listResult);
        }
    }
}
