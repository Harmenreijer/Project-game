using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour{
    public GameObject player;
    private Vector3 offset = new Vector3(0,7,-12);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate(){
        // transform.rotation = player.transform.rotation;
        // transform.position = player.transform.position + offset;
        transform.position = player.transform.position + new Vector3(0, 1, -5);
    }

    void Update(){

    }
}
