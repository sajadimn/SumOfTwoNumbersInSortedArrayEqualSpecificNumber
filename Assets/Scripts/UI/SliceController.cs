using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliceController : MonoBehaviour
{
    public Image backGround;
    public Text value;
    
    public void Init(float count)
    {
        value.text = count.ToString();
    }

    public void SetAsResult(Color result)
    {
        backGround.color = result;
    }
}
