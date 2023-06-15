using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeRotateByInput : MonoBehaviour
{
    public InputField inputFieldX;
    public InputField inputFieldY;
    
    private void Start()
    {
        inputFieldX.onEndEdit.AddListener(OnInputEndEditX);
        inputFieldY.onEndEdit.AddListener(OnInputEndEditY);
    }
    private void OnInputEndEditX(string text)
    {
        var a = transform.position.x;
        var b = transform.position.y;
        var c = transform.position.z;
        if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter))
        {
            a = TextToInt(text);
            Vector3 currentRotation = transform.rotation.eulerAngles;
            Vector3 newRotation = new Vector3(a, currentRotation.y, currentRotation.z);
            //transform.rotation = Quaternion.Euler(newRotation);
            transform.Rotate(newRotation);
        }
        // Clear input field
        inputFieldX.text = "";
    }
    private void OnInputEndEditY(string text)
    {
        var a = transform.position.x;
        var b = transform.position.y;
        var c = transform.position.z;
        if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.KeypadEnter))
        {
            a = TextToInt(text);
            Vector3 currentRotation = transform.rotation.eulerAngles;
            Vector3 newRotation = new Vector3(currentRotation.x, a, currentRotation.z);
            // transform.rotation = Quaternion.Euler(newRotation);
            transform.Rotate(newRotation);
        }
        // Clear input field
        inputFieldY.text = "";
    }
    private int TextToInt(string text)
    {
        int parsedInt;

        if (int.TryParse(text, out parsedInt))
        {
            // Giá trị đã được chuyển đổi thành số nguyên thành công
            Debug.Log("Giá trị số nguyên: " + parsedInt);
        }
        else
        {
            // Không thể chuyển đổi thành số nguyên
            Debug.Log("Không thể chuyển đổi thành số nguyên: " + text);
        }
        return parsedInt;
    }
}
