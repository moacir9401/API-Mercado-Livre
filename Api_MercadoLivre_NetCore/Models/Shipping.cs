    public class Shipping
    {
        public string logistic_type { get; set; }
        public string mode { get; set; }
        public bool store_pick_up { get; set; }
        public bool free_shipping { get; set; }
        public List<string> tags { get; set; }
        public object promise { get; set; }
    }
