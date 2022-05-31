using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class UIControl : MonoBehaviour
{

    Button startGameBtn;
    Button msgBtn;
    Label msgText1;
    Label msgText2;
    // Start is called before the first frame update
    void Start()
    {
        VisualElement r = GetComponent<UIDocument>().rootVisualElement;
        startGameBtn = r.Q<Button>("start_btn");
        msgBtn = r.Q<Button>("msg_btn");
        msgText1 = r.Q<Label>("Juan");
        msgText2 = r.Q<Label>("Jose");

        msgBtn.clicked += showMessage;
        startGameBtn.clicked += comenzar;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void comenzar()
    {
        SceneManager.LoadScene(1);
    }
    void showMessage()
    {
        msgText1.style.display = DisplayStyle.Flex;
        msgText2.style.display = DisplayStyle.Flex;
    }
}
