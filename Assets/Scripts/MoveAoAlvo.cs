using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAoAlvo : MonoBehaviour
{
    public float velocidade = 2.0f;
    public float precisao = 1f;
    public Transform alvo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 alvoParaOlhar = new Vector3(alvo.position.x,
                                this.transform.position.y,
                                alvo.position.z);
        this.transform.LookAt(alvoParaOlhar);
        Vector3 direcao = alvo.position - this.transform.position;
        Debug.DrawRay(this.transform.position, direcao, Color.red);
        if (Vector3.Distance(this.transform.position, alvo.position) > precisao)
        {
            //this.transform.Translate(direcao.normalized * velocidade * Time.deltaTime, Space.World);
            this.transform.Translate(0, 0, velocidade * Time.deltaTime);
        }
    }
}
