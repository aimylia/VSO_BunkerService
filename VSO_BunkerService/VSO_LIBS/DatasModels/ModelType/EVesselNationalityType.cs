using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VSO_LIBS.DatasModels.ModelType
{
    public enum EVesselNationalityType
    {
        [Display(Name = "安提瓜和巴布达")]
        ANTIGUAANDBARBUDA = 200101,
        [Display(Name = "安的列斯群岛")]
        ANTILLES = 200102,
        [Display(Name = "巴哈马")]
        BAHAMAS = 200103,
        [Display(Name = "巴巴多斯")]
        BARBADOS = 200104,
        [Display(Name = "比利时")]
        BELGIUM = 200105,
        [Display(Name = "伯利兹")]
        BELIZE = 200106,
        [Display(Name = "百慕大")]
        BERMUDA = 200107,
        [Display(Name = "开曼群岛")]
        CAYMAN = 200108,
        [Display(Name = "中国")]
        CHINA = 200109,
        [Display(Name = "库克群岛")]
        COOKISLANDS = 200110,
        [Display(Name = "塞浦路斯")]
        CYPRUS = 200111,
        [Display(Name = "丹麦")]
        DENMARK = 200112,
        [Display(Name = "多米尼克")]
        DOMINICA = 200113,
        [Display(Name = "法国")]
        FRANCE = 200114,
        [Display(Name = "直布罗陀")]
        GIBRALTAR = 200115,
        [Display(Name = "荷兰")]
        HOLLAND = 200116,
        [Display(Name = "洪都拉斯")]
        HONDULAS = 200117,
        [Display(Name = "冰岛")]
        ICELAND = 200118,
        [Display(Name = "日本")]
        JAPAN = 200119,
        [Display(Name = "基里巴斯")]
        KIRIBATI = 200120,
        [Display(Name = "韩国")]
        KOREA = 200121,
        [Display(Name = "黎巴嫩")]
        LEBANON = 200122,
        [Display(Name = "利比里亚")]
        LIBERIA = 200123,
        [Display(Name = "马达加斯加")]
        MADAGASCAR = 200124,
        [Display(Name = "马来西亚")]
        MALAYSIA = 200125,
        [Display(Name = "马耳他")]
        MALTA = 200126,
        [Display(Name = "马绍尔群岛")]
        MARSHALL = 200127,
        [Display(Name = "缅甸")]
        MYANMAR = 200128,
        [Display(Name = "挪威")]
        NORWAY = 200129,
        [Display(Name = "巴拿马")]
        PANAMA = 200130,
        [Display(Name = "菲力宾")]
        PHILIPPINES = 200131,
        [Display(Name = "葡萄牙")]
        PORTUGAL = 200132,
        [Display(Name = "俄罗斯")]
        RUSSIA = 200133,
        [Display(Name = "圣基茨和尼维斯")]
        SAINTKITTSANDNEVIS = 200134,
        [Display(Name = "圣文森特和格林纳丁斯")]
        SAINTVINCENTANDGRENADINES = 200135,
        [Display(Name = "塞舌尔")]
        SEYCHELLES = 200136,
        [Display(Name = "塞拉利昂")]
        SIERRALEONE = 200137,
        [Display(Name = "南非")]
        SOUTHAFRICA = 200138,
        [Display(Name = "西班牙")]
        SPAIN = 200139,
        [Display(Name = "斯里兰卡")]
        SRILANKA = 200140,
        [Display(Name = "台湾")]
        TAIWAN = 200141,
        [Display(Name = "特立尼达和多巴哥")]
        TRINIDADANDTOBAGO = 200142,
        [Display(Name = "瓦努阿图")]
        VANUATU = 200143,
        [Display(Name = "其他船旗国")]
        OTHERFLAG = 200199
    }
}
