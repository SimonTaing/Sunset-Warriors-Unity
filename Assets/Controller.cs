using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    [SerializeField] private int p1Score;
    [SerializeField] private int p2Score;
    [SerializeField] private GameObject timerObject;
    [SerializeField] private Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = timerObject.GetComponent<Timer>();
        p1Score = 0;
        p2Score = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("left"))
        {
            P1Input();
        }
        else if (Input.GetKeyDown("right"))
        {
            P2Input();
        }
    }

    void P1Input()
    {
        Debug.Log("P1 input");
        if (timer.timerOver == true)
        {
            p1Score++;
            Debug.Log("P1 wins");

        }
        else
        {
            p2Score++;
            Debug.Log("P2 wins");
        }
        timer.SetTimer();
    }

    void P2Input()
    {
        Debug.Log("P2 input");
        if (timer.timerOver == true)
        {
            p2Score++;
            Debug.Log("P2 wins");
        }
        else
        {
            p1Score++;
            Debug.Log("P1 wins");
        }
        timer.SetTimer();
    }
}
