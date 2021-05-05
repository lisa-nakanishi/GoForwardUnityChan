using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSound : MonoBehaviour
{

    private AudioSource audioSource;

    //地面の位置
    private float groundLevel = -3.0f;

    Rigidbody2D rigid2D;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody2Dのコンポーネントを取得する
        this.rigid2D = GetComponent<Rigidbody2D>();
        //Audioを取得する
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {   //ブロックが積み重ねたとき音を鳴らす
        if (collision.gameObject.tag == "CubePrefabTag")
        {
            audioSource.Play();
        }
        if (collision.gameObject.tag == "GroundTag")
        {
            audioSource.Play();
        }
    }
}

