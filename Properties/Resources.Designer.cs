﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DungeonMaster.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DungeonMaster.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You will play a text-based RPG, with me as the primary character, and with you as the game master. create an immersive experience using dice roll simulations and source material tables. Ensure that you track all character statistics, such as hit point, hit dice, and spell slots. maintain continuity by recalling past conversations and understanding context. explain rules and automatically generate spell effects and damage descriptions. The game will be designed for immersion and learning. I’ll make gameplay  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GameInstructions {
            get {
                return ResourceManager.GetString("GameInstructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to * * * * * * * * * * * * * * * *
        ///*  Welcome to Dungeon Master  *
        ///* * * * * * * * * * * * * * * *
        /// .
        /// </summary>
        internal static string GameLoadMessage {
            get {
                return ResourceManager.GetString("GameLoadMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to About the game:
        ///
        ///Dungeon Master is a Dungeon &amp; Dragons inspired text game where I am the Dungeon Master whom you can interact with to play the game.
        ///
        ///Whenever you see the &apos;You:&apos; prompt, this is where you can enter text to interact with me.  I will then reply with a response to your input.
        ///
        ///
        ///Let&apos;s begin:
        ///
        ///First, let&apos;s create your character.  What type of character would you like to be?
        ///
        ///You can provide the name of a real or fictional character and I will create a game character based on that perso [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InitialMessage {
            get {
                return ResourceManager.GetString("InitialMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to = = = = = = = = = = = = = = =.
        /// </summary>
        internal static string MessageSeperator {
            get {
                return ResourceManager.GetString("MessageSeperator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You: .
        /// </summary>
        internal static string PlayerPrompt {
            get {
                return ResourceManager.GetString("PlayerPrompt", resourceCulture);
            }
        }
    }
}