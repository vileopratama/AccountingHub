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
    public partial class XtraUserControl2 : XtraUserControlBase
    {
        public XtraUserControl2()
        {
            InitializeComponent();
        }


        private MyClass _My_Class;

        public MyClass My_Class
        {
            get { return _My_Class; }
            set
            {
                _My_Class = value;

                dxErrorProvider1.DataSource = null;

                textEdit1.DataBindings.Clear();
                textEdit1.EditValue = null;
                if (value != null)
                {
                    
                    textEdit1.DataBindings.Add("EditValue", My_Class, "Age", false,
                                             DataSourceUpdateMode.OnPropertyChanged);

                    
                }


                // IT WORKS
                //dxErrorProvider1.DataSource = value;

                xtraUserControl11.My_Class = value;

                // IT DOESN'T WORK
                dxErrorProvider1.DataSource = value;
            }
        }
    }
}
