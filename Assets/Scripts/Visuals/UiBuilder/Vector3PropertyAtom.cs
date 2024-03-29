using System.Collections.Generic;
using Assets.Scripts.Visuals.PropertyHandler;
using Assets.Scripts.Visuals.UiHandler;
using UnityEngine;

namespace Assets.Scripts.Visuals.UiBuilder
{
    public class Vector3PropertyAtom : Atom
    {
        public new class Data : Atom.Data
        {
            public string name;
            public List<string> placeholders;
            public Vector3 currentContents;
            public StringPropertyAtom.UiPropertyActions<Vector3> actions;


            public override bool Equals(Atom.Data other)
            {
                if (!(other is Vector3PropertyAtom.Data otherVector3Property))
                {
                    return false;
                }

                return
                    name.Equals(otherVector3Property.name) &&
                    placeholders.Equals(otherVector3Property.placeholders) &&
                    currentContents.Equals(otherVector3Property.currentContents) &&
                    actions.Equals(otherVector3Property.actions);
            }
        }

        protected Data data;

        public override void Update(Atom.Data newData)
        {
            UiBuilder.Stats.atomsUpdatedCount++;

            var newVector3PropertyData = (Data) newData;

            // Stage 1: Check for a GameObject and make one, if it doesn't exist
            if (gameObject == null)
            {
                // Make new game object
                gameObject = MakeNewGameObject();
            }

            // Stage 2: Check for updated data and update, if data was changed
            if (!newVector3PropertyData.Equals(data))
            {
                // Update data
                var vector3PropertyHandler = gameObject.gameObject.GetComponent<Vector3PropertyHandler>();

                vector3PropertyHandler.ResetActions(); // Actions need to be reset, before changing values

                vector3PropertyHandler.propertyNameText.text = newVector3PropertyData.name;

                vector3PropertyHandler.numberInputX.SetCurrentNumber(newVector3PropertyData.currentContents.x);
                vector3PropertyHandler.numberInputX.TextInputHandler.SetPlaceHolder(newVector3PropertyData.placeholders[0]);

                vector3PropertyHandler.numberInputY.SetCurrentNumber(newVector3PropertyData.currentContents.y);
                vector3PropertyHandler.numberInputY.TextInputHandler.SetPlaceHolder(newVector3PropertyData.placeholders[1]);

                vector3PropertyHandler.numberInputZ.SetCurrentNumber(newVector3PropertyData.currentContents.z);
                vector3PropertyHandler.numberInputZ.TextInputHandler.SetPlaceHolder(newVector3PropertyData.placeholders[2]);

                // setup actions
                vector3PropertyHandler.SetActions(newVector3PropertyData.actions);
            }
        }

        protected virtual AtomGameObject MakeNewGameObject()
        {
            var atomObject = uiBuilder.GetAtomObjectFromPool(UiBuilder.AtomType.Vector3PropertyInput);
            return atomObject;
        }


        public Vector3PropertyAtom(UiBuilder uiBuilder) : base(uiBuilder)
        {
        }
    }

    public static class Vector3PropertyPanelHelper
    {
        public static Vector3PropertyAtom.Data AddVector3Property(this PanelAtom.Data panelAtomData, string name, List<string> placeholders, Vector3 currentContents, StringPropertyAtom.UiPropertyActions<Vector3> actions)
        {
            var data = new Vector3PropertyAtom.Data
            {
                name = name,
                placeholders = placeholders,
                currentContents = currentContents,
                actions = actions
            };

            panelAtomData.childDates.Add(data);
            return data;
        }
    }
}