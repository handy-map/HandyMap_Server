#!/bin/sh
rm -r gen
openapi-generator generate -i spec/openapi.yaml -g aspnetcore -t spec/netcore-template/ -o gen/server -c spec/config-server-aspnetcore.json
openapi-generator generate -i spec/openapi.yaml -g csharp -o gen/client -c spec/config-client-csharp.json
redoc-cli bundle -o dist/documentation.html spec/openapi.yaml

# Cleanup the dodgy files we don't need.
rm gen/server/*
rm gen/server/src/Lodgix.WebApi.Server/Program.cs
rm gen/server/src/Lodgix.WebApi.Server/Startup.cs
rm gen/server/src/Lodgix.WebApi.Server/Dockerfile
rm gen/server/src/Lodgix.WebApi.Server/.gitignore
rm gen/server/src/Lodgix.WebApi.Server/appsettings.json