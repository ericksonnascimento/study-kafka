# Kafka Study

Kafka study repo!

  - Producer (webapi) `done`
  - Producer (console) `in progress`
  - Consumer (webapi) `in progress`
  - Consumer (console) `in progress`
  
### Installation

In order to run this application, you must install [.NET 5][net5]

Restore packages and add required user-secrets

```sh
$ cd .\src\StudyKafka.Api\
$ dotnet user-secrets set "KafkaConfiguration:BootstrapServers" "<brokers urls>"
$ dotnet user-secrets set "KafkaConfiguration:Username" "<cluster username>"
$ dotnet user-secrets set "KafkaConfiguration:Password" "<cluster password>"
```

Finally run the application and open [this url][url]

```sh
$ dotnet run
```

License
----

MIT

   [net5]: <https://dotnet.microsoft.com/download/dotnet/5.0>
   [url]: <http://localhost:5000/swagger/index.html>