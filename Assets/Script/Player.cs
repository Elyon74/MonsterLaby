using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int CurrentPlayerHP = 5;
    public int CurrentNumberOfCardInDeck = 5;
    public int MaxNumberOfCardInDeck = 5;
    public int NumberOfMagicCardPosed = 0;
    public int NumberOfMonsterCardPosed = 0;
    public bool GameOver;
    public bool PlayerCanDrawACard;
    public bool PlayerWithdrawACard;
    public bool PlayerWithdrawAMonsterCardPosed;
    public bool PlayerWithdrawAMagicCardPosed;

    void Start()
    {
     
    }

    void Update()
    {
        HP();
        CardNumber();
        CardNumberPosed();
        MagicCardNumberPosed();
        MaxNumberOfCard();
        EchapMenu();
    }

    public void EchapMenu()
    {
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene(2);
        }
    }

    public void HP()
    {
        if (CurrentPlayerHP == 4)
        {
            Destroy(GameObject.Find("Sprite - HPNumber(4)"), 1f);
        }
        if (CurrentPlayerHP == 3)
        {
            Destroy(GameObject.Find("Sprite - HPNumber(3)"), 1f);
        }
        if (CurrentPlayerHP == 2)
        {
            Destroy(GameObject.Find("Sprite - HPNumber(2)"), 1f);
        }
        if (CurrentPlayerHP == 1)
        {
            Destroy(GameObject.Find("Sprite - HPNumber(1)"), 1f);
        }
        if (CurrentPlayerHP == 0)
        {
            Destroy(GameObject.Find("Sprite - HPNumber"), 1f);
            Destroy(GameObject.Find("Sprite - PlayerTemp"), 1f);
            GameOver = true;
            if (GameOver == true)
            {
                SceneManager.LoadScene(3);
            }
        }
    }

    public void CardNumber()
    {
        if (CurrentNumberOfCardInDeck == 5)
        {
            PlayerCanDrawACard = false;
            PlayerWithdrawACard = false;
        }
        if (CurrentNumberOfCardInDeck == 4)
        {
            PlayerCanDrawACard = true;
            PlayerWithdrawACard = false;
        }
        if (CurrentNumberOfCardInDeck == 3)
        {
            PlayerCanDrawACard = true;
            PlayerWithdrawACard = false;
        }
        if (CurrentNumberOfCardInDeck == 2)
        {
            PlayerCanDrawACard = true;
            PlayerWithdrawACard = false;
        }
        if (CurrentNumberOfCardInDeck == 1)
        {
            PlayerCanDrawACard = true;
            PlayerWithdrawACard = false;
        }
        if (CurrentNumberOfCardInDeck == 0)
        {
            PlayerCanDrawACard = true;
            PlayerWithdrawACard = false;
        }
        if (CurrentNumberOfCardInDeck > 5)
        {
            PlayerWithdrawACard = true;
            PlayerCanDrawACard = false;
        }
    }

    public void CardNumberPosed()
    {
        if (NumberOfMonsterCardPosed == 4)
        {
            PlayerWithdrawAMonsterCardPosed = false;
        }
        if (NumberOfMonsterCardPosed == 3)
        {
            PlayerWithdrawAMonsterCardPosed = false;
        }
        if (NumberOfMonsterCardPosed == 2)
        {
            PlayerWithdrawAMonsterCardPosed = false;
        }
        if (NumberOfMonsterCardPosed == 1)
        {
            PlayerWithdrawAMonsterCardPosed = false;
        }
        if (NumberOfMonsterCardPosed == 0)
        {
            PlayerWithdrawAMonsterCardPosed = false;
        }
        if (NumberOfMonsterCardPosed > 4)
        {
            PlayerWithdrawAMonsterCardPosed = true;
        }
    }

    public void MagicCardNumberPosed()
    {
        if (NumberOfMagicCardPosed == 1)
        {
            PlayerWithdrawAMagicCardPosed = false;
        }
        if (NumberOfMagicCardPosed == 0)
        {
            PlayerWithdrawAMagicCardPosed = false;
        }
        if (NumberOfMagicCardPosed > 1)
        {
            PlayerWithdrawAMagicCardPosed = true;
        }
    }

    public void MaxNumberOfCard()
    {
        if (MaxNumberOfCardInDeck == 4 & CurrentNumberOfCardInDeck == 4)
        {
            PlayerCanDrawACard = false;
        }
        if (MaxNumberOfCardInDeck == 4 & CurrentNumberOfCardInDeck == 3)
        {
            PlayerCanDrawACard = true;
        }
        if (MaxNumberOfCardInDeck == 3 & CurrentNumberOfCardInDeck == 3)
        {
            PlayerCanDrawACard = false;
        }
        if (MaxNumberOfCardInDeck == 3 & CurrentNumberOfCardInDeck == 2)
        {
            PlayerCanDrawACard = true;
        }
        if (MaxNumberOfCardInDeck == 2 & CurrentNumberOfCardInDeck == 2)
        {
            PlayerCanDrawACard = false;
        }
        if (MaxNumberOfCardInDeck == 2 & CurrentNumberOfCardInDeck == 1)
        {
            PlayerCanDrawACard = true;
        }
        if (MaxNumberOfCardInDeck == 1 & CurrentNumberOfCardInDeck == 1)
        {
            PlayerCanDrawACard = false;
        }
        if (MaxNumberOfCardInDeck == 1 & CurrentNumberOfCardInDeck == 0)
        {
            PlayerCanDrawACard = true;
        }
        if (MaxNumberOfCardInDeck == 0)
        {
            MaxNumberOfCardInDeck = 1;
        }
        if (MaxNumberOfCardInDeck > 5)
        {
            MaxNumberOfCardInDeck = 5;
        }
    }
}
