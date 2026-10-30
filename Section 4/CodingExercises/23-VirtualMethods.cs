

namespace Coding.Exercise
{
    public class Exercise
    {
        public List<string> ProcessAll(List<string> words)
        {
            var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };
    
            List<string> result = words;
            foreach (var stringsProcessor in stringsProcessors)
            {
                result = stringsProcessor.Process(result);
            }
            return result;
        }
    }
    
    public class StringsProcessor
    {
        public List<string> Process(List<string> list)
        {
            List<string> newList = new List<string>();   
            foreach (var item in list)
            {
                newList.Add(ProcessString(item));
            }
            return newList;
        }

        protected virtual string ProcessString(string str)
        {
            return str;
        }
    }

    public class StringsTrimmingProcessor : StringsProcessor
    {
        protected override string ProcessString(string str)
        {
            return str.Substring(0, str.Length / 2);
        }
    }

    public class StringsUppercaseProcessor : StringsProcessor
    {
        protected override string ProcessString(string str)
        {
            return str.ToUpper();
        }
    }
}
