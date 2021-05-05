using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //（追加）
public class UIController : MonoBehaviour
{
    //ゲームオーバーテキスト
    private GameObject gameOverText;
    //歩行距離速度
    private GameObject runLengthText;
    //走った距離
    private float len = 0;
    //走る速度
    private float speed = 5f;
    //ゲームオーバーの判定
    private bool isGameOver = false;
    // Use this for initialization
    void Start()
    {
        //シーンビューからオブジェクトの実態を検索する
        this.gameOverText = GameObject.Find("GameOver");
        this.runLengthText = GameObject.Find("RunLength");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isGameOver == false)
        {
            //走った距離を更新する
            this.len += this.speed * Time.deltaTime;
            //走った距離を表示する
            this.runLengthText.GetComponent<Text>().text = "Distance:" + len.ToString("F2") + "m";
        }
        //ゲームオーバーになった場合
        if (this.isGameOver == true)
        {
            //クリックされたらシーンをロードする（追加）
            if (Input.GetMouseButtonDown(0))
            {
                //SampleSceneを読み込む（追加）
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
    public void GameOver()
    {
        //ゲームオーバーになったときに、画面上にゲームオーバーを表示する
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        this.isGameOver = true;
    }


}
