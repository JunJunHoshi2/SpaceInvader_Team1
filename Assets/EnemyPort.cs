using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPort : MonoBehaviour
{
    [SerializeField] GameObject NormalEnemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateEnemy", 0f, 4f); //GenerateEnemy関数を4秒に一度呼び出すよ
    }

    //敵を生成する関数
    void GenerateEnemy()
    {
        GameObject enemy = Instantiate(NormalEnemy);  //敵を生成
        enemy.transform.position = this.transform.position; //生成した敵の位置を、このEnemyPortの位置に調整
    }
}
