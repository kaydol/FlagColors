
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using StringExtensions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FlagColors
{
    internal class FlagService
    {
        static string DataFolder = "Data";
        static string DefaultDataFile = "FlagColorsData.xml";

        enum CurrentParsedIndex {
            title, 
            img,
            desc,
            capital
        }

        public static FlagData? LoadDefaultDataFile()
        {
            var path = Path.Combine(
                Path.GetDirectoryName(Application.ExecutablePath)!, DefaultDataFile
            );

            if (!Path.Exists(path))
                return null;
            
            var flagData = Deserialize(path);

            return flagData;
        }

        public static void Serialize(string fileName, FlagData data)
        {
            FileStream fs;

            if (Path.Exists(fileName))
                File.Delete(fileName);

            fs = File.Create(fileName);
            
            XmlSerializer serializer = new XmlSerializer(typeof(FlagData));
            serializer.Serialize(fs, data);

            fs.Close();
        }

        public static FlagData Deserialize(string fileName)
        {
            FileStream fs;

            if (!Path.Exists(fileName))
                throw new FileNotFoundException(fileName);
            
            fs = File.OpenRead(fileName);

            FlagData? flagData;

            XmlSerializer serializer = new XmlSerializer(typeof(FlagData));
            
            flagData = (FlagData?)serializer.Deserialize(fs);

            if (flagData == null)
                throw new SerializationException(
                    string.Format("Could not deserialize existing file {0}", fileName)
                );

            fs.Close();

            return flagData;
        }

        /// <summary>
        /// This is what I used to parse initial data from a saved web page
        /// </summary>
        public static List<FlagModel> ParseWebPage(string pathToFile)
        {
            var fileStream = File.OpenText(pathToFile);
            var line = fileStream.ReadLine();

            var flagModels = new List<FlagModel>();
            var arraySize = 1 + (int)Enum.GetValues(typeof(CurrentParsedIndex)).Cast<CurrentParsedIndex>().Max();
            
            string[] currentParsed = new string[arraySize];
            for (int i = 0; i < currentParsed.Length; ++i)
                currentParsed[i] = string.Empty;

            while (line != null)
            {
                if (line.Contains("title="))
                {
                    var index1 = 1 + line.CustomIndexOf("\"", 0, 2);
                    var index2 = line.CustomIndexOf("\"", 0, 3);

                    var title = line.Substring(index1, index2 - index1);
                    currentParsed[(int)CurrentParsedIndex.title] = title;
                }

                if (line.Contains(".svg"))
                {
                    var index1 = 1 + line.CustomIndexOf("/", 0, 1);
                    var index2 = line.CustomIndexOf("\"", 0, 3);

                    var img = line.Substring(index1, index2 - index1);
                    currentParsed[(int)CurrentParsedIndex.img] = img;
                }

                if (line.Contains("alt="))
                {
                    var index1 = 1 + line.CustomIndexOf("\"", 0, 4);
                    var index2 = line.CustomIndexOf("\"", 0, 5);

                    var desc = line.Substring(index1, index2 - index1);
                    currentParsed[(int)CurrentParsedIndex.desc] = desc;
                }

                if (line.Contains("Capital"))
                {
                    var index1 = 1 + line.CustomIndexOf(">", 0, 3);
                    var index2 = line.CustomIndexOf("<", 0, 4);

                    var cap = line.Substring(index1, index2 - index1);
                    currentParsed[(int)CurrentParsedIndex.capital] = cap;
                }

                if (currentParsed.All(e => e.Trim() != string.Empty)) 
                {
                    flagModels.Add(new FlagModel(
                        currentParsed[(int)CurrentParsedIndex.title],
                        Path.Combine(DataFolder, currentParsed[(int)CurrentParsedIndex.img])
                        )
                    );

                    for (int i = 0; i < currentParsed.Length; ++i)
                        currentParsed[i] = string.Empty;
                }

                line = fileStream.ReadLine();
            }

            return flagModels;
        }

    }
}
