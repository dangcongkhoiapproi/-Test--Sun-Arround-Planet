using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SunPanel : MonoBehaviour
{
    //public InputField inputFieldX;
    //public InputField inputFieldY;
    //public Transform SunController;
    
    //public Transform Sun;
    //public Text potitionX;
    //public Text potitionY;

    //private void Start()
    //{
    //    inputFieldX.onEndEdit.AddListener(OnInputEndEditX);
    //    inputFieldY.onEndEdit.AddListener(OnInputEndEditY);
    //}
    //private void FixedUpdate()
    //{
    //    potitionX.text = Sun.transform.position.x.ToString();
    //    potitionY.text = Sun.transform.position.y.ToString();
    //}
    //private void OnInputEndEditX(string text)
    //{
    //    var a = SunController.position.x;
    //    var b = SunController.position.y;
    //    var c = SunController.position.z;
    //    if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter))
    //    {
    //        a = TextToInt(text);
    //        Vector3 currentRotation = SunController.rotation.eulerAngles;
    //        Vector3 newRotation = new Vector3(a, currentRotation.y, currentRotation.z);
    //        SunController.rotation = Quaternion.Euler(newRotation);
    //    }
    //    // Clear input field
    //    inputFieldX.text = "";
    //}
    //private void OnInputEndEditY(string text)
    //{
    //    var a = SunController.position.x;
    //    var b = SunController.position.y;
    //    var c = SunController.position.z;
    //    if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter))
    //    {
    //        a = TextToInt(text);
    //        Vector3 currentRotation = SunController.rotation.eulerAngles;
    //        Vector3 newRotation = new Vector3(currentRotation.x, a, currentRotation.z);
    //        SunController.rotation = Quaternion.Euler(newRotation);
    //    }
    //    // Clear input field
    //    inputFieldY.text = "";
    //}
    //private int TextToInt(string text)
    //{
    //    int parsedInt;

    //    if (int.TryParse(text, out parsedInt))
    //    {
    //        // Giá trị đã được chuyển đổi thành số nguyên thành công
    //        Debug.Log("Giá trị số nguyên: " + parsedInt);
    //    }
    //    else
    //    {
    //        // Không thể chuyển đổi thành số nguyên
    //        Debug.Log("Không thể chuyển đổi thành số nguyên: " + text);
    //    }
    //    return parsedInt;
    //}
}
