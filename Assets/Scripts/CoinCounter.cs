using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{    
    public Text coinCountText;
    
    public void SetCoinCount (int count)
    {
        if (count < 10)
        {
            coinCountText.text = "00" + count.ToString();
        }else if( count < 100)
        {
            coinCountText.text = "0" + count.ToString();
        }
        else
        {
            coinCountText.text = count.ToString();
        }
    }    
}
