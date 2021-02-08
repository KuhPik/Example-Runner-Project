using Kuhpik;
using NaughtyAttributes;
using UnityEngine;

public class CoinCollectSystem : GameSystem, IIniting
{
    [SerializeField] [Tag] string coinTag;

    void IIniting.OnInit()
    {
        game.player.GetComponent<TriggetListenerComponent>().OnTriggerEnterEvent += CollisionCheck;
    }

    void CollisionCheck(Transform other)
    {
        if (other.CompareTag(coinTag))
        {
            other.gameObject.SetActive(false);
            Debug.Log("Coin Collected");
            game.coinsCollected++;
        }
    }
}
