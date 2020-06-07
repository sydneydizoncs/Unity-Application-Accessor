//This codes allows the launching of applications directly from Unity via Unity's GUI.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonEditorWindow : UnityEditor.EditorWindow
{
    private const string x = "ROM Hack Components/Application Launcher";

    [UnityEditor.MenuItem(x, false, 0)]
    private static void Launch()
    {
        var window = GetWindow<PokemonEditorWindow>(true,"Application Launcher");
    }

    private void OnGUI()
    {
        //This method, "makeButton", creates a button in the Unity file that executes a path when pressed.
        void makeButton(string app, string path)
            {
        
                if (GUILayout.Button("Launch " + app))
                {
                    string consoleNotification = "\"" + app + "\" Launched";
                        consoleNotification.Log();
                    using (System.Diagnostics.Process proc = System.Diagnostics.Process.Start(path))
                    { }
             }

        }

        makeButton("\"VisualBoy Advance\"", @"C:\Users\sydney\Downloads\Pokemon ROM Hack\VisualBoyAdvance.exe");
        makeButton("\"Pokemon Fire Red\"", @"C:\Users\sydney\Downloads\Pokemon ROM Hack\Pokemon Games\[Original] Pokemon - Fire Red Version");
        makeButton("\"Advance Map\"", @"C:\Users\sydney\Downloads\Pokemon ROM Hack\AdvanceMap\AdvanceMap.exe");
        makeButton("\"XSE Script Editor\"", @"C:\Users\sydney\Desktop\XSE.exe");
        makeButton("\"Sublime\"", @"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Sublime Text 3");


    }
}
