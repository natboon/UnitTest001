UnitTest

643450647-2 ณัฐธิดา บุญพา

__ข้อ1) เมธอดคำนวณเกรด

สร้าง gradeCalculate โดยรับ score เป็น int ถ้ามากกว่าหรือเท่ากัย 80 ให้ส่งกลับมาเป็น string

ใช้ if ในฟังก์ชั่น ถ้า score มากกว่าหรือเท่ากับ 80 ส่งค่ากลับมาเป็น A

ถ้า score มากกว่าหรือเท่ากับ 75 และ น้อยกว่าหรือเท่ากับ 79 ส่งค่ากลับมาเป็น B+

ถ้า score มากกว่าหรือเท่ากับ 70 น้อยกว่าหรือเท่ากับ 74 ส่งค่ากลับมาเป็น B

ถ้า score มากกว่าหรือเท่ากับ 65 น้อยกว่าหรือเท่ากับ 69 ส่งค่ากลับมาเป็น C+

ถ้า score มากกว่าหรือเท่ากับ 60 น้อยกว่าหรือเท่ากับ 64 ส่งค่ากลับมาเป็น C

ถ้า score มากกว่าหรือเท่ากับ 55 น้อยกว่าหรือเท่ากับ 59 ส่งค่ากลับมาเป็น D+

ถ้า score มากกว่าหรือเท่ากับ 50 น้อยกว่าหรือเท่ากับ 54 ส่งค่ากลับมาเป็น D

น้อยกว่า 50 ส่งค่ากลับมาเป็น F

สร้างเมธอด เชื่อมกับ Assignment

กำหนด input ในหน่วย int เท่ากับหรือมากกว่า 100

สร้างตัวแปร result ในหน่วย string และ result รับค่าจาก gradeCalculate รับค่า input

เช็ค result ได้ค่าออกมาเป็น A หรือไม่

ส่ง input เป็นค่าน้อยกว่า 0 และเช็คว่าได้ result เป็น F หรือไม่

ส่ง input เป็น 80 และเช็คว่าได้ result เป็น A หรือไม่

ส่ง input เป็น 79 และเช็คว่าได้ result เป็น B+ หรือไม่

ส่ง input เป็น 49 และเช็คว่าได้ result เป็น F หรือไม่

__________________________________________________________________________________________
__ข้อ2) เมธอทสำหรับคำนวนระยะทางระหว่างจุดสองจุดบนกราฟ แต่ละจุดแทนด้วยตำแหน่ง x,y

สร้าง getDistance รับค่า x1, y1, x2, y2 เป็นค่า int ส่งค่ากลับมาเป็น double

กำหนดตัวแปร x = x2 - x1 ส่งค่ากลับมาเป็น double

กำหนดตัวแปร y = y2 - y1 ส่งค่ากลับมาเป็น double

กำหนดตัวแปร sum ใช้คำสั่ง Math.Pow(x, 2) คือ x กำลัง 2 + Math.Pow(y, 2) คือ y กำลัง 2

สร้างตัวแปร result เพื่อรับค่า Math.Sqrt(sum) คือ เอาค่า sum มาถอดรูท และส่งค่ากลับมาเป็น double

ส่งค่า return กลับ ใช้ Mayh.Round(result, 2) เพื่อทำให้ทศนิยมเหลือ 2 ตำแหน่ง

สร้างเมธอด เชื่อมกับ Assignment

กำหนดตัวแปร result ส่งค่ากลับมาเป็น double โดยรับค่ามาจาก getDistance

กำหนด x1 = 3, y1 = 2, x2 = 7, y2 = 8 result = 7.21 หรือไม่

กำหนด x1 = -3, y1 = 2, x2 = 7, y2 = -8 result = 14.14 หรือไม่

กำหนด x1 = -3, y1 = -2, x2 = -7, y2 = -8 result = 7.21 หรือไม่

กำหนด x1 = 3, y1 = -2, x2 = -7, y2 = 8 result = 14.14 หรือไม่

__________________________________________________________________________________________
__ข้อ3) เมธอทคำนวน Factorial

สร้าง getFactorrial รับค่า n หน่วย int ส่งค่ากลับมาเป็น int

ใช้ int ในฟังก์ชัน โดนถ้า n น้อยกว่า 2 ให้ส่งค่ากลับมาเป็น 1

นอกจากคำสั่งนี้ ให้ส่งค่ากลับมาเป็น n * getFactorial(n - 1)

สร้างเมธอด เชื่อมกับ Assignment

กำหนด n หน่วย รับค่าจาก getFactorial ให้ n = 5

เช็ค n เท่ากับ 120 หรือไม่

กำหนด n เท่ากับ 1 เช็ค n เท่ากับ 1 หรือไม่

กำหนด n เท่ากับ 0 เช็ค n เท่ากับ 1 หรือไม่

กำหนด n เท่ากับ -1 เช็ค n เท่ากับ 1 หรือไม่
__________________________________________________________________________________________
__ข้อ4)เมธอทตรวจสอบรหัสผ่านแต่ละตัวมีความปลอดภัยหรือไม่ โดยพิจารณาจากความยาวของรหัสผ่าน ต้องมากกว่า 8 ตัวอักษร และต้องมีตัวเลขอยู่ในรหัสผ่าน

สร้าง checkPassword รับค่า password และ password2 ในหน่วย string ส่งค่ากลับมาเป็น string

ใช้ if ในฟังก์ชั่น password.Length มากกว่าเท่ากับ 3 และ password2.Length มากกว่าเท่ากับ 5 

ให้ส่งค่ากลับมาเป็น true นอกจากคำสั่งนี้ ให้ส่งค่ากลับมาเป็น false

สร้างเมธอด เชื่อมกับ Assignment

กำหนด Password ในหน่วย string รับค่าเป็น abc

กำหนด Password2 ในหน่วย int รับค่าเป็น 123

เปลี่ยน int เป็น string ใช้ string เก็บ Password22 โดยใช้ Convert.ToString(Password2) แปลงเป็น string

เช็ค password ส่งค่ากลับมาเป็น false หรือไม่

กำหนด Password ในหน่วย string รับค่าเป็น abc

กำหนด Password2 ในหน่วย int รับค่าเป็น 12345
    
เช็ค password ส่งค่ากลับมาเป็น true หรือไม่

กำหนด Password ในหน่วย string รับค่าเป็น abcdefgh

กำหนด Password2 ในหน่วย int รับค่าเป็น ไม่มีข้อมูลที่รับเข้ามา

เช็ค password ส่งค่ากลับมาเป็น false หรือไม่

กำหนด Password ในหน่วย string โดยรับค่าเป็น ไม่มีข้อมูลที่รับเข้ามา

กำหนด Password2 ในหน่วย int โดยรับค่าเป็น 12345678

เช็ค password ส่งค่ากลับมาเป็น false หรือไม่

