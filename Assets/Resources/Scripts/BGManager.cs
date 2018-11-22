using UnityEngine;

public class BGManager : MonoBehaviour
{
    #region DEFAULT
    private Renderer rd_BG;
    private readonly Texture2D[] tx_BG = new Texture2D[2];
    private int r, t;
    private Vector2 move_BG;

    void Start()
    {
        r = Random.Range(0, 4);
        t = Random.Range(0, 2);
        rd_BG = GetComponent<Renderer>();

        for (int i = 0; i < tx_BG.Length; i++)
        {
            tx_BG[i] = Resources.Load("Sprites/UI/BG/Textures/" + i + "") as Texture2D;
        }

        Texture2D t2d = tx_BG[t];
        rd_BG.material.mainTexture = t2d;
        rd_BG.material.color = ButtonManager.c;
        Debug.Log(t2d);
    }

    void Update()
    {
        #region MOVE BG
        if (r == 0)
        {
            move_BG = new Vector2(Time.time * -0.5f, Time.time * 0.5f);
        }
        if (r == 1)
        {
            move_BG = new Vector2(Time.time * 0.5f, Time.time * -0.5f);
        }
        if (r == 2)
        {
            move_BG = new Vector2(Time.time * 0.5f, Time.time * 0.5f);
        }
        if (r == 3)
        {
            move_BG = new Vector2(Time.time * -0.5f, Time.time * -0.5f);
        }
        rd_BG.material.mainTextureOffset = move_BG;
        #endregion
    }
    #endregion
}