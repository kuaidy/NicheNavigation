namespace XzNav.Model
{
    public class SiteModel
    {
        public string Name { get; set; }
        public string SiteUrl { get; set; }

        public string Icon
        {
            get { return $"Images/{Name}.svg"; }
        }
        public string OnlineIcon
        {
            get; set;
        }

    }
}
