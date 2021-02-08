using Kuhpik;
using UnityEngine;

public class LevelLoadingSystem : GameSystem, IIniting
{
    [SerializeField] string levelsPath;
    [SerializeField] int maxLevels;

    void IIniting.OnInit()
    {
        var level = Mathf.Clamp(player.level, 0, maxLevels - 1);
        var levelGO = Resources.Load<GameObject>(string.Format(levelsPath, level + 1));

        game.level = Instantiate(levelGO);
    }
}
