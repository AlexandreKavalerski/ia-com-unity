using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanqueController : MonoBehaviour
{
    GameObject[] pontosDeReferencia;
    int indexAtual = 0;

    public float velocidadeDeRotacao = 2f;
    public float velocidade = 3.5f;
    public float precisao = 1f;
    // Start is called before the first frame update
    void Start()
    {
        pontosDeReferencia = GameObject.FindGameObjectsWithTag("referencia");
        print("tam: " + pontosDeReferencia.Length);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (pontosDeReferencia.Length == 0) return;

        Vector3 alvoParaOlhar = new Vector3(pontosDeReferencia[indexAtual].transform.position.x,
                                        this.transform.position.y,
                                        pontosDeReferencia[indexAtual].transform.position.z);
        Vector3 direcao = alvoParaOlhar - this.transform.position;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                    Quaternion.LookRotation(direcao),
                                    Time.deltaTime * velocidadeDeRotacao);

        if(direcao.magnitude < precisao)
        {
            indexAtual++;
            print("index: " + indexAtual);
            if(indexAtual >= pontosDeReferencia.Length)
            {
                indexAtual = 0;
            }
        }
        this.transform.Translate(0, 0, velocidade * Time.deltaTime);
    }
}
