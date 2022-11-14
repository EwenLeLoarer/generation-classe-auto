using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generation_classe.Modeles
{
    public class Attribut
    {
        #region Attributs
        private string _nomAttribut = "";
        private string _typeAttribut = "";
        private bool _hasGetter = true;
        private bool _hasSetter = true;
        private bool _inConstructeur = true;
        #endregion

        #region Constructor
        public Attribut(string nomAttribut, string typeAttribut, bool hasGetter, bool hasSetter, bool inConstructeur)
        {


            _nomAttribut = nomAttribut;
            _typeAttribut = typeAttribut;
            _hasGetter = hasGetter;
            _hasSetter = hasSetter;
            _inConstructeur = inConstructeur;

        }

        #endregion

        #region getter/setter
        public string NomAttribut
        {
            get
            {
                return _nomAttribut;
            }
            set 
            {
                if (value[0].ToString() != "_") value.Insert(0, "_");
                _nomAttribut = value;
            }
        
        }
        public string TypeAttribut { get => _typeAttribut; set => _typeAttribut = value; }
        public bool HasGetter { get => _hasGetter; set => _hasGetter = value; }
        public bool HasSetter { get => _hasSetter; set => _hasSetter = value; }
        public bool InConstructeur { get => _inConstructeur; set => _inConstructeur = value; }


        #endregion

        #region methodes
        private string GetVerificationNomUnderScore(string nom)
        {
            string resultat = nom;
            if (resultat[0].ToString() != "_") resultat.Insert(0, "_");
            return resultat;
        }

        private string SetLowerCaractere2()
        {
            string resultat = this.NomAttribut;
            resultat[1].ToString().ToLower();
            return resultat;
        }

        #endregion
    }
}
