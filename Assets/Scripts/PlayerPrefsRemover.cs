using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]
public class PlayerPrefsRemover : MonoBehaviour
{
    [MenuItem("Tools/Player Prefs Remover")]
    public static void DeletePlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Deleting player prefs...");
    }
}
