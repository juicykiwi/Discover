using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Discover.Stage
{
    public class StageBase : MonoBehaviour
    {
        bool _isLoadedStage = false;
        public bool isLoadedStage { get { return _isLoadedStage; } }

        [SerializeField]
        protected StageData _stageData = new StageData();

        protected List<FieldBase> _fieldList = new List<FieldBase>();
        protected StageDataControl _dataControl = new StageDataControl();


        public void SaveStageData()
        {
            _dataControl.Save(_stageData);
        }

        public void LoadStageData( int stageIndex )
        {
            StageData loadStageData = _dataControl.Load(stageIndex);
            _stageData = loadStageData;
        }

        public void LoadStage( StageInitInfo stageInitInfo )
        {
            StartCoroutine(LoadStageCoroutine(stageInitInfo));
        }

        IEnumerator LoadStageCoroutine( StageInitInfo stageInitInfo )
        {
            _isLoadedStage = false;
            LoadStageData(stageInitInfo.StageIndex);
            yield return null;

            _isLoadedStage = true;
        }
    }
}