using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    //здоровье нпс
    public int health = 5;
    //уровень нпс
    public int level = 1;
    //скорость нпс
    public int speed = 3;
    void Start()
    {
        health += level;
        print(health);   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;

    }
}
