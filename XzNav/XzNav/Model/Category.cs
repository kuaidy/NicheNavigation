namespace XzNav.Model
{
    public class CategoryModel
    {
        public string EName { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string File { get; set; }
        public string CatUrl { get; set; }
        public List<CategoryModel> Children { get; set; }
        public List<SiteModel> Sites { get; set; } = new List<SiteModel>();
    }
}
