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
        
        public string Link { get; set; } = String.Empty;
        public string LinkLabel { get; set; } = String.Empty;
        public string LinkPrefix { get; set; } = "Web";

        public string Link2 { get; set; } = String.Empty;
        public string Link2Label { get; set; } = String.Empty;
        public string Link2Prefix { get; set; } = "Web";

        [JsonIgnore]
        public bool HasLink
        {
            get
            {
                return !String.IsNullOrEmpty(Link) && !String.IsNullOrEmpty(LinkLabel) && !String.IsNullOrEmpty(LinkPrefix);
            }
        }

        [JsonIgnore]
        public bool HasLink2
        {
            get
            {
                return !String.IsNullOrEmpty(Link2) && !String.IsNullOrEmpty(Link2Label) && !String.IsNullOrEmpty(Link2Prefix);
            }
        }

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
