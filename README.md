# 🌤️ Weather App (.NET)

Simple weather application with search history tracking.

## ✨ Features

- 🌡️ Get current weather
- 📝 Save search history

## 📋 Prerequisites

- ⚡ .NET 7.0
- 🖥️ Visual Studio 2022 or VS Code

## 🚀 Getting Started

1. Clone and run:
   ```sh
   git clone <your-repository-url>
   cd weather-app
   dotnet run
   ```

2. Open in browser:
   ```
   https://localhost:5001
   ```

## 📝 API Routes

### GET /api/weather/history
- Get all previous weather searches
- Returns list of search history

### POST /api/weather/history
- Save new weather search
- Body: `{ "city": "cityName" }`



## 📁 Project Structure

- 📂 `/Controllers` - API Controllers
- 📂 `/Models` - Data Models
- 📂 `/Services` - Business Logic
- 📂 `/Data` - Database Context
- 📂 `/wwwroot` - Static Files

## 🛠️ Technologies Used

- ⚡ .NET 7.0
- 🎯 C#
- 🗄️ Entity Framework Core
- 🌐 ASP.NET Core
- 🎨 Bootstrap

## 🤝 Contributing

1. Fork the repository
2. Create your feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request



