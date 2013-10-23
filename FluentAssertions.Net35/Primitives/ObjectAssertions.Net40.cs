using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

using FluentAssertions.Execution;

namespace FluentAssertions.Primitives
{
    public static class ObjectAssertionsExtensions
    {
        /// <summary>
        /// Asserts that an object can be serialized and deserialized using the binary serializer and that it stills retains
        /// the values of all properties.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public static AndConstraint<ObjectAssertions> BeBinarySerializable(this ObjectAssertions  assertions, 
            string reason = "", params object[] reasonArgs)
        {
            try
            {
                object deserializedObject = CreateCloneUsingBinarySerializer(assertions.Subject);

                deserializedObject.ShouldHave().AllRuntimeProperties().EqualTo(assertions.Subject);
            }
            catch (Exception exc)
            {
                Execute.Assertion
                    .BecauseOf(reason, reasonArgs)
                    .FailWith("Expected {0} to be serializable{reason}, but serialization failed with:\r\n\r\n{1}", assertions.Subject,
                        exc.Message);
            }

            return new AndConstraint<ObjectAssertions>(assertions);
        }

        private static object CreateCloneUsingBinarySerializer(object subject)
        {
            var stream = new MemoryStream();
            var binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, subject);

            stream.Position = 0;
            return binaryFormatter.Deserialize(stream);
        }

        /// <summary>
        /// Asserts that an object can be serialized and deserialized using the XML serializer and that it stills retains
        /// the values of all properties.
        /// </summary>
        /// <param name="reason">
        /// A formatted phrase as is supported by <see cref="string.Format(string,object[])" /> explaining why the assertion 
        /// is needed. If the phrase does not start with the word <i>because</i>, it is prepended automatically.
        /// </param>
        /// <param name="reasonArgs">
        /// Zero or more objects to format using the placeholders in <see cref="reason" />.
        /// </param>
        public static AndConstraint<ObjectAssertions> BeXmlSerializable(this ObjectAssertions assertions, string reason = "", params object[] reasonArgs)
        {
            try
            {
                object deserializedObject = CreateCloneUsingXmlSerializer(assertions.Subject);

                deserializedObject.ShouldHave().AllRuntimeProperties().EqualTo(assertions.Subject);
            }
            catch (Exception exc)
            {
                Execute.Assertion
                    .BecauseOf(reason, reasonArgs)
                    .FailWith("Expected {0} to be serializable{reason}, but serialization failed with:\r\n\r\n{1}", assertions.Subject,
                        exc.Message);
            }

            return new AndConstraint<ObjectAssertions>(assertions);
        }

        private static object CreateCloneUsingXmlSerializer(object subject)
        {
            var stream = new MemoryStream();
            var binaryFormatter = new XmlSerializer(subject.GetType());
            binaryFormatter.Serialize(stream, subject);

            stream.Position = 0;
            return binaryFormatter.Deserialize(stream);
        }
    }
}