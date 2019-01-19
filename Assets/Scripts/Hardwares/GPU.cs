public class GPU : Hardware
{
    public float memory;
    public float bus;

    public GPU()
    {

    }
    public GPU(string modelName,string manufacturer, float malfunctionRate, float cost, float memory, float bus, bool isMantadory) : base(modelName, manufacturer, malfunctionRate, cost)
    {
        this.memory = memory;
        this.bus = bus;
    }
}