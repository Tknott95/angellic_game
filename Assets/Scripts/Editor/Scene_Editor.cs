using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;


public class Scene_Editor : MonoBehaviour {

	[MenuItem("Quick Open/Scene1 #1")]
    static void Scene1()
    {
        EditorSceneManager.SaveOpenScenes();
        EditorSceneManager.OpenScene("Assets/1_hell.unity");

    }

    [MenuItem("Quick Open/Scene2 #&2")]
    static void Scene2()
    {
        EditorSceneManager.SaveOpenScenes();
        EditorSceneManager.OpenScene("Assets/heaven_Scene.unity");




    }
}
