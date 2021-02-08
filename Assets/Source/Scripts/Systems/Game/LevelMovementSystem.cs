using Kuhpik;
using UnityEngine;

public class LevelMovementSystem : GameSystem, IUpdating
{
    [SerializeField] float moveSpeed;

    void IUpdating.OnUpdate()
    {
        game.level.transform.Translate(Vector3.forward * (-moveSpeed * Time.deltaTime));
    }
}
