# Abstractions

The purpose of this class library is to provide a shared project that contains all of the abstractions for both the [Grains](../Grains/README.md) and [Silo](../Silo/README.md) projects. Expected types in the project are as follows:

- Grain interfaces: Any interface that implements one of the following Orleans grain interfaces.

  - `IGrainWithGuidCompoundKey`
  - `IGrainWithGuidKey`
  - `IGrainWithIntegerCompoundKey`
  - `IGrainWithIntegerKey`
  - `IGrainWithStringKey`

- Models: Any custom model type that is shared between the [Grains](../Grains/README.md) and [Silo](../Silo/README.md) projects, typically objects in the grain interface APIs.
