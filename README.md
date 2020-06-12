# Chat-app-winform
- Tên: Trần Chí Thiện + Chiêm Tấn Hưng
- MSSV: 18520365 + 18520789
- Trường: Đại học Công Nghệ Thông Tin - Đại học Quốc gia Thành phố Hồ Chí Minh
- Môn học: Lập trình mạng căn bản

## Mô tả app
- Là 1 app đơn giản có chức năng chat 1v1, chat nhóm, gửi file, gửi hình ảnh, ...
- Chi tiết chức năng:
  + Đăng ký
  + Đăng nhập
  + Tạo room chat
  + Tham gia vào room chat
  + Gửi file
  + Gửi sticker
  
## USE CASE
(pending ...)

## Thiết kế giao diện
(pending ...)

## Thiết kế database
- Sử dụng công cụ quản lý cơ sở dữ liệu Navicat.
- Khởi tạo database -> Tạo model với 2 table cơ bản:

![2 table cơ bản](https://www.upsieutoc.com/images/2020/06/08/Untitled.jpg)

- Dựa trên 2 table cơ bản và chức năng của app sau đó ta có công việc xử lý như sau:
  + Thêm user vào mổi khi có tài khoản mới
  + Mỗi user được tạo sẽ có 1 tbl_<user>_list_rooms tương ứng được khởi tạo
  + Mỗi room được tạo sẽ có 1 tbl_<room>_list_users tương ứng được khởi tạo
  
## Thiết kế Class Diagram cho server và user
(pending ...)

## Tạo server
- Kết nối với database
- Lấy request từ clients -> Xử lý -> query database -> respone dữ liệu cho clients

## Tạo client
- Từ giao diện đã có, ta thêm các chức năng cơ bản (button, textbox, richtext,...)
- Gửi request đến server -> nhận respone -> Xử lý thông tin thô và đưa lên giao diện chính
