using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class navegacion : MonoBehaviour
{

    public RectTransform mainCategorias, cat_historicos,
        cat_artisticos, cat_urbanos, cat_help, cat_arqueolo;
    // Start is called before the first frame update
    void Start()
    {
        mainCategorias.DOAnchorPos(Vector2.zero, 0.25f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseCat_Historicos();
            CloseCat_Artisticos();
            CloseCat_Arqueologicos();
            CloseCat_Urbanos();
            CloseHelp_me();
        }
    }

    public void CambioEscena(string name) {
        print("Cambio la esena"+name);
        SceneManager.LoadScene(name);
    }



    //Metodos para cambiar de vistas... UwU

    public void ShowCat_Historicos() 
    {
        mainCategorias.DOAnchorPos(new Vector2(1600, 0),0.25f);
        cat_historicos.DOAnchorPos(new Vector2(0, 0), 0.25f);
     
           } 
    public void CloseCat_Historicos()
    {
        mainCategorias.DOAnchorPos(new Vector2(0, 0), 0.25f);
        cat_historicos.DOAnchorPos(new Vector2(1600, 0), 0.25f);
    }

    public void ShowCat_Artistricos()
    {
        mainCategorias.DOAnchorPos(new Vector2(2400, 0), 0.25f);
        cat_artisticos.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void CloseCat_Artisticos()
    {
        mainCategorias.DOAnchorPos(new Vector2(0, 0), 0.25f);
        cat_artisticos.DOAnchorPos(new Vector2(2400, 0), 0.25f);
    }

    public void ShowCat_Arqueologicos()
    {
        mainCategorias.DOAnchorPos(new Vector2(3210, 0), 0.25f);
        cat_arqueolo.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void CloseCat_Arqueologicos()
    {
        mainCategorias.DOAnchorPos(new Vector2(0, 0), 0.25f);
        cat_arqueolo.DOAnchorPos(new Vector2(3210, 0), 0.25f);
    }
    public void ShowCat_Urbanos()
    {
        mainCategorias.DOAnchorPos(new Vector2(-800, 0), 0.25f);
        cat_urbanos.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }
    public void CloseCat_Urbanos()
    {
        mainCategorias.DOAnchorPos(new Vector2(0, 0), 0.25f);
        cat_urbanos.DOAnchorPos(new Vector2(-800, 0), 0.25f);
    }
    public void ShowHelp_me()
    {
        mainCategorias.DOAnchorPos(new Vector2(800, 0), 0.25f);
        cat_help.DOAnchorPos(new Vector2(0, 0), 0.25f);
    }

    public void CloseHelp_me()
    {
        mainCategorias.DOAnchorPos(new Vector2(0, 0), 0.25f);
        cat_help.DOAnchorPos(new Vector2(800, 0), 0.25f);
    }
}
