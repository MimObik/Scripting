using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class bob : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        GameObject.CreatePrimitive(PrimitiveType).transform.position = new Vector3(0, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType).transform.position = new Vector3(-0.5f, 1, 0);
        GameObject.CreatePrimitive(PrimitiveType).transform.position = new Vector3(0.5f, 1, 0);
        GameObject.CreatePrimitive(PrimitiveType).transform.position = new Vector3(0.5f, 2, 0);
        GameObject.CreatePrimitive(PrimitiveType).transform.position = new Vector3(-0.5f, 2, 0);
        GameObject.CreatePrimitive(PrimitiveType).transform.position = new Vector3(0, 3, 0);








        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        print("crickets");
    }
}
