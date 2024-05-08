using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using week4_BankAPP.Model;
using week4_BankAPP.Logics;

namespace week4_BankAPP.User_Inerface
{
    public partial class CheckBalanceForm : Form
    {
        public CheckBalanceForm()
        {
            InitializeComponent();
        }
        public string userEmail;
        public CheckBalanceForm(string UserEmail)
        {
            InitializeComponent();
            userEmail = UserEmail;
        }
        public static List<UserModel> Customer = new List<UserModel>();
        private void CheckBalanceForm_Load(object sender, EventArgs e)
        {
            
            var customer = File.ReadAllText(@"Customer.Json");
            var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);
            var loggedin_user = result.Users.FirstOrDefault(x => x.Email == userEmail);

            lblFullname.Text = ($"{loggedin_user.FirstName.ToUpper()} {loggedin_user.LastName.ToUpper()}");

            lblAccount.Text = loggedin_user.Balance.ToString();



            
            

            //var customer = File.ReadAllText(@"Customer.Json");
            //var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);

            //var loggedin_user1 = result.Users.FirstOrDefault(x => x.Email == userEmail);
            //SuccessMsgDeposit.Text = loggedin_user1.FirstName;



        }
    }
}
