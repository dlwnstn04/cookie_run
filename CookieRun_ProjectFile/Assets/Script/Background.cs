using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed;
    Vector2 startpos;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-1, 0) * speed * Time.deltaTime);
        if (transform.position.x <= - 22.11364)
        {
            transform.position = startpos;
        }
    }
}
