namespace DemoMvc.Models
{
    public class BMI
    {
        public double Cannang { get; set; }
        public double Chieucao { get; set; }
        public double ChisoBMI { get; set; }
        public string Phanloai { get; set; }

        public void Tinh()
        {
            if (Chieucao > 0)
            {
                ChisoBMI = Cannang / (Chieucao * Chieucao);

                if (ChisoBMI < 18.5)
                    Phanloai = "Gầy";
                else if (ChisoBMI < 25)
                    Phanloai = "Bình thường";
                else if (ChisoBMI < 30)
                    Phanloai = "Thừa cân";
                else
                    Phanloai = "Béo phì";
            }
            else
            {
                ChisoBMI = 0;
                Phanloai = "Chiều cao không hợp lệ";
            }
        }

    }
    
}
