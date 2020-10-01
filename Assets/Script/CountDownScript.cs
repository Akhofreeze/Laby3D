using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDownScript : MonoBehaviour {

    [SerializeField]
    private int startCountDown = 60;

    [SerializeField]
    private Text TxtCountDown;

    // Start is called before the first frame update
    void Start()
    {
        TxtCountDown.text = "TimeLeft :" + startCountDown;
        StartCoroutine(Pause());
    }

    IEnumerator Pause()
    {
        while(startCountDown != 0)
        {
            yield return new WaitForSeconds(1f);
            startCountDown--;
            TxtCountDown.text = "TimeLeft :" + startCountDown;
        }
        Debug.Log("T'es mort zeubi");
        GameObject.Find("Player").GetComponent<PlayerControler>().GameOver();
    }
}
