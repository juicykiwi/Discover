using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discover.Stage.Block;
using Discover.Stage.Cover;

namespace Discover.Stage.Zone
{
    public class ZoneBase : MonoBehaviour
    {
        protected List<BlockBase> _blockList = new List<BlockBase>();
        protected List<CoverBase> _coverList = new List<CoverBase>();
    }
}