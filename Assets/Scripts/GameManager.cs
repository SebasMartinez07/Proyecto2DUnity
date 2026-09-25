using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI textoPuntaje;
    public GameObject panelGameOver;
    public int puntaje = 0;
    public bool perdio = false;

    void Awake()
    {
        if (Instance == null) Instance = this;
    }

    void Start()
    {
        puntaje = 0;
        perdio = false;
        Time.timeScale = 1f;
        ActualizarUI();
        if(panelGameOver != null) panelGameOver.SetActive(false);
    }

    public void SumarPunto()
    {
        if (perdio) return;
        puntaje++;
        ActualizarUI();
    }

    void ActualizarUI()
    {
        if(textoPuntaje != null) textoPuntaje.text = puntaje.ToString();
    }

    public void GameOver()
    {
        if (perdio) return;
        perdio = true;
        if(panelGameOver != null) panelGameOver.SetActive(true);
        Time.timeScale = 0f;
    }

    void Update()
    {
        if (perdio && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}