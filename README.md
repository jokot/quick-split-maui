# Quick Split

A .NET MAUI mobile application for splitting bills and expenses among friends and family. Built with modern UI design and intuitive user experience.

## 🚀 Features

- **Bill Management**: Create and manage split bills with detailed item tracking
- **Member Management**: Add and select members for bill splitting
- **Expense Tracking**: Track individual items, quantities, and prices
- **Shared Fees**: Handle service charges, delivery fees, and discounts
- **Modern UI**: Clean, intuitive interface with green color scheme
- **Cross-Platform**: Works on Android, iOS, and Windows

## 📱 Screenshots

### Bills Page
- View all your split bills
- See total amounts and member counts
- Quick access to add new bills

### Add Bill Page
- Create new split bills
- Add members to the bill
- Track individual items and expenses
- Handle shared fees and discounts

### Add Members Page
- Add new members to your bills
- Select from existing members
- Mark yourself in the group

## 🛠️ Technology Stack

- **.NET MAUI** - Cross-platform mobile framework
- **C#** - Programming language
- **XAML** - UI markup language
- **Visual Studio 2022** - Development environment

## 📋 Prerequisites

- Visual Studio 2022 (17.3 or later)
- .NET 9.0 SDK
- Android SDK (for Android development)
- Xcode (for iOS development, macOS only)
- Windows App SDK (for Windows development)

## 🚀 Getting Started

### 1. Clone the Repository
```bash
git clone https://github.com/jokot/quick-split-maui.git
cd quick-split-maui
```

### 2. Open in Visual Studio
- Open `quick-split.sln` in Visual Studio 2022
- Restore NuGet packages if prompted

### 3. Build and Run
- Select your target platform (Android, iOS, Windows)
- Press F5 or click "Start Debugging"

## 📁 Project Structure

```
quick-split/
├── Views/                    # UI Pages
│   ├── BillsPage.xaml       # Main bills list
│   ├── AddBillPage.xaml     # Create new bill
│   └── AddMembersPage.xaml  # Add/select members
├── Resources/               # App resources
│   ├── Styles/             # Color schemes and styles
│   ├── Images/             # App icons and images
│   └── Fonts/              # Custom fonts
├── Platforms/              # Platform-specific code
│   ├── Android/           # Android configuration
│   ├── iOS/              # iOS configuration
│   └── Windows/          # Windows configuration
└── App.xaml              # Application entry point
```

## 🎨 Design System

### Color Scheme
- **Primary Green**: `#16A34A` - Main brand color
- **Background**: `#F9FAFB` - Light gray background
- **Text**: `#111827` - Dark text for readability
- **Secondary**: `#6B7280` - Gray text for secondary information

### Typography
- **Font Family**: System fonts (San Francisco, Segoe UI, Roboto)
- **Font Weights**: Regular, Medium, Bold
- **Font Sizes**: 12px, 14px, 16px, 18px

## 🔧 Development

### Adding New Pages
1. Create new XAML file in `Views/` folder
2. Create corresponding code-behind file
3. Register page in `AppShell.xaml` if needed

### Styling
- Use the predefined color scheme in `Resources/Styles/Colors.xaml`
- Follow the existing UI patterns for consistency
- Use `CornerRadius` for rounded corners
- Apply shadows with `HasShadow="True"`

## 📦 Building for Production

### Android
```bash
dotnet build -f:quick-split.csproj -c:Release
dotnet publish -f:quick-split.csproj -c:Release -p:TargetFramework=net9.0-android
```

### iOS
```bash
dotnet build -f:quick-split.csproj -c:Release
dotnet publish -f:quick-split.csproj -c:Release -p:TargetFramework=net9.0-ios
```

### Windows
```bash
dotnet build -f:quick-split.csproj -c:Release
dotnet publish -f:quick-split.csproj -c:Release -p:TargetFramework=net9.0-windows10.0.19041.0
```

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.


---

Made with ❤️ using .NET MAUI 