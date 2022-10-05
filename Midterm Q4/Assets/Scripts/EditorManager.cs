using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EditorManager : MonoBehaviour
{
    PlayerAction InputAction;

    public Camera mainCam;
    public Camera editorCam;

    public GameObject prefab1;
    public GameObject prefab2;

    GameObject item;

    public bool editorMode = false;
    bool instantiated = false;

    private void OnEnable()
    {
        InputAction.Editor.Enable();
    }

    private void OnDisable()
    {
        InputAction.Editor.Disable();
    }

    // Start is called before the first frame update
    void Awake()
    {
        InputAction = new PlayerAction();

        InputAction.Editor.EnableEditor.performed += cntxt => SwitchCamera();
        InputAction.Editor.Additem1.performed += cntxt => AddItem(1);
        InputAction.Editor.Additem2.performed += cntxt => AddItem(2);
        InputAction.Editor.Dropitem.performed += cntxt => DropItem();

        mainCam.enabled = true;
        editorCam.enabled = false;
    }

    public void SwitchCamera()
    {
        mainCam.enabled = !mainCam.enabled;
        editorCam.enabled = !editorCam.enabled;
    }

    private void AddItem( int ItemId)
    {
        if(editorMode && !instantiated)
        {
            switch(ItemId)
            {
                case 1:
                    item = Instantiate(prefab1);
                    break;

                case 2:
                    item = Instantiate(prefab2);
                    break;

                default:
                    break;
            }

            instantiated = true;
        }
    }

    private void DropItem()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(mainCam.enabled == false && editorCam.enabled == true)
        {
            editorMode = true;
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }

        else
        {
            editorMode = false;
            Time.timeScale = 1;
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
