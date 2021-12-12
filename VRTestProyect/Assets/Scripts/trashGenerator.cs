using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashGenerator : MonoBehaviour
{
    public GameObject[] pieces;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateTrash()
    {
        Instantiate(pieces[Random.Range(0, pieces.Length)], this.transform.position, this.transform.rotation);
    }
}
