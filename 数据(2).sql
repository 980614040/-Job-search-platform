--管理员信息插入
insert 
into Administrator 
values('17110546002','symphony')
insert 
into Administrator 
values('17110546035','123456')
insert 
into Administrator 
values('17110546037','654321')


--企业表信息插入
insert 
into Employer
values('32100000001','111111','CJN爱喝的奶茶店','浙江省温州市','1','奶茶又好喝还打折，员工有员工价哦！还能随便喝！','招做奶茶的员工，收银员','00000000000000001','0','317810586@qq.com','15658697706')
insert 
into Employer
values('32100000002','111111','CJN爱吃的面包店','浙江省温州市','1','好吃的面包','招又高又帅还温柔的面包师','02000000000066601','0','8947565346@qq.com','18945147624')
insert 
into Employer
values('32100000003','111111','YZH爱去的猫咖','浙江省台州市','1','内有15只温柔漂亮的猫咪','招前台，温柔大方','01300000006476602','0','128746891@qq.com','19787544424')
insert 
into Employer
values('32100000004','111111','YJS的咖啡店','浙江省温岭市','1','有好多漂亮小姐姐都是常客','招做咖啡的大师，但得帅','15300087006476226','0','651221887@qq.com','13615448521')
insert 
into Employer
values('32100000005','111111','春木镇幼儿园','浙江省瑞安市','1','balala','招老师，包吃住','05301367006678829','0','13512218570@163.com','13512218570')


--求职人员表信息插入
insert 
into Employees
values('67800000001','000000','毕桦','男','20','0','浙江省宁波市','1','才华横溢，英俊潇洒，唯一缺点是太过完美','0','321321321321321321','balabala@163.com','11011011011')
insert 
into Employees
values('67800000002','000000','许振忠','男','20','0','浙江省','1','曾今担任过电医电击治疗科科长，唯一缺点是真的胖','0','123123123123123123','bqwfasfla@163.com','15645321310')
insert 
into Employees
values('67800000003','000000','余ji峰','男','28','0','浙江省衢州市','1','迷人又可爱的正派角色，笑起来甜甜的还有小虎牙，但并没有得到YJS的认可','0','191919191919191919','635155632a@qq.com','16545687536')
insert 
into Employees
values('67800000004','000000','金祐镇','男','29','5','韩国','1','帅，帅，帅','0','626262626262626262','5646153@gmail.com','19543687521')
insert 
into Employees
values('67800000005','000000','安宰贤','男','31','6','韩国','1','帅，可爱，可爱，可爱','0','520520520520520520','520520520@gmail.com','15205205205')
insert 
into Employees
values('67800000006','000000','工藤新一','男','18','0','日本','0','极强的推理能力','1','337567523248794511','kenan@google.com','18946532132')
insert 
into Employees
values('67800000007','000000','易烊千玺','男','18','13','湖南省怀化市','1','大佬；蓄力征途，熠熠耀星辰，万里如胸怀','0','111111111111111111','dalao@qq.com','12012012012')
insert 
into Employees
values('67800000008','000000','朱一龙','男','30','9','湖北省武汉市','1','朱一龙英俊，朱一龙帅气，朱一龙美丽，朱一龙漂亮，朱一龙儒雅，朱一龙温柔，朱一龙品行端正...','0','122111111111111111','zhuyilong@qq.com','17777532132')
insert 
into Employees
values('67800000009','000000','罗云熙','男','30','6','四川省成都市','1','我所遇见的最浪漫的事诗，是你；我望山望水望穿的秋水，是你','0','257137523289794361','shili@google.com','18336532542')
insert 
into Employees
values('67800000010','000000','古天乐','男','48','30','中国香港','1','慈善古','0','121567523248765611','cishan@google.com','17946536632')


--简历表信息插入
insert 
into Resumes
values('10000000001','32100000001','67800000005','我不在乎工资，想体验生活','有过三年类似经验')
insert 
into Resumes
values('10000000002','32100000005','67800000001','喜欢小孩，也有过经验','有过三年类似经验')
insert 
into Resumes
values('10000000003','32100000003','67800000007','喜欢动物，爱和他们呆在一起','有过三年类似经验')
insert 
into Resumes
values('10000000004','32100000003','67800000008','爱喝咖啡，也很咖啡','有过三年类似经验')
insert 
into Resumes
values('10000000005','32100000005','67800000003','我喜欢小孩子，也很希望与他们相处，和他们一起成长。','有过三年类似经验')
insert 
into Resumes
values('10000000006','32100000003','67800000004','从小就喜欢猫，若是工作与它一起，那会是我一生中最幸福的事。我是大佬','有过三年类似经验')


