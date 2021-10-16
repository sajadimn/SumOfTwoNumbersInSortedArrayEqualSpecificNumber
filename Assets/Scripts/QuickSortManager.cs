using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSortManager
{
    public float[] SortArray(float[] array)
    {
        Quicksort(array, 0, array.Length - 1);
        return array;
    }

    private void Quicksort(float[] array, int start, int end)
    {
        if (start >= end)
            return;
        int partition = Partition(array, start, end);
        Quicksort(array, start, partition - 1);
        Quicksort(array, partition + 1, end);
    }

    private int Partition(float[] array, int start, int end)
    {
        float pivot = array[end];
        int smallerThanPivot = start - 1;
        for (int j = start; j < end; ++j)
        {
            if (array[j] <= pivot)
            {
                ++smallerThanPivot;
                float temp = array[smallerThanPivot];
                array[smallerThanPivot] = array[j];
                array[j] = temp;
            }
        }

        ++smallerThanPivot;
        float temp2 = array[smallerThanPivot];
        array[smallerThanPivot] = array[end];
        array[end] = temp2;
        return smallerThanPivot;
    }
}