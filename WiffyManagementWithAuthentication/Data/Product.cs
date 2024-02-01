using System.ComponentModel.DataAnnotations;

namespace WiffyManagementWithAuthentication.Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string ProductFirstName { get; set; }

        public string ProductMiddleName { get; set; }

        public string ProductLastName { get; set; }

        public string ProductTitle { get; set; }

        public string ProductDescription { get; set; }

        public string ProductCountry { get; set; }

        public string ProductPhone { get; set; }
    }
}