--招聘信息表插入
insert 
into Recruitment
values('20000000001','32100000001',6700,'6700底薪+3%的提成，入职有一周的试用期','1')
insert 
into Recruitment
values('20000000002','32100000005',4500,'求职者要阳光开朗、亲切、有耐心，乐于与孩子交流','0')
insert 
into Recruitment
values('20000000003','32100000004',9000,'下午茶时间会比较忙，要有耐心，热爱生活，不会抽烟','1')
insert 
into Recruitment
values('20000000004','32100000002',12000,'热爱面包，从事面包行业5年及以上','1')


--余额表插入
update Balance
set balance=1500
where AccountID='32100000004'
update Balance
set balance=50
where AccountID='67800000007'
update Balance
set balance=3
where AccountID='67800000001'
update Balance
set balance=8000
where AccountID='32100000001'
update Balance
set balance=12000
where AccountID='32100000003'
update Balance
set balance=300
where AccountID='67800000004'


--求职黑名单插入
insert 
into EmployeeBlacklist 
values('67800000007','32100000004')
insert 
into EmployeeBlacklist 
values('67800000004','2100000005')


--单位黑名单插入
insert 
into EmployerBlacklist 
values('32100000005','67800000001')
insert 
into EmployerBlacklist 
values('32100000005','67800000003')
insert 
into EmployerBlacklist 
values('32100000004','67800000002')
insert 
into EmployerBlacklist 
values('32100000002','67800000008')
insert 
into EmployerBlacklist 
values('32100000001','67800000006')


--评分表插入
insert 
into Score
values('91250000001','1','32100000001',10)
insert 
into Score
values('91250000002','1','32100000001',9)
insert 
into Score
values('91250000003','1','32100000001',10)
insert 
into Score
values('91250000004','1','32100000001',10)
insert 
into Score
values('91250000005','1','32100000001',8)
insert 
into Score
values('91250000006','1','32100000002',7)
insert 
into Score
values('91250000007','1','32100000002',6)
insert 
into Score
values('91250000008','1','32100000002',2)
insert 
into Score
values('91250000009','1','32100000002',9)
insert 
into Score
values('91250000010','1','32100000002',6)
insert 
into Score
values('91250000011','1','32100000002',6)
insert 
into Score
values('91250000012','1','32100000003',10)
insert 
into Score
values('91250000013','1','32100000003',10)
insert 
into Score
values('91250000014','1','32100000003',9)
insert 
into Score
values('91250000015','1','32100000004',10)
insert 
into Score
values('91250000016','1','32100000004',10)
insert 
into Score
values('91250000017','1','32100000004',10)
insert 
into Score
values('91250000018','1','32100000005',10)
insert 
into Score
values('91250000019','0','67800000007',10)
insert 
into Score
values('91250000020','0','67800000007',10)
insert 
into Score
values('91250000021','0','67800000001',10)
insert 
into Score
values('91250000022','0','67800000004',10)
insert 
into Score
values('91250000023','0','67800000004',10)
insert 
into Score
values('91250000024','0','67800000005',9)
insert 
into Score
values('91250000025','0','67800000002',9)
insert 
into Score
values('91250000026','0','67800000003',7)
insert 
into Score
values('91250000027','0','67800000006',2)
insert 
into Score
values('91250000028','0','67800000006',1)
insert 
into Score
values('91250000029','0','67800000006',1)
insert 
into Score
values('91250000030','0','67800000006',0)
insert 
into Score
values('91250000031','0','67800000009',10)
insert 
into Score
values('91250000032','0','67800000008',10)
insert 
into Score
values('91250000033','0','67800000008',10)

--插入邀请表
insert 
into Invite
values('212501','32100000003','67800000010',13200,'下午1点上班，7点下班',1)
insert 
into Invite
values('212502','32100000003','67800000001',1500,'下午1点上班，4点下班',0)
insert 
into Invite
values('212503','32100000001','67800000004',9500,'早班9：00-12：30，晚班14：00-17：30',-1)
insert 
into Invite
values('212504','32100000002','67800000005',13000,'早班9：00-12：30，晚班14：00-17：30',2)
insert 
into Invite
values('212505','32100000004','67800000003',3600,'早班9：00-14：30，晚班15：00-20：30',0)
insert 
into Invite
values('212506','32100000005','67800000010',15000,'大佬就偶尔来一趟幼儿园就好',-1)
insert 
into Invite
values('212507','32100000005','67800000008',12000,'早上7点得叫孩子们起床，然后看着刷牙洗脸；饭点看着吃饭就好',0)