namespace Common.Models
{
    public class AddressModel
    {
        public int Job_id { get; set; }
        public string Address_line_1 { get; set; }
        public string Address_line_2 { get; set; }
        public string Address_line_3 { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Zip_code { get; set; }
    }
}