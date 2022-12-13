update 員工編號_姓名_電子信箱
set 電子信箱 = 'hello@csie.ncku.edu.tw'
where 員工編號 = 'F71234567' ;

update 電話_員工編號
set 電話 = '0977777777' 
where 員工編號 = 'F71234567' ;

update 員工編號_薪水
set 薪水= '100000' 
where 員工編號 = 'F87654321';  

SELECT 員工編號,電子信箱 FROM 員工編號_姓名_電子信箱
SELECT 電話,員工編號 FROM 電話_員工編號
SELECT 員工編號,薪水 FROM 員工編號_薪水
