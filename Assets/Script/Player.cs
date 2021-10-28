using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int CurrentPlayerHP = 4;
    public int CurrentNumberOfCardInDeck = 5;
    public int MaxNumberOfCardInDeck = 5;
    public int NumberOfMagicCardPosed = 0;
    public int NumberOfMonsterCardPosed = 0;

    void Start()
    {
     
    }

    void Update()
    {

    }
    public void HP()
    {
        if (CurrentPlayerHP == 3)
        {

        }
        if (CurrentPlayerHP == 2)
        {

        }
        if (CurrentPlayerHP == 1)
        {

        }
        if (CurrentPlayerHP == 0)
        {

        }
    }
    public void CardNumber()
    {
        if (CurrentNumberOfCardInDeck == 4)
        {

        }
        if (CurrentNumberOfCardInDeck == 3)
        {

        }
        if (CurrentNumberOfCardInDeck == 2)
        {

        }
        if (CurrentNumberOfCardInDeck == 1)
        {

        }
        if (CurrentNumberOfCardInDeck == 0)
        {

        }
        if (MaxNumberOfCardInDeck > 5)
        {

        }
    }
    public void CardNumberPosed()
    {
        if (NumberOfMonsterCardPosed == 4)
        {

        }
        if (NumberOfMonsterCardPosed == 3)
        {

        }
        if (NumberOfMonsterCardPosed == 2)
        {

        }
        if (NumberOfMonsterCardPosed == 1)
        {

        }
        if (NumberOfMonsterCardPosed == 0)
        {

        }
        if (NumberOfMonsterCardPosed > 4)
        {

        }
    }
    public void MagicCardNumberPosed()
    {
        if (NumberOfMagicCardPosed == 1)
        {

        }
        if (NumberOfMagicCardPosed == 0)
        {

        }
        if (NumberOfMagicCardPosed > 1)
        {

        }
    }
}
