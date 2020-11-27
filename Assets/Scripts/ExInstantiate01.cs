using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExInstantiate01 : MonoBehaviour
{
    public GameObject _spherePrefab;
    public GameObject _instance;

    void Start()
    {
        if (_spherePrefab != null)
        {
            _instance =  Instantiate(_spherePrefab, Vector3.zero, Quaternion.identity);
        }
        else
        {
            Debug.LogWarning("Asset manquante");
            //_spherePrefab = Resources.Load<GameObject>("Assets/Prefabs/Sphere");
        }
    }

    private void Update()
    {
        _instance.transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
