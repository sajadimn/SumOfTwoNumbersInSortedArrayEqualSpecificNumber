using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchAlgorithmManager : MonoBehaviour
{
    private float _sumOfTwoNumbers;

    private void Awake()
    {
        GameData.searchAlgorithmManager = this;
    }

    public void Init(float[] sortedArray, float sumOfTwoNumbers)
    {
        _sumOfTwoNumbers = sumOfTwoNumbers;
        Detection(sortedArray, 0, (sortedArray.Length - 1));
    }

    private void Detection(float[] sortedArray, int minIndex, int maxIndex)
    {
        if (minIndex != maxIndex && minIndex >= 0 && maxIndex < sortedArray.Length)
        {
            if (_sumOfTwoNumbers < sortedArray[minIndex] + sortedArray[maxIndex])
            {
                Detection(sortedArray, minIndex, maxIndex - 1);
            }
            else if (_sumOfTwoNumbers > sortedArray[minIndex] + sortedArray[maxIndex])
            {
                Detection(sortedArray, minIndex + 1, maxIndex);
            }
            else
            {
                GameData.gameManager.FoundResult(minIndex, maxIndex);
            }
        }
        else
        {
            GameData.gameManager.NotFoundResult();
        }
    }
}