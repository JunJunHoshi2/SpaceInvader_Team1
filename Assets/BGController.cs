using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();  //�ʒu������������ɍX�V

        if (transform.position.y >=11f)  //������ʂɉf��Ȃ��Ȃ�����
        {
            ResetPosition(); //��ԉ��̈ʒu�Ɉړ�
        }

    }
    void Scroll()
    {
        //�ʒu������������ɍX�V����R�[�h
        Vector3 pos = transform.position;

        float ScrollSpeed = 1;
        pos.y += ScrollSpeed;
        transform.position = pos;

    }
    void ResetPosition()
    {
        //��ԉ��̈ʒu�Ɉړ�����R�[�h
        Vector3 pos = transform.position;
        pos.y -= 30f;
        transform.position = pos;
    }
}
