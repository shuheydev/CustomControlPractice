using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControlPractice
{ 
    [DesignTimeVisible(true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyControl : ContentView
    {
        //private string _text;
        //public string Text
        //{
        //    get => _text;
        //    set
        //    {
        //        _text = value;
        //        this.entry.Text = _text;
        //    }
        //}

        public string Text { get; set; }
        public static readonly BindableProperty TextProperty = BindableProperty.Create(
                propertyName: nameof(Text),
                returnType: typeof(string),
                declaringType: typeof(MyControl),
                defaultValue: "",
                defaultBindingMode: BindingMode.TwoWay,
                propertyChanged: TitlePropertyChanged
            );
        private static void TitlePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MyControl)bindable;
            control.entry.Text = newValue.ToString();
        }

        public MyControl()
        {
            InitializeComponent();
        }
    }
}