using Assets.Scripts.Visuals.UiHandler;

namespace Assets.Scripts.Visuals.UiBuilder
{
    public class BooleanPropertyAtom : Atom
    {
        public new class Data : Atom.Data
        {
            public string name;
            public bool currentContents;
            public StringPropertyAtom.UiPropertyActions<bool> actions;


            public override bool Equals(Atom.Data other)
            {
                if (!(other is BooleanPropertyAtom.Data otherBooleanProperty))
                {
                    return false;
                }

                return
                    name.Equals(otherBooleanProperty.name) &&
                    currentContents.Equals(otherBooleanProperty.currentContents) &&
                    actions.Equals(otherBooleanProperty.actions);
            }
        }

        protected Data data;

        public override void Update(Atom.Data newData)
        {
            UiBuilder.Stats.atomsUpdatedCount++;

            var newBooleanPropertyData = (Data) newData;

            // Stage 1: Check for a GameObject and make one, if it doesn't exist
            if (gameObject == null)
            {
                // Make new game object
                gameObject = MakeNewGameObject();
            }

            // Stage 2: Check for updated data and update, if data was changed
            if (!newBooleanPropertyData.Equals(data))
            {
                // Update data
                var booleanPropertyHandler = gameObject.gameObject.GetComponent<BooleanPropertyHandler>();

                booleanPropertyHandler.ResetActions();

                booleanPropertyHandler.PropertyNameText.text = newBooleanPropertyData.name;
                booleanPropertyHandler.CheckBoxInput.isOn = newBooleanPropertyData.currentContents;

                // setup actions
                booleanPropertyHandler.SetActions(newBooleanPropertyData.actions);
            }
        }

        protected virtual AtomGameObject MakeNewGameObject()
        {
            var atomObject = uiBuilder.GetAtomObjectFromPool(UiBuilder.AtomType.BooleanPropertyInput);
            return atomObject;
        }


        public BooleanPropertyAtom(UiBuilder uiBuilder) : base(uiBuilder)
        {
        }
    }

    public static class BooleanPropertyPanelHelper
    {
        public static BooleanPropertyAtom.Data AddBooleanProperty(this PanelAtom.Data panelAtomData, string name, bool currentContents, StringPropertyAtom.UiPropertyActions<bool> actions)
        {
            var data = new BooleanPropertyAtom.Data
            {
                name = name,
                currentContents = currentContents,
                actions = actions
            };

            panelAtomData.childDates.Add(data);
            return data;
        }
    }
}