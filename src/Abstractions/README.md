# Abstractions

The purpose of this class library is to provide a shared project that contains all of the abstractions for both the **Grains** and **Silo** projects. Expected types in the project are as follows:

- Grain interfaces: Any interface that implements `IGrainWithGuidCompoundKey`, `IGrainWithGuidKey`, `IGrainWithIntegerCompoundKey`, `IGrainWithIntegerKey`, or `IGrainWithStringKey`. 
- Models: Any type that is shared between the **Grains** project and the **Silo** project, typically objects in the grain interface APIs.