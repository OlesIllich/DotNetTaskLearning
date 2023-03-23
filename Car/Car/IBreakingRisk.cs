namespace Car
{
    internal interface IBreakingRisk
    {
        event Action BreakingRisk;

        void Broke();
    }
}