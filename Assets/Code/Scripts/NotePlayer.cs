using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotePlayer : MonoBehaviour
{
    // on collision
    // get pitch: get key position and do some calculation to know how to change the pitch accordingly
    // play sound
    // launch anim
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("oui");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
