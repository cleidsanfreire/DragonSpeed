using UnityEngine;

public class ObjectsController : MonoBehaviour
{
    [SerializeField] private float girarObjetos = 5f;

    [SerializeField] private Transform[] obstaculos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < obstaculos.Length; i++)
        { 
            obstaculos[i].Rotate(0f, girarObjetos * Time.deltaTime, 0f); 
        }
    }
}
