using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * 7f);
        if (transform.position.x < -10f)
        {
            Destroy(this.gameObject);
        }
    }
}
