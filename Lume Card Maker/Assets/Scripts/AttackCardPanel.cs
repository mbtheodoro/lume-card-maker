using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackCardPanel : CardPanel
{
    [Header("Panel References")]
    public InputField baseDamageInput;

    [Header("Card References")]
    public Image baseDamageBorder;
    public Text baseDamageText;

    public override void LoadStyle(CardStyle style)
    {
        base.LoadStyle(style);

        baseDamageBorder.color = style.borderColor;
        baseDamageText.font = style.nameTextFont;
        baseDamageText.color = style.borderColor;
    }

    public void BaseDamageInputEvent()
    {
        baseDamageText.text = baseDamageInput.text;
    }
}
