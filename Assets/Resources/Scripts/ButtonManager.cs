using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private readonly float[] random_Color = new float[3]; // array random colors
    private int random_Model, n, number; // generate random
    private Sprite[] model; // array models
    private Sprite[] icons = new Sprite[34]; // array icons
    public Image icone; // image icone
    public static int check_Button; // check number button
    public static Color c; // color

    void Start()
    {
        random_Model = Random.Range(0, 4); // random sprite
        n = random_Model; // receive random sprite
        number = Random.Range(0, 35); // icon number
        model = Resources.LoadAll<Sprite>("Sprites/UI/Models/models"); // load all models 
        icons = Resources.LoadAll<Sprite>("Sprites/UI/Icons/icons"); // load all icons

        for (int i = 0; i < model.Length; i++)
        {
            if (i < 3)
            {
                random_Color[i] = Random.Range(0f, 1f); // receive random color
            }
        }

        if (random_Model == n)  // check random sprite
        {
            gameObject.GetComponent<Image>().sprite = model[n]; // sprite model receive random sprite
        }

        // sprites receive random colors
        c = new Color(random_Color[0], random_Color[1], random_Color[2], 1);
        gameObject.GetComponent<Image>().color = c;
        icone.color = c;

        icone.sprite = icons[number]; // icone receive random icon sprite
        gameObject.GetComponent<Button>().onClick.AddListener(() => ButtonClick()); // call the button click function 
    }
    void ButtonClick()
    {
        // check name button 
        check_Button = int.Parse(icone.sprite.name);
        Debug.Log("Button clicked =>" + check_Button + "!");
    }
}