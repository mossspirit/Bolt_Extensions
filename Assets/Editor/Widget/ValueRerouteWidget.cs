using Ludiq;
using System;
using UnityEngine;

namespace Bolt.Extensions
{
    [Widget(typeof(ValueReroute))]
    public sealed class ValueRerouteWidget : UnitWidget<ValueReroute>
    {

        //コンストラクタ呼び出し
        public ValueRerouteWidget(FlowCanvas canvas, ValueReroute unit) : base(canvas, unit)
        {
        }
        private Type lastType = typeof(object);

        /// <summary>
        /// 一定周期で呼ばれる
        /// 他にもDraw系があるがイマイチ違いが分かっていない・・・
        /// </summary>
        public override void DrawForeground()
        {
            //ノードの更新を行っている
            //コンストラクタで呼べば良いのでは？と思ったがダメっぽ
            GraphGUI.Node(new Rect(position.x, position.y, _position.width, _position.height), NodeShape.Square, NodeColor.Gray, isSelected);

            if (unit.input != null && unit.input.connection != null)
            {
                //inputが接続されている時はinputのtypeを反映
                unit.portType = unit.input.connection.source.type;
            }
            else
            {
                //inputが接続されていない時はデフォルトtype
                unit.portType = typeof(object);
            }
            
            if (lastType != unit.portType)
            {
                //最後に反映させたtypeと違かったら更新する
                lastType = unit.portType;
                unit.Define();
            }
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