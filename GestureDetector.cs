using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable] //Serializing structure, creating list in component
public struct Gesture //Gesture structure, meant for holding data (not be used as function)
{
    public string name; 
    public List<Vector3> fingerDatas; //Will hold fingerdata of the poses
    public UnityEvent onDetected; //Sending event to objects on recognition
}

public class GestureDetector : MonoBehaviour
{
    public OVRSkeleton skeleton;
    public List<Gesture> gestures;
    private List<OVRBone> fingerBones; //OVRbone is a class created by Oculus, which will help passing data of the fingers

    // Start is called before the first frame update
    void Start()
    {
        fingerBones = new List<OVRBone>(skeleton.Bones); //Populating the list with all accessible bones through OVRBone

    }

    // Update is called once per frame
    void Update()
    {
        //Pressing the space key initiates Save(), saves gesture
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Save();
        }
    }

    void Save()
    {
        Gesture g = new Gesture(); //Add/create new gesture
        g.name = "New Gesture"; //Give the new gesture a name
        List<Vector3> data = new List<Vector3>(); //Creating new Vector list
        foreach (var bone in fingerBones)
        {
            data.Add(skeleton.transform.InverseTransformPoint(bone.Transform.position)); //For each bone, calculate position of fingers towards root of hand
        }

        g.fingerDatas = data;
        gestures.Add(g); //Gesture is added to the list of gestures
    }
}
