using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelKeyCollision : MonoBehaviour
{
    private string PlayerTag = "PlayerCharacter";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col){

        if (col.gameObject.CompareTag(PlayerTag)){
            Destroy(this.gameObject);
        }

    }
}
