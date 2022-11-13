using generation_classe.vueModeles;

namespace generation_classe;

public partial class MainPage : ContentPage
{
    public int x = 0;
	MainPageVueModele _vueModele;

	public MainPage()
	{
        InitializeComponent();
        BindingContext = _vueModele = new MainPageVueModele();
    }

    //private void ajoutButton_Clicked(object sender, EventArgs e)
    //{
    //    _vueModele.index++;
    //    //_vueModele.LesAttributs.Add(new Modeles.Attribut("", "", true, true));

    //    StackLayout parent;

    //    Entry nomAttribut = new Entry {  Placeholder = "nom de l'attribut"};
    //    Entry typeAttribut = new Entry { Placeholder = "type de l'attribut" };
    //    Label getterLabel = new Label { Text = "getter: " };
    //    CheckBox getter = new CheckBox { IsChecked = true };
    //    Label setterLabel = new Label { Text = "setter: " };
    //    CheckBox setter = new CheckBox { IsChecked = true };
    //    Button validerAttribut = new Button { Text = "valider cet attribut" };

    //    nomAttribut.SetBinding(Button.CommandProperty, new Binding("Test"));
    //    typeAttribut.SetBinding(Button.CommandProperty, new Binding("typeAttribut" + _vueModele.index));
    //    getterLabel.SetBinding(Button.CommandProperty, new Binding("getterLabel" + _vueModele.index));
    //    getter.SetBinding(Button.CommandProperty, new Binding("getter" + _vueModele.index));
    //    setterLabel.SetBinding(Button.CommandProperty, new Binding("setterLabel" + _vueModele.index));
    //    setter.SetBinding(Button.CommandProperty, new Binding("setter" + _vueModele.index));


    //    nomAttribut.BindingContext = _vueModele;
    //    typeAttribut.BindingContext = _vueModele;
    //    getterLabel.BindingContext = _vueModele;
    //    getter.BindingContext = _vueModele; ;
    //    setterLabel.BindingContext = _vueModele;
    //    setter.BindingContext = _vueModele;
    //    validerAttribut.BindingContext = _vueModele;

    //    parent = layout;


    //    parent.Children.Add(nomAttribut);
    //    parent.Children.Add(typeAttribut);
    //    parent.Children.Add(getterLabel);
    //    parent.Children.Add(getter);
    //    parent.Children.Add(setterLabel);
    //    parent.Children.Add(setter);
    //    parent.Children.Add(validerAttribut);



    //}
    private void validerButton_Clicked(object sender, EventArgs e)
    {
        _vueModele.ajouterAttribut(nomAttributXAML.Text, typeAttributXAML.Text, getterXAML.IsChecked, setterXAML.IsChecked, nameClasseXAML.Text);
        finalText.Text = _vueModele.CreerClasse(_vueModele.LesAttributs, nameClasseXAML.Text);

        nomAttributXAML.Text = "";
        typeAttributXAML.Text = "";
        getterXAML.IsChecked = true;
        setterXAML.IsChecked = true;
        
    }

    private void generationFichier_Clicked(object sender, EventArgs e)
    {
        _vueModele.generationFichier(finalText.Text, "C:\\output.cs");
    }

    private void buttonDelete_Clicked(object sender, EventArgs e)
    {
        _vueModele.supprimerAttribut(deleteEntry.Text);
        finalText.Text = _vueModele.CreerClasse(_vueModele.LesAttributs, nameClasseXAML.Text);


    }
}

