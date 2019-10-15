using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public Vector3 alvo = new Vector3(5, 0, 4);
    public float velocidade = 1f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(alvo.normalized * velocidade * Time.deltaTime);
    }
}
