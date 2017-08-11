using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{
    

    // キューブの移動速度
    private float speed = -0.2f;

    private float groundLevel = -3.0f;

    // 消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        //障害物に衝突した場合（追加）
        if (col.gameObject.tag == "GroundTag")
        {
            GetComponent<AudioSource>().Play();
        }

        if (col.gameObject.tag == "CubeTag")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}