    public class Seller
    {
        public int id { get; set; }
        public string nickname { get; set; }
        public bool car_dealer { get; set; }
        public bool real_estate_agency { get; set; }
        public bool _ { get; set; }
        public DateTime registration_date { get; set; }
        public List<string> tags { get; set; }
        public string car_dealer_logo { get; set; }
        public string permalink { get; set; }
        public SellerReputation seller_reputation { get; set; }
        public Eshop eshop { get; set; }
    }
