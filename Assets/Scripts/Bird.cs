using UnityEngine;

public class Bird : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float fuerzaSalto = 4f;
    void Start() { rb = GetComponent<Rigidbody2D>(); }

    void Update()
    {
        if (GameManager.Instance != null && GameManager.Instance.perdio) return;

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * fuerzaSalto;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Score"))
        {
            GameManager.Instance.SumarPunto();
            other.enabled = false;
        }
    }
}