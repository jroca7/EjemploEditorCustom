using UnityEngine;
using UnityEditor;

public class Examplewindow : EditorWindow
{

    Color Color;

    [MenuItem("Window/Colorear")]
    public static void ShowWindow()
    {

        GetWindow<Examplewindow>("Colorear");
    }
    void OnGUI()
    {
        GUILayout.Label("Colorea la esfera", EditorStyles.boldLabel);

       Color = EditorGUILayout.ColorField("Color", Color);

        if (GUILayout.Button("Colorear"))
        {
         
            Colorize();
        }
    }
    void Colorize()
    {
        foreach (GameObject obj in Selection.gameObjects)

        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.sharedMaterial.color = Color;
            }
        }

    }
}