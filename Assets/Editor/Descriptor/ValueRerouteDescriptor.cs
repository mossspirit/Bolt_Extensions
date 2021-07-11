using Bolt;
using Ludiq;
using UnityEditor;
using UnityEngine;

namespace Bolt.Extensions
{
    [Descriptor(typeof(ValueReroute))]
    public sealed class ValueRerouteDescriptor : UnitDescriptor<ValueReroute>
    {
        public ValueRerouteDescriptor(ValueReroute target) : base(target)
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