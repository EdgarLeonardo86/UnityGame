using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ObstacleController : MonoBehaviour
{
   
        void Start()
    {
        for (int c=1;c <=5;c++)
        {
            GameObject primitiva = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            primitiva.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
            primitiva.name = "primitiva" + c;
            primitiva.AddComponent<Rigidbody>();
            primitiva.transform.position = new Vector3(Random.Range(-5, 5), Random.Range(5, 10), Random.Range(-5, 10));
            primitiva.transform.Rotate(new Vector3(Random.Range(0, 360), 0, 0));
        }
    }

    

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
           // loseTextObject.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

  /*  public void Level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/
}
