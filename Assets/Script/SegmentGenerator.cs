using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Rendering;
using UnityEngine;

public class SegmentGenerator: MonoBehaviour
{
    public GameObject[] segment;

    [SerializeField] int zPos=50;
    [SerializeField] bool CreateSegment = false;
    [SerializeField] int SegmentNum;


    void Update()
    {
        if (CreateSegment == false)
        {
            CreateSegment=true;
            StartCoroutine(SegmentGen());
        }
    }

    IEnumerator SegmentGen()
    {
        SegmentNum = Random.Range(0, segment.Length);
        Instantiate(segment[SegmentNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos +=50;
        yield return new WaitForSeconds(3);
        CreateSegment = false;
    }
}
