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
    public partial class AddPerson : ContentPage
    {
        public SQLiteConnection conn;
        public PeoPle PeoPle; 
        //public PeoPle PeoPle;
        public AddPerson()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            
            if (conn != null)
            {
                conn.CreateTable<ListErr>();
                conn.CreateTable<PeoPle>();
            }
            var count = (from li in conn.Table<PeoPle>() select li);
            if (count.Count() < 1)
            {
                Set_list();
            }

            LoadData();
        }
        private void SetDataValues(string a,string b,string c, string d , string e , string f)
        {
            PeoPle = new PeoPle();
            PeoPle.Name = a;
            PeoPle.CMND = b;
            PeoPle.Address = c;
            PeoPle.BX_Oto = d;
            PeoPle.BX_Xemay = e;
            PeoPle.Decription = f;
            conn.Insert(PeoPle);
        }
        private void SetData()
        {
            PeoPle = new PeoPle();
            PeoPle.Name = Name.Text;
            PeoPle.CMND = CMND.Text;
            PeoPle.Address = Address.Text;
            PeoPle.BX_Oto = BX_Oto.Text;
            PeoPle.BX_Xemay = BX_Xemay.Text;
            PeoPle.Decription = Decription.Text;
            conn.Insert(PeoPle);
        }
        private void Savebutton_Clicked(object sender, EventArgs e)
        {
            PeoPle = new PeoPle();
            SetData();
            SetNull();
        }
        private void SetNull()
        {
            Name.Text = "";
            Address.Text = "";
            CMND.Text = "";
            BX_Oto.Text = "";
            BX_Xemay.Text = "";
            Decription.Text = "";
        }
        private void LoadData()
        {
            var data = (from li in conn.Table<PeoPle>() select li);
            Datalist.ItemsSource = data;

        }
        private void Set_list()
        {
            AddPeople("Hồ Văn", "285789399", "45 Phung Khac Khoan, Da Kao Ward, District 1, Ho Chi Minh City", "78P123456", "", "");
            AddPeople("Hồ Long", "285785312", "175 Hai Ba Trung, District 3, Ho Chi Minh City", "38P122345", "38A12456", "");
            AddPeople("Nguyễn Hữu", "285781342", "	22 Phung Khac Khoan, Da Kao Ward, District 1, Ho Chi Minh City", "93P112345", "30G12345", "");
            AddPeople("Hoàng Văn", "285782359", "18 Phung Khac Khoan, Da Kao Ward, District 1, Ho Chi Minh City", "68P264689", "", "");
            AddPeople("Nguyễn Nhật", "285589360", "17 Le Duan Ward, Ben Nghe, District 1, Ho Chi Minh City", "68P209004", "36A16745", "");
            AddPeople("Hoàng Long", "285789755", "13-17 Nguyen Hue, Ben Nghe Ward, District 1, Ho Chi Minh City", "34P249122", "", "");
            AddPeople("Vân Phạm", "282789312", "65 Le Loi, Ben Nghe Ward, District 1, Ho Chi Minh City", "34P233322", "", "");
            AddPeople("Hiền Hòa", "285785377", "2 Ngo Duc Ke, Ben Nghe Ward, District 1, Ho Chi Minh City", "54P241112", "", "");
            AddPeople("Trần Long", "285789311", "4 Le Duan, Ben Nghe Ward, District 1, Ho Chi Minh City", "34P269002", "30G53347", "");
            AddPeople("Nguyễn Hoàng", "285787009", "123 Hoàng diệu", "66P269012", "", "");
        }
        void AddPeople(string a, string b, string c, string d, string e, string f ) {
            PeoPle = new PeoPle();
            PeoPle.Name = a;
            PeoPle.CMND = b;
            PeoPle.Address = c;
            PeoPle.BX_Oto = e;
            PeoPle.BX_Xemay = d;
            PeoPle.Decription = f;
            conn.Insert(PeoPle);
        }
        private void Showbutton_Clicked(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Deletebutton_Clicked(object sender, EventArgs e)
        {
            conn.DropTable<PeoPle>();
            conn.CreateTable<PeoPle>();
            LoadData();
        }

        private void Deletebutton_1_Clicked(object sender, EventArgs e)
        {
            var stt = Datalist.SelectedItem as PeoPle;
            conn.Delete<PeoPle>(stt.ID);
            // Shell.Current.GoToAsync($"//{nameof(AddListErr)}");

            LoadData();
        }
        void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        { // Them cast the object SENDER to your Datasource Object, my case House House myHouse = sender as House; 

        }
    }

}
