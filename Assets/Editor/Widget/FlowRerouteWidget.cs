using Ludiq;
using UnityEngine;

namespace Bolt.Extensions
{
    [Widget(typeof(FlowReroute))]
    public sealed class FlowRerouteWidget : UnitWidget<FlowReroute>
    {
        //コンストラクタ呼び出し
        public FlowRerouteWidget(FlowCanvas canvas, FlowReroute unit) : base(canvas, unit)
        {
        }

        /// <summary>
        /// 一定周期で呼ばれる
        /// 他にもDraw系があるがイマイチ違いが分かっていない・・・
        /// </summary>
        public override void DrawForeground()
        {
            //ノードの更新を行っている
            //コンストラクタで呼べば良いのでは？と思ったがダメっぽ
            GraphGUI.Node(new Rect(position.x, position.y, _position.width, _position.height), NodeShape.Square, NodeColor.Gray, isSelected);
        }

        /// <summary>
        /// APIにコメントが書かれていないので正確ではないが、
        /// ポジションの変更タイミングで呼ばれてるっぽい
        /// </summary>
        public override void CachePosition()
        {
            //Rectのサイズを変更し、Input, Outputの矢印だけ表示している  
            _position.width = 25;
            _position.height = 25;

            //サイズを変えてRectの位置が変わってしまっているのでノード（unit)のPositionを反映
            _position.x = unit.position.x;
            _position.y = unit.position.y;

            //矢印の位置を調整
            inputs[0].y = _position.y + 5;
            outputs[0].y = _position.y + 5;
        }

        //@todo Cキー押したら生成や、線をダブルクリックしたらそこに追加などの機能を作る
    }
}