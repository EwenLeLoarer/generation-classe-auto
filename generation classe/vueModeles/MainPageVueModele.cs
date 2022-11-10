//using Android.App.Admin;
using generation_classe.Modeles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generation_classe.vueModeles
{
    public class MainPageVueModele 
    {
        #region attribut
        private ModeleClasse _classe;
        public event PropertyChangedEventHandler PropertyChanged;
        private string[] _nomAttribut, _typeAttribut, _getter, _setter;
        public int index = 0;
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

        public string[] NomAttribut
        {
            protected set
            {
                for(int i = 0; i < index; i++)
                if (_nomAttribut != value)
                {
                        _nomAttribut = value;
                    OnPropertyChanged("nomAttribut"+i);
                    
                }
            }

            get { return _nomAttribut; }
        }
        #endregion

        #region methodes

        public void ajouterAttribut(string nomAttribut, string typeAttribut, string getter, string setter)
        {
            List<string> AttributsAjout = new List<string> { nomAttribut, typeAttribut, getter, setter };
            MaClasse.CollAttribut.Add(AttributsAjout);

            
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
