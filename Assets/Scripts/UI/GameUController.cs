using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUController : MonoBehaviour
{
    public GameObject slice;
    public GameObject unSortContent;
    public GameObject sortedContent;
    public GameObject searchContent;
    public GameObject notFound;
    public Text sumOfTwoNumbersValue;
    public Color unSortColor = new Color();
    public Color sortedColor = new Color();
    public Color searchColor = new Color();

    private void Awake()
    {
        GameData.gameUiController = this;
    }

    public void Init(float sumOfTwoNumbers)
    {
        sumOfTwoNumbersValue.text = sumOfTwoNumbers.ToString();
    }
    
    public void InitUnSort(float[] unSort)
    {
        for (int i = 0; i < unSort.Length; i++)
        {
            var newSlice = Instantiate(slice, unSortContent.transform);
            var newSliceController = newSlice.GetComponent<SliceController>();
            newSliceController.Init(unSort[i]);
            newSliceController.SetAsResult(unSortColor);        }
    }
    
    public void InitSorted(float[] sorted)
    {
        for (int i = 0; i < sorted.Length; i++)
        {
            var newSlice = Instantiate(slice, sortedContent.transform);
            var newSliceController = newSlice.GetComponent<SliceController>();
            newSliceController.Init(sorted[i]);
            newSliceController.SetAsResult(sortedColor);
        }
    }
    
    public void InitSearch(float[] sorted , int minIndex , int maxIndex)
    {
        notFound.SetActive(false);
        searchContent.SetActive(true);
        for (int i = 0; i < sorted.Length; i++)
        {
            var newSlice = Instantiate(slice, searchContent.transform);
            var newSliceController = newSlice.GetComponent<SliceController>();
            newSliceController.Init(sorted[i]);
            if (i == minIndex || i == maxIndex)
            {
                newSliceController.SetAsResult(searchColor);
            }
            else
            {
                newSliceController.SetAsResult(sortedColor);
            }
        }
    }

    public void InitNotFound()
    {
        searchContent.SetActive(false);
        notFound.SetActive(true);
    }
}
