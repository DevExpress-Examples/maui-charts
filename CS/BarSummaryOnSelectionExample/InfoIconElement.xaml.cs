namespace BarSummaryOnSelectionExample;

public partial class InfoIconElement : ContentView
{
	public string Value {
		get { return (string)GetValue(ValueProperty); }
		set { SetValue(ValueProperty, value); }
	}
	public static readonly BindableProperty ValueProperty =BindableProperty.Create("Value", typeof(string), typeof(InfoIconElement));

    public string Description {
        get { return (string)GetValue(DescriptionProperty); }
        set { SetValue(DescriptionProperty, value); }
    }
    public static readonly BindableProperty DescriptionProperty = BindableProperty.Create("Description", typeof(string), typeof(InfoIconElement));


    public ImageSource Image {
        get { return (ImageSource)GetValue(ImageProperty); }
        set { SetValue(ImageProperty, value); }
    }
    public static readonly BindableProperty ImageProperty = BindableProperty.Create("Image", typeof(ImageSource), typeof(InfoIconElement));


    public InfoIconElement()
	{
		InitializeComponent();
        rootPanel.BindingContext = this;
	}
}