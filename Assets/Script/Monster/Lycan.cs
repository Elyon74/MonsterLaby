using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lycan : MonoBehaviour
{
    public int CurrentHPLycan = 2;
    public int MaxHPLycan = 2;
    public int CurrentLvlLycan = 1;
    public int MaxLvlLycan = 2;
    public int CurrentDMGLycan = 2;
    public int MaxDMGLycan = 3;
    public bool LycanDead;

    void Start()
    {
        
    }

    void Update()
    {
        LycanHP();
        LycanStat();
    }

    public void LycanHP()
    {
        if (CurrentHPLycan == 3)
        {

        }
        if (CurrentHPLycan == 2)
        {

        }
        if (CurrentHPLycan == 1)
        {

        }
        if (CurrentHPLycan == 0)
        {
            LycanDead = true;
            if (LycanDead == true)
            {
                Destroy(GameObject.Find("Sprite-CardLycan"), 1f);
            }
        }
    }
    public void LycanStat()
    {
        if (CurrentLvlLycan == 2)
        {
            CurrentDMGLycan = 3;
            MaxHPLycan = 3;
        }
    }
}
