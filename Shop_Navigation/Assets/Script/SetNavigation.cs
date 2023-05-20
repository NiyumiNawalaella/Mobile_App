using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;
using UnityEngine.UI;

public class SetNavigation : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown navigationDropdown;

    [SerializeField]
    private List<Target> navigationTargetObjects = new List<Target>();

    [SerializeField]
    private Slider navigationYOffset;

    private NavMeshPath path; //current calculated path
    private LineRenderer line; //linerenderer o display path
    private Vector3 targetPostion = Vector3.zero; //current target position

    private bool lineToggle = false;

    private void Start()
    {
        path = new NavMeshPath();
        line = transform.GetComponent<LineRenderer>();
        line.enabled = lineToggle;
    }

    private void Update()
    {
        if(lineToggle && targetPostion !=Vector3.zero)
        {
            NavMesh.CalculatePath(transform.position, targetPostion, NavMesh.AllAreas, path);
            line.positionCount = path.corners.Length;
            Vector3[] calculatedPathAndOffset = AddLineOffset();
            line.SetPositions(calculatedPathAndOffset);
           
        }
    }
    private Vector3[] AddLineOffset()
    {
        if(navigationYOffset.value ==0)
        {
            return path.corners;
        }
        Vector3[] calculatedLine = new Vector3[path.corners.Length];
        for (int i = 0; i < path.corners.Length; i++)
        {
            calculatedLine[i] = path.corners[i] +new Vector3(0, navigationYOffset.value, 0);
        }
        return calculatedLine;
    }
    public void SetCurrentNavigationTarget(int selectedValue)
    {
        targetPostion = Vector3.zero;
        string selectedText = navigationDropdown.options[selectedValue].text;
        Target currentTarget = navigationTargetObjects.Find(x => x.Name.ToLower().Equals(selectedText.ToLower()));
        if(currentTarget !=null)
        {
            targetPostion = currentTarget.PositionObject.transform.position;
        }

    }
    public void ToggleVisibility()
    {
        lineToggle = !lineToggle;
        line.enabled = lineToggle;
    }
}
