using UnityEngine;

public class Active_On_Off : MonoBehaviour
{
    //[SerializeField]GameObject schoolSphere;
    //bool onOff;
    //private void Start()
    //{
    //    schoolSphere = GameObject.FindGameObjectWithTag("School Yard");
    //    onOff = false;
    //}
    //private void OnMouseDown()
    //{
    //    onOff = !onOff;
    //}
    //private void Update()
    //{
    //    if(onOff == true)
    //    {
    //        schoolSphere.SetActive(true);
    //    }
    //    else if(onOff == false)
    //    {
    //        schoolSphere.SetActive(false);
    //    }
    //}
    private void OnMouseDown()
    {
        //Instantiate(schoolSphere);
        Application.OpenURL("https://youtu.be/7KCuO-GZXCk");
    }
}
