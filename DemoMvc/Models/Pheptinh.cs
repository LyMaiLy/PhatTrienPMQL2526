namespace Demomvc.Models
{
    public class Pheptinh
    {
        public double SoA { get; set; }
        public double SoB { get; set; }
        public required string Pheptoan { get; set; }
        public double Ketqua { get; set; }

        public void Tinh()
        {
            switch (Pheptoan) //chọn nhánh xử lý phép toán 
            {
                case "Tong":
                    Ketqua = SoA + SoB;
                    break;
                case "Hieu":
                    Ketqua = SoA - SoB;
                    break;
                case "Tich":
                    Ketqua = SoA * SoB;
                    break;
                case "Thuong":
                    if (SoB != 0)
                        Ketqua = SoA / SoB;
                    else
                        Ketqua = double.NaN; //không hợp lệ
                    break;
            }

        }
    }
}
