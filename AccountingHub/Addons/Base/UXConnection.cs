using System;
using System.Windows.Forms;
using AccountingHub.Classes;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors;


namespace AccountingHub.Addons.Base
{
	public partial class UXConnection : DevExpress.XtraEditors.XtraForm
	{
		
		public UXConnection()
		{
			InitializeComponent();
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			//bindingValidate();
			if(dxValidationProvider.Validate())
			{
				INI ini = new INI(App.baseDirectory() + "/config.ini");
				ini.Write("Database", "Server", txtServerName.Text);
				ini.Write("Database", "Database", "AR_" + cbGroup.SelectedItem);
				ini.Write("Database", "Username", txtUsername.Text);
				ini.Write("Database", "Password", txtPassword.Text);

				this.BindingDatabase();

				DB.Connect();
				if(DB.isConnected == false)
				{
					MessageBox.Show("Error Connection,please check your configuration ?", "Database Configuration",
						MessageBoxButtons.OK,MessageBoxIcon.Warning);
				} else
				{
					MessageBox.Show("Successfull connection to database ?", "Database Configuration",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Hide();
				}
			} 
		}

		private void UXConnection_Load(object sender, EventArgs e)
		{
			this.BindingDatabase();
			this.bindingField();
			this.bindingValidate();
		}

		private void BindingDatabase()
		{
			INI ini = new INI(App.baseDirectory() + "/config.ini");
			DB.Server = ini.Read("Database", "Server");
			DB.Database = ini.Read("Database", "Database");
			DB.Username = ini.Read("Database", "Username");
			DB.Password = ini.Read("Database", "Password");
		}

		private void bindingField()
		{
			this.txtServerName.Text = DB.Server;
			this.txtUsername.Text = DB.Username;
			this.txtPassword.Text = DB.Password;
		}

		private void bindingValidate()
		{
			TextEdit[] text = new TextEdit[5];
			text[0] = txtServerName;
			text[1] = txtUsername;
			//text[2] = txtPassword;

			for (int i = 0; i < text.Length; i++)
			{
				ConditionValidationRule containsValidationRule = new ConditionValidationRule();
				containsValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
				containsValidationRule.ErrorText = "Please not empty field";
				containsValidationRule.ErrorType = ErrorType.Critical;
				dxValidationProvider.SetValidationRule(text[i], containsValidationRule);
			}
			
		}

		
	}
}