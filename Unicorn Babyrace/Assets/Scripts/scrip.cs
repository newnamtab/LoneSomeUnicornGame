using UnityEngine;
using System.Collections;
using System.Threading;


public class scrip : MonoBehaviour
{


    private int Speed = 15;
    //private int movex = 5;
    //private int movey = -5;
    private Vector2 Unicorn;
    Thread jumpThread;
    bool Isjumping = false;
    float lastTime;
    //sleep jump
    IEnumerator CheckJump()
    {
        Isjumping = true;
        yield return new WaitForSeconds(1);
        Isjumping = false;
    }

    
    // Use this for initialization
    void Start()
    {
        lastTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= lastTime + 0.1)
        {
            lastTime = Time.time;
            if (Input.GetKey(KeyCode.D))
            {
                Unicorn.Set(Speed, 0);
                transform.Translate(Unicorn);
            }
            if (Input.GetKey(KeyCode.A))
            {
                Unicorn.Set(-Speed, 0);
                transform.Translate(Unicorn);
            }
            

        }
        if (Input.GetKeyDown(KeyCode.W))
        {

            if (Isjumping == false)
            {
                Unicorn.Set(0, 10);
                transform.Translate(Unicorn);
                StartCoroutine(CheckJump());

            }

        }


    }
    
}
