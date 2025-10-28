# 🎭 Mood Tracker App

A colorful, user-friendly web application for tracking daily moods and notes. Built with **ASP.NET Core MVC**, **Entity Framework Core**, and **SQLite** for a seamless journaling experience.

---

## ✨ Features

- ✅ **Full CRUD Operations**: Create, Read, Update, and Delete mood entries
- 😊 **Emoji Mood Selection**: Choose from Happy, Sad, Stressed, Excited, Angry, and Tired
- 📝 **Daily Notes**: Write short notes (up to 400 characters) for each entry
- 🎨 **Animated UI**: Beautiful pastel gradient background with smooth animations
- 📱 **Responsive Design**: Works perfectly on mobile, tablet, and desktop
- 🔒 **Privacy-First**: All data stays local—no personal information collected
- 📄 **Built-in Privacy Policy**: Transparent about data handling
- 🌈 **Kid-Friendly Interface**: Colorful, intuitive, and easy to use

---

## 🚀 Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download) or later
- [Git](https://git-scm.com/downloads) (for cloning the repository)
- A code editor like [Visual Studio Code](https://code.visualstudio.com/)

### Installation Steps

1. **Clone the repository:**
   ```bash
   git clone https://github.com/Sneha-beth/MoodTrackerApp.git
   cd MoodTrackerApp
   ```

2. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

3. **Run database migrations:**
   ```bash
   dotnet ef database update
   ```
   This creates the SQLite database file (`moodtracker.db`) in your project folder.

4. **Run the application:**
   ```bash
   dotnet run
   ```

5. **Open in your browser:**
   Navigate to the URL shown in the terminal (usually `http://localhost:5042` or `https://localhost:7042`)

---

## 📦 Project Structure

```
MoodTrackerApp/
├── Controllers/
│   ├── HomeController.cs          # Home and Privacy pages
│   └── MoodEntriesController.cs   # CRUD operations for mood entries
├── Models/
│   ├── MoodEntry.cs               # Mood entry data model
│   └── ErrorViewModel.cs          # Error handling model
├── Data/
│   └── ApplicationDbContext.cs    # Entity Framework database context
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml           # Welcome/landing page
│   │   └── Privacy.cshtml         # Privacy policy page
│   ├── MoodEntries/
│   │   ├── Index.cshtml           # List all mood entries
│   │   ├── Create.cshtml          # Add new mood entry
│   │   ├── Edit.cshtml            # Edit existing entry
│   │   ├── Details.cshtml         # View entry details
│   │   └── Delete.cshtml          # Delete confirmation
│   └── Shared/
│       └── _Layout.cshtml         # Main layout template
├── wwwroot/
│   ├── css/
│   │   └── site.css               # Custom styles and animations
│   ├── js/
│   │   └── site.js                # JavaScript functionality
│   └── lib/                       # Bootstrap and jQuery libraries
├── Migrations/                     # Entity Framework migrations
├── appsettings.json               # App configuration
├── Program.cs                     # Application entry point
└── README.md                      # This file
```

---

## 🎓 Academic Project Information

**Created by:** Sneha Padhiyar Mahendrakumar  
**Enrollment Number:** 202303103510376  
**Division:** C  
**Subject:** Web Technologies With .NET  
**Institution:** Asha M. Tarsadia Institute of Computer Science and Technology

---

## 🛠️ Technologies & Tools

- **Framework:** ASP.NET Core 9.0 MVC
- **ORM:** Entity Framework Core
- **Database:** SQLite
- **View Engine:** Razor Pages
- **Frontend:** HTML5, CSS3, Bootstrap 5
- **Animations:** CSS Keyframes
- **Version Control:** Git & GitHub
- **IDE:** Visual Studio Code

---

## 📸 Screenshots

### Home Page
<img width="2875" height="1704" alt="Screenshot 2025-10-28 214418" src="https://github.com/user-attachments/assets/8eff140a-946b-4cac-8514-aeb9e45ff9c7" />

### Mood Entries List
<img width="2868" height="1704" alt="image" src="https://github.com/user-attachments/assets/9ffc7ede-d7bf-4751-9c14-c985576056c1" />

### Add Mood Entry
<img width="2874" height="1708" alt="image" src="https://github.com/user-attachments/assets/a1b61498-ba40-4b5d-8a4c-23e1dc8f1721" />

### Details of a entry
<img width="2880" height="1710" alt="image" src="https://github.com/user-attachments/assets/c5c222f0-f732-48b8-8987-38ac91f66112" />

---

## 🎨 Features Breakdown

### 1. Home Page
- Welcoming hero section with "Get Started" button
- Student information display box
- Animated gradient background

### 2. Mood Entries (Index)
- Displays all mood entries in beautiful cards
- Shows date, emoji, and first two lines of notes
- Quick action buttons: Edit, Details, Delete
- "Add New Entry" button prominently displayed

### 3. Create/Edit Pages
- Date picker (defaults to today)
- Dropdown menu with emoji mood options
- Multi-line text area for notes (up to 400 characters)
- Styled form with pastel colors

### 4. Details Page
- Clean display of entry information
- Edit and Back to List buttons

### 5. Delete Page
- Confirmation prompt before deletion
- Returns to list after successful deletion

### 6. Privacy Policy
- Comprehensive privacy information
- Explains data collection and usage
- Kid-friendly and transparent

---

## 🔧 Configuration

### Database Connection String
Located in `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=moodtracker.db"
}
```

### Switching to SQL Server (Optional)
To use SQL Server instead of SQLite:

1. Install the SQL Server package:
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   ```

2. Update `Program.cs`:
   ```csharp
   builder.Services.AddDbContext<ApplicationDbContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
   ```

3. Update connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=MoodTrackerDb;Trusted_Connection=True;"
   }
   ```

4. Run migrations again:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

---

## 📝 Usage Guide

1. **Landing Page**: Click "Get Started" to begin tracking moods
2. **Add Entry**: Click "Add New Entry" button, select mood, add note, and save
3. **View Entries**: All entries display on the main list with date and mood
4. **Edit Entry**: Click "Edit" to modify an existing entry
5. **View Details**: Click "Details" to see the full note
6. **Delete Entry**: Click "Delete" and confirm to remove an entry

---

## 🔐 Privacy & Data Security

- ✅ All data stored locally in SQLite database
- ✅ No personal information (name, email, location) collected
- ✅ No external APIs or third-party tracking
- ✅ Data never shared, sold, or used for advertising
- ✅ Users can delete their data anytime
- ✅ HTTPS supported for secure connections

---

## 🐛 Troubleshooting

### "Database not found" error
Run: `dotnet ef database update`

### Port already in use
Change the port in `Properties/launchSettings.json` or use:
```bash
dotnet run --urls="http://localhost:5050"
```

### Migration errors
Delete the `Migrations` folder and database file, then recreate:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## 🚀 Deployment

### Publishing for Production

1. **Build Release:**
   ```bash
   dotnet publish -c Release -o ./publish
   ```

2. **The published files** will be in the `publish/` folder

3. **Deploy to:**
   - IIS (Windows Server)
   - Azure App Service
   - Linux with Nginx/Apache
   - Docker container

### Sample Azure Deployment
```bash
az webapp up --name mood-tracker-app --resource-group MyResourceGroup
```

---

## 🎯 Future Enhancements

- [ ] Add weekly mood summary chart with Chart.js
- [ ] Export mood data to CSV
- [ ] User authentication and accounts
- [ ] Mood statistics and trends
- [ ] Dark mode toggle
- [ ] Search and filter entries by date/mood
- [ ] Reminder notifications

---

## 📜 License

This project is created for educational purposes as part of a Web Technologies with .NET course.  
**For academic and non-commercial use only.**

---

## 🤝 Contributing

This is a student project, but suggestions and improvements are welcome!

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/YourFeature`)
3. Commit your changes (`git commit -m 'Add some feature'`)
4. Push to the branch (`git push origin feature/YourFeature`)
5. Open a Pull Request

---

## 📞 Contact

**Developer:** Sneha Padhiyar Mahendrakumar  
**Email:** [23amtics376@gmail.com](mailto:23amtics376@gmail.com)  
**GitHub:** [@Sneha-beth](https://github.com/Sneha-beth)

---

## 🙏 Acknowledgments

- ASP.NET Core documentation and tutorials
- Entity Framework Core guides
- Bootstrap for responsive design
- Microsoft Learn resources

---

⭐ **If you find this project helpful, please give it a star on GitHub!**

---

**Made with 💙 by Sneha Padhiyar for Web Technologies with .NET**
