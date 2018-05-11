using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Discover.Stage
{
    public class ZoneBase : MonoBehaviour
    {
        protected List<BlockBase> _blockList = new List<BlockBase>();
        protected List<CoverBase> _coverList = new List<CoverBase>();
    }
}