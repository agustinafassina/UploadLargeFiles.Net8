# UploadLargeFiles.Net8
**This API is designed to support large file uploads.** It includes specific configurations to increase upload limits, enabling efficient transfer of large files without excessive restrictions. However, many solutions that involve simply removing limits in APIs are not secure and can jeopardize system security and stability. It is important to carefully evaluate these decisions and implement appropriate security measures. <br>
This API is built with .NET 8.0. It is crucial to keep in mind that, even if we increase the limits in the API, if it runs inside a Docker container, we will likely need to manage Docker's own limits to prevent restrictions on the uploads.

## Endpoints:
- Post: api/v1/File/upload

## Run scripts
Run script with dotnet:

```bash
  dotnet run
```

Result:

```bash
  http://localhost:5213/swagger/index.html
```
