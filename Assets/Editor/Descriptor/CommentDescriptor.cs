using Ludiq;
using UnityEditor;
using UnityEngine;

namespace Bolt.Extensions{
    [Descriptor(typeof(Comment))]
    public class CommentDescriptor : UnitDescriptor<Comment>
    {
        public CommentDescriptor(Comment unit) : base(unit) { }

        /// <summary>
        /// アイコンの設定をする
        /// </summary>
        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Editor/Resources/comment.png"));
        }
    }
}