namespace ElectricFox.SquaresSolver.Tests
{
    public class Tests
    {
        private Solver solver;

        private char[,] matrix = 
        {
            { 'p', 'e', 'm', 'o' },
            { 'r', 'r', 'r', 'b' },
            { 'g', 's', 'i', 'g' },
            { 't', 'e', 'd', 'a' }
        };

        [SetUp]
        public void Setup()
        {
            solver = new Solver(matrix);
        }

        [Test]
        [TestCase("remorse")]
        [TestCase("borers")]
        [TestCase("priest")]
        [TestCase("aides")]
        [TestCase("bidet")]
        [TestCase("more")]
        public void TestValidWords(string word)
        {
            Assert.IsTrue(solver.IsValidWord(word));
        }



        [Test]
        [TestCase("foobar")]
        [TestCase("yikes")]
        [TestCase("bromide")]
        [TestCase("gider")]
        [TestCase("skin")]
        [TestCase("illumination")]
        public void TestInvalidWords(string word)
        {
            Assert.IsFalse(solver.IsValidWord(word));
        }

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase("\t")]
        [TestCase("\r\n")]
        public void TestEdgeCases(string word)
        {
            Assert.IsFalse(solver.IsValidWord(word));
        }
    }
}