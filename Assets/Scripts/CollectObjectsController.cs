using UnityEngine;

public class CollectObjectsController : MonoBehaviour
{
    [SerializeField] private float velocity = 130f;

    [Header("Arrays")]
    [SerializeField] private Transform[] objectsCollect;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < objectsCollect.Length; i++)
        {
            objectsCollect[i].Rotate(0f, velocity * Time.deltaTime, 0f);
        }
    }
}
