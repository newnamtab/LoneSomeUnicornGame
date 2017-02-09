using UnityEngine;
using System.Collections;


public class GetEaten : MonoBehaviour
{
    public GameObject BabyBillede;
    
    public AudioClip clip;
    public AudioClip clip2;
    // Use this for initialization
    void Start()
    {
        

      //  gameObject.GetComponent<Animation>().Play("BloodSplatter");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player")
        { 
            gameObject.GetComponent<Animator>().SetTrigger("StartAnim");
            Destroy(BabyBillede.gameObject);
            AudioSource.PlayClipAtPoint(clip, transform.position);
            AudioSource.PlayClipAtPoint(clip2, transform.position,10);


            Destroy(gameObject.GetComponent<BoxCollider2D>());
            

            Destroy(gameObject,1);
        }
    }

}
