using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BagGrid : MonoBehaviour
{
    [SerializeField]
    private int label;
    private Image col;

    [SerializeField]
    private Text it;

    [SerializeField]
    private Text tar;
    private void Start()
    {
        col = GetComponent<Image>();
        if (GameManage.instance.collect[label] == 1)
        {
            col.color = new Color32(255, 255, 255, 255);
        }
    }

    public void info()
    {
        tar.text = it.text;
    }
}
