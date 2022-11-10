using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textTime;

    private float time = 61;


    void Start()
    {
        Time.timeScale = 0;
    }


    void Update()
    {
        if(Input.touchCount > 0)
        {
            Time.timeScale = 1;
        }

        time -= Time.deltaTime;
        textTime.text = "" + (int)time;
        if (time <=0)
        {
            Muerte();
        }
    }

    private void Muerte()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex)); //Recargar la misma escena en la que se está
    }

    public void RestarPuntos()
    {
        time-=2;
    }
}
