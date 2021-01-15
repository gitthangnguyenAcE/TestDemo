using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyApp_ss3.Models;
using MyApp_ss3.Data;

namespace MyApp_ss3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddXeVP : ContentPage
    {
        public SQLiteConnection conn;
        public LoiVP LoiVP;
        public AddXeVP()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<LoiVP>();
            var count = (from li in conn.Table<LoiVP>() select li);
            if (count.Count() < 1)
            {
                Set_list();
            }

            LoadData();
        }
        private void LoadData()
        {
            var data = (from li in conn.Table<LoiVP>() select li);
            Datalist.ItemsSource = data;
        }
        private void SetDataValues(string a, string b, string c, int d, int e, string f)
        {
            LoiVP = new LoiVP();
            LoiVP.BX = a;
            LoiVP.TG_vp = b;
            LoiVP.Address = c;
            LoiVP.IdVP = d;
            LoiVP.money = e;
            LoiVP.TT = f;
            conn.Insert(LoiVP);
        }
        private void Set_list()
        {
            SetDataValues("78P123456", "22/11/2020", "45 Phung Khac Khoan, Da Kao Ward, District 1, Ho Chi Minh City", 1, 30000, "Đã đóng phạt");
            SetDataValues("38P122345", "22/11/2020", "175 Hai Ba Trung, District 3, Ho Chi Minh City", 12, 30000, "Đã đóng phạt");
            SetDataValues("34P269002", "22/11/2020", "	22 Phung Khac Khoan, Da Kao Ward, District 1, Ho Chi Minh City",11, 30000, "Chưa đóng phạt");
            SetDataValues("30G12345", "22/11/2020", "18 Phung Khac Khoan, Da Kao Ward, District 1, Ho Chi Minh City", 5, 30000, "Đã đóng phạt");
            SetDataValues("30G12345", "22/11/2020", "17 Le Duan Ward, Ben Nghe, District 1, Ho Chi Minh City", 6, 30000, "Chưa đóng phạt");
            SetDataValues("30G12345", "22/11/2020", "13-17 Nguyen Hue, Ben Nghe Ward, District 1, Ho Chi Minh City", 3, 30000, "Chưa đóng phạt");
            SetDataValues("36A16745", "22/11/2020", "65 Le Loi, Ben Nghe Ward, District 1, Ho Chi Minh City",6, 30000, "Chưa đóng phạt");
            SetDataValues("36A16745", "22/11/2020", "2 Ngo Duc Ke, Ben Nghe Ward, District 1, Ho Chi Minh City", 4, 30000, "Đã đóng phạt");
            SetDataValues("54P241112", "285722/11/202089311", "4 Le Duan, Ben Nghe Ward, District 1, Ho Chi Minh City", 15, 30000, "Đã đóng phạt");
            SetDataValues("34P269002", "22/11/2020", "123 Hoàng diệu", 1, 1000000, "Đã đóng phạt");
        }
        

        private void SetDataValues(string a, string b, string c, int d, int e)
        {
            LoiVP = new LoiVP();
            LoiVP.BX = a;
            LoiVP.TG_vp = b;
            LoiVP.Address = c;
            LoiVP.IdVP = d;
            LoiVP.money = e;
            conn.Insert(LoiVP);
        }
        private void SetData()
        {
            LoiVP = new LoiVP();
            LoiVP.BX = BX.Text;
            LoiVP.TG_vp = TG_vp.Text;
            LoiVP.Address = Address.Text;
            LoiVP.IdVP = Int32.Parse(IdVP.Text);
            LoiVP.money =  Int32.Parse(money.Text);
            LoiVP.TT = TT.Text;
           // LoiVP.Decription = Decription.Text;
            conn.Insert(LoiVP);
        }
        private void Savebutton_Clicked(object sender, EventArgs e)
        {
            LoiVP = new LoiVP();
            SetData();
            SetNull();
        }
        private void SetNull()
        {
            BX.Text = "";
            Address.Text = "";
            TG_vp.Text = "";
            IdVP.Text = "";
            money.Text = "";
            TT.Text = "";
        }

        private void Showbutton_Clicked(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Deletebutton_Clicked(object sender, EventArgs e)
        {
            conn.DropTable<LoiVP>();
            conn.CreateTable<LoiVP>();
            LoadData();
        }

        private void Deletebutton_1_Clicked(object sender, EventArgs e)
        {
            var stt = Datalist.SelectedItem as LoiVP;
            conn.Delete<LoiVP>(stt.ID);
            // Shell.Current.GoToAsync($"//{nameof(AddListErr)}");

            LoadData();
        }

    }
}