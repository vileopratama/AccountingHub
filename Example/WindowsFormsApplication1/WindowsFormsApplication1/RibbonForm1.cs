using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace WindowsFormsApplication1
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            MyClass My_Class = new MyClass ();
            xtraUserControl21.My_Class = My_Class;
        }
    }

    public class MyClass : IDataErrorInfo, INotifyPropertyChanged, INotifyPropertyChanging
    {
        public string Name {
            get { return "Dx name"; }
        }
        public string Age {
            get { return "45"; }
        }

        public string Error
        {
            get { return null;
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Age")
                {
                    return "Incorrect age";
                }
                return null;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangingEventHandler PropertyChanging;
    }
}