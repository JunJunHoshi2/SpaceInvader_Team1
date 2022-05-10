using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPort : MonoBehaviour
{
    [SerializeField] GameObject NormalEnemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerateEnemy", 0f, 4f); //GenerateEnemy�֐���4�b�Ɉ�x�Ăяo����
    }

    //�G�𐶐�����֐�
    void GenerateEnemy()
    {
        GameObject enemy = Instantiate(NormalEnemy);  //�G�𐶐�
        enemy.transform.position = this.transform.position; //���������G�̈ʒu���A����EnemyPort�̈ʒu�ɒ���
    }
}
