using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScrollView : MonoBehaviour
{
    public GameObject scrollView;

    private bool isScrollViewVisible = false;

    public void ToggleScrollView()
    {
        isScrollViewVisible = !isScrollViewVisible;
        scrollView.SetActive(isScrollViewVisible);
    }
}
