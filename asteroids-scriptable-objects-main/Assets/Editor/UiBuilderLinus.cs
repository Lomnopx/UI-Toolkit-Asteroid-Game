using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;


public class UiBuilderLinus : EditorWindow
{
    [MenuItem("Window/UI Toolkit/UiBuilderLinus")]
    public static void ShowExample()
    {
        UiBuilderLinus wnd = GetWindow<UiBuilderLinus>();
        wnd.titleContent = new GUIContent("UiBuilderLinus");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement _root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy.


        // Import UXML
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/UiBuilderLinus.uxml");
        VisualElement labelFromUXML = visualTree.Instantiate();
        _root.Add(labelFromUXML);

        // A stylesheet can be added to a VisualElement.
        // The style will be applied to the VisualElement and all of its children.
        var styleSheet = AssetDatabase.LoadAssetAtPath<StyleSheet>("Assets/Editor/UiBuilderLinus.uss");
    }

    
}