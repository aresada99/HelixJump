using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    [SerializeField] Rigidbody rb;
    [SerializeField] float jumpForce;
    [SerializeField] GameObject splashPrefab;
    public GameManager gm;

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        rb.velocity = new Vector3(0f, 0f, 0f);
        rb.velocity = rb.velocity + new Vector3(0f, jumpForce, 0f);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;

        GameObject ballSplash = Instantiate(splashPrefab, transform.position + new Vector3(0f,-0.2f,0f), transform.rotation);
        ballSplash.transform.SetParent(collision.gameObject.transform);


        if (materialName == "UnsafeColor (Instance)")
        {
            // End game with failure
            gm.ShowFailureScreen();
            Debug.Log("UnsafeColor");
        }

        else if(materialName == "LevelFinished (Instance)")
        {
            // End game with victory
            gm.ShowVictoryScreen();
            Debug.Log("Victory");
        }

    }

    

}
