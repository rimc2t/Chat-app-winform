# Chat-app-winform-c-
- Tên: Trần Chí Thiện + Chiêm Tấn Hưng
- MSSV: 18520365 + 18520789
- Trường: Đại học Công Nghệ Thông Tin - Đại học Quốc gia Thành phố Hồ Chí Minh
- Môn học: Lập trình mạng căn bản

## Mô tả app
- Là 1 app đơn giản có chức năng chat 1v1, chat nhóm, gửi file, gửi hình ảnh, ...
- Chi tiết chức năng:
  + Đăng ký
  + Đăng nhập
  + Tìm tên người dùng (dựa vào username)
  + Gửi tin nhắn cho user khác (Là tạo 1 room chat với room_type là 1v1)
  + Đồng ý tin nhắn gửi đến (Là 1 hình thức thêm vào danh sách bạn)
  + Tạo room chat (room_type là group)
  + Thêm bạn bè vào room
  + Gửi file
  + Gửi sticker
  
## Thiết kế USE CASE
(pending ...)

## Thiết kế giao diện
(pending ...)

## Thiết kế database
- Sử dụng công cụ quản lý cơ sở dữ liệu Navicat.
- Khởi tạo database -> Tạo model với 2 table cơ bản:
![2 table cơ bản](https://i.imgur.com/MaU7j4L.png)
- Dựa trên 2 table cơ bản và chức năng của app sau đó ta có công việc xử lý như sau:
  + Thêm user vào mổi khi có tài khoản mới
  + Mỗi user được tạo sẽ có 1 table profile, list friends,... tương ứng được khởi tạo
  + ĐỒng ý tin nhắn gửi đến là thêm user đấy vào list friends của cả 2
  + Gửi tin nhắn cho 1 người là khởi tạo 1 room_chat đồng thời sẽ tạo các table lưu trữ tin nhắn, thành viên trong room,...
  
## Thiết kế Class Diagram cho server và user
(pending ...)

## Tạo server
- Kết nối với database
- Lấy request từ clients -> Xử lý -> query database -> respone dữ liệu cho clients
- ...

## Tạo client
- Từ giao diện đã có, ta thêm các chức năng cơ bản (button, textbox, richtext,...)
- Gửi request đến server -> nhận respone -> Xử lý thông tin thô và đưa lên giao diện chính
- ...
