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

    [DoNotSerialize] // No need to serialize ports
    public ValueOutput particleSystemOutput; // Adding the ValueInput variable for myValueA

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
        outputTrigger = ControlOutput("outputTrigger");

        particleSystem = ValueInput<ParticleSystem>("ParticleSystem");
        maxParticleCount = ValueInput<int>("MaxParticleCount");
        particleSystemOutput = ValueOutput<ParticleSystem>("System", (flow) => flow.GetValue<ParticleSystem>(particleSystem));

        Succession(inputTrigger, outputTrigger); //Specifies that the input trigger port's input exits at the output trigger port. Not setting your succession also dims connected nodes, but the execution still completes.
        Assignment(inputTrigger, particleSystemOutput);//Specifies that data is written to the result string output when the inputTrigger is triggered.
    }
}
