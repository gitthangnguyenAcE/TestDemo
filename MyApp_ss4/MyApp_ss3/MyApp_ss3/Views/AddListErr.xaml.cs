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
    public partial class AddListErr : ContentPage
    {
        private SQLiteConnection conn;
        public ListErr ListErrs;
        public AddListErr()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<ListErr>();
            var count = (from li in conn.Table<ListErr>() select li);
            if (count.Count() < 1)
            {
                Set_List();
            }

            LoadData();
            //Set_List();
        }
        //set data listerr
        public void Set_List()
        {

            //1
            ListErrs = new ListErr();
            ListErrs.Name = "Chuyển làn không có tín hiệu báo trước (Không Xi nhan)";
            ListErrs.Car = "400.000 đồng đến 600.000 đồng(Điểm a Khoản 2 Điều 5);3.000.000 đồng đến 5.000.000 đồng nếu vi phạm trên đường cao tốc(Điểm g Khoản 5 Điều 5)";
            ListErrs.Moto = "100.000 đồng đến 200.000 đồng";
            ListErrs.Decription = "Xe ô tô vi phạm: Tước quyền sử dụng Giấy phép lái xe từ 01 tháng đến 03 tháng nếu vi phạm trên cao tốc(Điểm b Khoản 11 Điều 5)";
            conn.Insert(ListErrs);
            //2
            ListErrs = new ListErr();
            ListErrs.Name = "Chuyến hướng không có tín hiệu báo hướng rẽ";
            ListErrs.Moto = "400.000 đồng đến 600.000 đồng (Điểm a Khoản 3 Điều 6)";
            ListErrs.Car = "800.000 đồng đến 1.000.000 đồng (Điểm c Khoản 3 Điều 5)";
            ListErrs.Decription = "";
            conn.Insert(ListErrs);
            //3
            ListErrs = new ListErr();
            ListErrs.Name = "Dùng tay sử dụng điện thoại di động khi đang điều khiển xe ô tô chạy trên đường";
            ListErrs.Car = "1.000.000 đồng đến 2.000.000 đồng";
            ListErrs.Moto = "";
            ListErrs.Decription = "Xe ô tô vi phạm: Tước quyền sử dụng Giấy phép lái xe từ 01 đến 03 tháng; từ 02 tháng đến 04 tháng nếu gây tai nạn giao thông (Điểm b, c Khoản 11 Điều 5)";
            conn.Insert(ListErrs);
            //4
            ListErrs = new ListErr();
            ListErrs.Name = "Người đang điều khiển xe máy sử dụng điện thoại di động, thiết bị âm thanh (trừ thiết bị trợ thính)";
            ListErrs.Car = "";
            ListErrs.Moto = "600.000 đồng đến 1.000.000 đồng (Điểm h Khoản 4 Điều 6)";
            ListErrs.Decription = " Xe máy vi phạm: Tước quyền sử dụng Giấy phép lái xe từ 01 tháng đến 03 tháng(Điểm b Khoản 10 Điều 6)";
            conn.Insert(ListErrs);
            //5
            ListErrs = new ListErr();
            ListErrs.Name = "Vượt đèn đỏ, đèn vàng (Lưu ý: Đèn tín hiệu vàng nhấp nháy thì được đi nhưng phải giảm tốc độ)";
            ListErrs.Car = "3.000.000 đồng đến 5.000.000 đồng(Điểm a Khoản 5 Điều 5";
            ListErrs.Moto = "600.000 đồng đến 1.000.000 đồng(Điểm e, khoản 4, Điều 6)";
            ListErrs.Decription = "- Xe máy vi phạm: Tước quyền sử dụng Giấy phép lái xe từ 01 tháng đến 03 tháng (Điểm b Khoản 10 Điều 6)- Xe ô tô vi phạm: Tước quyền sử dụng Giấy phép lái xe từ 01 tháng đến 03 tháng; từ 02 đến 04 tháng nếu gây tai nạn giao thông.(Điểm b, c Khoản 11 Điều 5)";
            conn.Insert(ListErrs);
            //6
            ListErrs = new ListErr();
            ListErrs.Name = "Đi không đúng phần đường hoặc làn đường quy định (Đi sai làn)";
            ListErrs.Car = "10.000.000 đồng đến 12.000.000 đồng nếu gây tai nạn giao thông";
            ListErrs.Moto = "400.000 đồng đến 600.000 đồng ; 4.000.000 đồng đến 5.000.000 đồng nếu gây tai nạn giao thông.";
            ListErrs.Decription = "- Xe máy vi phạm: Tước quyền sử dụng Giấy phép lái xe từ 02 tháng đến 04 tháng (Điểm c Khoản 10 Điều 6)- Xe ô tô vi phạm: Tước quyền sử dụng Giấy phép lái xe từ 02 tháng đến 04 tháng(Điểm c Khoản 11 Điều 5)";
            conn.Insert(ListErrs);
            //7
            ListErrs = new ListErr();
            ListErrs.Name = "Đi không đúng theo chỉ dẫn của vạch kẻ đường";
            ListErrs.Car = "200.000 đồng đến 400.000 đồng";
            ListErrs.Moto = "100.000 đồng đến 200.000 đồng";
            ListErrs.Decription = "";
            conn.Insert(ListErrs);
            //8
            ListErrs = new ListErr();
            ListErrs.Name = "Đi ngược chiều của đường một chiều, đi ngược chiều trên đường có biển “Cấm đi ngược chiều”";
            ListErrs.Car = "10.000.000 đồng đến 12.000.000 đồng nếu gây tai nạn giao thông. (Điểm a Khoản 7 Điều 5)";
            ListErrs.Moto = "4.000.000 đồng đến 5.000.000 đồng nếu gây tai nạn giao thông. (Điểm b Khoản 7 Điều 6)";
            ListErrs.Decription = "Xe máy vi phạm: Tước quyền sử dụng Giấy phép lái xe từ 02 tháng đến 04 tháng. (Điểm c Khoản 10 Điều 6) - Xe ô tô vi phạm: Tước quyền sử dụng Giấy phép lái xe từ 02 tháng đến 04 tháng (Điểm c Khoản 11 Điều 5)";
            conn.Insert(ListErrs);
            //9
            ListErrs = new ListErr();
            ListErrs.Name = "Đi vào đường có biển báo cấm phương tiện đang điều khiển";
            ListErrs.Car = "1.000.000 đồng đến 2.000.000 đồng";
            ListErrs.Moto = "400.000 đồng đến 600.000 đồng";
            ListErrs.Decription = "- Xe máy vi phạm: Tước quyền sử dụng Giấy phép lái xe từ 01 tháng đến 03 tháng. (Điểm b Khoản 10 Điều 6) - Xe ô tô vi phạm: Tước quyền sử dụng Giấy phép lái xe từ 01 tháng đến 03 tháng (Điểm b Khoản 11 Điều 5)";
            conn.Insert(ListErrs);
            //10
            ListErrs = new ListErr();
            ListErrs.Name = "Điều khiển xe ô tô không có gương chiếu hậu";
            ListErrs.Car = "300.000 đồng đến 400.000 đồng(Điểm a Khoản 2 Điều 16)";
            ListErrs.Moto = "";
            ListErrs.Decription = "";
            conn.Insert(ListErrs);
            //11
            ListErrs = new ListErr();
            ListErrs.Name = "Điều khiển xe máy không có gương chiếu hậu bên trái hoặc có nhưng không có tác dụng";
            ListErrs.Car = "";
            ListErrs.Moto = "100.000 đồng đến 200.000 đồng (Điểm a Khoản 1 Điều 17)";
            ListErrs.Decription = "";
            conn.Insert(ListErrs);
            //12
            ListErrs = new ListErr();
            ListErrs.Name = "Không đội mũ bảo hiểm hoặc đội nhưng không cài quai đúng quy cách";
            ListErrs.Car = "";
            ListErrs.Moto = "200.000 đồng đến 300.000 đồng(Điểm i Khoản 2 Điều 6)";
            ListErrs.Decription = "";
            conn.Insert(ListErrs);
            //13
            ListErrs = new ListErr();
            ListErrs.Name = "Không có  giấy phép lái xe(Với người đã đủ tuổi được điều khiển phương tiện)";
            ListErrs.Car = "4.000.000 đồng đến 6.000.000 đồng";
            ListErrs.Moto = "800.000 đồng đến 1.200.000 đồng khi điều xe máy hai bánh có dung tích xi lanh dưới 175 cm3 (Điểm a Khoản 5 Điều 21) 3.000.000 đồng đến 4.000.000 đồng khi điều khiển xe máy hai bánh có dung tích xi lanh từ 175 cm3 trở lên(Điểm b Khoản 7 Điều 21)";
            ListErrs.Decription = "";
            conn.Insert(ListErrs);
            //14
            ListErrs = new ListErr();
            ListErrs.Name = "Không có hoặc không mang theo Giấy chứng nhận bảo hiểm trách nhiệm dân sự của chủ xe cơ giới còn hiệu lực";
            ListErrs.Car = "400.000 đồng đến 600.000 đồng";
            ListErrs.Moto = "100.000 đồng đến 200.000 đồng";
            ListErrs.Decription = "";
            conn.Insert(ListErrs);
            //15
            ListErrs = new ListErr();
            ListErrs.Name = "Có nồng độ cồn trong máu hoặc hơi thở khi điều khiển xe";
            ListErrs.Car = "6.000.000 đồng đến 8.000.000 đồng nếu trong máu hoặc hơi thở có nồng độ cồn nhưng chưa vượt quá 50 miligam/100 mililít máu hoặc chưa vượt quá 0,25 miligam/1 lít khí thở";
            ListErrs.Moto = "2.000.000 đồng đến 3.000.000 đồng nếu trong máu hoặc hơi thở có nồng độ cồn nhưng chưa vượt quá 50 miligam/100 mililít máu hoặc chưa vượt quá 0,25 miligam/1 lít khí thở.";
            ListErrs.Decription = "Tước quyền sử dụng Giấy phép lái xe từ 10 tháng đến 12 tháng";
            conn.Insert(ListErrs);
            //16
            ListErrs = new ListErr();
            ListErrs.Name = "Có nồng độ cồn trong máu hoặc hơi thở khi điều khiển xe";
            ListErrs.Car = "16.000.000 đồng đến 18.000.000 đồng nếu có nồng độ cồn vượt quá 50 miligam đến 80 miligam/100 mililít máu hoặc vượt quá 0,25 miligam đến 0,4 miligam/1 lít khí thở.";
            ListErrs.Moto = "4.000.000 đồng đến 5.000.000 đồng nếu có nồng độ cồn vượt quá 50 miligam đến 80 miligam/100 mililít máu hoặc vượt quá 0,25 miligam đến 0,4 miligam/1 lít khí thở.";
            ListErrs.Decription = "Tước quyền sử dụng Giấy phép lái xe từ 16 tháng đến 18 tháng.";
            conn.Insert(ListErrs);
            //17
            ListErrs = new ListErr();
            ListErrs.Name = "Có nồng độ cồn trong máu hoặc hơi thở khi điều khiển xe";
            ListErrs.Car = "6.000.000 đồng đến 8.000.000 đồng nếu có nồng độ cồn vượt quá 80 miligam/100 mililít máu hoặc vượt quá 0,4 miligam/1 lít khí thở.";
            ListErrs.Moto = "30.000.000 đồng đến 40.000.000 đồng nếu có nồng độ cồn vượt quá 80 miligam/100 mililít máu hoặc vượt quá 0,4 miligam/1 lít khí thở";
            ListErrs.Decription = "Tước quyền sử dụng Giấy phép lái xe từ 22 tháng đến 24 tháng.";
            conn.Insert(ListErrs);

        }
        private void Savebutton_Clicked(object sender, EventArgs e)
        {
            ListErrs = new ListErr();
            ListErrs.Name = Name.Text;
            ListErrs.Car = Car.Text;
            ListErrs.Moto = Moto.Text;
            ListErrs.Decription = Decription.Text;
            conn.Insert(ListErrs);
            SetNull();
        }
        private void SetNull()
        {
            Name.Text = "";
            Car.Text = "";
            Moto.Text = "";
            Decription.Text = "";
        }
        private void LoadData()
        {
            var data = (from li in conn.Table<ListErr>() select li);
            Datalist.ItemsSource = data;
        }
        private void Showbutton_Clicked(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Deletebutton_Clicked(object sender, EventArgs e)
        {
            conn.DropTable<ListErr>();
            conn.CreateTable<ListErr>();
            LoadData();
        }
        void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
        { // Them cast the object SENDER to your Datasource Object, my case House House myHouse = sender as House; 
            
        }
            private void Deletebutton_1_Clicked(object sender, EventArgs e)
        {
            var stt = Datalist.SelectedItem as ListErr;
            conn.Delete<ListErr>(stt.ID);
            // Shell.Current.GoToAsync($"//{nameof(AddListErr)}");

            LoadData();
        }
    }
}