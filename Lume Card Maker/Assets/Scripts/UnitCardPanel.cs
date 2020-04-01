using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitCardPanel : CardPanel
{
    [Header("Panel References")]
    public InputField healthInput;
    public InputField attackInput;
    public InputField defenseInput;
    public InputField magicInput;
    public InputField speedInput;


    [Header("Card References")]
    public Image healthBorder;
    public Text healthText;

    public Text attackText;
    public Text defenseText;
    public Text magicText;
    public Text speedText;

    public override void LoadStyle(CardStyle style)
    {
        base.LoadStyle(style);

        healthBorder.color = style.borderColor;
        healthText.color = style.borderColor;
        healthText.font = style.nameTextFont;

        attackText.color = style.numbersTextColor;
        attackText.font = style.numbersTextFont;
        defenseText.color = style.numbersTextColor;
        defenseText.font = style.numbersTextFont;
        magicText.color = style.numbersTextColor;
        magicText.font = style.numbersTextFont;
        speedText.color = style.numbersTextColor;
        speedText.font = style.numbersTextFont;

        art.sprite = style.unitDefaultImage;
    }

    public void HealthInputEvent()
    {
        healthText.text = healthInput.text;
    }

    public void AttackInputEvent()
    {
        attackText.text = attackInput.text;
    }

    public void DefenseInputEvent()
    {
        defenseText.text = defenseInput.text;
    }

    public void MagicInputEvent()
    {
        magicText.text = magicInput.text;
    }

    public void SpeedInputEvent()
    {
        speedText.text = speedInput.text;
    }
}
