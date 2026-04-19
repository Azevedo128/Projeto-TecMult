using UnityEngine;
using TMPro;

public class TimerUI : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    float tempo = 0f;

    void Update()
    {
        tempo += Time.deltaTime;

        int minutos = Mathf.FloorToInt(tempo / 60);
        int segundos = Mathf.FloorToInt(tempo % 60);

        timerText.text = $"{minutos:00}:{segundos:00}";
    }
}