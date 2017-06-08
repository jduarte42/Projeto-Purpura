using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class temaJogo : MonoBehaviour
{

    public Button btnplay;
    public Text txtnometema;
    public GameObject infotema;
    public Text txtinfotema;
    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    public string[] nometema;
    public int numeroquestoes;

    private int idTema;



    void Start()
    {
        idTema = 0;
        txtinfotema.text = "Você Acertou X de X questões";
        infotema.SetActive(false);
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);
        btnplay.interactable = false;
    }
    public void selecionetema()
    {
        
        PlayerPrefs.SetInt("idtema", idTema);


        int score = PlayerPrefs.GetInt("Score" + idTema.ToString());
        int acertos = PlayerPrefs.GetInt("acertos" + idTema.ToString());
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        if (score >= 900)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);

        }
        else if (score >= 700)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }
        else if (score >= 500)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }

        txtinfotema.text = "Você Acertou " + acertos.ToString() + " de " + numeroquestoes.ToString() + " questões";
        
        btnplay.interactable = true;
        infotema.SetActive(true);

    }
    public void random ()
    {
        idTema = Random.Range(2, 3);
        txtnometema.text ="O tema escolhido foi:" +  nometema[idTema];
        
    }
    public void jogar()
    {
        SceneManager.LoadScene("T" + idTema.ToString());
    }
 
}