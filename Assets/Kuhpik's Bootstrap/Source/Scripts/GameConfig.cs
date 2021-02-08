using UnityEngine;
using NaughtyAttributes;

namespace Kuhpik
{
    [CreateAssetMenu(menuName = "Kuhpik/GameConfig")]
    public sealed class GameConfig : ScriptableObject
    {
        // Example
        // [SerializeField] [BoxGroup("Moving")] private float moveSpeed;
        // public float MoveSpeed => moveSpeed;

        //Line - линия, по которой бежит игрок.
        [SerializeField] int[] lineKeys;
        [SerializeField] float[] lineValues;

        public int[] LineKeys => lineKeys;
        public float[] LineValues => lineValues;
    }
}