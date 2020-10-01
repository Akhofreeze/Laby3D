using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    private float speed = 4f, currentSpeed, rotation = 150f;

    [SerializeField]
    GameObject ImGameOver;

    private Vector3 deplacement=Vector3.zero;

    
   
    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = speed * 2;
        } else
        {
            currentSpeed = speed;
        }

        transform.Rotate(Vector3.up * rotation * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.forward * currentSpeed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));

    }
    public void GameOver()
    {
        ImGameOver.SetActive(true);
        StartCoroutine(LoadMenu());
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");
    }

}

