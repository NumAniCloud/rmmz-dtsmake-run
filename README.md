# rmmz-dtsmake-run
Run `dtsmake` for RPG Maker MZ core scripts, to generate TypeScript type definition.

## Usage

Following instruction shows how to build, place, and run.

You can also use a binary from [Release](https://github.com/NumAniCloud/rmmz-dtsmake-run/releases/tag/1.0) and skip step 0 and 1.

### 0. requirement

You have to install RPG Maker MZ.

You have to install .NET Core 3.1.

You have to make `dtsmake` package installed via npm (node.js).

This software only support windows(x64).

You have to install `tern` package via npm.

### 1. build

First open terminal and change current directory to this project directory.

Then run this:

```
dotnet publish -r win-x64 /p:PublishSingleFile=true --configuration Release
```

After build, you get a binary `./bin/Release/net5.0/win-x64/publish/dtsmake-run.exe`.

### 2. place

You have to create new project with RPG Maker MZ.

Then place binary built in previous capter to `<tkool project folder>/js/`.

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
