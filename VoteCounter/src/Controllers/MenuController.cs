using System;
using System.Web.Script.Serialization;

namespace VoteCounter.src.Controllers
{
    class SaveLoadController
    {
        public void SaveGame(String fileName, GameState state)
        {
            var json = new JavaScriptSerializer().Serialize(state);

            var file = new System.IO.StreamWriter(fileName);

            file.Write(json);
            file.Close();
        }

        public GameState LoadGame(string fileName)
        {
            var file = new System.IO.StreamReader(fileName);

            var json = file.ReadToEnd();
            file.Close();

            return new JavaScriptSerializer().Deserialize<GameState>(json);
        }
    }


}
