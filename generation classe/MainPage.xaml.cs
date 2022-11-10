using generation_classe.vueModeles;

namespace generation_classe;

public partial class MainPage : ContentPage
{
    int x = 0;
	MainPageVueModele _vueModele;
	public MainPage()
	{
        InitializeComponent();
        BindingContext = _vueModele = new MainPageVueModele();
    }

    private void ajoutButton_Clicked(object sender, EventArgs e)
    {
        StackLayout parent;


        Entry nomAttribut = new Entry {  Placeholder = "nom de l'attribut"};
        Entry typeAttribut = new Entry { Placeholder = "type de l'attribut" };
        Label getterLabel = new Label { Text = "getter: " };
        CheckBox getter = new CheckBox { IsChecked = true };
        Label setterLabel = new Label { Text = "setter: " };
        CheckBox setter = new CheckBox { IsChecked = true };

        nomAttribut.SetBinding(Button.CommandProperty, new Binding("nomAttribut" + x));
        typeAttribut.SetBinding(Button.CommandProperty, new Binding("typeAttribut" + x));
        getterLabel.SetBinding(Button.CommandProperty, new Binding("getterLabel" + x));
        getter.SetBinding(Button.CommandProperty, new Binding("getter" + x));
        setterLabel.SetBinding(Button.CommandProperty, new Binding("setterLabel" + x));
        setter.SetBinding(Button.CommandProperty, new Binding("setter" + x));

        nomAttribut.BindingContext = _vueModele;
        typeAttribut.BindingContext = _vueModele;
        getterLabel.BindingContext = _vueModele;
        getter.BindingContext = _vueModele; ;
        setterLabel.BindingContext = _vueModele;
        setter.BindingContext = _vueModele;

        parent = layout;


        parent.Children.Add(nomAttribut);
        parent.Children.Add(typeAttribut);
        parent.Children.Add(getterLabel);
        parent.Children.Add(getter);
        parent.Children.Add(setterLabel);
        parent.Children.Add(setter);

        _vueModele.index++;

    }

    private void valider_Clicked(object sender, EventArgs e)
    {
        List<string> attribut = new List<string>();
        for(int i = 0; i < x; i++)
        {
           
        }
        //_vueModele.MaClasse.CollAttribut.Add();
    }
}

