using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Windlight.Data;
using Windlight.UnityObject;

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


        // Save and load stage

        public void SaveStageData()
        {
            _dataControl.Save(_stageData);
        }

        public void LoadStageData( int stageIndex )
        {
            StageData loadStageData = _dataControl.Load(stageIndex);
            _stageData = loadStageData;

            _stageData.InitData();
        }

        public void LoadStage( StageInitInfo stageInitInfo )
        {
            StartCoroutine(LoadStageCoroutine(stageInitInfo));
        }

        protected IEnumerator LoadStageCoroutine( StageInitInfo stageInitInfo )
        {
            _isLoadedStage = false;
            LoadStageData(stageInitInfo.StageIndex);
            yield return null;

            yield return StartCoroutine(CreateStageCoroutine());

            _isLoadedStage = true;
        }


        // Create stage

        protected IEnumerator CreateStageCoroutine()
        {
            foreach (FieldInfo eachFieldInfo in _stageData._fieldInfoList)
            {
                yield return StartCoroutine(CreateFieldCoroutine(eachFieldInfo));
            }

            yield break;
        }

        protected IEnumerator CreateFieldCoroutine( FieldInfo fieldInfo ) 
        {
            FieldBase field = FieldFactory.CreateField(fieldInfo);
            UnityObjectHelper.SetParent(gameObject, field.gameObject, true);

            field.InitField(fieldInfo);

            _fieldList.Add(field);
            yield break;
        }
    }
}