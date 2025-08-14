namespace dev_utilities.Models
{
    public class TimeFormatter
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public string TimeFormat { get; set; }

        public TimeFormatter() {
            this.Seconds = 0;
            this.Minutes = 0;
            this.TimeFormat = "";
        }
    }
}
