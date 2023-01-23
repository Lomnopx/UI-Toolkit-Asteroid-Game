using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

[CustomEditor(typeof(UIController))]
public class UIControllerManager : Editor
{
     public VisualTreeAsset m_UXML;
     
public override VisualElement CreateInspectorGUI()
{
    var _root = new VisualElement();

    m_UXML.CloneTree(_root);
    return _root;
    
    

    var foldout= new Foldout() { viewDataKey = "AsteroidFullInspectionFoldout", text = "Full Inspectior"};
    InspectorElement.FillDefaultInspector(foldout, serializedObject, this);
    _root.Add(foldout);
    return _root;
}
    
}