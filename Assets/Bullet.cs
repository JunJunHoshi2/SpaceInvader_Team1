using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float ActiveTime = 2f;
    void Start()
    {
        Invoke("DestroyMyself", ActiveTime);
    }

    void DestroyMyself()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject); //自分自身のオブジェクトを消去
    }

    void Update()
    {
        
    }
}
