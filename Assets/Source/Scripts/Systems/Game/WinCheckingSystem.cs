using Kuhpik;
using UnityEngine;

public class WinCheckingSystem : GameSystem, IUpdating
{
    [SerializeField] int coinsToWin;

    void IUpdating.OnUpdate()
    {
        if (game.coinsCollected >= coinsToWin)
        {
            Bootstrap.ChangeGameState(EGamestate.Victory);
            player.level++;
        }
    }
}
