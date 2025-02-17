# VS Code Torizon Templates

This repository maintains the templates used in conjunction with the [VS Code Torizon Integrated Development Environment Extension](https://developer.toradex.com/torizon/application-development/ide-extension/). Focusing in the VS Code for automation between the development environment for remote debug, remote deploy of containerized applications for Toradex TorizonCore easy-to-use Industrial Linux Software Platform.

## Toradex Supported Templates

> ℹ️ **Toradex Supported Templates** are templates with development stacks commonly used by customers of the Torizon platform and are maintained by the Torizon team at Toradex.

> ⚠️ Support for **x86-64** and **riscv64** architectures are experimental.

| TEMPLATE                                    | DESCRIPTION                      | RUNTIME     | LANGUAGE  | HW ARCH                                                                                                                                                                                      | FOLDER                             |
| ------------------------------------------- | -------------------------------- | ----------- | --------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------- |
| ![](assets/img/cppconsole.png?raw=true)     | C++ Makefile Console Application | libc        | C++       | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2) ![](assets/img/riscv64.png?raw=true&id=2) ![](assets/img/x8664.png?raw=true&id=2)                            | [cppConsole](./cppConsole)         |
| ![](assets/img/cmakeconsole.png?raw=true)   | C++ CMake Console Application    | libc        | C++       | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)                                                                                                              | [cmakeConsole](./cmakeConsole)     |
| ![](assets/img/qt6qml.png?raw=true)         | C++ Qt 6 QML Application         | Qt 6        | C++ / QML | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)  ![](assets/img/x8664.png?raw=true&id=2)                                                                     | [cppQML](./cppQML)                 |
| ![](assets/img/dotnetconsole.png?raw=true)  | .NET 6 C# Console Application    | .NET 6.0    | C#        | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)  ![](assets/img/x8664.png?raw=true&id=2)                                                                     | [dotnetConsole](./dotnetConsole)   |
| ![](assets/img/unogtk.png?raw=true)         | .NET 6 C# Uno Platform Skia.GTK  | .NET 6.0    | C#        | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)  ![](assets/img/x8664.png?raw=true&id=2)                                                                     | [dotnetUno](./dotnetUno)           |
| ![](assets/img/aspnetblazor.png?raw=true)   | ASP.NET 6 Blazor Application     | ASP.NET 6.0 | C#        | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)  ![](assets/img/x8664.png?raw=true&id=2)                                                                     | [aspnetBlazor](./aspnetBlazor)     |
| ![](assets/img/python3console.png?raw=true) | Python 3 Console Application     | Python 3    | Python 3  | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)                                                                                                              | [python3Console](./python3Console) |



# Partner Templates

Partner templates are contributions that come from [Toradex partner network](https://www.toradex.com/support/partner-network) associates:

| TEMPLATE                                | DESCRIPTION            | RUNTIME   | LANGUAGE | HW ARCH                                                                         | FOLDER                   |
| --------------------------------------- | ---------------------- | --------- | -------- | ------------------------------------------------------------------------------- | ------------------------ |
| ![](assets/img/slint-cpp.png?raw=true)  | C++ Slint Application  | Slint 1.0 | C++      | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2) | [cppSlint](./cppSlint)   |
| ![](assets/img/slint-rust.png?raw=true) | Rust Slint Application | Slint 1.0 | Rust     | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2) | [rustSlint](./rustSlint) |



# Contributing

