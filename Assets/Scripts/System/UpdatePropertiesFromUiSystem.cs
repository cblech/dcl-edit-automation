using Assets.Scripts.Command;
using Assets.Scripts.EditorState;
using Assets.Scripts.SceneState;
using UnityEngine;

namespace Assets.Scripts.System
{
    public class UpdatePropertiesFromUiSystem : MonoBehaviour
    {
        public static void SetNewName(DclEntity entity, string newName)
        {
            CommandSystem.ExecuteCommand(new ChangeEntityName(entity.Id, newName, entity.CustomName));
        }

        public static void SetIsExposed(DclEntity entity, bool isExposed)
        {
            if(isExposed == entity.IsExposed)
                return;

            if (isExposed)
            {
                if (ExposeEntitySystem.IsEntityExposable(entity))
                {
                    CommandSystem.ExecuteCommand(new ChangeIsExposed(entity.Id,true, entity.IsExposed));
                }
                else
                {
                    // TODO: show expose failed message
                    EditorStates.CurrentSceneState.CurrentScene?.SelectionState.SelectionChangedEvent.Invoke();
                }
            }
            else
            {
                CommandSystem.ExecuteCommand(new ChangeIsExposed(entity.Id, false, entity.IsExposed));
            }
        }

        public static void UpdateFloatingProperty<T>(DclPropertyIdentifier property, T value)
        {
            var scene = EditorStates.CurrentSceneState.CurrentScene;

            if (scene == null)
            {
                return;
            }

            scene.GetPropertyFromIdentifier(property).GetConcrete<T>().SetFloatingValue(value);

            scene.SelectionState.SelectionChangedEvent.Invoke();
        }

        public static void RevertFloatingProperty(DclPropertyIdentifier property)
        {
            var scene = EditorStates.CurrentSceneState.CurrentScene;

            if (scene == null)
            {
                return;
            }

            scene.GetPropertyFromIdentifier(property).ResetFloating();
        }

        public static void UpdateFixedProperty<T>(DclPropertyIdentifier property, T value)
        {
            var scene = EditorStates.CurrentSceneState.CurrentScene;

            if (scene == null)
            {
                return;
            }

            var dclProperty = scene.GetPropertyFromIdentifier(property);
            var oldValue = dclProperty.GetConcrete<T>().FixedValue;

            if (oldValue.Equals(value))
            {
                dclProperty.ResetFloating();
                //Debug.Log("Value hasn't changed");
                return;
            }

            CommandSystem.ExecuteCommand(new ChangeProperty<T>(property, oldValue, value));


            // TODO remove comments before merging
            //_commandSystem.ExecuteCommand(_commandFactory.MakeChangeProperty<T>(property, oldValue, value));
            //_commandSystem.ExecuteCommand(_commandSystem.Factory.CreateChangeProperty<T>(property, oldValue, value));
            //_commandSystem.ExecuteChangePropertyCommand<T>(property, oldValue, value);
        }
    }
}
