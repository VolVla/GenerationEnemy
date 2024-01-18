using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Vector3 _pointDirection;


    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _pointDirection ,Time.deltaTime);
    }

    public void SetDirection(Vector3 pointDirection)
    {
        _pointDirection = pointDirection;
    }
}
