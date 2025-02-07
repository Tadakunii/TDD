using Exercice03;

namespace Exercice03Test
{
    [TestClass]
    public sealed class RechercheVilleTest
    {
        private RechercheVille? _rechercheVille;

        [TestInitialize]
        public void SetUp()
        {
            _rechercheVille = new RechercheVille();
        }

        [TestCleanup]
        public void TearDown()
        {
            _rechercheVille = null;
        }
        [TestMethod]
        public void RechercheTextContainsLess2Character()
        {
            string recherche = "e";
            Assert.ThrowsException<NotFoundException>(() => {
                _rechercheVille.Rechercher(recherche);
            });
        }
    }
}
