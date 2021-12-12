using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public enum GameState { Tutorial, Playing };
    public GameState gameState = GameState.Tutorial;
    private AudioSource audioSource;
    //TUTORIAL
    public AudioClip audioClipCanecaVerde;
    public AudioClip audioClipCanecaNegra;
    public AudioClip audioClipInstruccionesJuego;
    private float puntosTutorialCanecaBlanca = 0;
    private float puntosTutorialCanecaNegra = 0;
    private float puntosTutorialCanecaVerde = 0;
    public GameObject objetosTutorialCanecaBlanca;
    public GameObject objetosTutorialCanecaNegra;
    public GameObject objetosTutorialCanecaVerde;
    private bool tutorialCanecaBlancaCompletado = false;
    private bool tutorialCanecaNegraCompletado = false;
    private bool tutorialCanecaVerdeCompletado = false;
    public GameObject botonIniciarJuego;
    public Text mainMenuText;
    public GameObject mainMenu;
    //JUEGO
    public GameObject medidorContaminaci�n;
    public Text medidorContaminaci�ntxt;
    public float scoreFloat = 0;
    public float contaminacion = 0;
    public GameObject score;
    public Text scoretxt;
    public Animator animatorCanecaBlanca;
    public Animator animatorCanecaNegra;
    public Animator animatorCanecaVerde;
    private IEnumerator coroutineContaminacionInstance;
    private bool gameOver;
    public GameObject finDelJuego;
    public GameObject trashGenerator;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = this.GetComponent<AudioSource>();
        audioSource.Play();
        gameState = GameState.Tutorial;
        
    }
    IEnumerator coroutineContaminacion()
    {
        while (true)
        {
            contaminacion = contaminacion+3;
            Debug.Log(contaminacion);
            yield return new WaitForSeconds(1);
        }
    }
    public void CanecaCorrecta(string tipoCaneca)
    {
        if(gameState == GameState.Tutorial)
        {
            if (tipoCaneca == "canecaBlanca")
            {
                puntosTutorialCanecaBlanca++;
            }
            else if (tipoCaneca == "canecaNegra")
            {
                puntosTutorialCanecaNegra++;
            }
            if (tipoCaneca == "canecaVerde")
            {
                puntosTutorialCanecaVerde++;
            }
        }
        if (gameState == GameState.Playing)
        {
            scoreFloat++;
            scoretxt.text = "Score: " + scoreFloat;
            contaminacion = contaminacion - 10;
            trashGenerator.SendMessage("GenerateTrash");
        }
    }

    public void IniciarContaminacion()
    {
        coroutineContaminacionInstance = coroutineContaminacion();
        StartCoroutine(coroutineContaminacionInstance);
    }
    public void IniciarJuego()
    {
        botonIniciarJuego.SetActive(false);
        gameState = GameState.Playing;
        mainMenu.SetActive(false);
        medidorContaminaci�n.SetActive(true);
        score.SetActive(true);
        IniciarContaminacion();
        animatorCanecaBlanca.SetBool("play", true);
        animatorCanecaVerde.SetBool("play", true);
        animatorCanecaNegra.SetBool("play", true);
        trashGenerator.SendMessage("GenerateTrash");
    }
    // Update is called once per frame
    void Update()
    {
        if(gameState == GameState.Tutorial)
        {
            if(puntosTutorialCanecaBlanca == 3 && tutorialCanecaBlancaCompletado == false)
            {
                objetosTutorialCanecaBlanca.SetActive(false);
                objetosTutorialCanecaNegra.SetActive(true);
                audioSource.clip = audioClipCanecaNegra;
                audioSource.Play();
                mainMenuText.text = "Muy bien, ahora en la mesa aparecieron unos nuevos residuos estos son residuos no aprovechables. Por lo tanto, tienen que ir en la caneca negra. Para continuar con el tutorial, por favor inserta los residuos en la caneca negra.";
                tutorialCanecaBlancaCompletado = true;
            }
            else if(puntosTutorialCanecaNegra == 3 && tutorialCanecaNegraCompletado == false)
            {
                objetosTutorialCanecaNegra.SetActive(false);
                objetosTutorialCanecaVerde.SetActive(true);
                audioSource.clip = audioClipCanecaVerde;
                audioSource.Play();
                mainMenuText.text = "Excelente, como podr�s observar ya aparecieron nuevos residuos encima de la mesa, estos son catalogados como residuos org�nicos aprovechables y tienen que ir en la caneca verde. Para continuar con el tutorial, por favor inserta los residuos en la caneca verde.";
                tutorialCanecaNegraCompletado = true;

            }
            else if(puntosTutorialCanecaVerde == 3 && tutorialCanecaVerdeCompletado == false)
            {
                objetosTutorialCanecaVerde.SetActive(false);
                botonIniciarJuego.SetActive(true);
                audioSource.clip = audioClipInstruccionesJuego;
                audioSource.Play();
                mainMenuText.text = "Como jugar: Para jugar tienes que evitar que la contaminaci�n suba, al lado tuyo aparece un medidor el cual te dir� cu�les son los niveles de contaminaciones actuales, entre m�s basura falles m�s contaminaci�n habr�. Para evitar que el medidor suba tienes que meter la basura en las canecas indicadas como se explic� previamente en el tutorial. Si los niveles de contaminaci�n llegan a un estado cr�tico, habr�s perdido el juego. Buena suerte y que te diviertas.";
                tutorialCanecaVerdeCompletado = true;
            }         
        }
        else if (gameState == GameState.Playing)
        {
            medidorContaminaci�ntxt.text = "Contaminaci�n actual: " + contaminacion + "%";
            if (contaminacion >= 100 && gameOver == false)
            {
                StopCoroutine(coroutineContaminacionInstance);
                gameOver = true;
                finDelJuego.SetActive(true);
            }
        }
    }
}
