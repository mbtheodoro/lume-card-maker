using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipCardPanel : CardPanel
{
    public CardStyle equipStyle;

    public override void LoadStyle(CardStyle style)
    {
        base.LoadStyle(equipStyle);
    }
}