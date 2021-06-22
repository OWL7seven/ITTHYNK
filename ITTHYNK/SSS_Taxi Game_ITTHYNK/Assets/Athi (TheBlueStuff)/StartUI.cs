using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartUI : MonoBehaviour { 

    public Button StartButton;
    public AudioSource Birds;
    public AudioSource crowd; 
    public AudioSource city;

    // Start is called before the first frame update
    public void Start()
    {
        //Cursor.visible = true;
        crowd.Play();
        city.Play();
        Birds.Play();

    }

    // Update is called once per frame
    void Update ()
    {

    }

    public void StartPress()
    {
            SceneManager.LoadScene(0);

    }
}


