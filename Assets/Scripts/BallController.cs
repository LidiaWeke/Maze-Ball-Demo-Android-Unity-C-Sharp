using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    private float velocity = 300;
    private GameManager gameManager;
    public GameObject menuPausa;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        gameManager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        Vector3 orientation = Input.acceleration;
        orientation = Quaternion.Euler(90, 0, -90) * orientation;
        rb.AddForce(orientation * velocity * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Exit"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Para cargar en orden del build las escenas

        }

        if (collision.gameObject.CompareTag("ExitDemo"))
        {
            Pausa();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else if (collision.gameObject.CompareTag("Wall"))
        {
            gameManager.RestarPuntos();
        }
    }

    public void Pausa()
    {
        Time.timeScale = 0f;
        menuPausa.SetActive(true);
    }
}

