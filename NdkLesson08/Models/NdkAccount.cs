namespace NdkLesson08.Models
{
    public class NdkAccount
    {
        public int NdkId { get; set; }
        public string NdkFullName { get; set; }
        public string NdkEmail { get; set; }
        public string NdkPhone { get; set; }
        public string NdkAddress { get; set; }
        public string NdkAvatar { get; set; }
        public DateTime NdkBirthday { get; set; }
        public string NdkGender { get; set; }
        public string NdkPassword { get; set; }
        public string NdkFacebook { get; set; }

        public NdkAccount()
        {
            NdkFullName = string.Empty;
            NdkEmail = string.Empty;
            NdkPhone = string.Empty;
            NdkAddress = string.Empty;
            NdkAvatar = string.Empty;
            NdkGender = string.Empty;
            NdkPassword = string.Empty;
            NdkFacebook = string.Empty;
        }
    }
}