using Unity.VisualScripting;
using UnityEngine;

public class ChangeParticleSystemMaxParticles : Unit
{
    [DoNotSerialize] // No need to serialize ports.
    public ControlInput inputTrigger; //Adding the ControlInput port variable

    [DoNotSerialize] // No need to serialize ports.
    public ControlOutput outputTrigger;//Adding the ControlOutput port variable.

    [DoNotSerialize] // No need to serialize ports
    public ValueInput particleSystem; // Adding the ValueInput variable for myValueA

    [DoNotSerialize] // No need to serialize ports
    public ValueInput maxParticleCount; // Adding the ValueInput variable for myValueA

    private ParticleSystem ps;
    private int count;

    protected override void Definition()
    {
        //Making the ControlInput port visible, setting its key and running the anonymous action method to pass the flow to the outputTrigger port.
        inputTrigger = ControlInput("", (flow) =>
        {
            ps = flow.GetValue<ParticleSystem>(particleSystem);
            count = flow.GetValue<int>(maxParticleCount);
            var main = ps.main;
            main.maxParticles = count;
            return outputTrigger;
        });

        //Making the ControlOutput port visible and setting its key.
        outputTrigger = ControlOutput("");

        particleSystem = ValueInput<ParticleSystem>("ParticleSystem");
        maxParticleCount = ValueInput<int>("MaxParticleCount");
    }
}
