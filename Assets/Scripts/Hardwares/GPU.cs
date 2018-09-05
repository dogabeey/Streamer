public class GPU : Hardware
{
    public float memory;
    public float bus;

    public GPU()
    {

    }
    public GPU(string modelName, Manufacturer manufacturer, float malfunctionRate, float cost, float memory, float bus, bool isMantadory) : base(modelName, manufacturer, malfunctionRate, cost, isMantadory)
    {
        this.memory = memory;
        this.bus = bus;
    }
}