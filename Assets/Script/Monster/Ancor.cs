using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ancor : MonoBehaviour
{
    public int CurrentHPAncor = 3;
    public int MaxHPAncor = 3;
    public int CurrentLvlAncor = 1;
    public int MaxLvlAncor = 2;
    public int CurrentDMGAncor = 1;
    public int MaxDMGAncor = 2;
    public bool AncorDead;

    void Start()
    {
        
    }

    void Update()
    {
        AncorHP();
        AncorStat();
    }

    public void AncorHP()
    {
        if (CurrentHPAncor == 3)
        {

        }
        if (CurrentHPAncor == 2)
        {

        }
        if (CurrentHPAncor == 1)
        {

        }
        if (CurrentHPAncor == 0)
        {
            AncorDead = true;
            if (AncorDead == true)
            {
                Destroy(GameObject.Find("Sprite-CardAncor"), 1f);
            }
        }
    }

    public void AncorStat()
    {
        if (CurrentLvlAncor == 2)
        {
            CurrentDMGAncor = 2;
            MaxHPAncor = 4;
        }
    }
}
