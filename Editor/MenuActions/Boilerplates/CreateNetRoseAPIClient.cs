using System.Collections.Generic;
using AlephVault.Unity.Boilerplates.Utils;
using AlephVault.Unity.NetRose.MenuActions.Boilerplates;
using UnityEditor;
using UnityEngine;

namespace AlephVault.Unity.NetRose.Storage
{
    namespace MenuActions
    {
        namespace Boilerplates
        {
            public static class CreateNetRoseAPIClient
            {
                /// <summary>
                ///   Opens a dialog to execute the single-account API client creation boilerplate.
                /// </summary>
                [MenuItem("Assets/Create/Aleph Vault/NetRose/Boilerplates/Create Single-Account storage API client", false, 205)]
                public static void ExecuteSingleAccountBoilerplate()
                {
                    string directory = "Packages/com.alephvault.unity.netrose.storage/" +
                                       "Editor/MenuActions/Boilerplates/Templates";
                    
                    TextAsset singleCharAccount = AssetDatabase.LoadAssetAtPath<TextAsset>(
                        directory + "/SingleCharAccount.cs.txt"
                    );
                    TextAsset scope = AssetDatabase.LoadAssetAtPath<TextAsset>(
                        directory + "/Scope.cs.txt"
                    );
                    TextAsset map = AssetDatabase.LoadAssetAtPath<TextAsset>(
                        directory + "/Map.cs.txt"
                    );
                    TextAsset position = AssetDatabase.LoadAssetAtPath<TextAsset>(
                        directory + "/Position.cs.txt"
                    );
                    TextAsset singleCharAccountAPIClient = AssetDatabase.LoadAssetAtPath<TextAsset>(
                        directory + "/SingleCharAccountAPIClient.cs.txt"
                    );
                    new Boilerplate()
                        .IntoDirectory("Scripts", false)
                            .IntoDirectory("Server", false)
                                .IntoDirectory("Authoring", false)
                                    .IntoDirectory("Behaviours", false)
                                        .IntoDirectory("External", false)
                                            .IntoDirectory("Client")
                                                .Do(Boilerplate.InstantiateScriptCodeTemplate(
                                                    singleCharAccountAPIClient, "SingleCharAccountAPIClient", 
                                                    new Dictionary<string, string>()
                                                ))
                                            .End()
                                            .IntoDirectory("Models")
                                                .Do(Boilerplate.InstantiateScriptCodeTemplate(
                                                    singleCharAccount, "SingleCharAccount", 
                                                    new Dictionary<string, string>()
                                                ))
                                                .Do(Boilerplate.InstantiateScriptCodeTemplate(
                                                    scope, "Scope", 
                                                    new Dictionary<string, string>()
                                                ))
                                                .Do(Boilerplate.InstantiateScriptCodeTemplate(
                                                    map, "Map", 
                                                    new Dictionary<string, string>()
                                                ))
                                                .Do(Boilerplate.InstantiateScriptCodeTemplate(
                                                    position, "Position", 
                                                    new Dictionary<string, string>()
                                                ))
                                            .End()
                                        .End()
                                    .End()
                                .End()
                            .End()
                        .End();
                }
                
                /// <summary>
                ///   Opens a dialog to execute the multiple-account API client creation boilerplate.
                /// </summary>
                [MenuItem("Assets/Create/Aleph Vault/NetRose/Boilerplates/Create Multiple-Account storage API client", false, 206)]
                public static void ExecuteBoilerplate()
                {
                    string directory = "Packages/com.alephvault.unity.netrose.storage/" +
                                       "Editor/MenuActions/Boilerplates/Templates";
                    
                    TextAsset multiCharAccount = AssetDatabase.LoadAssetAtPath<TextAsset>(
                        directory + "/MultiCharAccount.cs.txt"
                    );
                    TextAsset character = AssetDatabase.LoadAssetAtPath<TextAsset>(
                        directory + "/Character.cs.txt"
                    );
                    TextAsset scope = AssetDatabase.LoadAssetAtPath<TextAsset>(
                        directory + "/Scope.cs.txt"
                    );
                    TextAsset map = AssetDatabase.LoadAssetAtPath<TextAsset>(
                        directory + "/Map.cs.txt"
                    );
                    TextAsset position = AssetDatabase.LoadAssetAtPath<TextAsset>(
                        directory + "/Position.cs.txt"
                    );
                    TextAsset multiCharAccountAPIClient = AssetDatabase.LoadAssetAtPath<TextAsset>(
                        directory + "/MultiCharAccountAPIClient.cs.txt"
                    );
                    new Boilerplate()
                        .IntoDirectory("Scripts", false)
                            .IntoDirectory("Server", false)
                                .IntoDirectory("Authoring", false)
                                    .IntoDirectory("Behaviours", false)
                                        .IntoDirectory("External", false)
                                            .IntoDirectory("Client")
                                                .Do(Boilerplate.InstantiateScriptCodeTemplate(
                                                    multiCharAccountAPIClient, "MultiCharAccountAPIClient", 
                                                    new Dictionary<string, string>()
                                                ))
                                            .End()
                                            .IntoDirectory("Models")
                                                .Do(Boilerplate.InstantiateScriptCodeTemplate(
                                                    multiCharAccount, "MultiCharAccount", 
                                                    new Dictionary<string, string>()
                                                ))
                                                .Do(Boilerplate.InstantiateScriptCodeTemplate(
                                                    character, "Character", 
                                                    new Dictionary<string, string>()
                                                ))
                                                .Do(Boilerplate.InstantiateScriptCodeTemplate(
                                                    scope, "Scope", 
                                                    new Dictionary<string, string>()
                                                ))
                                                .Do(Boilerplate.InstantiateScriptCodeTemplate(
                                                    map, "Map", 
                                                    new Dictionary<string, string>()
                                                ))
                                                .Do(Boilerplate.InstantiateScriptCodeTemplate(
                                                    position, "Position", 
                                                    new Dictionary<string, string>()
                                                ))
                                            .End()
                                        .End()
                                    .End()
                                .End()
                            .End()
                        .End();
                }
            }
        }
    }
}
