## Guide to Creating a Dedicated Server for *Don't Starve Together* Using DST Toolkit

### Requirements:
- Operating System: Windows
- Steam
    > **[1. Don't Starve Together](https://store.steampowered.com/app/322330/Dont_Starve_Together)**<br>
    > **[2. Don't Starve Together Dedicated Server](#1-open-steam---library---tools---download-dont-starve-together-dedicated-server)**<br>

### 1. Open Steam -> Library -> Tools -> Find and Download *Don't Starve Together Dedicated Server*.
> Install it on the same drive as *Don't Starve Together*.

![DST Dedicated Server](https://github.com/user-attachments/assets/4fcc0274-606c-49e4-9741-e84193deb3c7)

### 2. Create a World
Create a Host in the game -> Adjust Settings, add Caves (optional), enable mods, choose a mode, etc. -> Click 'Generate World' to create and enter the game -> On the character selection screen, exit.
> Note: Choose 'Save Type: Local Save'!

![Create new world](https://github.com/user-attachments/assets/aae84b51-f03f-48fe-9f60-edfc8591ef06)

### 3. Generate and Retrieve the Klei Server Token
On the main screen, click 'Account'.
![Click 'Account' from home screen](https://github.com/user-attachments/assets/9ab665da-ce8d-4370-9d43-c466b5c035a6)

In the navigation bar, select 'Games', then 'Game Servers'.
![Klei Account](https://github.com/user-attachments/assets/965c327e-01e9-41e2-a503-563fc8d63b3a)

Enter any name (Cluster Name), then click 'Add New Server'. 
![DST Cluster Name](https://github.com/user-attachments/assets/50d87d06-7b65-40cc-b0c3-ff312957e1b9)

Server details will appear -> Copy the 'Token'.
![DST Server Token](https://github.com/user-attachments/assets/d2a45018-28c5-4a38-9bfd-2028bb31ff86)

### 4. Create a Shortcut and Run the Dedicated Server Using DST Toolkit
**[Download the Tool](https://github.com/kamedev02/DST-Toolkit/releases/download/1.0.0/DST.Toolkit-1.0.0.zip)** and launch `DST Toolkit.exe`.<br>
> If the tool prompts for .NET Desktop Runtime, click 'Download it now' in the popup or **[download .NET 8.0 Desktop Runtime here](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-8.0.10-windows-x64-installer)**!
![Capture](https://github.com/user-attachments/assets/defadb8c-1551-4332-a4d8-414c9ec86ea4)

![DST Toolkit](https://github.com/user-attachments/assets/92ee6893-431c-4a67-9eba-7782d43c840b)
1. 'Select folder "steamapps"'
> Choose the installation folder for *Don't Starve Together* and *Don't Starve Together Dedicated Server*.<br>
_Example: C:\Program Files (x86)\Steam\steamapps_

2. 'Select folder "Cluster_..."'
> Choose the save game folder. If you don't remember where your save game is located, go to the host game section and follow the steps in the image below.
![Find Cluster_... folder](https://github.com/user-attachments/assets/e0fc3114-9fe8-40ca-b653-73e8999c4ceb)

3. Paste the Token generated in **[the previous step](#3-generate-and-retrieve-the-klei-server-token)** into "Klei server token".

4. Click 'Create server' after completing the above steps.
> If you change any settings in the Server Info section, click 'Create server' again to update the shortcut with the new server information.

5. Click 'Start server' after successfully creating the server to launch it.
> Keep an eye on the tool’s status bar for updates.

Good luck, and enjoy playing with friends! ^^
