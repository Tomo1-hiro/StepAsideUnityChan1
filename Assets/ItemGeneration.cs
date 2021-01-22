using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGeneration : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    private int startPos = 80;
    private int goalPos = 360;
    private float posRange = 3.4f;

    void Start()
    {
        //一定の距離ごとにアイテムを生成
        for (int i = startPos; i < goalPos; i += 15)
        {
            //どのアイテムを出すのかランダムに生成
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab);
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }

            }
            else
            {   //レーンごとにアイテム生成
                for (int j = -1; j <= 1; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);
                    //アイエムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);
                    //６０％コイン配置：３０％車配置：１０％何もなし
                    if (1 <= item && item <= 6)
                    {
                        //コインを生成
                        GameObject coin = Instantiate(coinPrefab);
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
