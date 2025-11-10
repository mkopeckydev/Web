using System.Globalization;
using System.Text.Json.Serialization;

namespace Kopec.Web.Model
{
    public class IconListItem
    {
        public string Image { get; set; } = String.Empty;
        public string ImageAlt { get; set; } = String.Empty;

        public string RowsLabel {  get; set; } = String.Empty;
        public List<string> Rows { get; set; } = new List<string>();
        public List<IconListLink> Links { get; set; } = new List<IconListLink>();

        [JsonIgnore]
        public bool HasRowsLabel
        {
            get
            {
                return !String.IsNullOrEmpty(RowsLabel);
            }
        }
    }
}
