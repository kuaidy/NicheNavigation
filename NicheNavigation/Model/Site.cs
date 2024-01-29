namespace NicheNavigation.Model
{
    public class SiteModel
    {
        public string Name { get; set; }
        public string SiteUrl { get; set; }

        public string Icon
        {
            get { return $"Images/{this.Name}.svg"; }
        }
        public string OnlineIcon
        {
            get;set;
        }

    }
    public class SitesModel
    {
        private List<SiteModel> m_Sites = new List<SiteModel>();
        public List<SiteModel> Sites
        {
            get
            {
                return m_Sites;
            }
            set
            {
                m_Sites = value;
            }
        }
    }
    public class CategorySitesModel
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public SitesModel Sites { get; set; }
        public List<SitesModel> ListSites { get; set; }
    }
}
