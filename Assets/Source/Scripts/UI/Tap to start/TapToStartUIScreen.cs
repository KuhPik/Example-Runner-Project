using Kuhpik;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapToStartUIScreen : UIScreen
{
    [SerializeField] Button taptostartButton;

    public override void Subscribe()
    {
        base.Subscribe();
        taptostartButton.onClick.AddListener(() => Bootstrap.ChangeGameState(EGamestate.Game));
    }
}
