using System.Text.Json;

namespace DrawJson
{
    public  class WorkFromFile
    {

        public void SaveToFile(string path, string data)
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

            File.WriteAllText(path, data);
        }

        //public List<ObjectData> LoadFromFile(string path)
        //{
        //    string json = File.ReadAllText(path);
        //    var options = new JsonSerializerOptions { WriteIndented = true };
        //    var myObj = JsonSerializer.Deserialize<JsonData>(json);
        //    return myObj.objectData;
        //}
    }
}
