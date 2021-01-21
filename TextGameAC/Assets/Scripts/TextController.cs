using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text text;
    void Start()
    {
        text.text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. \n" +
            "Pellentesque suscipit justo sit amet dictum gravida.\n" +
            "Pellentesque facilisis aliquam velit eu dignissim.\n" +
            "Aliquam quis gravida lacus. Aenean dignissim sapien nec \n" +
            "blandit sollicitudin. Phasellus bibendum velit vehicula, \n" +
            "luctus sapien a, malesuada quam. Pellentesque scelerisque \n" +
            "libero id facilisis mattis. Quisque tempor bibendum diam, \n" +
            "non egestas urna tempor a. Vivamus condimentum aliquet urna \n" +
            "eget rutrum. Ut consectetur, lectus eget semper vehicula, \n" +
            "nulla massa luctus ligula, ac pretium elit magna nec urna. \n" +
            "Praesent vel risus et urna lobortis accumsan. Vestibulum sit \n" +
            "amet nunc mauris. Phasellus laoreet quam eget enim maximus \n" +
            "dignissim. Ut luctus pulvinar porttitor.\n";
        // zmienna -> typ nazwe i ew. wartosc
        // 
    }


    void Update()
    {
        //instrukcja warunkowa ktora bedzie przekazywac wartosc true w momencie nacisniecia klawisza enter

    }
}
