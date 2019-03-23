using System;
using System.Web.Script.Serialization;

namespace VoteCounter.src.Controllers
{
    class SaveLoadController
    {
        public void SaveGame(String fileName, GameState state)
        {
            var json = new JavaScriptSerializer().Serialize(state);

            using (var file = new System.IO.StreamWriter(fileName))
            {
                file.Write(json);
                file.Close();
            }
        }

        public GameState LoadGame(string fileName)
        {
            string json;
            using (var file = new System.IO.StreamReader(fileName))
            {
                json = file.ReadToEnd();
            }
            return new JavaScriptSerializer().Deserialize<GameState>(json);
        }
    }


}
