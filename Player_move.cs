using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float move_Speed = 0.1f; //속도초기값
    float x_Speed = 0; //x축 방향 변수
    float y_Speed = 0; //y축 방향 변수
    bool leftFlag = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        x_Speed = 0;
        y_Speed = 0;

        if (Input.GetKey("right"))
        {
            x_Speed = move_Speed;
            leftFlag = false;
            // this.transform.Translate(x_Speed, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            x_Speed = -move_Speed;
            leftFlag = true;
            // this.transform.Translate(x_Speed, 0, 0);
        }
        if (Input.GetKey("up"))
        {
            y_Speed = move_Speed;
            // this.transform.Translate(0, y_Speed, 0);
        }
        if (Input.GetKey("down"))
        {
            y_Speed = -move_Speed;
            // this.transform.Translate(0, y_Speed, 0);
        }

    }
   

    private void FixedUpdate()
    {
           this.transform.Translate(x_Speed, y_Speed, 0); //오브젝트 이동
           this.GetComponent<SpriteRenderer>().flipX = leftFlag; //좌우 방향전환시 스프라이트 방향전환
    }
}
