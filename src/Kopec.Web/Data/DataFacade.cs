using Kopec.Web.Model;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Kopec.Web.Data
{
    public class DataFacade
    {
        #region Read/Write DataJsonFile
        private async Task<IconListData> ReadDataJsonFileAsync(string name)
        {
            using FileStream stream = File.OpenRead($"wwwroot/data/{name}.json");

            var data = await JsonSerializer.DeserializeAsync<IconListData>(stream);

            if (data != null) return data;
            else return new IconListData();
        }
        private async Task WriteDataJsonFileAsync(IconListData data, string name)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };

            string json = JsonSerializer.Serialize(data, options);

            await File.WriteAllTextAsync($"D:\\Temp\\{name}.json", json, Encoding.UTF8);
        }
        #endregion

        #region Data
        public async Task<IconListData> HomeData()
        {
            return await ReadDataJsonFileAsync("home");
        }
        public async Task<IconListData> AppsData()
        {
            return await ReadDataJsonFileAsync("apps");
        }
        public async Task<IconListData> ReferenceData()
        {
            return await ReadDataJsonFileAsync("reference");
        }
        #endregion

        #region WebTitle
        public string WebTitle(string title)
        {
            return "Michal Kopecký - " + title;
        }
        #endregion
    }
}
