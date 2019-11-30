﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI resourceText;
    public TextMeshProUGUI deckText;
    public TextMeshProUGUI discardText;

    public GameObject map;
    public GameObject combatUI;
    
    public void UpdateUI()
    {
        deckText.text = gameManager.deck.Count.ToString();
        discardText.text = gameManager.discardPile.Count.ToString();
    }

    public void ToggleMap()
    {
        map.SetActive(!map.activeInHierarchy);
    }

    public void StartCombat()
    {
        combatUI.SetActive(true);
    }

    public void EndCombat()
    {
        combatUI.SetActive(false);
    }
}
