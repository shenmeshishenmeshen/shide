using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Wedding.Models;

namespace Wedding.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<WeddingEntity>
    {
        protected override void Seed(WeddingEntity context)
        {
            var User = new List<User>
            {

                new User { UserName = "11",UserPwd="11",Email="36273963@qq.com",RegTime=Convert.ToDateTime("2017-12-30"),Sex="男" }
            };
            User.ForEach(d => context.User.Add(d));
            context.SaveChanges();


            var members = new List<Member>
            {

                new Member { ManrName = "111",ManPwd="111",rEmail="36273963@qq.com",RegisterTime=Convert.ToDateTime("2017-12-30") }
        };
            members.ForEach(d => context.Member.Add(d));
            context.SaveChanges();

            var leiBies = new List<LeiBie>
            {
                new LeiBie { Name = "玫瑰",TypeId=1,Description="爱情、爱与美、容光焕发，勇敢" },
                new LeiBie { Name = "郁金香",TypeId=1,Description="爱、慈善、名誉、美丽、祝福、永恒、爱的表白和永恒的祝福"},
                new LeiBie { Name = "百合",TypeId=1,Description="百年好合、美好家庭、伟大的爱，深深祝福"},
                new LeiBie { Name = "康乃馨",TypeId=1,Description="爱，魅力，尊敬之情。" },
                new LeiBie { Name = "复合花束",TypeId=1,Description="这里包涵所有的祝福！" },
                new LeiBie { Name = "多肉",TypeId=2,Description="生命力顽强的小可爱？？" },
                new LeiBie { Name = "果树",TypeId=2,Description="净化空气的同时还可以期待即将成熟小果实" },
                new LeiBie { Name = "观赏性绿色植物",TypeId=2,Description="绿了绿了，全都绿起来了呢" },
                new LeiBie { Name = "鲜花",TypeId=2,Description="浓缩版的花树，小巧的灌木，都可以开花。" },
                new LeiBie { Name = "定制植物",TypeId=3,Description="自定义你最好的独一无二。" }
            };
            leiBies.ForEach(d => context.LeiBie.Add(d));

            context.SaveChanges();
            var shangpin = new List<Prouduct>
            {
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="轻轻的拂开一本，一阵花香袭来，那是一枝玫瑰，不是不是那个他……",Price=2.00m,TuPian="/Content/Flowers/1.jpg" },
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="完整的一枝花就要有叶，有枝，有花，还有刺。",Price=3.00m,TuPian="/Content/Flowers/2.jpg" },
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="Y",Title="在这134朵花里是我对你的承诺。",Price=499.00m,TuPian="/Content/Flowers/3.jpg" },
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="Y",Title="说真的鲜花也代表热烈了吧。" ,Price=5.00m,TuPian="/Content/Flowers/4.jpg"},
                new Prouduct{ LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="Y",Title="喏！送你的。什么啊？一束花。" ,Price=199.00m,TuPian="/Content/Flowers/5.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="白纱包裹的玫瑰，像被幸福包裹的你。" ,Price=8.00m,TuPian="/Content/Flowers/6.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="两朵了" ,Price=20.00m,TuPian="/Content/Flowers/7.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="Y",Title="这可是真的999朵红玫瑰，真的感觉震撼呢" ,Price=9999.00m,TuPian="/Content/Flowers/8.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="高贵优雅" ,Price=9999.00m,TuPian="/Content/Flowers/9.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="帮你包裹好，帮你送，帮你表白，帮你约会，帮你结婚，帮你生子。现在只需要你付钱。" ,Price=9999.00m,TuPian="/Content/Flowers/10.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="这支玫瑰比较高（我意思是价钱）" ,Price=9999.00m,TuPian="/Content/Flowers/11.jpg"},
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="Y",Title="之前我也买过，后来……" ,Price=399.00m,TuPian="/Content/Flowers/12.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="这一把玫瑰没有任何包装，就像是在田野里采摘直接送到他的手中。但是有史诗炫彩背景" ,Price=9999.00m,TuPian="/Content/Flowers/13.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="这是一个桃子型的花束" ,Price=599.00m,TuPian="/Content/Flowers/14.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="说真的，用报纸包的还挺好看" ,Price=599.00m,TuPian="/Content/Flowers/15.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="这是999朵玫瑰，周围是自然带粉色的蚕丝织成的绸缎" ,Price=9998.00m,TuPian="/Content/Flowers/16.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="这是月季，虽然这个不是月季，但是在这里面好像真的有月季" ,Price=1.00m,TuPian="/Content/Flowers/17.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="有光的地方就有黑暗，想要没有黑暗，那光也必须消失。哈哈哈" ,Price=199.00m,TuPian="/Content/Flowers/18.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="Y",Title="只是一种颜色怎么能代表性格，但是我就是这个性格。" ,Price=59.00m,TuPian="/Content/Flowers/19.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="这颜色让我想起了我以前的工作，脸上带着微笑，只是脸上而已。" ,Price=599.00m,TuPian="/Content/Flowers/20.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="这才是我想要的，我就应该身处其中，随心所欲。" ,Price=39.00m,TuPian="/Content/Flowers/21.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="那天下班，我带给我的妻子一直玫瑰。这照片简直和我妻子当时的动作一模一样。甚至连花的颜色。" ,Price=29.00m,TuPian="/Content/Flowers/22.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="妻子死后的日记中，依然放着这朵玫瑰。" ,Price=29.00m,TuPian="/Content/Flowers/23.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="我和两个穿着绅士服的男人在酒吧里聊天，巨大的金钱利益是我心动。我愉快得走出酒吧，看到酒吧门口桌子上的花盆……" ,Price=299.00m,TuPian="/Content/Flowers/24.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="他们只是去化工厂偷个东西，没关系的。回家的时候我又带了一束黑色玫瑰给妻子。" ,Price=699.00m,TuPian="/Content/Flowers/25.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="行动当天，他们让我带着红头套，并在我耳边说我妻子意外死亡了。这怎么可能，我出门的时候还好好的，为什么。" ,Price=499.00m,TuPian="/Content/Flowers/30.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="他们威胁我让我继续。" ,Price=199.00m,TuPian="/Content/Flowers/30.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="行动失败，蝙蝠侠前来阻挠，而我跌入了化工池。" ,Price=29.00m,TuPian="/Content/Flowers/26.jpg"},



                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "新郎服装"),Title="因为你是特别的",Price=13223.00m,TuPian="/Content/Xizhuang/1.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "新郎服装"),Title="因为你是特别的",Price=46546.00m,TuPian="/Content/Xizhuang/2.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "新郎服装"),Title="因为你是特别的",Price=4283.00m,TuPian="/Content/Xizhuang/3.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "新郎服装"),Title="因为你是特别的",Price=6936581.00m,TuPian="/Content/Xizhuang/4.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "新郎服装"),Title="因为你是特别的",Price=32626151.00m,TuPian="/Content/Xizhuang/5.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "新郎服装"),Title="因为你是特别的",Price=56262.00m,TuPian="/Content/Xizhuang/6.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "新郎服装"),Title="因为你是特别的",Price=6264626.00m,TuPian="/Content/Xizhuang/7.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "新郎服装"),Title="因为你是特别的",Price=96255.00m,TuPian="/Content/Xizhuang/8.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "新郎服装"),Title="因为你是特别的",Price=36399.00m,TuPian="/Content/Xizhuang/9.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "新郎服装"),Title="因为你是特别的",Price=36399.00m,TuPian="/Content/Xizhuang/10.jpg" },



                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "场地"),Title="婚礼举办在碧绿的草坪上。正中间是一个碧绿的窗帘，窗帘前面悬挂着华丽的灯，窗帘下面的地上摆放着很多的绿色盆栽，整体装饰风格偏欧式，清新而自然。",Price=262525.00m,TuPian="/Content/Site/1.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "场地"),Title="罗马仪式亭装饰方法：罗马仪式亭的风格主要是铁艺设计，顶部是使用铁艺镂空的设计，弄成圆形，我们都知道卢浮宫就类似这种设计，罗马亭主要是搭配鲜花，用铁艺来做好空架子，然后用鲜花装饰，就像公主的花门非常的漂亮。",Price=858285.00m,TuPian="/Content/Site/2.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "场地"),Title="室内婚礼仪式亭装饰方法：国内婚礼百分之八十都是在酒店大厅举行，这种舞台仪式亭就比较好装饰，一般选择新人的照片做一个大的背板，然后在进行花朵装饰，在舞台中间装饰一个走廊，是新娘进场的地方，整体也是选择用白色的花朵来搭配。",Price=59396.00m,TuPian="/Content/Site/3.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "场地"),Title="有特色的民族风格仪式亭装饰方法;海外风格的婚礼是大家都期待的，但是由于资金问题不能直接到海外，大家可以参考海外装饰风格来弥补，现在的很多装饰婚礼都可以做到这一天，使用3D的海外装饰方法，可以让婚礼变成海外风格仪式亭。",Price=59922.00m,TuPian="/Content/Site/4.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "场地"),Title="森林铁艺婚礼仪式亭装饰方法：这种仪式亭一般都是用在户外的草坪婚礼，大家可以选择有复古风格的藤条搭配铁艺技术，搭配弄好有欧式风格的外形，然后子啊使用一些木质材料进行装饰，搭配上一些小的照片，这样的仪式亭很有贵族气息教堂布置",Price=232135.00m,TuPian="/Content/Site/29.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "场地"),Title="在去教堂举办婚礼之前，对于礼堂的布置肯定是不能省略的。在这里你可不能随心所欲地布置得花花绿绿哦，既然是要举办西式神圣的婚礼，那一定是以纯洁的白色为主。",Price=122536.00m,TuPian="/Content/Site/6.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "场地"),Title="在选择婚礼用花时，挑选一些素雅高贵颜色的花为主，比如白色的百合、香槟色的玫瑰，配上简单的绿叶做点缀辅材。中式婚礼的主色调常常是喜庆的红色，但是在这里就不需要各种鞭炮、气球啦，尊重西方的习俗",Price=1262525.00m,TuPian="/Content/Site/7.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "场地"),Title="教堂婚礼对于新人的穿着有一定的要求，正如现场布置一样，选择红色秀禾服肯定是不妥，无论是在基督教堂还是天主教堂，都必须穿白色婚纱，必须!这时候配上教堂式头纱可谓是再适合不过了。",Price=48825.00m,TuPian="/Content/Site/8.jpg" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "场地"),Title="有特色的民族风格仪式亭装饰方法;海外风格的婚礼是大家都期待的，但是由于资金问题不能直接到海外，大家可以参考海外装饰风格来弥补，现在的很多装饰婚礼都可以做到这一天，使用3D的海外装饰方法，可以让婚礼变成海外风格仪式亭。",Price=59922.00m,TuPian="/Content/Site/9.jpg" },


                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "婚车"),Title="野马汽车在20世纪80年代末改革开放的大潮中诞生，是全国最早生产汽车的厂家之一。2006年8月更名为四川汽车工业集团有限公司，2011年12月经股份重组后正式更名为四川野马汽车股份有限公司。",Price=969332.00m,TuPian="/Content/HunCheImages/1.png" },
                  new Prouduct { LeiBie = leiBies.Single(g => g.Name == "婚车"),Title="在经典的黄色底漆上，科迈罗大黄蜂概念车于发动机罩上涂上了经典的黑色赛车条纹，使人很容易的辨认出其大黄蜂的真实身份。更狭窄的水箱格栅以及更圆滑的线条，也使科迈罗大黄蜂概念车拥有了与前3部截然不同的外型。",Price=825252.00m,TuPian="/Content/HunCheImages/2.png" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "婚车"),Title="保时捷911是由德国斯图加特市的保时捷公司所生产的跑车。由费迪南德·亚历山大·保时捷（Ferdinand Alexander Porsche）所设计的作品。从1963年诞生以来，共经历了七代车型，因其独特的风格与极佳的耐用性享誉世界",Price=262626.00m,TuPian="/Content/HunCheImages/3.png" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "婚车"),Title="Bugatti Veyron中国市场登记命名为布加迪威航，即布加迪威龙，世界顶级超跑车的典范，最普通款型的中国市场价也要2500万元，高性能版本的售价则更是在3500万以上。其品牌源自意大利，由法国车厂负责生产",Price=5959363.00m,TuPian="/Content/HunCheImages/4.png" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "婚车"),Title="保时捷911是由德国斯图加特市的保时捷公司所生产的跑车。由费迪南德·亚历山大·保时捷（Ferdinand Alexander Porsche）所设计的作品。从1963年诞生以来，共经历了七代车型，因其独特的风格与极佳的耐用性享誉世界",Price=156562.00m,TuPian="/Content/HunCheImages/5.png" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "婚车"),Title="保时捷911是由德国斯图加特市的保时捷公司所生产的跑车。由费迪南德·亚历山大·保时捷（Ferdinand Alexander Porsche）所设计的作品。从1963年诞生以来，共经历了七代车型，因其独特的风格与极佳的耐用性享誉世界",Price=15253.00m,TuPian="/Content/HunCheImages/6.png" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "婚车"),Title="保时捷911是由德国斯图加特市的保时捷公司所生产的跑车。由费迪南德·亚历山大·保时捷（Ferdinand Alexander Porsche）所设计的作品。从1963年诞生以来，共经历了七代车型，因其独特的风格与极佳的耐用性享誉世界",Price=65655.00m,TuPian="/Content/HunCheImages/7.png" },
                 new Prouduct { LeiBie = leiBies.Single(g => g.Name == "婚车"),Title="保时捷911是由德国斯图加特市的保时捷公司所生产的跑车。由费迪南德·亚历山大·保时捷（Ferdinand Alexander Porsche）所设计的作品。从1963年诞生以来，共经历了七代车型，因其独特的风格与极佳的耐用性享誉世界",Price=365226.00m,TuPian="/Content/HunCheImages/8.png" },
            };
            shangpin.ForEach(d => context.ShangPin.Add(d));

            context.SaveChanges();
        }
    }
}