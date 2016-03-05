using System;
using ICities;
using UnityEngine;
using System.Collections;
using System.IO;

namespace CSLMusicPack_mrnotsoevil_Collection1_Sky
{
    public class CSLMusicPackMod : IUserMod
    {
        public string Name
        {
            get
            {
                return "Music pack: Collection 1 - Sky Music";
            }
        }

        public string Description
        {
            get
            {
                return "Adds music by Ketsa and Blue Dot Sessions to the game. Needs CSLMusicMod and Collection 1.";
            }
        }
    }
}
