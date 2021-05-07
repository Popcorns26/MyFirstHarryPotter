using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteSpawner : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    public Transform line1;
    public Transform line2;
    public Transform line3;
    public Transform line4;
    // Start is called before the first frame update
    void Start()
    {
        SpawnNote(line1);
        SpawnNote(line2);
        SpawnNote(line3);
        SpawnNote(line4);
    }
    private void Update()
    {
        
    }

    public void SpawnNote(Transform line)
    {
        GameObject gameObject1 = Instantiate(prefabToInstantiate, line.position, Quaternion.identity);
        //gameObject1.transform.parent = transform;
        gameObject1.transform.SetParent(transform);
    }
}
