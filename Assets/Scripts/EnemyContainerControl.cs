using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContainerControl : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float TiempoActual;
    public float TiempoParaCrearEnemigo;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void CreateEnemy()
    {
        Instantiate(EnemyPrefab, transform.position, transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        TiempoActual = TiempoActual + Time.deltaTime;
        if (TiempoActual >= TiempoParaCrearEnemigo)
        {
            TiempoActual = 0;
            CreateEnemy();
        }
    }
}
