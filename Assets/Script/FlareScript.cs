using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlareScript : MonoBehaviour
{

    [SerializeField]
    int LevelToLoad;

    [SerializeField]
    bool autoIndex;

    private void Start()
    {
        if(autoIndex)
        {
            LevelToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        }
       
    }

    // OnCollisionEnter est appelé quand ce collider/rigidbody commence à toucher un autre rigidbody/collider
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            Debug.Log("Win");
            SceneManager.LoadScene(LevelToLoad); // Next Index
        }
    }

}
