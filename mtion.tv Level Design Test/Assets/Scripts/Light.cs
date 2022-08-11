using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
   
    public GameObject _light1;



    public float _timer = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Flicker(_light1));
    }

    // Update is called once per frame
    IEnumerator Flicker(GameObject _light)
    {
        _timer = Random.Range(0.7f, 2f);
        _light.SetActive(true);
        yield return new WaitForSeconds(_timer);
        _light.SetActive(false);
        _timer = Random.Range(0.7f, 2f);
        yield return new WaitForSeconds(_timer);
        StartCoroutine(Flicker(_light));
    }
}
