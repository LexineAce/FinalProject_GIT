using UnityEngine;
using System.Collections;

public class UFO : MonoBehaviour {

    public float speed = 1.0f;

    public float AX;
    public float AY;
    public float BX;
    public float BY;

    Vector2 pointA;
    Vector2 pointB;

    void Start()
    {
        pointA = new Vector2(AX, AY);
        pointB = new Vector2(BX, BY);
    }

    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);

        //transform.Rotate(new Vector3(0, 0, -150) * Time.deltaTime);
    }
}