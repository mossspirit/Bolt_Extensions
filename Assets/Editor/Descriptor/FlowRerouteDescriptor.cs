using Ludiq;

namespace Bolt.Extensions
{
    [Descriptor(typeof(FlowReroute))]
    public sealed class FlowRerouteDescriptor : UnitDescriptor<FlowReroute>
    {
        public FlowRerouteDescriptor(FlowReroute target) : base(target)
        {
        }

        /// <summary>
        /// ポートの定義をする
        /// </summary>
        protected override void DefinedPort(IUnitPort port, UnitPortDescription description)
        {
            //Labelの表示を消す
            description.showLabel = false;
            //ノード(unit?)に反映
            base.DefinedPort(port, description);     
        }
    }
} 