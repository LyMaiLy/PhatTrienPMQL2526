namespace DemoMvc.Models
{
    public class Bai1Controller
    {
        public string hoTen { get; set; }
        public int namSinh { get; set; }
        public int tinhTuoi() 
        {
            /* 
            Gọi hàm trả về 1 số nguyên là tuổi
            DateTime.Now.Year - Tuoi: lấy ngày và thời gian hiện tại trừ đi năm sinh để ra tuổi hiện tại 
            */
            return DateTime.Now.Year - namSinh;
        }
    }
}
