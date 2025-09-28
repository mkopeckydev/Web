namespace Kopec.Web.Model
{
    public class IconListData
    {
        public string Caption { get; set; } = String.Empty;
        public List<IconListGroup> Groups { get; set; } = new List<IconListGroup>();
        
    }
}
