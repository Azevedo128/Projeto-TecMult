using UnityEngine;

public class MasterInfo: MonoBehaviour
{
    public static int CoinCount=0;
    [SerializeField] GameObject CoinDisplay;

    void Update()
    {
        CoinDisplay.GetComponent<TMPro.TMP_Text>().text = "Coins: " + CoinCount;
    }
}
