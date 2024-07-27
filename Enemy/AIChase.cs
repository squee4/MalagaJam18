using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AIChase : MonoBehaviour
{
    public GameObject player;
    public float speed =2;
    bool facingLeft = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayerCharacter");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        transform.position += (Vector3)direction * speed * Time.deltaTime;
        Vector3 scaler;
        if (direction.x < 0 && !facingLeft)
        {
            scaler = transform.localScale;
            scaler.x *= -1;
            transform.localScale = scaler;
            facingLeft = true;
        }
        else if (direction.x > 0 && facingLeft)
        {
            scaler = transform.localScale;
            scaler.x *= -1;
            transform.localScale = scaler;
            facingLeft = false;
        }
    }
}
