using Svg;

namespace FlagColors
{
    [Serializable]
    public class FlagData
    {
        public List<FlagModel>? Flags { get; set; }
    }

    [Serializable]
    public class FlagModel
    {
        public string? Name { get; set; }
        public string? PathToPicture { get; set; }
        public string[]? Colors { get; set; }
        public string[]? Shapes { get; set; }

        private SvgDocument? _svg { get; set; }
        
        private FlagModel()
        {
            // parameterless constructor of any access level is needed for serialization
        }

        public FlagModel(string name, string img)
        {
            Name = name;
            PathToPicture = img;
        }

        public void AssignTitle(string title)
        {
            Name = title;
        }

        public void AssignColors(string[] colors)
        {
            Colors = colors;
        }

        public string[] GetColors()
        {
            return Colors ?? Array.Empty<string>();
        }

        public void AssignShapes(string[] shapes)
        {
            Shapes = shapes;
        }

        public string[] GetShapes()
        {
            return Shapes ?? Array.Empty<string>();
        }

        public SvgDocument GetSvgDocument()
        {
            if (_svg == null)
                _svg = SvgDocument.Open(Path.GetDirectoryName(Application.ExecutablePath) + PathToPicture);
            return _svg;
        }
    }
}
