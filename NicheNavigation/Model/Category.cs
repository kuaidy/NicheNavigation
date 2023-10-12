namespace NicheNavigation.Model
{
    public class CategoryModel
    {
        public string EName { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string File { get; set; }
        public List<CategoryModel> Children { get; set;}

    }
    public class CategoriesModel
    {
        private List<CategoryModel> m_Categories=new List<CategoryModel>();
        public List<CategoryModel> Categories
        {
            get { return m_Categories; }
            set { m_Categories = value; }
        }
    }
}
