using Ludiq;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Bolt.Extensions{
    [Descriptor(typeof(Comment))]
    public class CommentDescriptor : UnitDescriptor<Comment>
    {
        public CommentDescriptor(Comment unit) : base(unit) { }

        protected override EditorTexture DefinedIcon()
        {
            return EditorTexture.Single(AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Editor/Resources/comment.png"));
        }
    }
}