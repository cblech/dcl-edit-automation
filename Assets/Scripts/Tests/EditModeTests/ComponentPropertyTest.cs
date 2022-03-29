using Assets.Scripts.State;
using NUnit.Framework;
using UnityEngine;

namespace Assets.Scripts.Tests.EditModeTests
{
    public class ComponentPropertyTest
    {
        [Test]
        public void TestFloatingValues()
        {
            var stringProperty = new DclComponent.DclComponentProperty<string>("default string");
            Assert.AreEqual("default string", stringProperty.Value);
            Assert.AreEqual("default string",stringProperty.FixedValue);
            Assert.False(stringProperty.IsFloating);

            stringProperty.SetFloatingValue("new Floating string");
            Assert.AreEqual("new Floating string", stringProperty.Value);
            Assert.AreEqual("default string", stringProperty.FixedValue);
            Assert.True(stringProperty.IsFloating);

            stringProperty.ResetFloating();
            Assert.AreEqual("default string", stringProperty.Value);
            Assert.AreEqual("default string", stringProperty.FixedValue);
            Assert.False(stringProperty.IsFloating);

            stringProperty.SetFloatingValue("another Floating string");
            Assert.AreEqual("another Floating string", stringProperty.Value);
            Assert.AreEqual("default string", stringProperty.FixedValue);
            Assert.True(stringProperty.IsFloating);

            stringProperty.SetFixedValue("new Fixed value");
            Assert.AreEqual("new Fixed value", stringProperty.Value);
            Assert.AreEqual("new Fixed value", stringProperty.FixedValue);
            Assert.False(stringProperty.IsFloating);
        }

        [Test]
        public void TestPropertyTypes()
        {
            DclComponent.DclComponentProperty stringProperty = new DclComponent.DclComponentProperty<string>("default string");
            Assert.AreEqual(DclComponent.DclComponentProperty.PropertyType.String, stringProperty.Type);

            DclComponent.DclComponentProperty intProperty = new DclComponent.DclComponentProperty<int>(0);
            Assert.AreEqual(DclComponent.DclComponentProperty.PropertyType.Int, intProperty.Type);

            DclComponent.DclComponentProperty floatProperty = new DclComponent.DclComponentProperty<float>(0.0f);
            Assert.AreEqual(DclComponent.DclComponentProperty.PropertyType.Float, floatProperty.Type);

            DclComponent.DclComponentProperty vector3Property = new DclComponent.DclComponentProperty<Vector3>(Vector3.zero);
            Assert.AreEqual(DclComponent.DclComponentProperty.PropertyType.Vector3, vector3Property.Type);
        }

        [Test]
        public void TestGetConcrete()
        {
            DclComponent.DclComponentProperty stringProperty = new DclComponent.DclComponentProperty<string>("default string");
            DclComponent.DclComponentProperty<string> concreteStringProperty = stringProperty.GetConcrete<string>();
            Assert.AreEqual(stringProperty, concreteStringProperty);
            Assert.AreEqual("default string", concreteStringProperty.Value);

            Assert.Throws<System.Exception>(() => stringProperty.GetConcrete<int>());
        }

    }
}