using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExTransform01 : MonoBehaviour
{
    public Transform _monObjet;

    public enum _choixMouv { modeA, modeB, modeC }
    public _choixMouv _choixModeMouv = 0;

    public enum _choixRota { modeA, modeB }
    public _choixRota _choixModeRota = 0;

    public float _speed = 1f;
    public float _angularSpeed = 10f;

    private void Start()
    {
        _monObjet = this.GetComponent<Transform>();
    }

    private void Update()
    {
        switch (_choixModeMouv)
        {
            case _choixMouv.modeA:
                _monObjet.position += new Vector3(0f, 0f, _speed * Time.deltaTime);
                break;
            case _choixMouv.modeB:
                _monObjet.Translate(new Vector3(0f, 0f, _speed * Time.deltaTime), Space.Self);
                break;
            case _choixMouv.modeC:
                _monObjet.Translate(new Vector3(0f, 0f, _speed * Time.deltaTime), Space.World);
                break;
            default:
                break;
        }

        switch (_choixModeRota)
        {
            case _choixRota.modeA:
                _monObjet.Rotate(new Vector3(0f, _angularSpeed * Time.deltaTime, 0f));
                break;
            case _choixRota.modeB:
                break;
            default:
                break;
        }
    }
}
