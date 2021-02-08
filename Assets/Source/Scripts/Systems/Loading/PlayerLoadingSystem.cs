using Kuhpik;
using NaughtyAttributes;
using UnityEngine;

public class PlayerLoadingSystem : GameSystem, IIniting
{
    [SerializeField] [Tag] string playerTag;

    void IIniting.OnInit()
    {
        game.player = GameObject.FindGameObjectWithTag(playerTag).transform;
    }
}
