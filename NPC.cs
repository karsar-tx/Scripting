using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int hp = 5;
    public int lvl = 1;
    public float speed = 1.2f;
    void Start()
    {
        hp += lvl;
        print ("Жизней: " + hp);
    }

    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;   
    }
}
