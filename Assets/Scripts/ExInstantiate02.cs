using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExInstantiate02 : MonoBehaviour
{
    public GameObject _spherePrefab;
    public GameObject[] _tableauSphere;

    void Start()
    {
        int x = 5;
        int y = 5;
        int z = 5;

        if (_spherePrefab != null)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    for (int k = 0; k < z; k++)
                    {
                        Instantiate(_spherePrefab, new Vector3(i, j, k), Quaternion.identity);
                    }
                }
            }
        }
        else { Debug.LogWarning("Asset manquante"); }

        _tableauSphere = GameObject.FindGameObjectsWithTag("Player");
    }

    private void Update()
    {
        //foreach (GameObject item in _tableauSphere)
        //{
        //    float myRandomFloat = Random.Range(-1f, 1f);
        //    Vector3 randomVector = new Vector3(myRandomFloat, myRandomFloat, myRandomFloat);
        //    item.transform.position += randomVector * myRandomFloat * Time.deltaTime;
        //    //item.transform.Translate(randomVector * 0.03f * Time.deltaTime);
        //    item.transform.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        //}

        int r = 0;
        while (r < _tableauSphere.Length)
        {
            _tableauSphere[r].transform.Translate(Vector3.forward * Time.deltaTime);
            r++;
        }
    }
}
