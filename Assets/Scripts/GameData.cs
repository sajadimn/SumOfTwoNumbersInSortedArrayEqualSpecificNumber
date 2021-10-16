using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameData
{
    public static GameManager gameManager = null;
    public static SearchAlgorithmManager searchAlgorithmManager = null;
    public static GameUController gameUiController = null;
    private static QuickSortManager quickSortManager = null;
    public static QuickSortManager GetQuickSortManager()
    {
        if(quickSortManager == null)
            quickSortManager = new QuickSortManager();
        return quickSortManager;
    }
}
