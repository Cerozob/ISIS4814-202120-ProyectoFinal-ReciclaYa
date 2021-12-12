using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookingPotController : MonoBehaviour
{
    public Text textPlayer;
    private bool oil;
    private bool choppedMushrooms;
    private bool choppedTomatoes;
    private bool salt;
    public GameObject finishedDish;
    public GameObject TomatoesReady;
    public GameObject mushroomsReady;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oil & choppedMushrooms & choppedTomatoes & salt)
        {
            textPlayer.text = "And we are done! Now to enjoy our mushroom and tomato saute.";
            finishedDish.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (oil)
        { 
            if (collision.gameObject.name == "Tomato")
            {      
                if (collision.gameObject.transform.Find("ChoppedTomatoes").gameObject.activeSelf)
                {
                    choppedTomatoes = true;
                    TomatoesReady.SetActive(true);
                    GameObject[] toDeactivateObjects = GameObject.FindGameObjectsWithTag("DeactivateTomato");
                    foreach (GameObject toDeactivate in toDeactivateObjects)
                    {
                        toDeactivate.SetActive(false);
                    }
                    if (choppedMushrooms)
                    {
                        textPlayer.text = "Good job! Now we only need to springle some salt";                     
                    }
                    else
                    {
                        textPlayer.text = "Now we need to add the chopped mushrooms";
                    }
                }
            }
            else if (collision.gameObject.name == "Mushrooms")
            {
                if (collision.gameObject.transform.Find("ChoppedMushrooms").gameObject.activeSelf)
                {
                    choppedMushrooms = true;
                    mushroomsReady.SetActive(true);
                    GameObject[] toDeactivateObjects = GameObject.FindGameObjectsWithTag("DeactivateMushroom");
                    foreach (GameObject toDeactivate in toDeactivateObjects)
                    {
                        toDeactivate.SetActive(false);
                    }
                    if (choppedTomatoes)
                    {
                        textPlayer.text = "Good job! Now we only need to springle some salt";
                    }
                    else
                    {
                        textPlayer.text = "Now we need to add the chopped tomatoes";
                    }
                }
            }
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("PARTICLE DETECTED");
        Debug.Log(other.name);
        if(other.name == "Oil")
        {
            oil = true;
            textPlayer.text = "Ok, now that the oil is heating in the pan, we can start chopping the Tomato and Mushrooms and add them to the pan.";
        }
        if (other.name == "Salt" && oil && choppedMushrooms && choppedTomatoes)
        {
            salt = true;
        }
    }
}
