using UnityEngine;

public class MasterInfo: MonoBehaviour
{
    public static int CoinCount=0;
    [SerializeField] GameObject CoinDisplay;
    [SerializeField] GameObject RunDisplay;
    public static int DistanceRun;

    [SerializeField] int InternalDistance;

    void Update()
    {
        CoinDisplay.GetComponent<TMPro.TMP_Text>().text = "Coins: " + CoinCount;
        RunDisplay.GetComponent<TMPro.TMP_Text>().text = "Distance: " + DistanceRun;
    }
}
