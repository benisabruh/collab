using UnityEngine;
using UnityEngine.InputSystem;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Zoom : MonoBehaviour
{
    new Camera camera;
    public float defaultFOV = 70;
    public float maxZoomFOV = 15;
    [Range(0, 1)]
    public float currentZoom;
    public float sensitivity = 1;
    
    private PlayerInput playerInput;


    void Awake()
    {
        // Get the camera on this gameObject and the defaultZoom.
        camera = GetComponent<Camera>();
        if (camera)
        {
            defaultFOV = camera.fieldOfView;
        }
    }

    void Update()
    {
        // Update the currentZoom and the camera's fieldOfView.
        float scrollValue = Mouse.current.scroll.y.ReadValue();
        currentZoom += scrollValue * sensitivity * .05f;
        currentZoom = Mathf.Clamp01(currentZoom);
        camera.fieldOfView = Mathf.Lerp(defaultFOV, maxZoomFOV, currentZoom);
    }
}
