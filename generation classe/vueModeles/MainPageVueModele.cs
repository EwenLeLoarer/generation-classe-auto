using generation_classe.Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generation_classe.vueModeles
{
    public class MainPageVueModele
    {
        #region attribut
        private ModeleClasse _classe;
        #endregion

        #region constructeur
        public MainPageVueModele()
        {

        }
        #endregion

        #region getter/setter

        public ModeleClasse MaClasse
        {
            get { return _classe; }
            set { _classe = value; }
        }
        #endregion

        #region methodes

        public void ajouterAttribut(string nomAttribut, string typeAttribut, string getter, string setter)
        {
            List<string> AttributsAjout = new List<string> { nomAttribut, typeAttribut, getter, setter };
            MaClasse.CollAttribut.Add(AttributsAjout);
        }
        #endregion
    }
}
