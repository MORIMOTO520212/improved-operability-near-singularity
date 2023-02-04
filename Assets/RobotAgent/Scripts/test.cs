using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class test : MonoBehaviour
{
    public Transform j1;
    public Transform j2;
    public Transform j3;
    public Transform j4;
    public Transform j5;

    private StreamWriter sw;
    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        sw = new StreamWriter(@"SaveData.csv", false, Encoding.GetEncoding("Shift_JIS"));
        string[] s1 = { "axis1", "axis2", "axis3", "axis4", "axis5" };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);
    }

    // Update is called once per frame
    void Update()
    {
        string[] s1 = {
            j1.localEulerAngles.y.ToString(), 
            j2.localEulerAngles.y.ToString(), 
            j3.localEulerAngles.y.ToString(), 
            j4.localEulerAngles.z.ToString(), 
            j5.localEulerAngles.y.ToString() };
        string s2 = string.Join(",", s1);
        sw.WriteLine(s2);


        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Stop!");
            sw.Close();
        }

        i++;
    }
}
