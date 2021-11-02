using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle01 : MonoBehaviour
{
    public int CurrentBattle01ComputerHP = 5;
    public int CurrentBattle01ComputerNumberOfCardInDeck = 5;
    public int MaxBattle01ComputerNumberOfCardInDeck = 5;
    public int Battle01ComputerNumberOfMagicCardPosed = 0;
    public int Battle01ComputerNumberOfMonsterCardPosed = 0;
    public bool Battle01Win;
    public bool Battle01CanDrawACard;
    public bool Battle01WithdrawACard;
    public bool Battle01WithdrawAMonsterCardPosed;
    public bool Battle01WithdrawAMagicCardPosed;

    void Start()
    {

    }

    void Update()
    {
        Battle01HP();
        Battle01CardNumber();
        Battle01CardNumberPosed();
        Battle01MagicCardNumberPosed();
        Battle01MaxNumberOfCard();
    }

    public void Battle01HP()
    {
        if (CurrentBattle01ComputerHP == 4)
        {

        }
        if (CurrentBattle01ComputerHP == 3)
        {

        }
        if (CurrentBattle01ComputerHP == 2)
        {

        }
        if (CurrentBattle01ComputerHP == 1)
        {

        }
        if (CurrentBattle01ComputerHP == 0)
        {
            Battle01Win = true;
            if (Battle01Win == true)
            {
                Destroy(GameObject.Find("Sprite-EnnemyCase"), 1f);
            }
        }
    }
    public void Battle01CardNumber()
    {
        if (CurrentBattle01ComputerNumberOfCardInDeck == 5)
        {
            Battle01CanDrawACard = false;
            Battle01WithdrawACard = false;
        }
        if (CurrentBattle01ComputerNumberOfCardInDeck == 4)
        {
            Battle01CanDrawACard = true;
            Battle01WithdrawACard = false;
        }
        if (CurrentBattle01ComputerNumberOfCardInDeck == 3)
        {
            Battle01CanDrawACard = true;
            Battle01WithdrawACard = false;
        }
        if (CurrentBattle01ComputerNumberOfCardInDeck == 2)
        {
            Battle01CanDrawACard = true;
            Battle01WithdrawACard = false;
        }
        if (CurrentBattle01ComputerNumberOfCardInDeck == 1)
        {
            Battle01CanDrawACard = true;
            Battle01WithdrawACard = false;
        }
        if (CurrentBattle01ComputerNumberOfCardInDeck == 0)
        {
            Battle01CanDrawACard = true;
            Battle01WithdrawACard = false;
        }
        if (CurrentBattle01ComputerNumberOfCardInDeck > 5)
        {
            Battle01WithdrawACard = true;
            Battle01CanDrawACard = false;
        }
    }

    public void Battle01CardNumberPosed()
    {
        if (Battle01ComputerNumberOfMonsterCardPosed == 4)
        {
            Battle01WithdrawAMonsterCardPosed = false;
        }
        if (Battle01ComputerNumberOfMonsterCardPosed == 3)
        {
            Battle01WithdrawAMonsterCardPosed = false;
        }
        if (Battle01ComputerNumberOfMonsterCardPosed == 2)
        {
            Battle01WithdrawAMonsterCardPosed = false;
        }
        if (Battle01ComputerNumberOfMonsterCardPosed == 1)
        {
            Battle01WithdrawAMonsterCardPosed = false;
        }
        if (Battle01ComputerNumberOfMonsterCardPosed == 0)
        {
            Battle01WithdrawAMonsterCardPosed = false;
        }
        if (Battle01ComputerNumberOfMonsterCardPosed > 4)
        {
            Battle01WithdrawAMonsterCardPosed = true;
        }
    }

    public void Battle01MagicCardNumberPosed()
    {
        if (Battle01ComputerNumberOfMagicCardPosed == 1)
        {
            Battle01WithdrawAMagicCardPosed = false;
        }
        if (Battle01ComputerNumberOfMagicCardPosed == 0)
        {
            Battle01WithdrawAMagicCardPosed = false;
        }
        if (Battle01ComputerNumberOfMagicCardPosed > 1)
        {
            Battle01WithdrawAMagicCardPosed = true;
        }
    }

    public void Battle01MaxNumberOfCard()
    {
        if (MaxBattle01ComputerNumberOfCardInDeck == 4 & CurrentBattle01ComputerNumberOfCardInDeck == 4)
        {
            Battle01CanDrawACard = false;
        }
        if (MaxBattle01ComputerNumberOfCardInDeck == 4 & CurrentBattle01ComputerNumberOfCardInDeck == 3)
        {
            Battle01CanDrawACard = true;
        }
        if (MaxBattle01ComputerNumberOfCardInDeck == 3 & CurrentBattle01ComputerNumberOfCardInDeck == 3)
        {
            Battle01CanDrawACard = false;
        }
        if (MaxBattle01ComputerNumberOfCardInDeck == 3 & CurrentBattle01ComputerNumberOfCardInDeck == 2)
        {
            Battle01CanDrawACard = true;
        }
        if (MaxBattle01ComputerNumberOfCardInDeck == 2 & CurrentBattle01ComputerNumberOfCardInDeck == 2)
        {
            Battle01CanDrawACard = false;
        }
        if (MaxBattle01ComputerNumberOfCardInDeck == 2 & CurrentBattle01ComputerNumberOfCardInDeck == 1)
        {
            Battle01CanDrawACard = true;
        }
        if (MaxBattle01ComputerNumberOfCardInDeck == 1 & CurrentBattle01ComputerNumberOfCardInDeck == 1)
        {
            Battle01CanDrawACard = false;
        }
        if (MaxBattle01ComputerNumberOfCardInDeck == 1 & CurrentBattle01ComputerNumberOfCardInDeck == 0)
        {
            Battle01CanDrawACard = true;
        }
        if (MaxBattle01ComputerNumberOfCardInDeck == 0)
        {
            MaxBattle01ComputerNumberOfCardInDeck = 1;
        }
        if (MaxBattle01ComputerNumberOfCardInDeck > 5)
        {
            MaxBattle01ComputerNumberOfCardInDeck = 5;
        }
    }
}
