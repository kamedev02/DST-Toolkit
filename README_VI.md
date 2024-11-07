## Hướng dẫn tạo Dedicated Server cho Don't starve together bằng DST Toolkit
Yêu cầu:
- Hệ điều hành: Windows
- Steam
    > **[1. Don't Starve Together](https://store.steampowered.com/app/322330/Dont_Starve_Together)** <br>
    > **[2. Don't Starve Together Dedicated Server](#1-tại-library---tools-tải-về-dont-starve-together-dedicated-server)** <br>

### 1. Mở Steam -> Library -> Tools -> Tìm và tải về Don't Starve Together Dedicated Server.
> Lưu cùng ổ đĩa với game Don't Starve Together!

![DST Dedicated Server](https://github.com/user-attachments/assets/4fcc0274-606c-49e4-9741-e84193deb3c7)
### 2. Tạo thế giới
Tạo một Host trong game -> Thay đổi Settings, thêm Caves (nếu muốn), bật mods, chọn chế độ... Sau đó bấm 'Generate World' để tạo và vào game -> Tại bước chọn nhân vật -> Thoát ra.
> Lưu ý: Chọn 'Save Type: Local Save'!

![Create new world](https://github.com/user-attachments/assets/aae84b51-f03f-48fe-9f60-edfc8591ef06)
### 3. Tạo và lấy Klei Server Token
Tại màn hình chính bấm 'Account'.
![Click 'Account' from home screen](https://github.com/user-attachments/assets/9ab665da-ce8d-4370-9d43-c466b5c035a6)

Tại thanh điều hướng bấm 'Games' sau đó bấm 'Game Servers'.
![Klei Account](https://github.com/user-attachments/assets/965c327e-01e9-41e2-a503-563fc8d63b3a)

Nhập tên bất kì (Cluster Name), sau đó bấm 'Add New Server'. 
![DST Cluster Name](https://github.com/user-attachments/assets/50d87d06-7b65-40cc-b0c3-ff312957e1b9)
Thông tin Server hiện ra -> Copy 'Token'.
![DST Server Token](https://github.com/user-attachments/assets/d2a45018-28c5-4a38-9bfd-2028bb31ff86)

### 4. Tạo shortcut và chạy Dedicated Server bằng DST Toolkit
**[Tải Tool](https://github.com/kamedev02/DST-Toolkit/releases/download/1.0.0/DST.Toolkit-1.0.0.zip)** và chạy `DST Toolkit.exe`.<br>
> Nếu chạy tool mà gặp thông báo yêu cầu .NET Desktop Runtime thì bấm 'Download it now' bên trong cửa sổ thông báo hoặc **[tải về .NET 8.0 Desktop Runtime tại đây](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-8.0.10-windows-x64-installer)**!
![Capture](https://github.com/user-attachments/assets/defadb8c-1551-4332-a4d8-414c9ec86ea4)

![DST Toolkit](https://github.com/user-attachments/assets/92ee6893-431c-4a67-9eba-7782d43c840b)
[1] 'Select folder "steamapps"'
> Chọn thư mục cài đặt Don't Starve Together và Don't Starve Together Dedicated Server<br>
_Ví dụ: C:\Program Files (x86)\Steam\steamapps_

[2] 'Select folder "Cluster_..."'
> Chọn thư mục save game. Nếu không nhớ save game của mình được lưu ở đâu thì vào phần host game và làm theo các bước trong hình bên dưới.
![Find Cluster_... folder](https://github.com/user-attachments/assets/e0fc3114-9fe8-40ca-b653-73e8999c4ceb)

[3] Dán Token đã tạo ở **[bước trước](#3-tạo-và-lấy-klei-server-token)** vào "Klei server token".

[4] Bấm 'Create server' sau khi thực hiện xong 3 bước trên.
> Nếu thay đổi thông tin tại group Server info thì hãy bấm 'Create server' để tạo lại shortcut theo thông tin mới cho server.

[5] Bấm 'Start server' sau khi thực hiện 'Create server' thành công để khởi chạy server.
> Hãy theo dõi trạng thái khi sử dụng tool tại thanh báo trạng thái (Status bar).

Chúc bạn thành công và có thời gian chơi game vui vẻ cùng bạn bè! ^^