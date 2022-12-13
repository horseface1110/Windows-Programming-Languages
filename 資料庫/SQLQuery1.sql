insert into 員工編號_姓名_電子信箱 (員工編號, 姓名,電子信箱)
values('F71234567' , 'Lewis' , 'lewis@csie.ncku.edu.tw');
insert into 員工編號_姓名_電子信箱 (員工編號,姓名,電子信箱)
values('F87654321' , 'Eddie' , 'eddie@csie.ncku.edu.tw');
insert into 員工編號_姓名_電子信箱 (員工編號,姓名,電子信箱)
values('F74102226' , N'吳仲倫' , 'oloomb6@gmail.com');



insert into 電話_員工編號 (電話,員工編號)
values('0912345678' , 'F71234567');
insert into 電話_員工編號 (電話,員工編號)
values('0987654321' , 'F87654321');
insert into 電話_員工編號 (電話,員工編號)
values('0900000000' , 'F74102226');


insert into 員工編號_薪水 (員工編號 , 薪水)
values('F71234567' , '100');
insert into 員工編號_薪水 (員工編號 , 薪水)
values('F87654321' , '65535');
insert into 員工編號_薪水 (員工編號 , 薪水)
values('F74102226' , '99999');


select * from 員工編號_姓名_電子信箱
select * from 電話_員工編號
select * from 員工編號_薪水 

