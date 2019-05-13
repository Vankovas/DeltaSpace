using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameMaster : MonoBehaviour
{
    public int coins;
    public Text coinsText;

    void Update()
    {
        coinsText.text = ("x " + coins);
    }
}
