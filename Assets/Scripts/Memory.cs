﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Assertions;

public class Memory : MonoBehaviour
{
    protected Hashtable statistics;     // Dictionnaire de stats
    [SerializeField]
    protected List<string> statNames;   // Liste des stats
    private int i;
    public static Memory instance;
    public int nombreMur = 1;
    public int nombreMonstre = 1;
    public int nombreOutil = 1;
    public int nombreArbre = 1;
    public bool engueule = false;
    [SerializeField]
    public int day = 1;

    public static Memory Instance
    {
        get
        {
            return instance;
        }
    }

    // Use this for initialization
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
            statistics = new Hashtable();
            for (i = 0; i < statNames.Count; i++)
            {
                statistics[statNames[i]] = 0;
            }
        }
        
    }
    
    public Hashtable GetStatistics()
    {
        return statistics;
    }

    public void SetStatistics(Hashtable stat)
    {
        statistics = stat;
    }

    public List<string> GetStatNames()
    {
        return statNames;
    }

    public int GetDay()
    {
        return day;
    }

    public void DayIncrement()
    {
        day += 1;
    }

    // BlockType : 0 = mur / 1 = monstre / 2 = outil / 3 = arbre
    public void AddBlocks(int blockType, int number)
    {
        bool assertBlockType = true;
        if (blockType < 0 || blockType > 3 || number < 1)
            assertBlockType = false;
        Assert.IsTrue(assertBlockType);
        if (blockType == 0)
            nombreMur += number;
        else if (blockType == 1)
            nombreMonstre += number;
        else if (blockType == 2)
            nombreOutil += number;
        else
            nombreArbre += number;
    }

    public void RemoveBlocks(int blockType, int number)
    {
        bool assertBlockType = true;
        if (blockType < 0 || blockType > 3 || number < 1)
            assertBlockType = false;
        Assert.IsTrue(assertBlockType);
        if (blockType == 0)
            nombreMur -= number;
        else if (blockType == 1)
            nombreMonstre -= number;
        else if (blockType == 2)
            nombreOutil -= number;
        else
            nombreArbre -= number;
    }

    public void Engueule()
    {
        engueule = true;
    }

    public bool GetEngueule()
    {
        return engueule;
    }
}
