using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string recherche) : base(String.Format("Une exception est levé de type NotFoundException. Valeur : {0}", recherche)) 
        { }
    
        
    }
}
