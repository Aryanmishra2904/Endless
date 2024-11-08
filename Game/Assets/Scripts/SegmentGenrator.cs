using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentGenrator : MonoBehaviour
{
    public GameObject SegmentMap01;
    public GameObject SegmentMap02;
    public GameObject SegmentMap03;
    public GameObject SegmentMap04;
    public GameObject SegmentMap05;
    public GameObject SegmentMap06;
    public GameObject SegmentMap07;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SegmentGen());
        
    }

    IEnumerator SegmentGen()
    {
        yield return new WaitForSeconds(10);
        SegmentMap02.SetActive(true);
        yield return new WaitForSeconds(10);
        SegmentMap03.SetActive(true);

         
    }
}
