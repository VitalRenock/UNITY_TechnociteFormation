using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvPlayer : MonoBehaviour
{
    public Transform _playerTransform;
    public Rigidbody _playerRigbo;

    public float _speed;
    public float _forceSaut;

    public float _distanceFromOrigin;
    public float _boundRadius;

    public Vector2 _centerOfBoundaries;
    public Vector3 _direction;
    public Vector2 _playerPosition2D;
    public Vector2 originToPosition;
    public Vector2 newPositionFromOrigin;
    public Vector2 newPosition2d;

    private void Start()
    {
        _playerTransform = this.GetComponent<Transform>();
        _playerRigbo = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        // On récupère les inputs du joueur et on les normalises.
        _direction = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        _direction.Normalize();

        // On déplace le personnage.
        _playerTransform.Translate(_direction * _speed * Time.deltaTime);

        // On récupère la nouvelle position du personnage dans un Vector2
        _playerPosition2D = new Vector2(transform.position.x, transform.position.z);

        //z
        originToPosition = _playerPosition2D - _centerOfBoundaries;
        _distanceFromOrigin = originToPosition.magnitude;

        if(_distanceFromOrigin > _boundRadius)
        {
            newPositionFromOrigin = originToPosition.normalized * _boundRadius;
            newPosition2d = _centerOfBoundaries + newPositionFromOrigin;
            transform.position = new Vector3(newPosition2d.x, transform.position.y, newPosition2d.y);
        }

        if(Input.GetKeyDown(KeyCode.Space)) { SautJoueur(); }
    }

    void SautJoueur()
    {
        _playerRigbo.AddForce(Vector3.up * _forceSaut * Time.fixedDeltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere (Vector3.zero, _boundRadius);
    }
}
