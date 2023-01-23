namespace DotNetLearning.TuplesTasks
{
    public class TuplesTasks
    {
        public (string String, int Number, bool Bool) GetTuple(string firstLetter, int number, bool boolParam)
        {
            
            var tuple = (firstLetter, number, boolParam);
            return tuple;
        }

        public string GeStringPart(Tuple<string,int,bool> tuple)
        {
            var stringPart = tuple.Item1;
            return stringPart;
        }

        public int GetIntPart(Tuple<string, int, bool> tuple)
        {
            var intPart = tuple.Item2;
            return intPart;
        }

        public bool GetBoolPart(Tuple<string, int, bool> tuple)
        {
            var boolPart = tuple.Item3;
            return boolPart;
        }
    }
}
