# IO.Swagger - ASP.NET Core 2.0 Server

For this sample, you can use the api key `special-key` to test the authorization filters.

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```
