using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer
{
    public PowerSupply psu;
    public Motherboard mb;
    public Monitor monitor;
    public RAM[] rams;
    public GPU gpu;
    public Keyboard kb;
    public Mouse mouse;
    public Headphone headphone;
    public Microphone mic;

    public Computer(PowerSupply psu, Motherboard mb, Monitor monitor, RAM[] rams, GPU gpu, Keyboard kb = null, Mouse mouse = null)
    {
        this.psu = psu;
        this.mb = mb;
        this.monitor = monitor;
        this.rams = rams;
        this.gpu = gpu;
        this.kb = kb;
        this.mouse = mouse;
    }
}
