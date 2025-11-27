Quilt Designer

Quilt Designer is an interactive web application that allows hobbyist quilters to visualize quilt layouts before sewing. 
Built for my mom, the app lets her upload fabrics, generate quilt grids, and experiment with different patterns
without waiting for manual sketches. It combines functionality and usability with a clean, responsive interface, 
making it both a personal project and a portfolio-worthy example of Blazor WebAssembly development.

Features
- Fabric Manager
- Upload, preview, and manage multiple fabrics.
- See thumbnails of fabrics instantly.

Quilt Builder
- Generate customizable quilt grids (blocks wide × blocks tall).
- Click to assign fabrics to each block.
- Visualize quilts in real-time.


Getting Started
Prerequisites
- Visual Studio 2022 with ASP.NET and web development workload.
- .NET 7 SDK or newer.

Installation & Running
-Clone the repository:

git clone https://github.com/YOUR_USERNAME/QuiltDesigner.git
cd QuiltDesigner

- Open QuiltDesigner.sln in Visual Studio 2022.
- Build the solution (Ctrl+Shift+B).
- Run the client project (QuiltDesigner.Client) with IIS Express or F5.

Usage:
- Go to Fabric Manager and upload your fabric images.
- Navigate to Quilt Builder.
- Set quilt dimensions and click Generate Layout.
- Select a fabric and click on the quilt grid to fill blocks.
- Experiment with different fabric combinations to visualize quilts instantly.

Project Structure
QuiltDesigner/
├─ QuiltDesigner.Client/   # Blazor WebAssembly front-end
├─ QuiltDesigner.Core/     # Application services (FabricService, PatternService)
├─ QuiltDesigner.Shared/   # Shared models (Fabric, Pattern, Block)

Future Enhancements:
- Support for custom quilt patterns (triangles, strips, etc.).
- Undo/redo functionality.
- Save/load quilt layouts.
- Export quilt designs as images.
- Eraser tool & Clear All feature.

  Fabriuc Manager
  <img width="613" height="463" alt="Screenshot 2025-11-27 235838" src="https://github.com/user-attachments/assets/0deb4c87-eaec-40f7-a5c3-e18cd04b67cd" />

  Quilt Builder
  <img width="612" height="659" alt="Screenshot 2025-11-27 235940" src="https://github.com/user-attachments/assets/2b696281-a2f1-4e96-b297-d93a29e09585" />

