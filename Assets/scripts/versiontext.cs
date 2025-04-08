using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class versiontext : MonoBehaviour
{
    public Text versionstuff;
    // Start is called before the first frame update
    void Start()
    {
        versionstuff.text = "Version: " + Application.version;
        Application.targetFrameRate = -1;
    }
}
