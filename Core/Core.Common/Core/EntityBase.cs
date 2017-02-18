using System.Runtime.Serialization;

namespace Core.Common.Core
{
    public abstract class EntityBase : IExtensibleDataObject
    {
        public ExtensionDataObject ExtensionData { get; set; }
    }
}
