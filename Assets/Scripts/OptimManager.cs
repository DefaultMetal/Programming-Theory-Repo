using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptimManager : MonoBehaviour
{
    public OptimUnit OptimPrefab;
    public int InstanceCount;
    public Vector3 Size;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < InstanceCount; ++i)
        {
            Vector3 position = new Vector3(
            Random.Range(-18, 18),
            Random.Range(-3, 3),
            Random.Range(-10, 10));

            var newUnit = Instantiate(OptimPrefab, position, Quaternion.identity);
            //newUnit.SetAreaSize(Size);
        }
    }
}
