using System;
using Assets.Scripts.EditorState;
using Assets.Scripts.ProjectState;
using Assets.Scripts.SceneState;
using Assets.Scripts.System;
using UnityEngine;

namespace Assets.Scripts.SceneVisuals
{
    public class GltfShapeVisuals : MonoBehaviour
    {
        private GameObject _currentModelObject = null;

        public void UpdateVisuals(DclEntity entity)
        {
            var assetGuid = entity.GetComponentByName("GLTFShape")?.GetPropertyByName("asset")?.GetConcrete<Guid>().Value;

            if (!assetGuid.HasValue)
                return;

            if (EditorStates.CurrentProjectState.Assets.UsedAssets.TryGetValue(assetGuid.Value, out var asset))
            {
                var gltfAsset = asset as DclGltfAsset;

                if (gltfAsset == null)
                    return;

                ModelCacheSystem.GetModel(gltfAsset.Path, "",
                    o =>
                    {
                        if (o == null)
                            return;

                        Destroy(_currentModelObject);

                        o.transform.SetParent(transform);
                        o.transform.localScale = Vector3.one;
                        o.transform.localRotation = Quaternion.identity;
                        o.transform.localPosition = Vector3.zero;

                        _currentModelObject = o;
                    });
            }

        }

        public void Deactivate()
        {

        }
    }
}
