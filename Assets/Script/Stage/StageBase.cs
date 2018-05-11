using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Discover.Stage
{
    public class StageBase : MonoBehaviour
    {
        [SerializeField]
        protected StageData _stageData = new StageData();

        protected List<FieldBase> _fieldList = new List<FieldBase>();
        protected StageDataControl _dataControl = new StageDataControl();

        public void Init( StageInitInfo stageInitInfo )
        {
            
        }

        public void Save()
        {
            _dataControl.Save(_stageData);
        }

        public void Load( int stageIndex )
        {
            StageData loadStageData = _dataControl.Load(stageIndex);
            _stageData = loadStageData;
        }
    }
}