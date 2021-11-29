using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    public void Back()
    {
        //GameObject.Find("Fade").SetActive(true);
        //Fade.instance.Change_Scene(0);
        SceneManager.LoadScene(0);
    }

    public Slider BGMSlider;
    public AudioSource BGMSource;
    public void AdjustTheVolume()
    {
        BGMSource.volume = BGMSlider.value;
    }

    Dropdown dpn;
    void Start()
    {
        Dropdown.OptionData data1 = new Dropdown.OptionData();
        data1.text = "1280*1024";
        Dropdown.OptionData data2 = new Dropdown.OptionData();
        data2.text = "1024*768";
        Dropdown.OptionData data3 = new Dropdown.OptionData();
        data3.text = "800*600";
        Dropdown.OptionData data4 = new Dropdown.OptionData();
        data4.text = "1280*800";
        Dropdown.OptionData data5 = new Dropdown.OptionData();
        data5.text = "1440*900";
        Dropdown.OptionData data6 = new Dropdown.OptionData();
        data6.text = "1680*1050";
        dpn = transform.GetComponent<Dropdown>();
        dpn.options.Add(data1);
        dpn.options.Add(data2);
        dpn.options.Add(data3);
        dpn.options.Add(data4);
        dpn.options.Add(data5);
        dpn.options.Add(data6);
    }
}