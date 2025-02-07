using Exercice01;

namespace Exercice01Test
{
    [TestClass]
    public sealed class GradingCalculatorTest
    {

        private GradingCalculator _gradingCalculator;

        [TestInitialize] 
        public void SetUp()
        {
            _gradingCalculator = new GradingCalculator(); 
        }

        [TestCleanup]  // s'exécutera APRES CHAQUE TEST
        public void TearDown()
        {
            _gradingCalculator = null;
        }

        [TestMethod]
        public void WhenScoreIs95_Presence90_Then_A()
        {
            _gradingCalculator.Score = 95;
            _gradingCalculator.AttendancePercentage = 90;
            var result = _gradingCalculator.GetGrade();

            Assert.AreEqual('A', result);
        }

        [TestMethod]
        public void WhenScoreIs85_Presence90_Then_B()
        {
            _gradingCalculator.Score = 85;
            _gradingCalculator.AttendancePercentage = 90;
            var result = _gradingCalculator.GetGrade();

            Assert.AreEqual('B', result);
        }

        [TestMethod]
        public void WhenScoreIs65_Presence90_Then_C()
        {
            _gradingCalculator.Score = 65;
            _gradingCalculator.AttendancePercentage = 90;
            var result = _gradingCalculator.GetGrade();

            Assert.AreEqual('C', result);
        }

        [TestMethod]
        public void WhenScoreIs95_Presence60_Then_B()
        {
            _gradingCalculator.Score = 95;
            _gradingCalculator.AttendancePercentage = 65;
            var result = _gradingCalculator.GetGrade();

            Assert.AreEqual('B', result);
        }
        [TestMethod]
        public void WhenScoreIs95_Presence55_Then_F()
        {
            _gradingCalculator.Score = 95;
            _gradingCalculator.AttendancePercentage = 55;
            var result = _gradingCalculator.GetGrade();

            Assert.AreEqual('F', result);
        }
        [TestMethod]
        public void WhenScoreIs65_Presence55_Then_F()
        {
            _gradingCalculator.Score = 65;
            _gradingCalculator.AttendancePercentage = 55;
            var result = _gradingCalculator.GetGrade();

            Assert.AreEqual('F', result);
        }
        [TestMethod]
        public void WhenScoreIs50_Presence55_Then_F()
        {
            _gradingCalculator.Score = 50;
            _gradingCalculator.AttendancePercentage = 90;
            var result = _gradingCalculator.GetGrade();

            Assert.AreEqual('F', result);
        }
    }
}
