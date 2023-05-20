using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class SetNavigation : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown navigationDropdown;

    [SerializeField]
    private List<Target> navigationTargetObjects = new List<Target>();

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
            line.SetPositions(path.corners);
           
        }
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
    public void ToogleVisibility()
    {
        lineToggle = !lineToggle;
        line.enabled = lineToggle;
    }
}
