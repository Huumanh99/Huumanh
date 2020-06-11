namespace Nguyenmanh_lab456.Controllers
{
    internal class CourseViewModel
    {
        public object Categories { get; set; }
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public System.DateTime GetDateTime()
        {
            return System.DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}