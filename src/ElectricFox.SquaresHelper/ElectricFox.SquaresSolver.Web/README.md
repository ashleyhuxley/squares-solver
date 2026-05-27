# Squares Solver - Blazor Web Application

A Blazor web front end for the Squares Solver puzzle game.

## Getting Started

### Prerequisites

- .NET 8.0 SDK
- A dictionary file (sowpods.txt) containing valid words

### Dictionary File Setup

The application requires a dictionary file to validate words. You have two options:

#### Option 1: Place the file in wwwroot (Recommended)
1. Copy your `sowpods.txt` file to `ElectricFox.SquaresSolver.Web/wwwroot/`
2. The application will automatically find it there

#### Option 2: Configure a custom path
1. Open `appsettings.json`
2. Set the `DictionaryPath` to your file location:
   ```json
   {
	 "DictionaryPath": "C:\\Path\\To\\Your\\sowpods.txt"
   }
   ```

### Running the Application

1. Navigate to the project directory:
   ```bash
   cd ElectricFox.SquaresSolver.Web
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

3. Open your browser and navigate to the URL shown in the terminal (typically `https://localhost:5001` or `http://localhost:5000`)

### Using the Solver

1. Enter one letter in each of the 16 grid cells (4x4 grid)
2. Click "Find Words" to search for valid words
3. The application will display all valid words found, sorted by length (longest first) then alphabetically
4. Valid words must:
   - Be 4-16 characters long
   - Be in the dictionary file
   - Form a path through adjacent cells (horizontally, vertically, or diagonally)
   - Not reuse the same cell within a single word

## Features

- Interactive 4x4 letter grid input
- Real-time word validation using the Solver engine
- Results sorted by word length and alphabetically
- Responsive web design
- Error handling with user-friendly messages

## Project Structure

- `Components/Pages/Index.razor` - Main solver page
- `Components/Layout/MainLayout.razor` - Application layout
- `Program.cs` - Application configuration
- `wwwroot/` - Static files (CSS, dictionary file)

## Technical Details

- Built with Blazor Server (.NET 8)
- Uses the ElectricFox.SquaresSolver library for word validation
- Interactive server-side rendering for real-time updates
