using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] public bool timerOver = false;
    [SerializeField] private float timerValue = 0f;
    [SerializeField] private GameObject timerText;
    [SerializeField] private Text uiText;
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
        }
        else
        {
            timerOver = false;
        }
    }

    public void SetTimer()
    {
        timerValue = Random.Range(3, 10);
    }
}
