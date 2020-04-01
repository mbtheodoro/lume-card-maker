using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelSelector : MonoBehaviour
{
    public Dropdown panelSelector;
    public Dropdown colorSelector;

    public List<CardPanel> panels;
    public List<CardStyle> styles;

    private int activePanel = 0;

    // Start is called before the first frame update
    public void SelectPanel()
    {
        panels[activePanel].gameObject.SetActive(false);

        activePanel = panelSelector.value;

        panels[activePanel].gameObject.SetActive(true);
        SelectColor();
    }

    public void SelectColor()
    {
        panels[activePanel].LoadStyle(styles[colorSelector.value]);
    }

    public RectTransform GetActiveCard()
    {
        return panels[activePanel].card;
    }

    private void Start()
    {
        SelectPanel();
    }
}
