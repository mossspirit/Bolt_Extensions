using Ludiq;


namespace Bolt.Extensions
{
    public sealed class FlowReroute : Unit
    {
        [DoNotSerialize]
        [PortLabelHidden]
        public ControlInput input;
        [DoNotSerialize]
        [PortLabelHidden]
        public ControlOutput output;

        protected override void Definition()
        {
            input = ControlInput("in", (flow) => { return output; });
            output = ControlOutput("out");
            Succession(input, output);
        }
    }
}