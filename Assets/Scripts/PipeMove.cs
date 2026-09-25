using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float destroyX = -12f;


    void Update()
    {
        if (GameManager.Instance.perdio) return;
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        if (transform.position.x < destroyX) Destroy(gameObject);
    }
}