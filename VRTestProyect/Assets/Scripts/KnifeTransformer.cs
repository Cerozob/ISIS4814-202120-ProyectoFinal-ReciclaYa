using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeTransformer : MonoBehaviour
{
    public ParticleSystem chopParticles;
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Tomato" )
        {
            chopParticles.Play();
            collision.gameObject.transform.Find("TomatoComplete").gameObject.SetActive(false);
            collision.gameObject.transform.Find("ChoppedTomatoes").gameObject.SetActive(true);
        }
        else if(collision.gameObject.name == "Mushrooms")
        {
            chopParticles.Play();
            collision.gameObject.transform.Find("MushroomCollection").gameObject.SetActive(false);
            collision.gameObject.transform.Find("ChoppedMushrooms").gameObject.SetActive(true);
        }
    }
}
