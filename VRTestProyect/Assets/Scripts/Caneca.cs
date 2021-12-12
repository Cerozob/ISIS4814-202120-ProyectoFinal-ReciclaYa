using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caneca : MonoBehaviour
{
    public GameController gameController;
    public string tipoCaneca;
    private AudioSource audioSource;
    public AudioClip bien;
    public AudioClip mal;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisión detectada");
        if (collision.gameObject.tag == tipoCaneca)
        {
            Debug.Log("CanecaCorrecta");
            audioSource.clip = bien;
            audioSource.Play();
            gameController.SendMessage("CanecaCorrecta",tipoCaneca);
            Destroy(collision.gameObject);
        }
        else
        {
            audioSource.clip = mal;
            audioSource.Play();
            collision.gameObject.SendMessage("returnObject");
        }
    }
}