We encourage you to also contribute templates. The community supported templates can also be used in the [VS Code Torizon Integrated Development Environment Extension](https://developer.toradex.com/torizon/application-development/ide-extension/):

- [Code of Conduct](./CODE_OF_CONDUCT.md)

- [How to Contribute](./CONTRIBUTING.md)

## Community Supported Templates

> ⚠️ **Community Supported Templates** are templates with emerging development stacks or unstable technology stacks and are maintained by the Torizon community.

| TEMPLATE                                         | DESCRIPTION                             | RUNTIME  | LANGUAGE     | HW ARCH                                                                                                                                                            | FOLDER                                                   | CONTRIBUTOR                                                                                                  |
| -------------------------------------------------| --------------------------------------- | -------- | ------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------ |:-------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------ |
| ![](assets/img/rust-console.png?raw=true)        | Rust Console Application                | libc     | Rust         | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)                                                                                    | [rustConsole](./rustConsole)                             | ![](https://avatars.githubusercontent.com/u/19845403?v=4)[@skkywalker](https://www.github.com/skkywalker)    |
| ![](assets/img/jframe.png?raw=true)              | Java Swing JFrame Application           | JRE      | Java         | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)                                                                                    | [javaForms](./javaForms)                                 | ![](https://avatars.githubusercontent.com/u/2633321?v=4) [@microhobby](https://www.github.com/microhobby)    |
| ![](assets/img/nodejsts.png?raw=true)            | Node.js TypeScript Application          | Node.js  | TypeScript   | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)                                                                                    | [nodeJSTypeScript](./nodeJSTypeScript)                   | ![](https://avatars.githubusercontent.com/u/2633321?v=4) [@microhobby](https://www.github.com/microhobby)    |
| ![](assets/img/electronjs.png?raw=true)          | Node.js JavaScript Electron Application | Electron | JavaScript   | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)                                                                                    | [nodeElectron](./nodeElectron)                           | ![](https://avatars.githubusercontent.com/u/2633321?v=4) [@microhobby](https://www.github.com/microhobby)    |
| ![](assets/img/monowinforms.png?raw=true)        | Mono 4.7 C# Windows Forms Application   | .NET 4.7 | C#           | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)                                                                                    | [monoCsharpForms](./monoCsharpForms)                     | ![](https://avatars.githubusercontent.com/u/2633321?v=4) [@microhobby](https://www.github.com/microhobby)    |
| ![](assets/img/unofbdrm.png?raw=true)            | .NET 6 C# Uno Platform Frame Buffer     | .NET 6.0 | C#           | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)                                                                                    | [dotnetUnoFrameBuffer](./dotnetUnoFrameBuffer)           | ![](https://avatars.githubusercontent.com/u/2633321?v=4) [@microhobby](https://www.github.com/microhobby)    |
| ![](assets/img/avaloniafbdrm.png?raw=true)       | .NET 6 C# Avalonia Frame Buffer DRM     | .NET 6.0 | C#           | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)                                                                                    | [dotnetAvaloniaFrameBuffer](./dotnetAvaloniaFrameBuffer) | ![](https://avatars.githubusercontent.com/u/2633321?v=4) [@microhobby](https://www.github.com/microhobby)    |
| ![](assets/img/avaloniagtk.png?raw=true)         | .NET 6 C# Avalonia GTK MVVM             | .NET 6.0 | C#           | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)                                                                                    | [dotnetAvalonia](./dotnetAvalonia)                       | ![](https://avatars.githubusercontent.com/u/2633321?v=4) [@microhobby](https://www.github.com/microhobby)    |
| ![](assets/img/gambasform.png?raw=true)          | Gambas3 Form Project                    | Gambas3  | Visual Basic | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)                                                                                    | [gambasForms](./gambasForms)                             | ![](https://avatars.githubusercontent.com/u/2633321?v=4) [@microhobby](https://www.github.com/microhobby)    |
| ![](assets/img/python3console.png?raw=true)      | Python 3 Pyside 2(Qt5) QML              | Pyside 2 | Python 3     | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)                                                                                    | [python3Pyside2QML](./python3Pyside2QML)                 | ![](https://avatars.githubusercontent.com/u/83607022?v=4) [@andreriesco](https://www.github.com/andreriesco) |
| ![](assets/img/cconsole.png?raw=true)            | C Makefile Console Application          | libc     | C            | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2) ![](assets/img/riscv64.png?raw=true&id=2) ![](assets/img/x8664.png?raw=true&id=2)  | [cConsole](./cConsole)                                   | ![](https://avatars.githubusercontent.com/u/19562097?v=4) [@hiagofranco](https://www.github.com/hiagofranco) |
| ![](assets/img/zig-console.png?raw=true)         | Zig Console Application                 | no-libc  | Zig          | ![](assets/img/arm32.png?raw=true&id=2) ![](assets/img/arm64.png?raw=true&id=2)                                                                                    | [zigConsole](./zigConsole)                               | ![](https://avatars.githubusercontent.com/u/6756180?v=4) [@kassane](https://www.github.com/kassane)          |
