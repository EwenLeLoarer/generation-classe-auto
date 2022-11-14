//using Android.App.Admin;
using generation_classe.Modeles;
//using Java.Security;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace generation_classe.vueModeles
{
    public class MainPageVueModele 
    {
        #region attribut
        private ModeleClasse _classe;
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Attribut> _lesAttributs;
        private Attribut _leAttribut;
        private string _nom ;
        private string _type;
        private bool _hasGetter;
        private bool _hasSetter;
        public int index = 0;
        #endregion




        #region constructeur
        public MainPageVueModele()
        {
            LesAttributs= new ObservableCollection<Attribut>();
        }

        #endregion

        #region getter/setter

        public ModeleClasse MaClasse
        {
            get { return _classe; }
            set { _classe = value; }
        }

        public ObservableCollection<Attribut> LesAttributs { get => _lesAttributs; set => _lesAttributs = value; }
        
        public Attribut LeAttribut {
            get => _leAttribut;
            set
            {
                _leAttribut = value;
                OnPropertyChanged();
            } 
        }
        

        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
                LeAttribut.NomAttribut = value;
                OnPropertyChanged();
                
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                LeAttribut.TypeAttribut = value;
                OnPropertyChanged();
            }
        }

        public bool HasGetter
        {
            get
            {
                return _hasGetter;
            }
            set
            {
                _hasGetter = value;
                LeAttribut.HasGetter = value;
                OnPropertyChanged();
            }
        }

        public bool HasSetter
        {
            get
            {
                return _hasSetter;
            }
            set
            {
                _hasSetter = value;
                LeAttribut.HasSetter = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region methodes

        public void ajouterAttribut(string nomAttribut, string typeAttribut, bool getter, bool setter, string nomClasse)
        {
            LeAttribut = new Attribut(nomAttribut, typeAttribut,getter, setter);
            _lesAttributs.Add(LeAttribut);
        }

        public string CreerClasse(ObservableCollection<Attribut> ListAttribut, string nomClasse)
        {

            string resultat = "using System;\n" +
                "using System.Collections.Generic; \n" +
                "using System.Linq;\n" +
                "using System.Text;\n" +
                "using System.Threding.Tasks \n \n" +
                "public class " + nomClasse + "; \n" +
                "{ \n #region attributs \n";

            foreach(Attribut attribut in ListAttribut)
            {
                resultat += "private " + attribut.TypeAttribut + " " + attribut.NomAttribut + "; \n";
            }
            resultat += "public static ObservableCollection<" + nomClasse + "> CollCLasse = new ObservableCollection<" + nomClasse + ">(); \n" + 
                "#endregion \n" +
                "\n #region constructeur \n" +
                "public " + nomClasse + "(";

            foreach(Attribut attribut in ListAttribut)
            {
                resultat += attribut.TypeAttribut + " " + attribut.NomAttribut.Remove(0, 1) + ", ";
            }
            resultat = resultat.Substring(0, resultat.Length - 2);
            resultat += ")\n { \n ";
            foreach(Attribut attribut in ListAttribut)
            {
                resultat += attribut.NomAttribut + " = " + attribut.NomAttribut.Remove(0, 1) + "; \n";
            }
            resultat += "CollClasse.Add(this); \n";
            resultat += "} \n #endregion \n \n #region getter/setter \n";

            foreach(Attribut attribut in ListAttribut)
            {
                resultat += "public " + attribut.TypeAttribut + " " + char.ToUpper(attribut.NomAttribut[0]) + attribut.NomAttribut.Substring(1) + "{";
                    if(attribut.HasGetter) { resultat += "get => " + attribut.NomAttribut + "; " ; }
                    if(attribut.HasSetter) { resultat += "set => " + attribut.NomAttribut + " = value; "; }
                resultat += "} \n";
            }

            resultat += "#endregion \n \n #region methodes \n" +
                "#endregion";

            return resultat;           
        }

        public void generationFichier(string classe, string endroit)
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("D:\\output.cs");
                //Write a line of text
                sw.WriteLine(classe);
                //Write a second line of text
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void supprimerAttribut(string nomAttribut)
        {
            foreach(Attribut attribut in LesAttributs)
            {
                if(attribut.NomAttribut == nomAttribut)
                {
                    LesAttributs.Remove(attribut);
                    return;
                }
            }
            Console.WriteLine("pas d'attribut avec ce nom");
        }
        #endregion
    }
}
