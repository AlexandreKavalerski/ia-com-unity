using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAoAlvo : MonoBehaviour
{
    public float velocidade = 2.0f;
    public float precisao = 0.01f;
    public Transform alvo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(alvo.position);
        Vector3 direcao = alvo.position - this.transform.position;
        Debug.DrawRay(this.transform.position, direcao, Color.red);
        if (direcao.magnitude > precisao)
        {
            this.transform.Translate(direcao.normalized * velocidade * Time.deltaTime, Space.World);
        }
    }
}
