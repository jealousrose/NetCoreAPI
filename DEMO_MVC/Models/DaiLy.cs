using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEMO_MVC.Models
{
    public class DaiLy
    {
        [Key] // Khóa chính
        public string MaDaiLy { get; set; }

        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }

        [ForeignKey("HeThongPhanPhoi")]
        public string MaHTPP { get; set; } // Khóa ngoại

        public HeThongPhanPhoi HeThongPhanPhoi { get; set; }
    }
}
