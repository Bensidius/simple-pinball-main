using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Survivalist : Achievement
{
    public override Image Icon
    {
        get => AchievementGUI.instance.Survivalist;
    }
}