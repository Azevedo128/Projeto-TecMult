using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverUI : MonoBehaviour
{
    public TMP_Text distanceText;
    public TMP_Text coinsText;

    void Start()
    {
        distanceText.text = "Distance: " + Mathf.FloorToInt(MasterInfo.FinalDistance) + "m";
        coinsText.text = "Coins: " + MasterInfo.FinalCoins;
    }
}