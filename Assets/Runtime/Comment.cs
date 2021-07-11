using Ludiq;
using UnityEngine;

namespace Bolt.Extensions
{
    [UnitTitle("Comment")]
    [UnitShortTitle("")]
    public class Comment : Unit
    {
        [Inspectable]
        public Color color;

        [Inspectable]
        [UnitHeaderInspectable]
        [InspectorTextArea()]
        public string comment;
        protected override void Definition()
        {
        }

        //選択していなくてもアクティブにする
        public override bool isControlRoot { get { return true; } }
    }
        
}
