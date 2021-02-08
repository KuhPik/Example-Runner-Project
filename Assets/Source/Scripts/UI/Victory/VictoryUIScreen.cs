using Kuhpik;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.UI;

public class VictoryUIScreen : UIScreen
{
    [SerializeField] [BoxGroup("Buttons")] Button restartButton;

    public override void Subscribe()
    {
        base.Subscribe();
        restartButton.onClick.AddListener(() => Bootstrap.GameRestart(0));
    }
}
