using System.ComponentModel.DataAnnotations;

namespace DEMO_MVC.Models
{
    public class HeThongPhanPhoi
    {
        [Key] // Khóa chính
        public string MaHTPP { get; set; }

        public string TenHTPP { get; set; }

        // Quan hệ 1-nhiều
        public ICollection<DaiLy> DaiLys { get; set; }
    }
}
