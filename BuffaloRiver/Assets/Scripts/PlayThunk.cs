using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayThunk : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource audio;

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click(){
        audio.Play();
        print("Thunk");
    }
}
