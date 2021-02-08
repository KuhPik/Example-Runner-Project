using Kuhpik;
using UnityEngine;

public class PlayerInputSystem : GameSystem, IIniting, IUpdating
{
    [SerializeField] float minDistance;

    Vector3 firstTouchPosition;

    void IIniting.OnInit()
    {
        firstTouchPosition = Input.mousePosition;
    }

    void IUpdating.OnUpdate()
    {
        game.swipeDirection = 0;

        if (Input.GetMouseButtonDown(0))
        {
            firstTouchPosition = Input.mousePosition;
        }

        else if (Input.GetMouseButtonUp(0))
        {
            var direction = Input.mousePosition.x - firstTouchPosition.x;

            if (Mathf.Abs(direction) > minDistance)
            {
                game.swipeDirection = direction > 0 ? 1 : -1;
            }
        }
    }
}
