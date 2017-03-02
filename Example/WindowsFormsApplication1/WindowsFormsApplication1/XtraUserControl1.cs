using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace WindowsFormsApplication1
{
    public partial class XtraUserControl1 : XtraUserControlBase
    {
        public XtraUserControl1()
        {
            InitializeComponent();
        }



        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
        }


        private MyClass _My_Class;

        public MyClass My_Class
        {
            get { return _My_Class; }
            set
            {
                _My_Class = value;

                buttonEdit1.DataBindings.Clear();
                buttonEdit1.EditValue = null;

                if (My_Class != null)
                {
                    buttonEdit1.DataBindings.Add("EditValue", My_Class, "Name", false,
                                                 DataSourceUpdateMode.OnPropertyChanged);
                    dxErrorProvider1.SetError(buttonEdit1, "Incorrect value");
                }
            }
        }
    }
}
