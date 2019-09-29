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

                new User { UserName = "11",UserPwd="11",Email="36273963@qq.com",RegTime=Convert.ToDateTime("2019-12-30"),Sex="男" }
            };
            User.ForEach(d => context.User.Add(d));
            context.SaveChanges();


            var members = new List<Member>
            {

                new Member { ManrName = "111",ManPwd="111",rEmail="36273963@qq.com",RegisterTime=Convert.ToDateTime("2019-12-30") }
        };
            members.ForEach(d => context.Member.Add(d));
            context.SaveChanges();

            var leiBies = new List<LeiBie>
            {
                new LeiBie {LeiBieId=1, Name = "玫瑰",TypeId=1,Description="爱情、爱与美、容光焕发，勇敢" },
                new LeiBie {LeiBieId=2, Name = "郁金香",TypeId=1,Description="爱、慈善、名誉、美丽、祝福、永恒、爱的表白和永恒的祝福"},
                new LeiBie {LeiBieId=2, Name = "百合",TypeId=1,Description="百年好合、美好家庭、伟大的爱，深深祝福"},
                new LeiBie {LeiBieId=2, Name = "复合花束",TypeId=1,Description="这里包涵所有的祝福！" },
                new LeiBie {LeiBieId=2, Name = "多肉",TypeId=2,Description="生命力顽强的小可爱？？" },
                new LeiBie {LeiBieId=2, Name = "果树",TypeId=2,Description="净化空气的同时还可以期待即将成熟小果实" },
                new LeiBie { LeiBieId=2,Name = "观赏性绿色植物",TypeId=2,Description="绿了绿了，全都绿起来了呢" },
                new LeiBie {LeiBieId=2, Name = "定制植物",TypeId=3,Description="自定义你最好的独一无二。" }
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
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="Y",Title="说真的，用报纸包的还挺好看" ,Price=599.00m,TuPian="/Content/Flowers/15.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="这是999朵玫瑰，周围是自然带粉色的蚕丝织成的绸缎" ,Price=9998.00m,TuPian="/Content/Flowers/16.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="红玫瑰（卡罗拉）",IsNew="N",Title="这是月季，虽然这个不是月季，但是在这里面好像真的有月季" ,Price=1.00m,TuPian="/Content/Flowers/17.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="有光的地方就有黑暗，想要没有黑暗，那光也必须消失。哈哈哈" ,Price=199.00m,TuPian="/Content/Flowers/18.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="Y",Title="只是一种颜色怎么能代表性格，但是我就是这个性格。" ,Price=59.00m,TuPian="/Content/Flowers/19.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="这颜色让我想起了我以前的工作，脸上带着微笑，只是脸上而已。" ,Price=599.00m,TuPian="/Content/Flowers/20.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="这才是我想要的，我就应该身处其中，随心所欲。" ,Price=39.00m,TuPian="/Content/Flowers/21.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="那天下班，我带给我的妻子一直玫瑰。这照片简直和我妻子当时的动作一模一样。甚至连花的颜色。" ,Price=29.00m,TuPian="/Content/Flowers/22.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="妻子死后的日记中，依然放着这朵玫瑰。" ,Price=29.00m,TuPian="/Content/Flowers/23.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="Y",Title="我和两个穿着绅士服的男人在酒吧里聊天，巨大的金钱利益是我心动。我愉快得走出酒吧，看到酒吧门口桌子上的花盆……" ,Price=299.00m,TuPian="/Content/Flowers/24.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="他们只是去化工厂偷个东西，没关系的。回家的时候我又带了一束黑色玫瑰给妻子。" ,Price=699.00m,TuPian="/Content/Flowers/25.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="行动当天，他们让我带着红头套，并在我耳边说我妻子意外死亡了。这怎么可能，我出门的时候还好好的，为什么。" ,Price=499.00m,TuPian="/Content/Flowers/30.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="Y",Title="他们威胁我让我继续。" ,Price=199.00m,TuPian="/Content/Flowers/29.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="黑魔术（黑丝绒）",IsNew="N",Title="行动失败，蝙蝠侠前来阻挠，而我跌入了化工池。" ,Price=19999.00m,TuPian="/Content/Flowers/26.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="香槟玫瑰（蜜桃雪山）",IsNew="Y",Title="这一支的颜色不算真正的香槟色。" ,Price=29.00m,TuPian="/Content/Flowers/31.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="香槟玫瑰（蜜桃雪山）",IsNew="N",Title="你要送花就应该送这样的玫瑰花，这样的才是纯洁。" ,Price=559.00m,TuPian="/Content/Flowers/32.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="香槟玫瑰（蜜桃雪山）",IsNew="N",Title="又是报纸包的，不过很有文艺加欧美气息。朝阳下咖啡馆，香槟玫瑰。" ,Price=299.00m,TuPian="/Content/Flowers/33.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="香槟玫瑰（蜜桃雪山）",IsNew="Y",Title="怎一美字了得。" ,Price=299.00m,TuPian="/Content/Flowers/34.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="香槟玫瑰（蜜桃雪山）",IsNew="Y",Title="一捧土，一捧花，只爱中国千万家。" ,Price=488.00m,TuPian="/Content/Flowers/35.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="香槟玫瑰（蜜桃雪山）",IsNew="N",Title="含苞待放，含苞待放，含苞待放！" ,Price=289.00m,TuPian="/Content/Flowers/36.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="香槟玫瑰（蜜桃雪山）",IsNew="N",Title="填数据也有点累啊，费手。" ,Price=289.00m,TuPian="/Content/Flowers/37.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="香槟玫瑰（蜜桃雪山）",IsNew="N",Title="说真的，这个是不是有点撞色。" ,Price=289.00m,TuPian="/Content/Flowers/38.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="香槟玫瑰（蜜桃雪山）",IsNew="N",Title="这是大报纸，圆的报纸。" ,Price=589.00m,TuPian="/Content/Flowers/39.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "玫瑰"),Varieties="香槟玫瑰（蜜桃雪山）",IsNew="N",Title="你看就这么多，你觉得能便宜吗。" ,Price=1889.00m,TuPian="/Content/Flowers/40.jpg"},



                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="N",Title="想编自己编。" ,Price=359.00m,TuPian="/Content/yujin/1.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="N",Title="想编自己编。" ,Price=369.00m,TuPian="/Content/yujin/2.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="Y",Title="想编自己编。" ,Price=456.00m,TuPian="/Content/yujin/3.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="N",Title="想编自己编。" ,Price=75.00m,TuPian="/Content/yujin/4.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="N",Title="想编自己编。" ,Price=854.00m,TuPian="/Content/yujin/5.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="Y",Title="想编自己编。" ,Price=666.00m,TuPian="/Content/yujin/6.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="N",Title="想编自己编。" ,Price=999.00m,TuPian="/Content/yujin/7.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="N",Title="想编自己编。" ,Price=854.00m,TuPian="/Content/yujin/8.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="Y",Title="想编自己编。" ,Price=476.00m,TuPian="/Content/yujin/9.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="Y",Title="想编自己编。" ,Price=5774.00m,TuPian="/Content/yujin/10.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="Y",Title="想编自己编。" ,Price=754.00m,TuPian="/Content/yujin/11.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="N",Title="想编自己编。" ,Price=544.00m,TuPian="/Content/yujin/12.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="Y",Title="想编自己编。" ,Price=352.00m,TuPian="/Content/yujin/13.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="N",Title="想编自己编。" ,Price=233.00m,TuPian="/Content/yujin/14.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "郁金香"),Varieties="郁金香",IsNew="N",Title="想编自己编。" ,Price=233.00m,TuPian="/Content/yujin/15.jpg"},

                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="N",Title="想编自己编。" ,Price=56.00m,TuPian="/Content/Lily/1.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="Y",Title="想编自己编。" ,Price=562.00m,TuPian="/Content/Lily/2.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="N",Title="想编自己编。" ,Price=562.00m,TuPian="/Content/Lily/3.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="N",Title="想编自己编。" ,Price=451.00m,TuPian="/Content/Lily/4.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="Y",Title="想编自己编。" ,Price=521.00m,TuPian="/Content/Lily/5.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="N",Title="想编自己编。" ,Price=561.00m,TuPian="/Content/Lily/6.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="Y",Title="想编自己编。" ,Price=232.00m,TuPian="/Content/Lily/7.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="N",Title="想编自己编。" ,Price=621.00m,TuPian="/Content/Lily/8.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="Y",Title="想编自己编。" ,Price=541.00m,TuPian="/Content/Lily/9.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="N",Title="想编自己编。" ,Price=412.00m,TuPian="/Content/Lily/10.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="Y",Title="想编自己编。" ,Price=632.00m,TuPian="/Content/Lily/11.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="N",Title="想编自己编。" ,Price=588.00m,TuPian="/Content/Lily/12.jpg"},
                new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="Y",Title="想编自己编。" ,Price=688.00m,TuPian="/Content/Lily/13.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="N",Title="想编自己编。" ,Price=588.00m,TuPian="/Content/Lily/14.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "百合"),Varieties="百合",IsNew="N",Title="想编自己编。" ,Price=188.00m,TuPian="/Content/Lily/15.jpg"},

               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="N",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/1.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="Y",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/2.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="N",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/3.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="N",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/5.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="Y",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/6.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="N",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/7.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="N",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/8.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="N",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/9.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="N",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/10.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="Y",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/11.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="N",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/12.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="N",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/13.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="Y",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/14.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "复合花束"),Varieties="多花",IsNew="N",Title="想编自己编。" ,Price=258.00m,TuPian="/Content/Complex/15.jpg"},


               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/1.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/2.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="Y",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/3.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/4.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/5.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/6.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="Y",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/7.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/8.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/9.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/10.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="Y",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/11.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/12.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="Y",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/13.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/14.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "多肉"),Varieties="多肉",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Meaty/15.jpg"},

               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/1.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/2.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="Y",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/3.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/4.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/5.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="Y",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/6.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/7.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/8.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/9.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="Y",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/10.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/11.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/12.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="Y",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/13.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/14.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "果树"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=389.00m,TuPian="/Content/fruitTrees/15.jpg"},

               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=58.00m,TuPian="/Content/green/1.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=69.00m,TuPian="/Content/green/2.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=39.00m,TuPian="/Content/green/3.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="果树",IsNew="Y",Title="想编自己编。" ,Price=59.00m,TuPian="/Content/green/4.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=38.00m,TuPian="/Content/green/5.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="果树",IsNew="N",Title="想编自己编。" ,Price=49.00m,TuPian="/Content/green/6.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="Y",Title="想编自己编。" ,Price=569.00m,TuPian="/Content/green/7.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="N",Title="想编自己编。" ,Price=59.00m,TuPian="/Content/green/8.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="N",Title="想编自己编。" ,Price=239.00m,TuPian="/Content/green/9.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="N",Title="想编自己编。" ,Price=89.00m,TuPian="/Content/green/10.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/green/10.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="Y",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/green/11.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/green/12.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/green/13.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="N",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/green/14.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="Y",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/green/15.jpg"},

               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="Y",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Custom/1.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="Y",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Custom/2.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="Y",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Custom/3.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="Y",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Custom/4.jpg"},
               new Prouduct { LeiBie = leiBies.Single(g => g.Name == "观赏性绿色植物"),Varieties="观赏性绿色植物",IsNew="Y",Title="想编自己编。" ,Price=99.00m,TuPian="/Content/Custom/5.jpg"},

            };
            shangpin.ForEach(d => context.ShangPin.Add(d));

            context.SaveChanges();
        }
    }
}