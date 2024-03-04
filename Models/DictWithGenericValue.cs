using System.Collections.Generic;

namespace PathTrainingOoTRandomizer.Models
{
    public class DictWithGenericValue
    {
        public int integerValue { get; set; }
        public string stringValue { get; set; }
        public bool booleanValue { get; set; }


        public List<string> listStringValue { get; set; }
        public List<int> listWithIntValue { get; set; }
        public List<bool> listWithBoolValue { get; set; }


        public Dictionary<string, int> dictionaryWithIntValue { get; set; }
        public Dictionary<string, bool> dictionaryWithBoolValue { get; set; }
        public Dictionary<string, string> dictionaryWithStringValue { get; set; }

    }
}
