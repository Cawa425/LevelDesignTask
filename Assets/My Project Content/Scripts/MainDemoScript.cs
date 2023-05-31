using System.Collections;
using System.Collections.Generic;
using System.Linq;
using My_Project_Content.Scripts.Interfaces;
using TMPro;
using UnityEngine;

public class MainDemoScript : MonoBehaviour
{
    public List<GameObject> sequence = new();
    public Canvas MainCanvas;
    public TextMeshProUGUI mainText;
    public static MainDemoScript Instance { get; set; }

    // Start is called before the first frame update
    private void Start()
    {
        if (Instance != null) return;
        Instance = this;
    }
}
