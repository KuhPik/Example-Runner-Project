using Kuhpik;
using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSystem : GameSystem, IUpdating
{
    [SerializeField] [ReadOnly] int currentLine; // -1 - лево, 0 центр, 1 право

    void IUpdating.OnUpdate()
    {
        if (game.swipeDirection != 0)
        {
            if (currentLine != game.swipeDirection)
            {
                currentLine += game.swipeDirection;

                //Добавить код плавного смещения.

                var position = game.player.position;
                position.x = game.linesPositions[currentLine];
                game.player.position = position;
            }
        }
    }
}
