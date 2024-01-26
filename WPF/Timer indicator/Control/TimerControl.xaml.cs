using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Color = System.Drawing.Color;

namespace WPFControls
{
    /// <summary>
    /// Interaction logic for TimerControl.xaml
    /// </summary>
    public partial class TimerControl : UserControl
    {
        public TimerControl()
        {
            InitializeComponent();
        }



        public Color CountForeColor
        {
            get { return (Color)GetValue(CountForeColorProperty); }
            set { SetValue(CountForeColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CountForeColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CountForeColorProperty =
            DependencyProperty.Register("CountForeColor", typeof(Color), typeof(TimerControl), new PropertyMetadata(Color.Red));


    }
}
