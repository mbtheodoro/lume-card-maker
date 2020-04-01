using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardPanel : MonoBehaviour
{
    [Header("Panel References")]
    public InputField nameInput;
    public InputField descriptionInput;
    public InputField flavorInput;

    [Header("Card References")]
    public RectTransform card;

    public Image cardIcon;
    public Image art;
    public Image nameBackground;
    public Image descriptionBackground;
    public Text nameText;
    public Text descriptionText;
    public Text flavorText;

    void OnEnable()
    {
        card.gameObject.SetActive(true);
    }

    private void OnDisable()
    {
        card.gameObject.SetActive(false);
    }

    public virtual void LoadStyle(CardStyle style)
    {
        cardIcon.sprite = style.cardIcon;

        nameBackground.color = style.mainColorA;
        nameText.font = style.nameTextFont;
        nameText.color = style.nameTextColor;

        descriptionBackground.color = style.mainColorB;
        descriptionText.font = style.descriptionTextFont;
        descriptionText.color = style.descriptionTextColor;

        flavorText.color = style.flavorTextColor;
        flavorText.font = style.flavorTextFont;
    }

    public void NameInputEvent()
    {
        nameText.text = nameInput.text;
    }

    public void DescriptionInputEvent()
    {
        descriptionText.text = descriptionInput.text;
    }

    public void FlavorInputEvent()
    {
        flavorText.text = flavorInput.text;
    }
}
