using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace WPF.Common.UserControls
{
    /// <summary>
    /// Interaction logic for LabeledTextBox.xaml
    /// </summary>
    public partial class LabeledTextBox : UserControl
    {
        public LabeledTextBox()
        {
            InitializeComponent();
        }


        [Description("The text displayed by the Label")]
        public string LabelText
        {
            get { return (string)GetValue(LabelTextProperty); }
            set { SetValue(LabelTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register("LabelText", typeof(string), typeof(LabeledTextBox), new UIPropertyMetadata(string.Empty));



        public int LabelMinWidth
        {
            get { return (int)GetValue(LabelMinWidthProperty); }
            set { SetValue(LabelMinWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LabelMinWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelMinWidthProperty =
            DependencyProperty.Register("LabelMinWidth", typeof(int), typeof(LabeledTextBox), new UIPropertyMetadata(100));




        [Description("The text displayed by the TextBox")]
        public string TextBoxText
        {
            get { return (string)GetValue(TextBoxTextProperty); }
            set { SetValue(TextBoxTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBoxText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxTextProperty =
            DependencyProperty.Register("TextBoxText", typeof(string), typeof(LabeledTextBox), new UIPropertyMetadata(string.Empty));




        public int TextBoxMinWidth
        {
            get { return (int)GetValue(TextBoxMinWidthProperty); }
            set { SetValue(TextBoxMinWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for TextBoxMinWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxMinWidthProperty =
            DependencyProperty.Register("TextBoxMinWidth", typeof(int), typeof(LabeledTextBox), new UIPropertyMetadata(250));


        

    }
}
