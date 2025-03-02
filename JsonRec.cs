using System.Collections.Generic;

namespace DrawJson
{
    //public class ObjectData
    //{
    //    public int PosX { get; }
    //    public int PosY { get; }
    //    public int Width { get; }
    //    public int Height { get; }
    //    public string Text { get; }

    //    public ObjectData(ObjectRectangle rec)
    //    {
    //        PosX = int.Parse(rec.PosX.Text);
    //        PosY = int.Parse(rec.PosY.Text);
    //        Width = int.Parse(rec.Width.Text);
    //        Height = int.Parse(rec.Heigth.Text);
    //        Text = rec.Name.Text;
    //    }
    //}

    public class ObjectInfo
    {
        public string MaxPlayers { get; }
        public string File { get; }

        public ObjectInfo(string players, string file)
        {
            MaxPlayers = players;
            File = file;
        }
    }

    public class JsonData
    {
        public ObjectInfo Info;
        public List<Players> Players;

        public JsonData(ObjectInfo info, List<Players> data)
        {
            Info = info;
            Players = data;
        }
    }
}
