### C# classes for xml version 3. Makes it easy to consume and produce XML files from DotNet Applications.

Available as a nuget package with name [`IOF.XML.V3`](https://www.nuget.org/packages/IOF.XML.V3/)

Sample class to be used with dependency injection bleow. The implementation below is to read and write files to disk but can be modified to work with `strings` and `memory streams`.


```c#
public interface IXmlSerializerService {
  T Deserialize<T>(string path)where T : class;
  void Serialize<T>(string path, T instance);
}
```

```c#
public class XmlSerializerService : IXmlSerializerService {
  public XmlSerializerService() {
    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
  }

  public void Serialize<T>(string path, T instance) {
    using(FileStream fileStream = new FileStream(path, FileMode.Create)) {
      new XmlSerializer(typeof(T)).Serialize(fileStream, instance);
    }
  }

  public T Deserialize<T>(string path)where T : class {
    if (!File.Exists(path)) {
      return null;
    }

    using(FileStream fileStream = new FileStream(path, FileMode.Open)) {
      return new XmlSerializer(typeof(T)).Deserialize(fileStream)as T;
    }
  }
}
```

Add `services.AddSingleton<IXmlSerializerService, XmlSerializerService>();` to `ConfigureServices` in the `Startup.cs` file, if you are using DotNetCore with dependency injection.

As an example, `ResultList` files should now be able to be loaded with:

```c#
var results = _XmlSerializerService.Deserialize<ResultList>(xmlFilePath);
```

To save a `ResultList`:

```c#
_XmlSerializerService.Serialize<ResultList>(xmlFilePath, results);
```

Please note that the default encoding for the xml files producted from SportSoftware OE and OS is `windows-1252`. You are required to reference `System.Text.Encoding.CodePages` and to call `Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)` before reading files for this to work.
