using Newtonsoft.Json;
namespace DrawJson
{
    public  class WorkFromFile
    {

        public void SaveToFile(string path, string data, string name)
        {
            //string json = "{ \"info\" : { \"Players\" : \" "+data.objectInfo.Players+"\", \"File\" : \" "+ @data.objectInfo.File +"\" }";
            //for (int i = 0; i < data.objectData.Count; i++)
            //{
            //    json += " ,\"Player"+i.ToString() +"\" : ";
            //    foreach (var player in data.objectData[i])
            //    {
            //        json += " [{ \"PosX\" : "+ player.PosX.Text +", \"PosY\" : "+player.PosY.Text+", \"Width\" : "+player.Width.Text+", \"Heigth\" : "+player.Heigth.Text+", \"Text \" : "+player.Name.Text+"}]";
            //    }
            //}
            //json += "}";

            File.WriteAllText(path + name + "Max.json", data);
        }

        public List<ObjectRectangle> LoadFromFile(string path)
        {
            var json = File.ReadAllText(path);
            var data = JsonConvert.DeserializeObject<List<ObjectRectangle>>(json);
            return data;
        }
    }
}
