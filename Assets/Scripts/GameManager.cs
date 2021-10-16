using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float sumOfTwoNumbers;
    public float[] input;
    private float[] sortedArray;
    
    private void Awake()
    {
        GameData.gameManager = this;
    }
    
    private void Start()
    {
        GameData.gameUiController.Init(sumOfTwoNumbers);
        GameData.gameUiController.InitUnSort(input);
        sortedArray = GameData.GetQuickSortManager().SortArray(input);
        GameData.gameUiController.InitSorted(sortedArray);
        GameData.searchAlgorithmManager.Init(sortedArray , sumOfTwoNumbers);
    }

    public void FoundResult(int minIndex , int maxIndex)
    {
        GameData.gameUiController.InitSearch(sortedArray, minIndex, maxIndex);
    }

    public void NotFoundResult()
    {
        GameData.gameUiController.InitNotFound();
    }
}
