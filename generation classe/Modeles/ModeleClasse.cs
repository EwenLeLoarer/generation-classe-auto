using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generation_classe.Modeles
{
    public class ModeleClasse
    {
        #region Attribut
        public List<ModeleClasse> CollClasse = new List<ModeleClasse>();
        public List<List<string>> CollAttribut;
        #endregion

        #region Constructeur
        public ModeleClasse()
        {
            CollAttribut = new List<List<string>>();
            CollClasse.Add(this);
        }
        #endregion

        #region getter/setter
        #endregion

        #region Methodes
        #endregion
    }
}
