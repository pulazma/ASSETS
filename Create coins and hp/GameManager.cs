using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int currentGold = 0;
    public Text myText;
    // Start is called before the first frame update
    public void AddGold(int value)
    {
        currentGold = currentGold + value;
        myText.text = "Coins: " + currentGold;
    }
}
