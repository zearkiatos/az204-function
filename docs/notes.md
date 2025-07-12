# Notes
1. Create an Azure function project

```sh
$ func init --worker-runtime dotnet-isolated --target-framework net8.0 --force
```

2. Create an Azure function project base on a template

```sh
$ func new --template "HTTP trigger" --name "az204-http-trigger-function"
```

3. Execute a function
```sh
$ func start --build
```

4. Try with cURL
```sh
$ curl -X POST -i http://localhost:7071/api/az204_http_trigger_function
```
