using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab;
    public float tiempoEntreTubos = 2f;
    public float alturaMin = -3f;
    public float alturaMax = 3f;
    float cronometro;

    void Update()
    {
        if (GameManager.Instance.perdio) return;
        cronometro += Time.deltaTime;
        if (cronometro > tiempoEntreTubos)
        {
            cronometro = 0;
            float y = Random.Range(alturaMin, alturaMax);
            Instantiate(pipePrefab, new Vector3(transform.position.x, y, 0), Quaternion.identity);
        }
    }
}