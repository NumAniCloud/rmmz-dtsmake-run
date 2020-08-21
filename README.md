# rmmz-dtsmake-run
Run `dtsmake` for RPG Tkool MZ core scripts, to generate TypeScript type definition.

## Usage

### 0. requirement

You have to install .NET Core 5.0 preview.

You have to make `dtsmake` installed via npm (node.js).

This software only support windows(x64).

### 1. build

First open terminal and change current directory to this project directory.

Then run this:

```
dotnet publish -r win-x64 /p:PublishSingleFile=true --configuration Release
```

After build, you get these files in `./bin/Release/net5.0/win-x64/publish/`:

```
dtsmake-run.exe
clrcompression.dll
clrjit.dll
coreclr.dll
mscordaccore.dll
```

### 2. place

You have to create new project with RPG Tkool MZ.

Then place files built in previous capter to `<tkool project folder>/js/`.

Your directory contents should looks like:

```
js 
└ libs/
└ plugins/
└ main.js
└ plugins.js
└ rmmz_core.js
└ rmmz_managers.js
└ rmmz_objects.js
└ rmmz_scenes.js
└ rmmz_sprites.js
└ rmmz_windows.js
└ dtsmake-run.exe
└ clrcompression.dll
└ clrjit.dll
└ coreclr.dll
└ mscordaccore.dll
```

### 3. run

Finally run `dtsmake-run.exe` to generate type definition files.

resluting `d.ts` files are:

```
js
└ main.d.ts
└ rmmz_core.d.ts
└ rmmz_managers.d.ts
└ rmmz_objects.d.ts
└ rmmz_scenes.d.ts
└ rmmz_sprites.d.ts
└ rmmz_windows.d.ts
```

Generated type definitions is incomplete to use. Please edit for your plugin development.