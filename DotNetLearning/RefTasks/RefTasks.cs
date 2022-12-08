namespace DotNetLearning.RefTasks
{
    public class RefTasks
    {
        public void RefValueType(ref int value)
        {
            value += 10;
        }

        public void SimpleReferenceType(RefTasksParam refTasksParam)
        {
            refTasksParam.Value = "new Value";
        }

        public void RefReferenceType(ref RefTasksParam refTasksParam)
        {
            refTasksParam.Value = "new Value";
            refTasksParam = new RefTasksParam() { Value = "new new Value" };
        }
    }

    public class RefTasksParam
    {
        public string Value { get; set; }
    }
}
