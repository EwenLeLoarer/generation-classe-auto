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
        #endregion

        #region Constructor
        public Attribut(string nomAttribut, string typeAttribut, bool hasGetter, bool hasSetter)
        {
            _nomAttribut = nomAttribut;
            _typeAttribut = typeAttribut;
            _hasGetter = hasGetter;
            _hasSetter = hasSetter;
        }

        #endregion

        #region getter/setter
        public string NomAttribut { get => _nomAttribut; set => _nomAttribut = value; }
        public string TypeAttribut { get => _typeAttribut; set => _typeAttribut = value; }
        public bool HasGetter { get => _hasGetter; set => _hasGetter = value; }
        public bool HasSetter { get => _hasSetter; set => _hasSetter = value; }


        #endregion

        #region methodes
        #endregion
    }
}
