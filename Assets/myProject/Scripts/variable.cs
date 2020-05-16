using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class variable : MonoBehaviour
{
    public static string mgs = "初始化";
    public static string packageName = "demo.u3d"; // 包名
    public static string ip = @"http://192.168.31.101:8000"; // ip地址

    public static Text isMutedText;// 静音按钮文字
    public static bool isToAR = false; // 是否跳转
    public static GameObject bottomChangeStyle;
    public static GameObject detailplane; // 详情
    public static GameObject full; // 全屏
    public static GameObject bottomFull; // 底部全屏
    public static GameObject bottomBTn; // 底部
    public static Text nametext;
    public static GameObject loading;
    public static Text loadingtimetext;
    public static int time = 3;
    public static string currentVoice = "请扫描卡片！";
    public static bool isMuted = false;



    public static bool isRotate = true;
    public static Text votext;
    public static bool isFirst = true;
    public static string TrackableName;
    // o 对象
    public static GameObject Image_lxt;
    public static GameObject Image_pyh;
    public static GameObject Image_bwg;
    public static GameObject Image_jxyh;
    public static GameObject Image_czxt;
    public static GameObject loadpanel;

    public static GameObject Image_amstl;
    public static GameObject Image_jqxyj;
    public static GameObject Image_gshc;
    public static GameObject Image_mal;
    public static GameObject Image_hsy;

    public static GameObject Image_yf;
    public static GameObject Image_sbz;
    public static GameObject Image_zty;
    public static GameObject Image_dsc;
    public static GameObject Image_zzt;





    // 线宽
    public static GameObject LXTXK;
    public static GameObject BWGXK;
    public static GameObject JXYHXK;
    public static GameObject CZXTXK;
    public static GameObject PYHXK;

    public static GameObject AMSTLXK;
    public static GameObject JQXYJXK;
    public static GameObject GSHCXK;
    public static GameObject MALXK;
    public static GameObject HSYXK;

    // fbx对象
    public static GameObject lxtobj;
    public static GameObject bwgobj;
    public static GameObject jxyhobj;
    public static GameObject czxtobj;
    public static GameObject pyhobj;

    public static GameObject amstlobj;
    public static GameObject jqxyjobj;
    public static GameObject gshcobj;
    public static GameObject malobj;
    public static GameObject hsyobj;





    #region 语音简介文字
    public static string hello = "欢迎来到船政文化A——R系统，为了您的良好体验建议您打开声音！";
    public static string introduce = "“天行健，君子以自强不息。”虽因时代局限，福州马尾福建船政的辉煌只延续了40多年。但在历史的弹指挥间，却展现了近代中国先进科技、高等教育、工业制造、西方经典文化翻译传播等丰硕成果，孕育了诸多仁人志士及其先进思想，折射出中华民族特有的砺志进取、虚心好学、博采众长、勇于创新、忠心报国的传统文化神韵，为此，我们将之称为“船政文化”。";
    public static string voice_lxt = "罗星塔位于福建省福州市马尾区南部的闽江之滨，是国际公认的航标、闽江门户标志，有“中国塔”之誉。塔下是罗星塔公园，公园旁有国际海员俱乐部。登临塔顶，港口码头，开发区尽在眼底。江岸两旁还有古炮台，可以看到当年烟火弥漫的中法马江海战的古战场，可以看到昭忠祠凭吊为国捐躯的先烈。附近有一山百洞的青芝寺。";
    public static string voice_pyh = "海上奇观，莫过于海战。战舰则是海战的主要角色。几个世纪来，战舰经历了一个从小到大、从木质到装甲、从原始装备到现代装备的发展过程。战舰始于木质结构，靠摇橹航行，与一般大型货船相似，敌我相遇时，先是靠惯性冲撞，然后登船白刃格斗。15世纪，出现了帆船，马上被用作战舰。16世纪中期，陆地上出现了火炮，不久，木帆战舰也装上了火炮。18世纪末。由于海战日益频繁，完全用风帆来操纵的战舰开始占主要地位。";
    public static string voice_jxyh = "1917年冬，国内局势稍稳，巴玉藻、王助怀揣献身祖国航空事业的志向，毅然启程回国。经北洋政府批准，巴玉藻、王助等人于1918年2月正式在福建马尾船政局内创设我国第一个飞机制造厂——“海军飞机工程处”。他们集中优秀技工，进行专业培训；筛选国产材料，测试物理性能；利用船政局原有的机器加工飞机部件。他们在简陋的条件下，终于于1919年8月研制成功中国第一架水上飞机“甲型一号”";
    public static string voice_czxt = "船政学堂是清朝船政大臣沈葆祯在1866年于福建福州马尾港所设的海军学院，又称福建船政学堂，福州船政学堂或马尾水师学堂。船政学堂最初称“求是堂艺局”，是专门为福建船政培训人材而设。学堂成立之初即聘用外国教习教授造船、航海等专业知识，毕业生中优异者更会被派往西欧各国深造。船政学堂被称为中国海军摇篮，除了是近代中国首家海军及航海学院外，它亦是首家现代军事学院，和首家现代专业院校。船政学堂的毕业生不少成为北洋海军的高级将领外，部份亦成为中国近代的著名知识份子。";
    public static string voice_bwg = "中国船政文化博物馆为中国第一个以船政为主题的博物馆。馆内通过大量珍贵文物、图片、模型以及各种仿真场景，运用声、光、电等现代手段多角度综合展示了中国船政在近代中国先进科技、新式教育、工业制造、西方经典文化翻译传播等方面取得丰硕成果，生动展现了诸多爱国仁人志士的丰伟形象及其先进思想，折射出中华民族优良的砺志进取、虚心好学、博采众长、勇于创新、忠心爱国的传统文化理念。";

    public static string voice_amstl = "阿姆斯特朗乃是一个世界军事史上有着盛名的武器家族。广义上的“阿姆斯特朗炮”是泛指由19世纪英国著名火炮专家Sir William Armstrong所建立的阿姆斯特朗公司所开发的一系列大中口径火炮。该炮在日本家喻户晓，与日本近代史有巨大渊源，同时与我国也有巨大渊源。";
    public static string voice_jqxyj = "镜清号，福建船政所造，由法国地中海船厂设计，船政工程师吴德章、李寿田、杨廉臣等监造。1884年1月4日开工，1885年12月23日下水，1886年8月11日试航，1918年退役。所属南洋水师。‘镜清号’还是中国最早使用电灯的地方之一。”船政研究专家陈道章向记者透露，1885年马尾船政在建造“镜清号”时，首次安装了电灯，瞭望台上还配置了双灯式探照灯，由发电机提供电源。";
    public static string voice_gshc = "干散货船，是指专门用于装载干散货物的“船舶”。由于散货不怕压，为了装卸方便，其货舱均为单层甲板，舱口围板高而大，货舱横剖面呈棱形，货舱四角的三角形舱柜为压载水舱，可以用于调节吃水和稳性高度。一般用于运输大宗货物，故吨位较大，其始达的港口一般都有装卸设备，所以大型散货船可以不设置起货设备。";
    public static string voice_mal = "福建闽安楼，是以福建当地千年古镇闽安为主体，通过半景画影片、沙盘规划片等展项全方位介绍闽安古镇的人文历史和文化内涵，让参观者仿佛回到千年之前，享受一场时光之旅。";
    public static string voice_hsy = "绘事院初名“绘事楼”画馆，清同治七年(1868年)建，是法国式两层砖木结构建筑。上层为绘事楼，绘制船身构造图样、绘制机器图样以及测算、设计；下层为合拢厂（安装车间），占地1689平方米。绘事院现为马尾造船厂厂史陈列馆。";

    // 沈葆桢 邓世昌 严复 詹天佑 左宗棠
    public static string voice_sbz = "沈葆桢（1820年—1879年），原名沈振宗，字幼丹，又字翰宇，汉族，福建侯官（今福建福州）人。 晚清时期的重要大臣，政治家、军事家、外交家、民族英雄。 中国近代造船、航运、海军建设事业的奠基人之一 。是清朝抵抗侵略的封疆大吏林则徐之婿。";
    public static string voice_dsc = "邓世昌，字正卿，广东番禺茭塘司龙导尾乡（今广州市海珠区）人。出身农民家庭。少年时随父旅沪，从欧洲人学英语，写读俱精。清同治六年（1867），沈葆桢接任福建船政大臣，创办福州船政学堂以培养海军人才，邓世昌入选，在学期间成绩优异，深得沈葆桢赏识。同治十三年，任“琛航”号运输舰大副。光绪元年（1875），调任“东云”舰管带（舰长）。后任“振威”号兵舰管带，加都司衔。光绪五年，李鸿章负责筹建海军，以邓熟悉管驾事宜，特调其至北洋海军，任“飞霆”号炮舰管带，旋调任“镇南”号炮舰管带。";
    public static string voice_yf = "严复（1854年1月8日—1921年10月27日），原名宗光，字又陵，后改名复，字几道，汉族，福建侯官县人，近代极具影响力的资产阶级启蒙思想家，著名的翻译家、教育家   ，新法家代表人物。先后毕业于福建船政学堂和英国皇家海军学院，曾担任过京师大学堂译局总办、上海复旦公学校长、安庆高等师范学堂校长，清朝学部名辞馆总编辑。在李鸿章创办的北洋水师学堂任教期间，培养了中国近代第一批海军人才，并翻译了《天演论》、创办了《国闻报》，系统地介绍西方民主和科学，宣传维新变法思想，将西方的社会学、政治学、政治经济学、哲学和自然科学介绍到中国。";
    public static string voice_zty = "詹天佑（1861年4月26日－1919年4月24日，英文名：Jeme Tien Yow），汉族，字眷诚，号达朝。  祖籍徽州婺源，生于广东省广州府南海县，故居位于广州市荔湾区恩宁路十二甫西街芽菜巷42号。12岁留学美国，1878年考入耶鲁大学土木工程系，主修铁路工程。他是中国近代铁路工程专家，被誉为中国首位铁路总工程师。其负责修建了京张铁路等工程，有“中国铁路之父”、“中国近代工程之父”之称。";
    public static string voice_zzt = "左宗棠（1812年11月10日—1885年9月5日），汉族，字季高，一字朴存，号湘上农人。湖南湘阴人。晚清重臣，军事家、政治家、湘军著名将领，洋务派代表人物之一。与曾国藩、李鸿章、张之洞并称“晚清中兴四大名臣”。左宗棠曾就读于长沙城南书院，二十岁乡试中举，虽此后在会试中屡试不第，但留意农事，遍读群书，钻研舆地、兵法。后由幕友而起，参与平定太平天国运动，兴办洋务运动，镇压捻军，平定陕甘同治回乱，收复新疆，推动新疆建省。历任闽浙总督、陕甘总督、两江总督，官至东阁大学士、军机大臣，封二等恪靖侯。中法战争时，自请赴福建督师，光绪十一年（1885年）在福州病逝，享年七十三岁。追赠太傅，谥号“文襄”，并入祀昭忠祠、贤良祠。";



    #endregion






}

