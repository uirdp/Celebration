using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeScript : MonoBehaviour
{
    [SerializeField] float xOffset;
    [SerializeField] float yOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos2 = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        Vector3 nextPosition = new Vector3(pos2.x + xOffset, pos2.y + yOffset, transform.position.z);

        transform.position = nextPosition;
    }
}
