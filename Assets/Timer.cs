using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] public bool timerOver = false;
    [SerializeField] private float timerValue = 0f;
    [SerializeField] private int reactionTime = 0;
    [SerializeField] private GameObject timerText;
    [SerializeField] private Text uiText;
    [SerializeField] private GameObject prompt;
    // Start is called before the first frame update
    void Start()
    {
        SetTimer();
        uiText = timerText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        timerValue -= Time.deltaTime;
        uiText.text = timerValue.ToString();

        if (timerValue <= 0)
        {
            timerOver = true;
            prompt.GetComponent<Image>().enabled = true;
            reactionTime++;
        }
        else
        {
            timerOver = false;
        }
    }

    public void SetTimer()
    {
        timerValue = Random.Range(3, 10);
        reactionTime = 0;
        prompt.GetComponent<Image>().enabled = false;
    }
}
