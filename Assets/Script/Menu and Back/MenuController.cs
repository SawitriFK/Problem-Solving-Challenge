using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Button button1;
    [SerializeField] private Button button2;
    [SerializeField] private Button button3;
    [SerializeField] private Button button4;
    [SerializeField] private Button button5;
    [SerializeField] private Button button6;
    [SerializeField] private Button button7;
    [SerializeField] private Button button8;
    [SerializeField] private Button button9;

    private void Start()
    {
        button1.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("problem1");
        });

        button2.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("problem2");
        });

        button3.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("problem3");
        });

        button4.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("problem4");
        });

        button5.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("problem5");
        });

        button6.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("problem6");
        });

        button7.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("problem7");
        });

        button8.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("problem8");
        });

        button9.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("problem9");
        });
    }
}
