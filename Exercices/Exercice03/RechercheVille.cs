using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    public class RechercheVille
    {
        private List<String> _villes = new List<String>()
        {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
        };

        public List<String> Rechercher(String recherche)
        {
            if(recherche.Length <2)
            {
                throw new NotImplementedException();
            }
            throw new NotImplementedException();
        }
    }
}
