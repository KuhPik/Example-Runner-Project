using Kuhpik;
using System.Collections.Generic;

public class LinePositioningSystem : GameSystem, IIniting
{
    void IIniting.OnInit()
    {
        InitDictionary();
        PlaceObjects();
    }

    void PlaceObjects()
    {
        foreach (var @object in FindObjectsOfType<LineObjectComponent>())
        {
            var position = @object.transform.position;
            position.x = game.linesPositions[@object.Line];
            @object.transform.position = position;
        }
    }

    void InitDictionary()
    {
        game.linesPositions = new Dictionary<int, float>();

        for (int i = 0; i < config.LineKeys.Length; i++)
        {
            game.linesPositions.Add(config.LineKeys[i], config.LineValues[i]);
        }
    }
}
