# AWS-File-Uploader-.NET-AWS-S3-
A simple ASP.NET Core MVC application that allows users to upload and view files stored in an AWS S3 bucket.
## ✨ Features
- Upload files to an Amazon S3 bucket
- View the list of uploaded files
- Clean and responsive UI using Razor Pages
- Error handling and async AWS SDK usage

## 🚀 Tech Stack
- ASP.NET Core MVC
- AWS SDK for .NET (AWSSDK.S3)
- Razor Pages
- C#
- Amazon S3

## 🔧 Setup Instructions

### 1. Clone the repository
```bash
git clone https://github.com/sanskruthi9/AWSFileUploader.git
cd AWSFileUploader
```

### 2. Set AWS credentials
Use environment variables or the AWS credentials file:
```bash
export AWS_ACCESS_KEY_ID=your_access_key
export AWS_SECRET_ACCESS_KEY=your_secret_key
```

### 3. Update `appsettings.json`
```json
{
  "AWS": {
    "BucketName": "your-s3-bucket",
    "Region": "us-east-1"
  }
}
```

### 4. Run the app
```bash
dotnet run
```

Navigate to `https://localhost:5001/File/Index` to use the app.

## 📂 Project Structure
- `Controllers/` — Contains MVC controller for file upload
- `Services/` — Logic to interact with AWS S3
- `Views/` — Razor views for UI
- `appsettings.json` — Config for AWS bucket
