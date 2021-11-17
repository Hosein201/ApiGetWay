namespace OrderProcessing.Dto
{
    public class LoginDto
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }

    public class RegsiterDto
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool ComfirmPassWord { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}