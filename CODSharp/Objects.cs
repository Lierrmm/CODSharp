using System.ComponentModel;

namespace CODSharp
{
    public class baseResponse
    {
        public string status { get; set; }
        public Data data { get; set; }
        public class Data
        {
            public string type { get; set; }
            public string message { get; set; }
        }
    }

    public class search : baseResponse
    {

    }

    public class WZStats : baseResponse
    {
        public new Data data { get; set; }

        public new class Data
        {
            public string title { get; set; }
            public string platform { get; set; }
            public string username { get; set; }
            public string type { get; set; }
            public float level { get; set; }
            public float maxLevel { get; set; }
            public float levelXpRemainder { get; set; }
            public float levelXpGained { get; set; }
            public float prestige { get; set; }
            public float prestigeId { get; set; }
            public float maxPrestige { get; set; }
            public float totalXp { get; set; }
            public float paragonRank { get; set; }
            public float paragonId { get; set; }
            public float s { get; set; }
            public float p { get; set; }
            public Lifetime lifetime { get; set; }
            public Weekly weekly { get; set; }
            public object engagement { get; set; }
        }

        public class Lifetime
        {
            public All all { get; set; }
            public Mode mode { get; set; }
            public Map map { get; set; }
            public Itemdata itemData { get; set; }
            public Scorestreakdata scorestreakData { get; set; }
            public Accoladedata accoladeData { get; set; }
        }

        public class All
        {
            public Properties properties { get; set; }
        }

        public class Properties
        {
            public float recordLongestWinStreak { get; set; }
            public float recordXpInAMatch { get; set; }
            public float accuracy { get; set; }
            public float losses { get; set; }
            public float totalGamesPlayed { get; set; }
            public float score { get; set; }
            public float winLossRatio { get; set; }
            public float totalShots { get; set; }
            public float bestScoreXp { get; set; }
            public float gamesPlayed { get; set; }
            public float bestSquardKills { get; set; }
            public float bestSguardWave { get; set; }
            public float bestConfirmed { get; set; }
            public float deaths { get; set; }
            public float wins { get; set; }
            public float bestSquardCrates { get; set; }
            public float kdRatio { get; set; }
            public float bestAssists { get; set; }
            public float bestFieldgoals { get; set; }
            public float bestScore { get; set; }
            public float recordDeathsInAMatch { get; set; }
            public float scorePerGame { get; set; }
            public float bestSPM { get; set; }
            public float bestKillChains { get; set; }
            public float recordKillsInAMatch { get; set; }
            public float suicides { get; set; }
            public float wlRatio { get; set; }
            public float currentWinStreak { get; set; }
            public float bestMatchBonusXp { get; set; }
            public float bestMatchXp { get; set; }
            public float bestSguardWeaponLevel { get; set; }
            public float bestKD { get; set; }
            public float kills { get; set; }
            public float bestKillsAsInfected { get; set; }
            public float bestReturns { get; set; }
            public float bestStabs { get; set; }
            public float bestKillsAsSurvivor { get; set; }
            public float timePlayedTotal { get; set; }
            public float bestDestructions { get; set; }
            public float headshots { get; set; }
            public float bestRescues { get; set; }
            public float assists { get; set; }
            public float ties { get; set; }
            public float recordKillStreak { get; set; }
            public float bestPlants { get; set; }
            public float misses { get; set; }
            public float bestDamage { get; set; }
            public float bestSetbacks { get; set; }
            public float bestTouchdowns { get; set; }
            public float scorePerMinute { get; set; }
            public float bestDeaths { get; set; }
            public float bestMedalXp { get; set; }
            public float bestDefends { get; set; }
            public float bestSquardRevives { get; set; }
            public float bestKills { get; set; }
            public float bestDefuses { get; set; }
            public float bestCaptures { get; set; }
            public float hits { get; set; }
            public float bestKillStreak { get; set; }
            public float bestDenied { get; set; }
        }

        public class Mode
        {
            public Gun gun { get; set; }
            public Dom dom { get; set; }
            public War war { get; set; }
            public Hq hq { get; set; }
            public Hc_Dom hc_dom { get; set; }
            public Hc_Conf hc_conf { get; set; }
            public Koth koth { get; set; }
            public Conf conf { get; set; }
            public Hc_Hq hc_hq { get; set; }
            public Arena arena { get; set; }
            public Br_Dmz br_dmz { get; set; }
            public Br br { get; set; }
            public Sd sd { get; set; }
            public Grnd grnd { get; set; }
            public Cyber cyber { get; set; }
            public Hc_War hc_war { get; set; }
            public Br_All br_all { get; set; }
            public Hc_Sd hc_sd { get; set; }
            public Arm arm { get; set; }
            public Hc_Cyber hc_cyber { get; set; }
            public Infect infect { get; set; }
        }

        public class Gun
        {
            public Properties1 properties { get; set; }
        }

        public class Properties1
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float setBacks { get; set; }
            public float scorePerMinute { get; set; }
            public float stabs { get; set; }
            public float deaths { get; set; }
        }

        public class Dom
        {
            public Properties2 properties { get; set; }
        }

        public class Properties2
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float captures { get; set; }
            public float defends { get; set; }
            public float scorePerMinute { get; set; }
            public float deaths { get; set; }
        }

        public class War
        {
            public Properties3 properties { get; set; }
        }

        public class Properties3
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float assists { get; set; }
            public float scorePerMinute { get; set; }
            public float deaths { get; set; }
        }

        public class Hq
        {
            public Properties4 properties { get; set; }
        }

        public class Properties4
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float captures { get; set; }
            public float defends { get; set; }
            public float scorePerMinute { get; set; }
            public float deaths { get; set; }
        }

        public class Hc_Dom
        {
            public Properties5 properties { get; set; }
        }

        public class Properties5
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float captures { get; set; }
            public float defends { get; set; }
            public float scorePerMinute { get; set; }
            public float deaths { get; set; }
        }

        public class Hc_Conf
        {
            public Properties6 properties { get; set; }
        }

        public class Properties6
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float confirms { get; set; }
            public float scorePerMinute { get; set; }
            public float denies { get; set; }
            public float deaths { get; set; }
        }

        public class Koth
        {
            public Properties7 properties { get; set; }
        }

        public class Properties7
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float defends { get; set; }
            public float objTime { get; set; }
            public float scorePerMinute { get; set; }
            public float deaths { get; set; }
        }

        public class Conf
        {
            public Properties8 properties { get; set; }
        }

        public class Properties8
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float confirms { get; set; }
            public float scorePerMinute { get; set; }
            public float denies { get; set; }
            public float deaths { get; set; }
        }

        public class Hc_Hq
        {
            public Properties9 properties { get; set; }
        }

        public class Properties9
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float captures { get; set; }
            public float defends { get; set; }
            public float scorePerMinute { get; set; }
            public float deaths { get; set; }
        }

        public class Arena
        {
            public Properties10 properties { get; set; }
        }

        public class Properties10
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float damage { get; set; }
            public float kdRatio { get; set; }
            public float assists { get; set; }
            public float scorePerMinute { get; set; }
            public float deaths { get; set; }
        }

        public class Br_Dmz
        {
            public Properties11 properties { get; set; }
        }

        public class Properties11
        {
            public float wins { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float downs { get; set; }
            public float topTwentyFive { get; set; }
            public float topTen { get; set; }
            public float contracts { get; set; }
            public float revives { get; set; }
            public float topFive { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float gamesPlayed { get; set; }
            public float tokens { get; set; }
            public float scorePerMinute { get; set; }
            public float cash { get; set; }
            public float deaths { get; set; }
        }

        public class Br
        {
            public Properties12 properties { get; set; }
        }

        public class Properties12
        {
            public float wins { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float downs { get; set; }
            public float topTwentyFive { get; set; }
            public float topTen { get; set; }
            public float contracts { get; set; }
            public float revives { get; set; }
            public float topFive { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float gamesPlayed { get; set; }
            public float tokens { get; set; }
            public float scorePerMinute { get; set; }
            public float cash { get; set; }
            public float deaths { get; set; }
        }

        public class Sd
        {
            public Properties13 properties { get; set; }
        }

        public class Properties13
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float plants { get; set; }
            public float scorePerMinute { get; set; }
            public float defuses { get; set; }
            public float deaths { get; set; }
        }

        public class Grnd
        {
            public Properties14 properties { get; set; }
        }

        public class Properties14
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float defends { get; set; }
            public float objTime { get; set; }
            public float scorePerMinute { get; set; }
            public float deaths { get; set; }
        }

        public class Cyber
        {
            public Properties15 properties { get; set; }
        }

        public class Properties15
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float plants { get; set; }
            public float scorePerMinute { get; set; }
            public float revives { get; set; }
            public float deaths { get; set; }
        }

        public class Hc_War
        {
            public Properties16 properties { get; set; }
        }

        public class Properties16
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float assists { get; set; }
            public float scorePerMinute { get; set; }
            public float deaths { get; set; }
        }

        public class Br_All
        {
            public Properties17 properties { get; set; }
        }

        public class Properties17
        {
            public float wins { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float downs { get; set; }
            public float topTwentyFive { get; set; }
            public float topTen { get; set; }
            public float contracts { get; set; }
            public float revives { get; set; }
            public float topFive { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float gamesPlayed { get; set; }
            public float tokens { get; set; }
            public float scorePerMinute { get; set; }
            public float cash { get; set; }
            public float deaths { get; set; }
        }

        public class Hc_Sd
        {
            public Properties18 properties { get; set; }
        }

        public class Properties18
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float plants { get; set; }
            public float scorePerMinute { get; set; }
            public float defuses { get; set; }
            public float deaths { get; set; }
        }

        public class Arm
        {
            public Properties19 properties { get; set; }
        }

        public class Properties19
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float captures { get; set; }
            public float defends { get; set; }
            public float scorePerMinute { get; set; }
            public float deaths { get; set; }
        }

        public class Hc_Cyber
        {
            public Properties20 properties { get; set; }
        }

        public class Properties20
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float plants { get; set; }
            public float scorePerMinute { get; set; }
            public float revives { get; set; }
            public float deaths { get; set; }
        }

        public class Infect
        {
            public Properties21 properties { get; set; }
        }

        public class Properties21
        {
            public float kills { get; set; }
            public float score { get; set; }
            public float infected { get; set; }
            public float timePlayed { get; set; }
            public float kdRatio { get; set; }
            public float scorePerMinute { get; set; }
            public float time { get; set; }
            public float deaths { get; set; }
        }

        public class Map { }

        public class Itemdata
        {
            public Weapon_Assault_Rifle weapon_assault_rifle { get; set; }
            public Weapon_Shotgun weapon_shotgun { get; set; }
            public Weapon_Marksman weapon_marksman { get; set; }
            public Weapon_Sniper weapon_sniper { get; set; }
            public Tacticals tacticals { get; set; }
            public Lethals lethals { get; set; }
            public Weapon_Lmg weapon_lmg { get; set; }
            public Weapon_Launcher weapon_launcher { get; set; }
            public Supers supers { get; set; }
            public Weapon_Pistol weapon_pistol { get; set; }
            public Weapon_Other weapon_other { get; set; }
            public Weapon_Smg weapon_smg { get; set; }
            public Weapon_Melee weapon_melee { get; set; }
        }

        public class Weapon_Assault_Rifle
        {
            public Iw8_Ar_Tango21 iw8_ar_tango21 { get; set; }
            public Iw8_Ar_Mike4 iw8_ar_mike4 { get; set; }
            public Iw8_Ar_Valpha iw8_ar_valpha { get; set; }
            public Iw8_Ar_Falpha iw8_ar_falpha { get; set; }
            public Iw8_Ar_Mcharlie iw8_ar_mcharlie { get; set; }
            public Iw8_Ar_Akilo47 iw8_ar_akilo47 { get; set; }
            public Iw8_Ar_Asierra12 iw8_ar_asierra12 { get; set; }
            public Iw8_Ar_Galima iw8_ar_galima { get; set; }
            public Iw8_Ar_Sierra552 iw8_ar_sierra552 { get; set; }
            public Iw8_Ar_Falima iw8_ar_falima { get; set; }
            public Iw8_Ar_Anovember94 iw8_ar_anovember94 { get; set; }
            public Iw8_Ar_Kilo433 iw8_ar_kilo433 { get; set; }
            public Iw8_Ar_Scharlie iw8_ar_scharlie { get; set; }
        }

        public class Iw8_Ar_Tango21
        {
            public Properties22 properties { get; set; }
        }

        public class Properties22
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Ar_Mike4
        {
            public Properties23 properties { get; set; }
        }

        public class Properties23
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Ar_Valpha
        {
            public Properties24 properties { get; set; }
        }

        public class Properties24
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Ar_Falpha
        {
            public Properties25 properties { get; set; }
        }

        public class Properties25
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Ar_Mcharlie
        {
            public Properties26 properties { get; set; }
        }

        public class Properties26
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Ar_Akilo47
        {
            public Properties27 properties { get; set; }
        }

        public class Properties27
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Ar_Asierra12
        {
            public Properties28 properties { get; set; }
        }

        public class Properties28
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Ar_Galima
        {
            public Properties29 properties { get; set; }
        }

        public class Properties29
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Ar_Sierra552
        {
            public Properties30 properties { get; set; }
        }

        public class Properties30
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Ar_Falima
        {
            public Properties31 properties { get; set; }
        }

        public class Properties31
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Ar_Anovember94
        {
            public Properties32 properties { get; set; }
        }

        public class Properties32
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Ar_Kilo433
        {
            public Properties33 properties { get; set; }
        }

        public class Properties33
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Ar_Scharlie
        {
            public Properties34 properties { get; set; }
        }

        public class Properties34
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Weapon_Shotgun
        {
            public Iw8_Sh_Mike26 iw8_sh_mike26 { get; set; }
            public Iw8_Sh_Charlie725 iw8_sh_charlie725 { get; set; }
            public Iw8_Sh_Oscar12 iw8_sh_oscar12 { get; set; }
            public Iw8_Sh_Aalpha12 iw8_sh_aalpha12 { get; set; }
            public Iw8_Sh_Romeo870 iw8_sh_romeo870 { get; set; }
            public Iw8_Sh_Dpapa12 iw8_sh_dpapa12 { get; set; }
        }

        public class Iw8_Sh_Mike26
        {
            public Properties35 properties { get; set; }
        }

        public class Properties35
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sh_Charlie725
        {
            public Properties36 properties { get; set; }
        }

        public class Properties36
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sh_Oscar12
        {
            public Properties37 properties { get; set; }
        }

        public class Properties37
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sh_Aalpha12
        {
            public Properties38 properties { get; set; }
        }

        public class Properties38
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sh_Romeo870
        {
            public Properties39 properties { get; set; }
        }

        public class Properties39
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sh_Dpapa12
        {
            public Properties40 properties { get; set; }
        }

        public class Properties40
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Weapon_Marksman
        {
            public Iw8_Sn_Sbeta iw8_sn_sbeta { get; set; }
            public Iw8_Sn_Crossbow iw8_sn_crossbow { get; set; }
            public Iw8_Sn_Romeo700 iw8_sn_romeo700 { get; set; }
            public Iw8_Sn_Kilo98 iw8_sn_kilo98 { get; set; }
            public Iw8_Sn_Mike14 iw8_sn_mike14 { get; set; }
            public Iw8_Sn_Sksierra iw8_sn_sksierra { get; set; }
        }

        public class Iw8_Sn_Sbeta
        {
            public Properties41 properties { get; set; }
        }

        public class Properties41
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sn_Crossbow
        {
            public Properties42 properties { get; set; }
        }

        public class Properties42
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sn_Romeo700
        {
            public Properties43 properties { get; set; }
        }

        public class Properties43
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sn_Kilo98
        {
            public Properties44 properties { get; set; }
        }

        public class Properties44
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sn_Mike14
        {
            public Properties45 properties { get; set; }
        }

        public class Properties45
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sn_Sksierra
        {
            public Properties46 properties { get; set; }
        }

        public class Properties46
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Weapon_Sniper
        {
            public Iw8_Sn_Alpha50 iw8_sn_alpha50 { get; set; }
            public Iw8_Sn_Hdromeo iw8_sn_hdromeo { get; set; }
            public Iw8_Sn_Delta iw8_sn_delta { get; set; }
            public Iw8_Sn_Xmike109 iw8_sn_xmike109 { get; set; }
        }

        public class Iw8_Sn_Alpha50
        {
            public Properties47 properties { get; set; }
        }

        public class Properties47
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sn_Hdromeo
        {
            public Properties48 properties { get; set; }
        }

        public class Properties48
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sn_Delta
        {
            public Properties49 properties { get; set; }
        }

        public class Properties49
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sn_Xmike109
        {
            public Properties50 properties { get; set; }
        }

        public class Properties50
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Tacticals
        {
            public Equip_Gas_Grenade equip_gas_grenade { get; set; }
            public Equip_Snapshot_Grenade equip_snapshot_grenade { get; set; }
            public Equip_Decoy equip_decoy { get; set; }
            public Equip_Smoke equip_smoke { get; set; }
            public Equip_Concussion equip_concussion { get; set; }
            public Equip_Hb_Sensor equip_hb_sensor { get; set; }
            public Equip_Flash equip_flash { get; set; }
            public Equip_Adrenaline equip_adrenaline { get; set; }
        }

        public class Equip_Gas_Grenade
        {
            public Properties51 properties { get; set; }
        }

        public class Properties51
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
        }

        public class Equip_Snapshot_Grenade
        {
            public Properties52 properties { get; set; }
        }

        public class Properties52
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
        }

        public class Equip_Decoy
        {
            public Properties53 properties { get; set; }
        }

        public class Properties53
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
        }

        public class Equip_Smoke
        {
            public Properties54 properties { get; set; }
        }

        public class Properties54
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
        }

        public class Equip_Concussion
        {
            public Properties55 properties { get; set; }
        }

        public class Properties55
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
        }

        public class Equip_Hb_Sensor
        {
            public Properties56 properties { get; set; }
        }

        public class Properties56
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
        }

        public class Equip_Flash
        {
            public Properties57 properties { get; set; }
        }

        public class Properties57
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
        }

        public class Equip_Adrenaline
        {
            public Properties58 properties { get; set; }
        }

        public class Properties58
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
        }

        public class Lethals
        {
            public Equip_Frag equip_frag { get; set; }
            public Equip_Thermite equip_thermite { get; set; }
            public Equip_Semtex equip_semtex { get; set; }
            public Equip_Claymore equip_claymore { get; set; }
            public Equip_C4 equip_c4 { get; set; }
            public Equip_At_Mine equip_at_mine { get; set; }
            public Equip_Throwing_Knife equip_throwing_knife { get; set; }
            public Equip_Molotov equip_molotov { get; set; }
        }

        public class Equip_Frag
        {
            public Properties59 properties { get; set; }
        }

        public class Properties59
        {
            public float kills { get; set; }
            public float uses { get; set; }
        }

        public class Equip_Thermite
        {
            public Properties60 properties { get; set; }
        }

        public class Properties60
        {
            public float kills { get; set; }
            public float uses { get; set; }
        }

        public class Equip_Semtex
        {
            public Properties61 properties { get; set; }
        }

        public class Properties61
        {
            public float kills { get; set; }
            public float uses { get; set; }
        }

        public class Equip_Claymore
        {
            public Properties62 properties { get; set; }
        }

        public class Properties62
        {
            public float kills { get; set; }
            public float uses { get; set; }
        }

        public class Equip_C4
        {
            public Properties63 properties { get; set; }
        }

        public class Properties63
        {
            public float kills { get; set; }
            public float uses { get; set; }
        }

        public class Equip_At_Mine
        {
            public Properties64 properties { get; set; }
        }

        public class Properties64
        {
            public float kills { get; set; }
            public float uses { get; set; }
        }

        public class Equip_Throwing_Knife
        {
            public Properties65 properties { get; set; }
        }

        public class Properties65
        {
            public float kills { get; set; }
            public float uses { get; set; }
        }

        public class Equip_Molotov
        {
            public Properties66 properties { get; set; }
        }

        public class Properties66
        {
            public float kills { get; set; }
            public float uses { get; set; }
        }

        public class Weapon_Lmg
        {
            public Iw8_Lm_Kilo121 iw8_lm_kilo121 { get; set; }
            public Iw8_Lm_Mkilo3 iw8_lm_mkilo3 { get; set; }
            public Iw8_Lm_Mgolf34 iw8_lm_mgolf34 { get; set; }
            public Iw8_Lm_Lima86 iw8_lm_lima86 { get; set; }
            public Iw8_Lm_Pkilo iw8_lm_pkilo { get; set; }
            public Iw8_Lm_Sierrax iw8_lm_sierrax { get; set; }
            public Iw8_Lm_Mgolf36 iw8_lm_mgolf36 { get; set; }
        }

        public class Iw8_Lm_Kilo121
        {
            public Properties67 properties { get; set; }
        }

        public class Properties67
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Lm_Mkilo3
        {
            public Properties68 properties { get; set; }
        }

        public class Properties68
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Lm_Mgolf34
        {
            public Properties69 properties { get; set; }
        }

        public class Properties69
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Lm_Lima86
        {
            public Properties70 properties { get; set; }
        }

        public class Properties70
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Lm_Pkilo
        {
            public Properties71 properties { get; set; }
        }

        public class Properties71
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Lm_Sierrax
        {
            public Properties72 properties { get; set; }
        }

        public class Properties72
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Lm_Mgolf36
        {
            public Properties73 properties { get; set; }
        }

        public class Properties73
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Weapon_Launcher
        {
            public Iw8_La_Gromeo iw8_la_gromeo { get; set; }
            public Iw8_La_Rpapa7 iw8_la_rpapa7 { get; set; }
            public Iw8_La_Juliet iw8_la_juliet { get; set; }
            public Iw8_La_Kgolf iw8_la_kgolf { get; set; }
            public Iw8_La_Mike32 iw8_la_mike32 { get; set; }
        }

        public class Iw8_La_Gromeo
        {
            public Properties74 properties { get; set; }
        }

        public class Properties74
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_La_Rpapa7
        {
            public Properties75 properties { get; set; }
        }

        public class Properties75
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_La_Juliet
        {
            public Properties76 properties { get; set; }
        }

        public class Properties76
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_La_Kgolf
        {
            public Properties77 properties { get; set; }
        }

        public class Properties77
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_La_Mike32
        {
            public Properties78 properties { get; set; }
        }

        public class Properties78
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Supers
        {
            public Super_Emp_Drone super_emp_drone { get; set; }
            public Super_Trophy super_trophy { get; set; }
            public Super_Ammo_Drop super_ammo_drop { get; set; }
            public Super_Weapon_Drop super_weapon_drop { get; set; }
            public Super_Fulton super_fulton { get; set; }
            public Super_Armor_Drop super_armor_drop { get; set; }
            public Super_Select super_select { get; set; }
            public Super_Tac_Insert super_tac_insert { get; set; }
            public Super_Recon_Drone super_recon_drone { get; set; }
            public Super_Deadsilence super_deadsilence { get; set; }
            public Super_Supply_Drop super_supply_drop { get; set; }
            public Super_Tac_Cover super_tac_cover { get; set; }
            public Super_Support_Box super_support_box { get; set; }
        }

        public class Super_Emp_Drone
        {
            public Properties79 properties { get; set; }
        }

        public class Properties79
        {
            public float kills { get; set; }
            public float misc1 { get; set; }
            public float misc2 { get; set; }
            public float uses { get; set; }
        }

        public class Super_Trophy
        {
            public Properties80 properties { get; set; }
        }

        public class Properties80
        {
            public float kills { get; set; }
            public float misc1 { get; set; }
            public float misc2 { get; set; }
            public float uses { get; set; }
        }

        public class Super_Ammo_Drop
        {
            public Properties81 properties { get; set; }
        }

        public class Properties81
        {
            public float kills { get; set; }
            public float misc1 { get; set; }
            public float misc2 { get; set; }
            public float uses { get; set; }
        }

        public class Super_Weapon_Drop
        {
            public Properties82 properties { get; set; }
        }

        public class Properties82
        {
            public float kills { get; set; }
            public float misc1 { get; set; }
            public float misc2 { get; set; }
            public float uses { get; set; }
        }

        public class Super_Fulton
        {
            public Properties83 properties { get; set; }
        }

        public class Properties83
        {
            public float kills { get; set; }
            public float misc1 { get; set; }
            public float misc2 { get; set; }
            public float uses { get; set; }
        }

        public class Super_Armor_Drop
        {
            public Properties84 properties { get; set; }
        }

        public class Properties84
        {
            public float kills { get; set; }
            public float misc1 { get; set; }
            public float misc2 { get; set; }
            public float uses { get; set; }
        }

        public class Super_Select
        {
            public Properties85 properties { get; set; }
        }

        public class Properties85
        {
            public float kills { get; set; }
            public float misc1 { get; set; }
            public float misc2 { get; set; }
            public float uses { get; set; }
        }

        public class Super_Tac_Insert
        {
            public Properties86 properties { get; set; }
        }

        public class Properties86
        {
            public float kills { get; set; }
            public float misc1 { get; set; }
            public float misc2 { get; set; }
            public float uses { get; set; }
        }

        public class Super_Recon_Drone
        {
            public Properties87 properties { get; set; }
        }

        public class Properties87
        {
            public float kills { get; set; }
            public float misc1 { get; set; }
            public float misc2 { get; set; }
            public float uses { get; set; }
        }

        public class Super_Deadsilence
        {
            public Properties88 properties { get; set; }
        }

        public class Properties88
        {
            public float kills { get; set; }
            public float misc1 { get; set; }
            public float misc2 { get; set; }
            public float uses { get; set; }
        }

        public class Super_Supply_Drop
        {
            public Properties89 properties { get; set; }
        }

        public class Properties89
        {
            public float kills { get; set; }
            public float misc1 { get; set; }
            public float misc2 { get; set; }
            public float uses { get; set; }
        }

        public class Super_Tac_Cover
        {
            public Properties90 properties { get; set; }
        }

        public class Properties90
        {
            public float kills { get; set; }
            public float misc1 { get; set; }
            public float misc2 { get; set; }
            public float uses { get; set; }
        }

        public class Super_Support_Box
        {
            public Properties91 properties { get; set; }
        }

        public class Properties91
        {
            public float kills { get; set; }
            public float misc1 { get; set; }
            public float misc2 { get; set; }
            public float uses { get; set; }
        }

        public class Weapon_Pistol
        {
            public Iw8_Pi_Cpapa iw8_pi_cpapa { get; set; }
            public Iw8_Pi_Mike9 iw8_pi_mike9 { get; set; }
            public Iw8_Pi_Mike1911 iw8_pi_mike1911 { get; set; }
            public Iw8_Pi_Golf21 iw8_pi_golf21 { get; set; }
            public Iw8_Pi_Decho iw8_pi_decho { get; set; }
            public Iw8_Pi_Papa320 iw8_pi_papa320 { get; set; }
        }

        public class Iw8_Pi_Cpapa
        {
            public Properties92 properties { get; set; }
        }

        public class Properties92
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Pi_Mike9
        {
            public Properties93 properties { get; set; }
        }

        public class Properties93
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Pi_Mike1911
        {
            public Properties94 properties { get; set; }
        }

        public class Properties94
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Pi_Golf21
        {
            public Properties95 properties { get; set; }
        }

        public class Properties95
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Pi_Decho
        {
            public Properties96 properties { get; set; }
        }

        public class Properties96
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Pi_Papa320
        {
            public Properties97 properties { get; set; }
        }

        public class Properties97
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Weapon_Other
        {
            public Iw8_Me_Riotshield iw8_me_riotshield { get; set; }
        }

        public class Iw8_Me_Riotshield
        {
            public Properties98 properties { get; set; }
        }

        public class Properties98
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Weapon_Smg
        {
            public Iw8_Sm_Mpapa7 iw8_sm_mpapa7 { get; set; }
            public Iw8_Sm_Augolf iw8_sm_augolf { get; set; }
            public Iw8_Sm_Papa90 iw8_sm_papa90 { get; set; }
            public Iw8_Sm_Charlie9 iw8_sm_charlie9 { get; set; }
            public Iw8_Sm_Mpapa5 iw8_sm_mpapa5 { get; set; }
            public Iw8_Sm_Smgolf45 iw8_sm_smgolf45 { get; set; }
            public Iw8_Sm_Beta iw8_sm_beta { get; set; }
            public Iw8_Sm_Victor iw8_sm_victor { get; set; }
            public Iw8_Sm_Uzulu iw8_sm_uzulu { get; set; }
        }

        public class Iw8_Sm_Mpapa7
        {
            public Properties99 properties { get; set; }
        }

        public class Properties99
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sm_Augolf
        {
            public Properties100 properties { get; set; }
        }

        public class Properties100
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sm_Papa90
        {
            public Properties101 properties { get; set; }
        }

        public class Properties101
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sm_Charlie9
        {
            public Properties102 properties { get; set; }
        }

        public class Properties102
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sm_Mpapa5
        {
            public Properties103 properties { get; set; }
        }

        public class Properties103
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sm_Smgolf45
        {
            public Properties104 properties { get; set; }
        }

        public class Properties104
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sm_Beta
        {
            public Properties105 properties { get; set; }
        }

        public class Properties105
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sm_Victor
        {
            public Properties106 properties { get; set; }
        }

        public class Properties106
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Sm_Uzulu
        {
            public Properties107 properties { get; set; }
        }

        public class Properties107
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Weapon_Melee
        {
            public Iw8_Me_Akimboblunt iw8_me_akimboblunt { get; set; }
            public Iw8_Me_Akimboblades iw8_me_akimboblades { get; set; }
            public Iw8_Knife iw8_knife { get; set; }
        }

        public class Iw8_Me_Akimboblunt
        {
            public Properties108 properties { get; set; }
        }

        public class Properties108
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Me_Akimboblades
        {
            public Properties109 properties { get; set; }
        }

        public class Properties109
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Iw8_Knife
        {
            public Properties110 properties { get; set; }
        }

        public class Properties110
        {
            public float hits { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float headshots { get; set; }
            public float accuracy { get; set; }
            public float shots { get; set; }
            public float deaths { get; set; }
        }

        public class Scorestreakdata
        {
            public Lethalscorestreakdata lethalScorestreakData { get; set; }
            public Supportscorestreakdata supportScorestreakData { get; set; }
        }

        public class Lethalscorestreakdata
        {
            public Precision_Airstrike precision_airstrike { get; set; }
            public Cruise_Predator cruise_predator { get; set; }
            public Manual_Turret manual_turret { get; set; }
            public White_Phosphorus white_phosphorus { get; set; }
            public Hover_Jet hover_jet { get; set; }
            public Chopper_Gunner chopper_gunner { get; set; }
            public Gunship gunship { get; set; }
            public Sentry_Gun sentry_gun { get; set; }
            public Toma_Strike toma_strike { get; set; }
            public Nuke nuke { get; set; }
            public Juggernaut juggernaut { get; set; }
            public Pac_Sentry pac_sentry { get; set; }
            public Chopper_Support chopper_support { get; set; }
            public Bradley bradley { get; set; }
        }

        public class Precision_Airstrike
        {
            public Properties111 properties { get; set; }
        }

        public class Properties111
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Cruise_Predator
        {
            public Properties112 properties { get; set; }
        }

        public class Properties112
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Manual_Turret
        {
            public Properties113 properties { get; set; }
        }

        public class Properties113
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class White_Phosphorus
        {
            public Properties114 properties { get; set; }
        }

        public class Properties114
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Hover_Jet
        {
            public Properties115 properties { get; set; }
        }

        public class Properties115
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Chopper_Gunner
        {
            public Properties116 properties { get; set; }
        }

        public class Properties116
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Gunship
        {
            public Properties117 properties { get; set; }
        }

        public class Properties117
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Sentry_Gun
        {
            public Properties118 properties { get; set; }
        }

        public class Properties118
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Toma_Strike
        {
            public Properties119 properties { get; set; }
        }

        public class Properties119
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Nuke
        {
            public Properties120 properties { get; set; }
        }

        public class Properties120
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Juggernaut
        {
            public Properties121 properties { get; set; }
        }

        public class Properties121
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Pac_Sentry
        {
            public Properties122 properties { get; set; }
        }

        public class Properties122
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Chopper_Support
        {
            public Properties123 properties { get; set; }
        }

        public class Properties123
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Bradley
        {
            public Properties124 properties { get; set; }
        }

        public class Properties124
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Supportscorestreakdata
        {
            public Airdrop airdrop { get; set; }
            public Radar_Drone_Overwatch radar_drone_overwatch { get; set; }
            public Scrambler_Drone_Guard scrambler_drone_guard { get; set; }
            public Uav uav { get; set; }
            public Airdrop_Multiple airdrop_multiple { get; set; }
            public Directional_Uav directional_uav { get; set; }
        }

        public class Airdrop
        {
            public Properties125 properties { get; set; }
        }

        public class Properties125
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Radar_Drone_Overwatch
        {
            public Properties126 properties { get; set; }
        }

        public class Properties126
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Scrambler_Drone_Guard
        {
            public Properties127 properties { get; set; }
        }

        public class Properties127
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Uav
        {
            public Properties128 properties { get; set; }
        }

        public class Properties128
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Airdrop_Multiple
        {
            public Properties129 properties { get; set; }
        }

        public class Properties129
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Directional_Uav
        {
            public Properties130 properties { get; set; }
        }

        public class Properties130
        {
            public float extraStat1 { get; set; }
            public float uses { get; set; }
            public float awardedCount { get; set; }
        }

        public class Accoladedata
        {
            public Properties131 properties { get; set; }
        }

        public class Properties131
        {
            public float classChanges { get; set; }
            public float highestAvgAltitude { get; set; }
            public float killsFromBehind { get; set; }
            public float lmgDeaths { get; set; }
            public float riotShieldDamageAbsorbed { get; set; }
            public float flashbangHits { get; set; }
            public float meleeKills { get; set; }
            public float tagsLargestBank { get; set; }
            public float shotgunKills { get; set; }
            public float sniperDeaths { get; set; }
            public float timeProne { get; set; }
            public float killstreakWhitePhosphorousKillsAssists { get; set; }
            public float shortestLife { get; set; }
            public float deathsFromBehind { get; set; }
            public float higherRankedKills { get; set; }
            public float mostAssists { get; set; }
            public float leastKills { get; set; }
            public float tagsDenied { get; set; }
            public float killstreakWheelsonKills { get; set; }
            public float sniperHeadshots { get; set; }
            public float killstreakJuggernautKills { get; set; }
            public float smokesUsed { get; set; }
            public float avengerKills { get; set; }
            public float decoyHits { get; set; }
            public float killstreakCarePackageUsed { get; set; }
            public float molotovKills { get; set; }
            public float gasHits { get; set; }
            public float comebackKills { get; set; }
            public float lmgHeadshots { get; set; }
            public float smgDeaths { get; set; }
            public float carrierKills { get; set; }
            public float deployableCoverUsed { get; set; }
            public float thermiteKills { get; set; }
            public float arKills { get; set; }
            public float c4Kills { get; set; }
            public float suicides { get; set; }
            public float clutch { get; set; }
            public float survivorKills { get; set; }
            public float killstreakGunshipKills { get; set; }
            public float timeSpentAsPassenger { get; set; }
            public float returns { get; set; }
            public float smgHeadshots { get; set; }
            public float launcherDeaths { get; set; }
            public float oneShotOneKills { get; set; }
            public float ammoBoxUsed { get; set; }
            public float spawnSelectSquad { get; set; }
            public float weaponPickups { get; set; }
            public float pointBlankKills { get; set; }
            public float tagsCaptured { get; set; }
            public float killstreakGroundKills { get; set; }
            public float distanceTraveledInVehicle { get; set; }
            public float longestLife { get; set; }
            public float stunHits { get; set; }
            public float spawnSelectFlag { get; set; }
            public float shotgunHeadshots { get; set; }
            public float bombDefused { get; set; }
            public float snapshotHits { get; set; }
            public float noKillsWithDeath { get; set; }
            public float killstreakAUAVAssists { get; set; }
            public float killstreakPersonalUAVKills { get; set; }
            public float tacticalInsertionSpawns { get; set; }
            public float launcherKills { get; set; }
            public float spawnSelectVehicle { get; set; }
            public float mostKillsLeastDeaths { get; set; }
            public float mostKills { get; set; }
            public float defends { get; set; }
            public float timeSpentAsDriver { get; set; }
            public float bombDetonated { get; set; }
            public float arHeadshots { get; set; }
            public float timeOnPoint { get; set; }
            public float lmgKills { get; set; }
            public float killstreakUAVAssists { get; set; }
            public float carepackagesCaptured { get; set; }
            public float mostKillsLongestStreak { get; set; }
            public float killstreakCruiseMissileKills { get; set; }
            public float longestStreak { get; set; }
            public float destroyedKillstreaks { get; set; }
            public float hipfireKills { get; set; }
            public float stimDamageHealed { get; set; }
            public float skippedKillcams { get; set; }
            public float leastAssists { get; set; }
            public float mostMultikills { get; set; }
            public float highestRankedKills { get; set; }
            public float killstreakAirstrikeKills { get; set; }
            public float distanceTravelled { get; set; }
            public float killstreakKills { get; set; }
            public float semtexKills { get; set; }
            public float penetrationKills { get; set; }
            public float explosionsSurvived { get; set; }
            public float highestMultikill { get; set; }
            public float arDeaths { get; set; }
            public float longshotKills { get; set; }
            public float proximityMineKills { get; set; }
            public float tagsMegaBanked { get; set; }
            public float mostKillsMostHeadshots { get; set; }
            public float firstInfected { get; set; }
            public float killstreakCUAVAssists { get; set; }
            public float throwingKnifeKills { get; set; }
            public float executionKills { get; set; }
            public float lastSurvivor { get; set; }
            public float reconDroneMarks { get; set; }
            public float deadSilenceKills { get; set; }
            public float revengeKills { get; set; }
            public float infectedKills { get; set; }
            public float killEnemyTeam { get; set; }
            public float sniperKills { get; set; }
            public float killstreakCluserStrikeKills { get; set; }
            public float meleeDeaths { get; set; }
            public float timeWatchingKillcams { get; set; }
            public float killstreakTankKills { get; set; }
            public float noKillNoDeath { get; set; }
            public float shotgunDeaths { get; set; }
            public float killstreakChopperGunnerKills { get; set; }
            public float shotsFired { get; set; }
            public float stoppingPowerKills { get; set; }
            public float pistolPeaths { get; set; }
            public float killstreakShieldTurretKills { get; set; }
            public float timeCrouched { get; set; }
            public float noDeathsFromBehind { get; set; }
            public float bombPlanted { get; set; }
            public float setbacks { get; set; }
            public float smgKills { get; set; }
            public float claymoreKills { get; set; }
            public float kills10NoDeaths { get; set; }
            public float pistolHeadshots { get; set; }
            public float killstreakVTOLJetKills { get; set; }
            public float headshots { get; set; }
            public float mostDeaths { get; set; }
            public float adsKills { get; set; }
            public float empDroneHits { get; set; }
            public float defenderKills { get; set; }
            public float launcherHeadshots { get; set; }
            public float timesSelectedAsSquadLeader { get; set; }
            public float killstreakAirKills { get; set; }
            public float assaults { get; set; }
            public float fragKills { get; set; }
            public float killstreakEmergencyAirdropUsed { get; set; }
            public float captures { get; set; }
            public float killstreakChopperSupportKills { get; set; }
            public float spawnSelectBase { get; set; }
            public float noKill10Deaths { get; set; }
            public float leastDeaths { get; set; }
            public float killstreakSentryGunKills { get; set; }
            public float longestTimeSpentOnWeapon { get; set; }
            public float lowerRankedKills { get; set; }
            public float trophySystemHits { get; set; }
            public float clutchRevives { get; set; }
            public float lowestAvgAltitude { get; set; }
            public float pickups { get; set; }
            public float pistolKills { get; set; }
            public float reloads { get; set; }
        }

        public class Weekly
        {
            public All1 all { get; set; }
            public Mode1 mode { get; set; }
            public Map1 map { get; set; }
        }

        public class All1
        {
            public Properties132 properties { get; set; }
        }

        public class Properties132
        {
            public float kills { get; set; }
            public float objectiveTeamWiped { get; set; }
            public float objectiveLastStandKill { get; set; }
            public float objectiveAssistDecoy { get; set; }
            public float wallBangs { get; set; }
            public float avgLifeTime { get; set; }
            public float objectivePlunderCashBloodMoney { get; set; }
            public float score { get; set; }
            public float headshots { get; set; }
            public float assists { get; set; }
            public float objectiveDestroyedVehicleLight { get; set; }
            public float killsPerGame { get; set; }
            public float objectiveDestroyedVehicleMedium { get; set; }
            public float scorePerMinute { get; set; }
            public float distanceTraveled { get; set; }
            public float deaths { get; set; }
            public float objectiveDestroyedEquipment { get; set; }
            public float objectiveMunitionsBoxTeammateUsed { get; set; }
            public float objectiveBrDownEnemyCircle4 { get; set; }
            public float objectiveBrDownEnemyCircle3 { get; set; }
            public float objectiveMedalScoreSsKillPrecisionAirstrike { get; set; }
            public float objectiveBrDownEnemyCircle2 { get; set; }
            public float kdRatio { get; set; }
            public float objectiveBrDownEnemyCircle1 { get; set; }
            public float objectiveBrMissionPickupTablet { get; set; }
            public float objectiveReviver { get; set; }
            public float objectiveBrKioskBuy { get; set; }
            public float gulagDeaths { get; set; }
            public float objectiveBrDownEnemyCircle6 { get; set; }
            public float objectiveBrDownEnemyCircle5 { get; set; }
            public float timePlayed { get; set; }
            public float headshotPercentage { get; set; }
            public float executions { get; set; }
            public float matchesPlayed { get; set; }
            public float gulagKills { get; set; }
            public float nearmisses { get; set; }
            public float objectiveBrCacheOpen { get; set; }
            public float damageDone { get; set; }
            public float damageTaken { get; set; }
        }

        public class Mode1
        {
            public Br_Dmz_Plndtrios br_dmz_plndtrios { get; set; }
            public Br_Rebirth_Rbrthquad br_rebirth_rbrthquad { get; set; }
            public Br_Brtrios br_brtrios { get; set; }
            public Br_All1 br_all { get; set; }
            public Br_Rebirth_Rbrthtrios br_rebirth_rbrthtrios { get; set; }
            public Br_Brduos br_brduos { get; set; }
            public Br_Brquads br_brquads { get; set; }
        }

        public class Br_Dmz_Plndtrios
        {
            public Properties133 properties { get; set; }
        }

        public class Properties133
        {
            public float kills { get; set; }
            public float objectiveTeamWiped { get; set; }
            public float objectiveLastStandKill { get; set; }
            public float wallBangs { get; set; }
            public float avgLifeTime { get; set; }
            public float objectivePlunderCashBloodMoney { get; set; }
            public float score { get; set; }
            public float headshots { get; set; }
            public float assists { get; set; }
            public float killsPerGame { get; set; }
            public float scorePerMinute { get; set; }
            public float distanceTraveled { get; set; }
            public float deaths { get; set; }
            public float kdRatio { get; set; }
            public float objectiveBrMissionPickupTablet { get; set; }
            public float objectiveReviver { get; set; }
            public float scorePerGame { get; set; }
            public float timePlayed { get; set; }
            public float headshotPercentage { get; set; }
            public float executions { get; set; }
            public float matchesPlayed { get; set; }
            public float nearmisses { get; set; }
            public float objectiveBrCacheOpen { get; set; }
            public float damageDone { get; set; }
            public float damageTaken { get; set; }
        }

        public class Br_Rebirth_Rbrthquad
        {
            public Properties134 properties { get; set; }
        }

        public class Properties134
        {
            public float kills { get; set; }
            public float objectiveLastStandKill { get; set; }
            public float wallBangs { get; set; }
            public float avgLifeTime { get; set; }
            public float score { get; set; }
            public float headshots { get; set; }
            public float assists { get; set; }
            public float killsPerGame { get; set; }
            public float scorePerMinute { get; set; }
            public float distanceTraveled { get; set; }
            public float deaths { get; set; }
            public float objectiveBrDownEnemyCircle3 { get; set; }
            public float objectiveBrDownEnemyCircle2 { get; set; }
            public float kdRatio { get; set; }
            public float objectiveBrDownEnemyCircle1 { get; set; }
            public float objectiveBrMissionPickupTablet { get; set; }
            public float objectiveReviver { get; set; }
            public float scorePerGame { get; set; }
            public float objectiveBrKioskBuy { get; set; }
            public float gulagDeaths { get; set; }
            public float timePlayed { get; set; }
            public float headshotPercentage { get; set; }
            public float executions { get; set; }
            public float matchesPlayed { get; set; }
            public float gulagKills { get; set; }
            public float nearmisses { get; set; }
            public float objectiveBrCacheOpen { get; set; }
            public float damageDone { get; set; }
            public float damageTaken { get; set; }
        }

        public class Br_Brtrios
        {
            public Properties135 properties { get; set; }
        }

        public class Properties135
        {
            public float kills { get; set; }
            public float objectiveTeamWiped { get; set; }
            public float objectiveLastStandKill { get; set; }
            public float wallBangs { get; set; }
            public float avgLifeTime { get; set; }
            public float score { get; set; }
            public float headshots { get; set; }
            public float assists { get; set; }
            public float killsPerGame { get; set; }
            public float scorePerMinute { get; set; }
            public float distanceTraveled { get; set; }
            public float deaths { get; set; }
            public float kdRatio { get; set; }
            public float objectiveBrDownEnemyCircle1 { get; set; }
            public float objectiveBrMissionPickupTablet { get; set; }
            public float scorePerGame { get; set; }
            public float objectiveBrKioskBuy { get; set; }
            public float gulagDeaths { get; set; }
            public float timePlayed { get; set; }
            public float headshotPercentage { get; set; }
            public float executions { get; set; }
            public float matchesPlayed { get; set; }
            public float gulagKills { get; set; }
            public float nearmisses { get; set; }
            public float objectiveBrCacheOpen { get; set; }
            public float damageDone { get; set; }
            public float damageTaken { get; set; }
        }

        public class Br_All1
        {
            public Properties136 properties { get; set; }
        }

        public class Properties136
        {
            public float kills { get; set; }
            public float objectiveTeamWiped { get; set; }
            public float objectiveLastStandKill { get; set; }
            public float objectiveAssistDecoy { get; set; }
            public float wallBangs { get; set; }
            public float avgLifeTime { get; set; }
            public float objectivePlunderCashBloodMoney { get; set; }
            public float score { get; set; }
            public float headshots { get; set; }
            public float assists { get; set; }
            public float objectiveDestroyedVehicleLight { get; set; }
            public float killsPerGame { get; set; }
            public float objectiveDestroyedVehicleMedium { get; set; }
            public float scorePerMinute { get; set; }
            public float distanceTraveled { get; set; }
            public float deaths { get; set; }
            public float objectiveDestroyedEquipment { get; set; }
            public float objectiveMunitionsBoxTeammateUsed { get; set; }
            public float objectiveBrDownEnemyCircle4 { get; set; }
            public float objectiveBrDownEnemyCircle3 { get; set; }
            public float objectiveMedalScoreSsKillPrecisionAirstrike { get; set; }
            public float objectiveBrDownEnemyCircle2 { get; set; }
            public float kdRatio { get; set; }
            public float objectiveBrDownEnemyCircle1 { get; set; }
            public float objectiveBrMissionPickupTablet { get; set; }
            public float objectiveReviver { get; set; }
            public float objectiveBrKioskBuy { get; set; }
            public float gulagDeaths { get; set; }
            public float objectiveBrDownEnemyCircle6 { get; set; }
            public float objectiveBrDownEnemyCircle5 { get; set; }
            public float timePlayed { get; set; }
            public float headshotPercentage { get; set; }
            public float executions { get; set; }
            public float matchesPlayed { get; set; }
            public float gulagKills { get; set; }
            public float nearmisses { get; set; }
            public float objectiveBrCacheOpen { get; set; }
            public float damageDone { get; set; }
            public float damageTaken { get; set; }
        }

        public class Br_Rebirth_Rbrthtrios
        {
            public Properties137 properties { get; set; }
        }

        public class Properties137
        {
            public float kills { get; set; }
            public float objectiveTeamWiped { get; set; }
            public float objectiveLastStandKill { get; set; }
            public float wallBangs { get; set; }
            public float avgLifeTime { get; set; }
            public float score { get; set; }
            public float headshots { get; set; }
            public float assists { get; set; }
            public float killsPerGame { get; set; }
            public float scorePerMinute { get; set; }
            public float distanceTraveled { get; set; }
            public float deaths { get; set; }
            public float objectiveDestroyedEquipment { get; set; }
            public float objectiveBrDownEnemyCircle4 { get; set; }
            public float objectiveBrDownEnemyCircle3 { get; set; }
            public float objectiveBrDownEnemyCircle2 { get; set; }
            public float kdRatio { get; set; }
            public float objectiveBrDownEnemyCircle1 { get; set; }
            public float objectiveBrMissionPickupTablet { get; set; }
            public float objectiveReviver { get; set; }
            public float scorePerGame { get; set; }
            public float gulagDeaths { get; set; }
            public float timePlayed { get; set; }
            public float headshotPercentage { get; set; }
            public float executions { get; set; }
            public float matchesPlayed { get; set; }
            public float gulagKills { get; set; }
            public float nearmisses { get; set; }
            public float objectiveBrCacheOpen { get; set; }
            public float damageDone { get; set; }
            public float damageTaken { get; set; }
        }

        public class Br_Brduos
        {
            public Properties138 properties { get; set; }
        }

        public class Properties138
        {
            public float kills { get; set; }
            public float objectiveTeamWiped { get; set; }
            public float objectiveLastStandKill { get; set; }
            public float objectiveAssistDecoy { get; set; }
            public float wallBangs { get; set; }
            public float avgLifeTime { get; set; }
            public float score { get; set; }
            public float headshots { get; set; }
            public float assists { get; set; }
            public float killsPerGame { get; set; }
            public float objectiveDestroyedVehicleMedium { get; set; }
            public float scorePerMinute { get; set; }
            public float distanceTraveled { get; set; }
            public float deaths { get; set; }
            public float objectiveMunitionsBoxTeammateUsed { get; set; }
            public float objectiveMedalScoreSsKillPrecisionAirstrike { get; set; }
            public float objectiveBrDownEnemyCircle3 { get; set; }
            public float objectiveBrDownEnemyCircle2 { get; set; }
            public float kdRatio { get; set; }
            public float objectiveBrDownEnemyCircle1 { get; set; }
            public float objectiveBrMissionPickupTablet { get; set; }
            public float objectiveReviver { get; set; }
            public float scorePerGame { get; set; }
            public float objectiveBrKioskBuy { get; set; }
            public float gulagDeaths { get; set; }
            public float objectiveBrDownEnemyCircle6 { get; set; }
            public float objectiveBrDownEnemyCircle5 { get; set; }
            public float timePlayed { get; set; }
            public float headshotPercentage { get; set; }
            public float executions { get; set; }
            public float matchesPlayed { get; set; }
            public float gulagKills { get; set; }
            public float nearmisses { get; set; }
            public float objectiveBrCacheOpen { get; set; }
            public float damageDone { get; set; }
            public float damageTaken { get; set; }
        }

        public class Br_Brquads
        {
            public Properties139 properties { get; set; }
        }

        public class Properties139
        {
            public float kills { get; set; }
            public float objectiveTeamWiped { get; set; }
            public float objectiveLastStandKill { get; set; }
            public float wallBangs { get; set; }
            public float avgLifeTime { get; set; }
            public float score { get; set; }
            public float headshots { get; set; }
            public float assists { get; set; }
            public float objectiveDestroyedVehicleLight { get; set; }
            public float killsPerGame { get; set; }
            public float scorePerMinute { get; set; }
            public float distanceTraveled { get; set; }
            public float deaths { get; set; }
            public float objectiveMunitionsBoxTeammateUsed { get; set; }
            public float objectiveBrDownEnemyCircle2 { get; set; }
            public float kdRatio { get; set; }
            public float objectiveBrDownEnemyCircle1 { get; set; }
            public float objectiveBrMissionPickupTablet { get; set; }
            public float objectiveReviver { get; set; }
            public float scorePerGame { get; set; }
            public float objectiveBrKioskBuy { get; set; }
            public float gulagDeaths { get; set; }
            public float timePlayed { get; set; }
            public float headshotPercentage { get; set; }
            public float executions { get; set; }
            public float matchesPlayed { get; set; }
            public float gulagKills { get; set; }
            public float nearmisses { get; set; }
            public float objectiveBrCacheOpen { get; set; }
            public float damageDone { get; set; }
            public float damageTaken { get; set; }
        }
        public class Map1 { }
    }

    public class BRInfo
    {
        public Info br { get; set; }
        public Info plunder { get; set; }
        public Info all { get; set; }

        public class Info
        {
            public float wins { get; set; }
            public float kills { get; set; }
            public float kdRatio { get; set; }
            public float downs { get; set; }
            public float topTwentyFive { get; set; }
            public float topTen { get; set; }
            public float contracts { get; set; }
            public float revives { get; set; }
            public float topFive { get; set; }
            public float score { get; set; }
            public float timePlayed { get; set; }
            public float gamesPlayed { get; set; }
            public float tokens { get; set; }
            public float scorePerMinute { get; set; }
            public float cash { get; set; }
            public float deaths { get; set; }
        }
    }

    public class BPInfo : baseResponse
    {
        public new Data data { get; set; }
        public new class Data
        {
            public Streams streams { get; set; }
            public class Streams
            {
                public Loot loot_season_0 { get; set; }
                public Loot loot_season_1 { get; set; }
                public Loot loot_season_2 { get; set; }
                public Loot loot_season_3 { get; set; }
                public Loot loot_season_4 { get; set; }
                public Loot loot_season_5 { get; set; }
                public Loot loot_season_6 { get; set; }
                public Loot loot_season_7 { get; set; }

                public class Loot
                {
                    public string name { get; set; }
                    public string categoryNameLabel { get; set; }
                    public string categoryTitleLabel { get; set; }
                    public int tier { get; set; }
                    public string streamType { get; set; }
                    public object rarity { get; set; }
                    public object lootType { get; set; }
                    public string seasonInfoUrlKey { get; set; }
                    public object itemsObtained { get; set; }
                    public bool premiumTokenOwnedNotRedeemed { get; set; }
                    public object tierSkipTokensUnredeemed { get; set; }
                    public bool premium { get; set; }
                }
            }
        }
    }

    public class Analysis : baseResponse
    {
        public new Datum[] data { get; set; }
        public class Datum
        {
            public Payload payLoad { get; set; }

            public class Payload
            {
                public string team1Score { get; set; }
                public string winningTeam { get; set; }
                public string matchXp { get; set; }
                public string scoreXp { get; set; }
                public string accuracy { get; set; }
                public string arena { get; set; }
                public string shotsLanded { get; set; }
                public string mode { get; set; }
                public string isPresentAtEnd { get; set; }
                public string score { get; set; }
                public string totalXp { get; set; }
                public string game_name { get; set; }
                public string gameBattle { get; set; }
                public string rank { get; set; }
                public string deaths { get; set; }
                public string privateMatch { get; set; }
                public string kdRatio { get; set; }
                public string shotsMissed { get; set; }
                public string utcStartSeconds { get; set; }
                public string map_name { get; set; }
                public string version { get; set; }
                public string team2Score { get; set; }
                public string allPlayers { get; set; }
                public string timePlayed { get; set; }
                public string suicides { get; set; }
                public string percentTimeMoving { get; set; }
                public string damageDone { get; set; }
                public string shotsFired { get; set; }
                public string matchID { get; set; }
                public string kills { get; set; }
                public string medalXp { get; set; }
                public string gameType { get; set; }
                public string averageSpeedDuringMatch { get; set; }
                public string utcEndSeconds { get; set; }
                public string game_type { get; set; }
                public string duration { get; set; }
                public string result { get; set; }
                public string headshots { get; set; }
                public string assists { get; set; }
                public string scorePerMinute { get; set; }
                public string place { get; set; }
                public string mode_name { get; set; }
                public string distanceTraveled { get; set; }
                public string map { get; set; }
                public string player { get; set; }
                public string weaponStats { get; set; }
                public string playlistName { get; set; }
                public string executions { get; set; }
                public string seasonRank { get; set; }
                public string miscXp { get; set; }
                public string longestStreak { get; set; }
                public string damageTaken { get; set; }
                public string objectiveMedalModeXDefendScore { get; set; }
                public string objectiveMedalModeXAssaultScore { get; set; }
                public string objectiveMedalModeDomSecureScore { get; set; }
                public string objectiveMedalModeDomSecureAssistScore { get; set; }
                public string objectiveMedalModeDomSecureNeutralScore { get; set; }
                public string objectiveObjProgDefend { get; set; }
                public string objectiveUavAssist { get; set; }
                public string objectiveCaptureKill { get; set; }
                public string objectiveMedalModeHpSecureScore { get; set; }
                public string objectiveKothInObj { get; set; }
            }
        }
    }

    public class MWMapList : baseResponse
    {
        public new Data data { get; set; }
        public new class Data
        {
            public string[] mp_cave_am { get; set; }
            public string[] mp_farms2_gw { get; set; }
            public string[] mp_spear { get; set; }
            public string[] mp_m_stadium { get; set; }
            public string[] mp_m_showers { get; set; }
            public string[] mp_promenade_gw { get; set; }
            public string[] mp_riverside_gw { get; set; }
            public string[] mp_runner { get; set; }
            public string[] mp_spear_pm { get; set; }
            public string[] mp_vacant { get; set; }
            public string[] mp_hackney_am { get; set; }
            public string[] mp_rust { get; set; }
            public string[] mp_shipment { get; set; }
            public string[] mp_m_cornfield { get; set; }
            public string[] mp_hackney_yard { get; set; }
            public string[] mp_m_pine { get; set; }
            public string[] mp_m_train { get; set; }
            public string[] mp_hideout { get; set; }
            public string[] mp_m_wallco2 { get; set; }
            public string[] mp_layover_gw { get; set; }
            public string[] mp_quarry2 { get; set; }
            public string[] mp_m_overwinter { get; set; }
            public string[] mp_cave { get; set; }
            public string[] mp_village2 { get; set; }
            public string[] mp_m_speed { get; set; }
            public string[] mp_boneyard_gw { get; set; }
            public string[] mp_malyshev { get; set; }
            public string[] mp_petrograd { get; set; }
            public string[] mp_raid { get; set; }
            public string[] mp_harbor { get; set; }
            public string[] mp_broadcast2 { get; set; }
            public string[] mp_m_speedball { get; set; }
            public string[] mp_garden { get; set; }
            public string[] mp_m_king { get; set; }
            public string[] mp_aniyah_tac { get; set; }
            public string[] mp_m_cargo { get; set; }
            public string[] mp_euphrates { get; set; }
            public string[] mp_downtown_gw { get; set; }
            public string[] mp_backlot2 { get; set; }
            public string[] mp_scrapyard { get; set; }
            public string[] mp_deadzone { get; set; }
            public string[] mp_m_overunder { get; set; }
            public string[] mp_oilrig { get; set; }
            public string[] mp_piccadilly { get; set; }
            public string[] mp_m_trench { get; set; }
            public string[] mp_emporium { get; set; }
            public string[] mp_m_stack { get; set; }
            public string[] mp_m_cage { get; set; }
            public string[] mp_runner_pm { get; set; }
            public string[] mp_m_hill { get; set; }
            public string[] mp_m_fork { get; set; }
            public string[] mp_port2_gw { get; set; }
            public string[] mp_aniyah { get; set; }
            public string[] mp_crash2 { get; set; }
            public string[] mp_hardhat { get; set; }
        }
    }

    public class MatchInfo : baseResponse
    {
        public new Datum[] data { get; set; }
        public class Datum
        {
            public string platform { get; set; }
            public string title { get; set; }
            public long timestamp { get; set; }
            public string type { get; set; }
            public string matchId { get; set; }
            public string map { get; set; }
        }
    }

    public class DetailedMatchInfo : baseResponse
    {
        public new Data data { get; set; }

        public new class Data
        {
            public Summary summary { get; set; }
            public Match[] matches { get; set; }

            public class Summary
            {
                public All all { get; set; }
                public Br_Dmz_Plndtrios br_dmz_plndtrios { get; set; }
                public Br_Rebirth_Rbrthquad br_rebirth_rbrthquad { get; set; }
                public Br_Brtrios br_brtrios { get; set; }
                public Br_Rebirth_Rbrthtrios br_rebirth_rbrthtrios { get; set; }
                public Br_Brduos br_brduos { get; set; }

                public class All
                {
                    public float kills { get; set; }
                    public float objectiveTeamWiped { get; set; }
                    public float objectiveLastStandKill { get; set; }
                    public float wallBangs { get; set; }
                    public float avgLifeTime { get; set; }
                    public float objectivePlunderCashBloodMoney { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float killsPerGame { get; set; }
                    public float scorePerMinute { get; set; }
                    public float distanceTraveled { get; set; }
                    public float deaths { get; set; }
                    public float objectiveDestroyedEquipment { get; set; }
                    public float objectiveMunitionsBoxTeammateUsed { get; set; }
                    public float objectiveBrDownEnemyCircle4 { get; set; }
                    public float objectiveBrDownEnemyCircle3 { get; set; }
                    public float objectiveMedalScoreSsKillPrecisionAirstrike { get; set; }
                    public float objectiveBrDownEnemyCircle2 { get; set; }
                    public float kdRatio { get; set; }
                    public float objectiveBrDownEnemyCircle1 { get; set; }
                    public float objectiveBrMissionPickupTablet { get; set; }
                    public float objectiveReviver { get; set; }
                    public float objectiveBrKioskBuy { get; set; }
                    public float gulagDeaths { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float executions { get; set; }
                    public float matchesPlayed { get; set; }
                    public float gulagKills { get; set; }
                    public float nearmisses { get; set; }
                    public float objectiveBrCacheOpen { get; set; }
                    public float damageDone { get; set; }
                    public float damageTaken { get; set; }
                }

                public class Br_Dmz_Plndtrios
                {
                    public float kills { get; set; }
                    public float objectiveTeamWiped { get; set; }
                    public float objectiveLastStandKill { get; set; }
                    public float kdRatio { get; set; }
                    public float objectiveBrMissionPickupTablet { get; set; }
                    public float scorePerGame { get; set; }
                    public float wallBangs { get; set; }
                    public float avgLifeTime { get; set; }
                    public float objectivePlunderCashBloodMoney { get; set; }
                    public float score { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float headshots { get; set; }
                    public float executions { get; set; }
                    public float matchesPlayed { get; set; }
                    public float assists { get; set; }
                    public float nearmisses { get; set; }
                    public float objectiveBrCacheOpen { get; set; }
                    public float killsPerGame { get; set; }
                    public float scorePerMinute { get; set; }
                    public float distanceTraveled { get; set; }
                    public float damageDone { get; set; }
                    public float deaths { get; set; }
                    public float damageTaken { get; set; }
                }

                public class Br_Rebirth_Rbrthquad
                {
                    public float kills { get; set; }
                    public float objectiveLastStandKill { get; set; }
                    public float wallBangs { get; set; }
                    public float avgLifeTime { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float killsPerGame { get; set; }
                    public float scorePerMinute { get; set; }
                    public float distanceTraveled { get; set; }
                    public float deaths { get; set; }
                    public float objectiveBrDownEnemyCircle3 { get; set; }
                    public float objectiveBrDownEnemyCircle2 { get; set; }
                    public float kdRatio { get; set; }
                    public float objectiveBrDownEnemyCircle1 { get; set; }
                    public float objectiveBrMissionPickupTablet { get; set; }
                    public float scorePerGame { get; set; }
                    public float objectiveBrKioskBuy { get; set; }
                    public float gulagDeaths { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float executions { get; set; }
                    public float matchesPlayed { get; set; }
                    public float gulagKills { get; set; }
                    public float nearmisses { get; set; }
                    public float objectiveBrCacheOpen { get; set; }
                    public float damageDone { get; set; }
                    public float damageTaken { get; set; }
                }

                public class Br_Brtrios
                {
                    public float kills { get; set; }
                    public float kdRatio { get; set; }
                    public float objectiveBrMissionPickupTablet { get; set; }
                    public float scorePerGame { get; set; }
                    public float objectiveBrKioskBuy { get; set; }
                    public float wallBangs { get; set; }
                    public float avgLifeTime { get; set; }
                    public float gulagDeaths { get; set; }
                    public float score { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float headshots { get; set; }
                    public float executions { get; set; }
                    public float matchesPlayed { get; set; }
                    public float assists { get; set; }
                    public float gulagKills { get; set; }
                    public float nearmisses { get; set; }
                    public float objectiveBrCacheOpen { get; set; }
                    public float killsPerGame { get; set; }
                    public float scorePerMinute { get; set; }
                    public float distanceTraveled { get; set; }
                    public float damageDone { get; set; }
                    public float deaths { get; set; }
                    public float damageTaken { get; set; }
                }

                public class Br_Rebirth_Rbrthtrios
                {
                    public float kills { get; set; }
                    public float objectiveTeamWiped { get; set; }
                    public float objectiveLastStandKill { get; set; }
                    public float wallBangs { get; set; }
                    public float avgLifeTime { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float killsPerGame { get; set; }
                    public float scorePerMinute { get; set; }
                    public float distanceTraveled { get; set; }
                    public float deaths { get; set; }
                    public float objectiveDestroyedEquipment { get; set; }
                    public float objectiveBrDownEnemyCircle4 { get; set; }
                    public float objectiveBrDownEnemyCircle3 { get; set; }
                    public float objectiveBrDownEnemyCircle2 { get; set; }
                    public float kdRatio { get; set; }
                    public float objectiveBrDownEnemyCircle1 { get; set; }
                    public float objectiveBrMissionPickupTablet { get; set; }
                    public float objectiveReviver { get; set; }
                    public float scorePerGame { get; set; }
                    public float gulagDeaths { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float executions { get; set; }
                    public float matchesPlayed { get; set; }
                    public float gulagKills { get; set; }
                    public float nearmisses { get; set; }
                    public float objectiveBrCacheOpen { get; set; }
                    public float damageDone { get; set; }
                    public float damageTaken { get; set; }
                }

                public class Br_Brduos
                {
                    public float kills { get; set; }
                    public float objectiveTeamWiped { get; set; }
                    public float objectiveLastStandKill { get; set; }
                    public float wallBangs { get; set; }
                    public float avgLifeTime { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float killsPerGame { get; set; }
                    public float scorePerMinute { get; set; }
                    public float distanceTraveled { get; set; }
                    public float deaths { get; set; }
                    public float objectiveMunitionsBoxTeammateUsed { get; set; }
                    public float objectiveMedalScoreSsKillPrecisionAirstrike { get; set; }
                    public float objectiveBrDownEnemyCircle3 { get; set; }
                    public float objectiveBrDownEnemyCircle2 { get; set; }
                    public float kdRatio { get; set; }
                    public float objectiveBrDownEnemyCircle1 { get; set; }
                    public float objectiveBrMissionPickupTablet { get; set; }
                    public float scorePerGame { get; set; }
                    public float objectiveBrKioskBuy { get; set; }
                    public float gulagDeaths { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float executions { get; set; }
                    public float matchesPlayed { get; set; }
                    public float gulagKills { get; set; }
                    public float nearmisses { get; set; }
                    public float objectiveBrCacheOpen { get; set; }
                    public float damageDone { get; set; }
                    public float damageTaken { get; set; }
                }
            }

            public class Match
            {
                public int utcStartSeconds { get; set; }
                public int utcEndSeconds { get; set; }
                public string map { get; set; }
                public string mode { get; set; }
                public string matchID { get; set; }
                public int duration { get; set; }
                public object playlistName { get; set; }
                public int version { get; set; }
                public string gameType { get; set; }
                public int playerCount { get; set; }
                public Playerstats playerStats { get; set; }
                public Player player { get; set; }
                public int teamCount { get; set; }
                public object rankedTeams { get; set; }
                public bool draw { get; set; }
                public bool privateMatch { get; set; }

                public class Playerstats
                {
                    public float kills { get; set; }
                    public float medalXp { get; set; }
                    public float objectiveTeamWiped { get; set; }
                    public float objectiveLastStandKill { get; set; }
                    public float matchXp { get; set; }
                    public float scoreXp { get; set; }
                    public float wallBangs { get; set; }
                    public float score { get; set; }
                    public float totalXp { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float challengeXp { get; set; }
                    public float rank { get; set; }
                    public float scorePerMinute { get; set; }
                    public float distanceTraveled { get; set; }
                    public float teamSurvivalTime { get; set; }
                    public float deaths { get; set; }
                    public float objectiveDestroyedEquipment { get; set; }
                    public float objectiveBrDownEnemyCircle4 { get; set; }
                    public float objectiveBrDownEnemyCircle3 { get; set; }
                    public float kdRatio { get; set; }
                    public float objectiveBrDownEnemyCircle2 { get; set; }
                    public float objectiveBrDownEnemyCircle1 { get; set; }
                    public float objectiveBrMissionPickupTablet { get; set; }
                    public float bonusXp { get; set; }
                    public float objectiveReviver { get; set; }
                    public float gulagDeaths { get; set; }
                    public float timePlayed { get; set; }
                    public float executions { get; set; }
                    public float gulagKills { get; set; }
                    public float nearmisses { get; set; }
                    public float objectiveBrCacheOpen { get; set; }
                    public float percentTimeMoving { get; set; }
                    public float miscXp { get; set; }
                    public float longestStreak { get; set; }
                    public float teamPlacement { get; set; }
                    public float damageDone { get; set; }
                    public float damageTaken { get; set; }
                    public float objectiveBrKioskBuy { get; set; }
                    public float objectiveMunitionsBoxTeammateUsed { get; set; }
                    public float objectiveMedalScoreSsKillPrecisionAirstrike { get; set; }
                    public float objectivePlunderCashBloodMoney { get; set; }
                }

                public class Player
                {
                    public string team { get; set; }
                    public float rank { get; set; }
                    public Awards awards { get; set; }
                    public string username { get; set; }
                    public string uno { get; set; }
                    public string clantag { get; set; }
                    public Brmissionstats brMissionStats { get; set; }
                    public Loadout[] loadout { get; set; }

                    public class Awards { }

                    public class Brmissionstats
                    {
                        public int missionsComplete { get; set; }
                        public float totalMissionXpEarned { get; set; }
                        public float totalMissionWeaponXpEarned { get; set; }
                        public Missionstatsbytype missionStatsByType { get; set; }

                        public class Missionstatsbytype
                        {
                            public missionData domination { get; set; }
                            public missionData assassination { get; set; }
                            public missionData timedrun { get; set; }

                            public class missionData
                            {
                                public float weaponXp { get; set; }
                                public float xp { get; set; }
                                public float count { get; set; }
                            }
                        }
                    }

                    public class Loadout
                    {
                        public Primaryweapon primaryWeapon { get; set; }
                        public Secondaryweapon secondaryWeapon { get; set; }
                        public Perk[] perks { get; set; }
                        public Extraperk[] extraPerks { get; set; }
                        public Killstreak[] killstreaks { get; set; }
                        public Tactical tactical { get; set; }
                        public Lethal lethal { get; set; }

                        public class Primaryweapon
                        {
                            public string name { get; set; }
                            public object label { get; set; }
                            public object imageLoot { get; set; }
                            public object imageIcon { get; set; }
                            public string variant { get; set; }
                            public Attachment[] attachments { get; set; }
                        }

                        public class Secondaryweapon
                        {
                            public string name { get; set; }
                            public object label { get; set; }
                            public object imageLoot { get; set; }
                            public object imageIcon { get; set; }
                            public string variant { get; set; }
                            public Attachment[] attachments { get; set; }
                        }

                        public class Tactical
                        {
                            public string name { get; set; }
                            public object label { get; set; }
                            public object image { get; set; }
                            public object imageLarge { get; set; }
                            public object progressionImage { get; set; }
                        }

                        public class Lethal
                        {
                            public string name { get; set; }
                            public object label { get; set; }
                            public object image { get; set; }
                            public object imageLarge { get; set; }
                            public object progressionImage { get; set; }
                        }

                        public class Perk
                        {
                            public string name { get; set; }
                            public object label { get; set; }
                            public object image { get; set; }
                            public object imageMainUi { get; set; }
                            public object imageProgression { get; set; }
                        }

                        public class Extraperk
                        {
                            public string name { get; set; }
                            public object label { get; set; }
                            public object image { get; set; }
                            public object imageMainUi { get; set; }
                            public object imageProgression { get; set; }
                        }

                        public class Killstreak
                        {
                            public string name { get; set; }
                            public object label { get; set; }
                        }

                        public class Attachment
                        {
                            public string name { get; set; }
                            public object label { get; set; }
                            public object image { get; set; }
                            public object category { get; set; }
                        }
                    }
                }
            }
        }
    }

    public class FullMatchData : baseResponse
    {
        public new Data data { get; set; }

        public new class Data
        {
            public Allplayer[] allPlayers { get; set; }
            public class Allplayer
            {
                public int utcStartSeconds { get; set; }
                public int utcEndSeconds { get; set; }
                public string map { get; set; }
                public string mode { get; set; }
                public string matchID { get; set; }
                public int duration { get; set; }
                public object playlistName { get; set; }
                public int version { get; set; }
                public string gameType { get; set; }
                public int playerCount { get; set; }
                public Playerstats playerStats { get; set; }
                public Player player { get; set; }
                public int teamCount { get; set; }
                public object rankedTeams { get; set; }
                public bool draw { get; set; }
                public bool privateMatch { get; set; }

                public class Playerstats
                {
                    public float kills { get; set; }
                    public float medalXp { get; set; }
                    public float objectiveLastStandKill { get; set; }
                    public float matchXp { get; set; }
                    public float scoreXp { get; set; }
                    public float wallBangs { get; set; }
                    public float score { get; set; }
                    public float totalXp { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float challengeXp { get; set; }
                    public float rank { get; set; }
                    public float scorePerMinute { get; set; }
                    public float distanceTraveled { get; set; }
                    public float teamSurvivalTime { get; set; }
                    public float deaths { get; set; }
                    public float kdRatio { get; set; }
                    public float objectiveBrDownEnemyCircle1 { get; set; }
                    public float objectiveBrMissionPickupTablet { get; set; }
                    public float bonusXp { get; set; }
                    public float objectiveBrKioskBuy { get; set; }
                    public float gulagDeaths { get; set; }
                    public float timePlayed { get; set; }
                    public float executions { get; set; }
                    public float gulagKills { get; set; }
                    public float nearmisses { get; set; }
                    public float objectiveBrCacheOpen { get; set; }
                    public float percentTimeMoving { get; set; }
                    public float miscXp { get; set; }
                    public float longestStreak { get; set; }
                    public float teamPlacement { get; set; }
                    public float damageDone { get; set; }
                    public float damageTaken { get; set; }
                    public float objectiveBrDownEnemyCircle2 { get; set; }
                    public float objectiveReviver { get; set; }
                    public float objectiveTeamWiped { get; set; }
                    public float objectiveDestroyedEquipment { get; set; }
                    public float objectiveMunitionsBoxTeammateUsed { get; set; }
                    public float objectiveBrDownEnemyCircle3 { get; set; }
                    public float objectiveBrDownEnemyCircle4 { get; set; }
                }

                public class Player
                {
                    public string team { get; set; }
                    public float rank { get; set; }
                    public Awards awards { get; set; }
                    public string username { get; set; }
                    public string uno { get; set; }
                    public Brmissionstats brMissionStats { get; set; }
                    public Loadout[] loadout { get; set; }
                    public string clantag { get; set; }

                    public class Awards { }

                    public class Brmissionstats
                    {
                        public int missionsComplete { get; set; }
                        public float totalMissionXpEarned { get; set; }
                        public float totalMissionWeaponXpEarned { get; set; }
                        public Missionstatsbytype missionStatsByType { get; set; }

                        public class Missionstatsbytype
                        {
                            public missionData assassination { get; set; }
                            public missionData domination { get; set; }

                            public class missionData
                            {
                                public float weaponXp { get; set; }
                                public float xp { get; set; }
                                public float count { get; set; }
                            }
                        }
                    }

                    public class Loadout
                    {
                        public Primaryweapon primaryWeapon { get; set; }
                        public Secondaryweapon secondaryWeapon { get; set; }
                        public Perk[] perks { get; set; }
                        public Extraperk[] extraPerks { get; set; }
                        public Killstreak[] killstreaks { get; set; }
                        public Tactical tactical { get; set; }
                        public Lethal lethal { get; set; }
                    }

                    public class Primaryweapon
                    {
                        public string name { get; set; }
                        public object label { get; set; }
                        public object imageLoot { get; set; }
                        public object imageIcon { get; set; }
                        public string variant { get; set; }
                        public Attachment[] attachments { get; set; }
                    }

                    public class Secondaryweapon
                    {
                        public string name { get; set; }
                        public object label { get; set; }
                        public object imageLoot { get; set; }
                        public object imageIcon { get; set; }
                        public string variant { get; set; }
                        public Attachment[] attachments { get; set; }
                    }

                    public class Attachment
                    {
                        public string name { get; set; }
                        public object label { get; set; }
                        public object image { get; set; }
                        public object category { get; set; }
                    }

                    public class Tactical
                    {
                        public string name { get; set; }
                        public object label { get; set; }
                        public object image { get; set; }
                        public object imageLarge { get; set; }
                        public object progressionImage { get; set; }
                    }

                    public class Lethal
                    {
                        public string name { get; set; }
                        public object label { get; set; }
                        public object image { get; set; }
                        public object imageLarge { get; set; }
                        public object progressionImage { get; set; }
                    }

                    public class Perk
                    {
                        public string name { get; set; }
                        public object label { get; set; }
                        public object image { get; set; }
                        public object imageMainUi { get; set; }
                        public object imageProgression { get; set; }
                    }

                    public class Extraperk
                    {
                        public string name { get; set; }
                        public object label { get; set; }
                        public object image { get; set; }
                        public object imageMainUi { get; set; }
                        public object imageProgression { get; set; }
                    }

                    public class Killstreak
                    {
                        public string name { get; set; }
                        public object label { get; set; }
                    }
                }
            }
        }
    }

    public class CWStats : baseResponse
    {
        public new Data data { get; set; }

        public new class Data
        {
            public string title { get; set; }
            public string platform { get; set; }
            public string username { get; set; }
            public string type { get; set; }
            public float level { get; set; }
            public float maxLevel { get; set; }
            public float levelXpRemainder { get; set; }
            public float levelXpGained { get; set; }
            public float prestige { get; set; }
            public float prestigeId { get; set; }
            public float maxPrestige { get; set; }
            public float totalXp { get; set; }
            public float paragonRank { get; set; }
            public float paragonId { get; set; }
            public float s { get; set; }
            public float p { get; set; }
            public Lifetime lifetime { get; set; }
            public Weekly weekly { get; set; }
            public object engagement { get; set; }
        }

        public class Lifetime
        {
            public All all { get; set; }
            public Mode mode { get; set; }
            public Map map { get; set; }
            public Itemdata itemData { get; set; }
            public Itemdata.Attachmentdata attachmentData { get; set; }
            public Scorestreakdata scorestreakData { get; set; }

            public class All
            {
                public Properties properties { get; set; }
                public class Properties
                {
                    public float kills { get; set; }
                    public float kdratio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float accuracy { get; set; }
                    public float offends { get; set; }
                    public float losses { get; set; }
                    public float defuses { get; set; }
                    public float totalGamesPlayed { get; set; }
                    public float ekia { get; set; }
                    public float longestKillstreak { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float wlratio { get; set; }
                    public float assists { get; set; }
                    public float gamesPlayed { get; set; }
                    public float plants { get; set; }
                    public float misses { get; set; }
                    public float scorePerMinute { get; set; }
                    public float longestDistanceKill { get; set; }
                    public float deaths { get; set; }
                    public float wins { get; set; }
                    public float objectiveEkia { get; set; }
                    public float destructions { get; set; }
                    public float captures { get; set; }
                    public float scorePerGame { get; set; }
                    public float defends { get; set; }
                    public float curWinStreak { get; set; }
                    public float throws { get; set; }
                    public float disables { get; set; }
                    public float escorts { get; set; }
                    public float hits { get; set; }
                    public float carries { get; set; }
                    public float suicides { get; set; }
                    public float mostKillsInAGame { get; set; }
                    public float rankxp { get; set; }
                    public float mostDamageInAGame { get; set; }
                    public float returns { get; set; }
                    public float shots { get; set; }
                }
            }
            public class Mode
            {
                public Fireteam_Dirty_Bomb fireteam_dirty_bomb { get; set; }
                public Dom dom { get; set; }
                public Dm_Hc dm_hc { get; set; }
                public Conf_Hc conf_hc { get; set; }
                public Dom10v10 dom10v10 { get; set; }
                public Dm dm { get; set; }
                public Sd_Hc sd_hc { get; set; }
                public Conf conf { get; set; }
                public Koth koth { get; set; }
                public Control control { get; set; }
                public Dom_Hc dom_hc { get; set; }
                public Sd sd { get; set; }
                public War12v12 war12v12 { get; set; }
                public Dropkick dropkick { get; set; }
                public Tdm_Hc tdm_hc { get; set; }
                public Tdm tdm { get; set; }
                public Vip vip { get; set; }


                public class Fireteam_Dirty_Bomb
                {
                    public Properties1 properties { get; set; }
                }

                public class Properties1
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Dom
                {
                    public Properties2 properties { get; set; }
                }

                public class Properties2
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Dm_Hc
                {
                    public Properties3 properties { get; set; }
                }

                public class Properties3
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Conf_Hc
                {
                    public Properties4 properties { get; set; }
                }

                public class Properties4
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Dom10v10
                {
                    public Properties5 properties { get; set; }
                }

                public class Properties5
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Dm
                {
                    public Properties6 properties { get; set; }
                }

                public class Properties6
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Sd_Hc
                {
                    public Properties7 properties { get; set; }
                }

                public class Properties7
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Conf
                {
                    public Properties8 properties { get; set; }
                }

                public class Properties8
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Koth
                {
                    public Properties9 properties { get; set; }
                }

                public class Properties9
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Control
                {
                    public Properties10 properties { get; set; }
                }

                public class Properties10
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Dom_Hc
                {
                    public Properties11 properties { get; set; }
                }

                public class Properties11
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Sd
                {
                    public Properties12 properties { get; set; }
                }

                public class Properties12
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class War12v12
                {
                    public Properties13 properties { get; set; }
                }

                public class Properties13
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Dropkick
                {
                    public Properties14 properties { get; set; }
                }

                public class Properties14
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Tdm_Hc
                {
                    public Properties15 properties { get; set; }
                }

                public class Properties15
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Tdm
                {
                    public Properties16 properties { get; set; }
                }

                public class Properties16
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }

                public class Vip
                {
                    public Properties17 properties { get; set; }
                }

                public class Properties17
                {
                    public float wins { get; set; }
                    public float kills { get; set; }
                    public float objectiveScore { get; set; }
                    public float killStreak { get; set; }
                    public float kdRatio { get; set; }
                    public float ekiadRatio { get; set; }
                    public float timePlayedTotal { get; set; }
                    public float damagePerGame { get; set; }
                    public float defends { get; set; }
                    public float winStreak { get; set; }
                    public float offends { get; set; }
                    public float curWinStreak { get; set; }
                    public float losses { get; set; }
                    public float score { get; set; }
                    public float ekia { get; set; }
                    public float totalDamage { get; set; }
                    public float crush { get; set; }
                    public float wlRatio { get; set; }
                    public float ties { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                }
            }

            public class Map
            {
                public Mp_Miami mp_miami { get; set; }
                public Mp_Mall mp_mall { get; set; }
                public Mp_Sm_Finance mp_sm_finance { get; set; }
                public Wz_Ski_Slopes wz_ski_slopes { get; set; }
                public Mp_Sm_Berlin_Tunnel mp_sm_berlin_tunnel { get; set; }
                public Mp_Nuketown6 mp_nuketown6 { get; set; }
                public Mp_Satellite mp_satellite { get; set; }
                public Mp_Tundra mp_tundra { get; set; }
                public Mp_Sm_Game_Show mp_sm_game_show { get; set; }
                public Mp_Cartel mp_cartel { get; set; }
                public Mp_Tank mp_tank { get; set; }
                public Mp_Black_Sea mp_black_sea { get; set; }
                public Mp_Apocalypse mp_apocalypse { get; set; }
                public Mp_Sm_Central mp_sm_central { get; set; }
                public Wz_Forest wz_forest { get; set; }
                public Mp_Raid_Rm mp_raid_rm { get; set; }
                public Mp_Kgb mp_kgb { get; set; }
                public Mp_Moscow mp_moscow { get; set; }
            }

            public class Mp_Miami
            {
                public Fireteam_Dirty_Bomb1 fireteam_dirty_bomb { get; set; }
                public Dom1 dom { get; set; }
                public Dm_Hc1 dm_hc { get; set; }
                public Conf_Hc1 conf_hc { get; set; }
                public Dom10v101 dom10v10 { get; set; }
                public Dm1 dm { get; set; }
                public Sd_Hc1 sd_hc { get; set; }
                public Conf1 conf { get; set; }
                public Koth1 koth { get; set; }
                public Control1 control { get; set; }
                public Dom_Hc1 dom_hc { get; set; }
                public Sd1 sd { get; set; }
                public War12v121 war12v12 { get; set; }
                public Dropkick1 dropkick { get; set; }
                public Tdm_Hc1 tdm_hc { get; set; }
                public Tdm1 tdm { get; set; }
                public Vip1 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb1
            {
                public Properties18 properties { get; set; }
            }

            public class Properties18
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom1
            {
                public Properties19 properties { get; set; }
            }

            public class Properties19
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc1
            {
                public Properties20 properties { get; set; }
            }

            public class Properties20
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc1
            {
                public Properties21 properties { get; set; }
            }

            public class Properties21
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v101
            {
                public Properties22 properties { get; set; }
            }

            public class Properties22
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm1
            {
                public Properties23 properties { get; set; }
            }

            public class Properties23
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc1
            {
                public Properties24 properties { get; set; }
            }

            public class Properties24
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf1
            {
                public Properties25 properties { get; set; }
            }

            public class Properties25
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth1
            {
                public Properties26 properties { get; set; }
            }

            public class Properties26
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control1
            {
                public Properties27 properties { get; set; }
            }

            public class Properties27
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc1
            {
                public Properties28 properties { get; set; }
            }

            public class Properties28
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd1
            {
                public Properties29 properties { get; set; }
            }

            public class Properties29
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v121
            {
                public Properties30 properties { get; set; }
            }

            public class Properties30
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick1
            {
                public Properties31 properties { get; set; }
            }

            public class Properties31
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc1
            {
                public Properties32 properties { get; set; }
            }

            public class Properties32
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm1
            {
                public Properties33 properties { get; set; }
            }

            public class Properties33
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip1
            {
                public Properties34 properties { get; set; }
            }

            public class Properties34
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Mall
            {
                public Fireteam_Dirty_Bomb2 fireteam_dirty_bomb { get; set; }
                public Dom2 dom { get; set; }
                public Dm_Hc2 dm_hc { get; set; }
                public Conf_Hc2 conf_hc { get; set; }
                public Dom10v102 dom10v10 { get; set; }
                public Dm2 dm { get; set; }
                public Sd_Hc2 sd_hc { get; set; }
                public Conf2 conf { get; set; }
                public Koth2 koth { get; set; }
                public Control2 control { get; set; }
                public Dom_Hc2 dom_hc { get; set; }
                public Sd2 sd { get; set; }
                public War12v122 war12v12 { get; set; }
                public Dropkick2 dropkick { get; set; }
                public Tdm_Hc2 tdm_hc { get; set; }
                public Tdm2 tdm { get; set; }
                public Vip2 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb2
            {
                public Properties35 properties { get; set; }
            }

            public class Properties35
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom2
            {
                public Properties36 properties { get; set; }
            }

            public class Properties36
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc2
            {
                public Properties37 properties { get; set; }
            }

            public class Properties37
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc2
            {
                public Properties38 properties { get; set; }
            }

            public class Properties38
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v102
            {
                public Properties39 properties { get; set; }
            }

            public class Properties39
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm2
            {
                public Properties40 properties { get; set; }
            }

            public class Properties40
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc2
            {
                public Properties41 properties { get; set; }
            }

            public class Properties41
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf2
            {
                public Properties42 properties { get; set; }
            }

            public class Properties42
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth2
            {
                public Properties43 properties { get; set; }
            }

            public class Properties43
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control2
            {
                public Properties44 properties { get; set; }
            }

            public class Properties44
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc2
            {
                public Properties45 properties { get; set; }
            }

            public class Properties45
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd2
            {
                public Properties46 properties { get; set; }
            }

            public class Properties46
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v122
            {
                public Properties47 properties { get; set; }
            }

            public class Properties47
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick2
            {
                public Properties48 properties { get; set; }
            }

            public class Properties48
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc2
            {
                public Properties49 properties { get; set; }
            }

            public class Properties49
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm2
            {
                public Properties50 properties { get; set; }
            }

            public class Properties50
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip2
            {
                public Properties51 properties { get; set; }
            }

            public class Properties51
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Sm_Finance
            {
                public Fireteam_Dirty_Bomb3 fireteam_dirty_bomb { get; set; }
                public Dom3 dom { get; set; }
                public Dm_Hc3 dm_hc { get; set; }
                public Conf_Hc3 conf_hc { get; set; }
                public Dom10v103 dom10v10 { get; set; }
                public Dm3 dm { get; set; }
                public Sd_Hc3 sd_hc { get; set; }
                public Conf3 conf { get; set; }
                public Koth3 koth { get; set; }
                public Control3 control { get; set; }
                public Dom_Hc3 dom_hc { get; set; }
                public Sd3 sd { get; set; }
                public War12v123 war12v12 { get; set; }
                public Dropkick3 dropkick { get; set; }
                public Tdm_Hc3 tdm_hc { get; set; }
                public Tdm3 tdm { get; set; }
                public Vip3 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb3
            {
                public Properties52 properties { get; set; }
            }

            public class Properties52
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom3
            {
                public Properties53 properties { get; set; }
            }

            public class Properties53
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc3
            {
                public Properties54 properties { get; set; }
            }

            public class Properties54
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc3
            {
                public Properties55 properties { get; set; }
            }

            public class Properties55
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v103
            {
                public Properties56 properties { get; set; }
            }

            public class Properties56
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm3
            {
                public Properties57 properties { get; set; }
            }

            public class Properties57
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc3
            {
                public Properties58 properties { get; set; }
            }

            public class Properties58
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf3
            {
                public Properties59 properties { get; set; }
            }

            public class Properties59
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth3
            {
                public Properties60 properties { get; set; }
            }

            public class Properties60
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control3
            {
                public Properties61 properties { get; set; }
            }

            public class Properties61
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc3
            {
                public Properties62 properties { get; set; }
            }

            public class Properties62
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd3
            {
                public Properties63 properties { get; set; }
            }

            public class Properties63
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v123
            {
                public Properties64 properties { get; set; }
            }

            public class Properties64
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick3
            {
                public Properties65 properties { get; set; }
            }

            public class Properties65
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc3
            {
                public Properties66 properties { get; set; }
            }

            public class Properties66
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm3
            {
                public Properties67 properties { get; set; }
            }

            public class Properties67
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip3
            {
                public Properties68 properties { get; set; }
            }

            public class Properties68
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Wz_Ski_Slopes
            {
                public Fireteam_Dirty_Bomb4 fireteam_dirty_bomb { get; set; }
                public Dom4 dom { get; set; }
                public Dm_Hc4 dm_hc { get; set; }
                public Conf_Hc4 conf_hc { get; set; }
                public Dom10v104 dom10v10 { get; set; }
                public Dm4 dm { get; set; }
                public Sd_Hc4 sd_hc { get; set; }
                public Conf4 conf { get; set; }
                public Koth4 koth { get; set; }
                public Control4 control { get; set; }
                public Dom_Hc4 dom_hc { get; set; }
                public Sd4 sd { get; set; }
                public War12v124 war12v12 { get; set; }
                public Dropkick4 dropkick { get; set; }
                public Tdm_Hc4 tdm_hc { get; set; }
                public Tdm4 tdm { get; set; }
                public Vip4 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb4
            {
                public Properties69 properties { get; set; }
            }

            public class Properties69
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom4
            {
                public Properties70 properties { get; set; }
            }

            public class Properties70
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc4
            {
                public Properties71 properties { get; set; }
            }

            public class Properties71
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc4
            {
                public Properties72 properties { get; set; }
            }

            public class Properties72
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v104
            {
                public Properties73 properties { get; set; }
            }

            public class Properties73
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm4
            {
                public Properties74 properties { get; set; }
            }

            public class Properties74
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc4
            {
                public Properties75 properties { get; set; }
            }

            public class Properties75
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf4
            {
                public Properties76 properties { get; set; }
            }

            public class Properties76
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth4
            {
                public Properties77 properties { get; set; }
            }

            public class Properties77
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control4
            {
                public Properties78 properties { get; set; }
            }

            public class Properties78
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc4
            {
                public Properties79 properties { get; set; }
            }

            public class Properties79
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd4
            {
                public Properties80 properties { get; set; }
            }

            public class Properties80
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v124
            {
                public Properties81 properties { get; set; }
            }

            public class Properties81
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick4
            {
                public Properties82 properties { get; set; }
            }

            public class Properties82
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc4
            {
                public Properties83 properties { get; set; }
            }

            public class Properties83
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm4
            {
                public Properties84 properties { get; set; }
            }

            public class Properties84
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip4
            {
                public Properties85 properties { get; set; }
            }

            public class Properties85
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Sm_Berlin_Tunnel
            {
                public Fireteam_Dirty_Bomb5 fireteam_dirty_bomb { get; set; }
                public Dom5 dom { get; set; }
                public Dm_Hc5 dm_hc { get; set; }
                public Conf_Hc5 conf_hc { get; set; }
                public Dom10v105 dom10v10 { get; set; }
                public Dm5 dm { get; set; }
                public Sd_Hc5 sd_hc { get; set; }
                public Conf5 conf { get; set; }
                public Koth5 koth { get; set; }
                public Control5 control { get; set; }
                public Dom_Hc5 dom_hc { get; set; }
                public Sd5 sd { get; set; }
                public War12v125 war12v12 { get; set; }
                public Dropkick5 dropkick { get; set; }
                public Tdm_Hc5 tdm_hc { get; set; }
                public Tdm5 tdm { get; set; }
                public Vip5 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb5
            {
                public Properties86 properties { get; set; }
            }

            public class Properties86
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom5
            {
                public Properties87 properties { get; set; }
            }

            public class Properties87
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc5
            {
                public Properties88 properties { get; set; }
            }

            public class Properties88
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc5
            {
                public Properties89 properties { get; set; }
            }

            public class Properties89
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v105
            {
                public Properties90 properties { get; set; }
            }

            public class Properties90
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm5
            {
                public Properties91 properties { get; set; }
            }

            public class Properties91
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc5
            {
                public Properties92 properties { get; set; }
            }

            public class Properties92
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf5
            {
                public Properties93 properties { get; set; }
            }

            public class Properties93
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth5
            {
                public Properties94 properties { get; set; }
            }

            public class Properties94
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control5
            {
                public Properties95 properties { get; set; }
            }

            public class Properties95
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc5
            {
                public Properties96 properties { get; set; }
            }

            public class Properties96
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd5
            {
                public Properties97 properties { get; set; }
            }

            public class Properties97
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v125
            {
                public Properties98 properties { get; set; }
            }

            public class Properties98
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick5
            {
                public Properties99 properties { get; set; }
            }

            public class Properties99
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc5
            {
                public Properties100 properties { get; set; }
            }

            public class Properties100
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm5
            {
                public Properties101 properties { get; set; }
            }

            public class Properties101
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip5
            {
                public Properties102 properties { get; set; }
            }

            public class Properties102
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Nuketown6
            {
                public Fireteam_Dirty_Bomb6 fireteam_dirty_bomb { get; set; }
                public Dom6 dom { get; set; }
                public Dm_Hc6 dm_hc { get; set; }
                public Conf_Hc6 conf_hc { get; set; }
                public Dom10v106 dom10v10 { get; set; }
                public Dm6 dm { get; set; }
                public Sd_Hc6 sd_hc { get; set; }
                public Conf6 conf { get; set; }
                public Koth6 koth { get; set; }
                public Control6 control { get; set; }
                public Dom_Hc6 dom_hc { get; set; }
                public Sd6 sd { get; set; }
                public War12v126 war12v12 { get; set; }
                public Dropkick6 dropkick { get; set; }
                public Tdm_Hc6 tdm_hc { get; set; }
                public Tdm6 tdm { get; set; }
                public Vip6 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb6
            {
                public Properties103 properties { get; set; }
            }

            public class Properties103
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom6
            {
                public Properties104 properties { get; set; }
            }

            public class Properties104
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc6
            {
                public Properties105 properties { get; set; }
            }

            public class Properties105
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc6
            {
                public Properties106 properties { get; set; }
            }

            public class Properties106
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v106
            {
                public Properties107 properties { get; set; }
            }

            public class Properties107
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm6
            {
                public Properties108 properties { get; set; }
            }

            public class Properties108
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc6
            {
                public Properties109 properties { get; set; }
            }

            public class Properties109
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf6
            {
                public Properties110 properties { get; set; }
            }

            public class Properties110
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth6
            {
                public Properties111 properties { get; set; }
            }

            public class Properties111
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control6
            {
                public Properties112 properties { get; set; }
            }

            public class Properties112
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc6
            {
                public Properties113 properties { get; set; }
            }

            public class Properties113
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd6
            {
                public Properties114 properties { get; set; }
            }

            public class Properties114
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v126
            {
                public Properties115 properties { get; set; }
            }

            public class Properties115
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick6
            {
                public Properties116 properties { get; set; }
            }

            public class Properties116
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc6
            {
                public Properties117 properties { get; set; }
            }

            public class Properties117
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm6
            {
                public Properties118 properties { get; set; }
            }

            public class Properties118
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip6
            {
                public Properties119 properties { get; set; }
            }

            public class Properties119
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Satellite
            {
                public Fireteam_Dirty_Bomb7 fireteam_dirty_bomb { get; set; }
                public Dom7 dom { get; set; }
                public Dm_Hc7 dm_hc { get; set; }
                public Conf_Hc7 conf_hc { get; set; }
                public Dom10v107 dom10v10 { get; set; }
                public Dm7 dm { get; set; }
                public Sd_Hc7 sd_hc { get; set; }
                public Conf7 conf { get; set; }
                public Koth7 koth { get; set; }
                public Control7 control { get; set; }
                public Dom_Hc7 dom_hc { get; set; }
                public Sd7 sd { get; set; }
                public War12v127 war12v12 { get; set; }
                public Dropkick7 dropkick { get; set; }
                public Tdm_Hc7 tdm_hc { get; set; }
                public Tdm7 tdm { get; set; }
                public Vip7 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb7
            {
                public Properties120 properties { get; set; }
            }

            public class Properties120
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom7
            {
                public Properties121 properties { get; set; }
            }

            public class Properties121
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc7
            {
                public Properties122 properties { get; set; }
            }

            public class Properties122
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc7
            {
                public Properties123 properties { get; set; }
            }

            public class Properties123
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v107
            {
                public Properties124 properties { get; set; }
            }

            public class Properties124
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm7
            {
                public Properties125 properties { get; set; }
            }

            public class Properties125
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc7
            {
                public Properties126 properties { get; set; }
            }

            public class Properties126
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf7
            {
                public Properties127 properties { get; set; }
            }

            public class Properties127
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth7
            {
                public Properties128 properties { get; set; }
            }

            public class Properties128
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control7
            {
                public Properties129 properties { get; set; }
            }

            public class Properties129
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc7
            {
                public Properties130 properties { get; set; }
            }

            public class Properties130
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd7
            {
                public Properties131 properties { get; set; }
            }

            public class Properties131
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v127
            {
                public Properties132 properties { get; set; }
            }

            public class Properties132
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick7
            {
                public Properties133 properties { get; set; }
            }

            public class Properties133
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc7
            {
                public Properties134 properties { get; set; }
            }

            public class Properties134
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm7
            {
                public Properties135 properties { get; set; }
            }

            public class Properties135
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip7
            {
                public Properties136 properties { get; set; }
            }

            public class Properties136
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Tundra
            {
                public Fireteam_Dirty_Bomb8 fireteam_dirty_bomb { get; set; }
                public Dom8 dom { get; set; }
                public Dm_Hc8 dm_hc { get; set; }
                public Conf_Hc8 conf_hc { get; set; }
                public Dom10v108 dom10v10 { get; set; }
                public Dm8 dm { get; set; }
                public Sd_Hc8 sd_hc { get; set; }
                public Conf8 conf { get; set; }
                public Koth8 koth { get; set; }
                public Control8 control { get; set; }
                public Dom_Hc8 dom_hc { get; set; }
                public Sd8 sd { get; set; }
                public War12v128 war12v12 { get; set; }
                public Dropkick8 dropkick { get; set; }
                public Tdm_Hc8 tdm_hc { get; set; }
                public Tdm8 tdm { get; set; }
                public Vip8 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb8
            {
                public Properties137 properties { get; set; }
            }

            public class Properties137
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom8
            {
                public Properties138 properties { get; set; }
            }

            public class Properties138
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc8
            {
                public Properties139 properties { get; set; }
            }

            public class Properties139
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc8
            {
                public Properties140 properties { get; set; }
            }

            public class Properties140
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v108
            {
                public Properties141 properties { get; set; }
            }

            public class Properties141
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm8
            {
                public Properties142 properties { get; set; }
            }

            public class Properties142
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc8
            {
                public Properties143 properties { get; set; }
            }

            public class Properties143
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf8
            {
                public Properties144 properties { get; set; }
            }

            public class Properties144
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth8
            {
                public Properties145 properties { get; set; }
            }

            public class Properties145
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control8
            {
                public Properties146 properties { get; set; }
            }

            public class Properties146
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc8
            {
                public Properties147 properties { get; set; }
            }

            public class Properties147
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd8
            {
                public Properties148 properties { get; set; }
            }

            public class Properties148
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v128
            {
                public Properties149 properties { get; set; }
            }

            public class Properties149
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick8
            {
                public Properties150 properties { get; set; }
            }

            public class Properties150
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc8
            {
                public Properties151 properties { get; set; }
            }

            public class Properties151
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm8
            {
                public Properties152 properties { get; set; }
            }

            public class Properties152
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip8
            {
                public Properties153 properties { get; set; }
            }

            public class Properties153
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Sm_Game_Show
            {
                public Fireteam_Dirty_Bomb9 fireteam_dirty_bomb { get; set; }
                public Dom9 dom { get; set; }
                public Dm_Hc9 dm_hc { get; set; }
                public Conf_Hc9 conf_hc { get; set; }
                public Dom10v109 dom10v10 { get; set; }
                public Dm9 dm { get; set; }
                public Sd_Hc9 sd_hc { get; set; }
                public Conf9 conf { get; set; }
                public Koth9 koth { get; set; }
                public Control9 control { get; set; }
                public Dom_Hc9 dom_hc { get; set; }
                public Sd9 sd { get; set; }
                public War12v129 war12v12 { get; set; }
                public Dropkick9 dropkick { get; set; }
                public Tdm_Hc9 tdm_hc { get; set; }
                public Tdm9 tdm { get; set; }
                public Vip9 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb9
            {
                public Properties154 properties { get; set; }
            }

            public class Properties154
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom9
            {
                public Properties155 properties { get; set; }
            }

            public class Properties155
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc9
            {
                public Properties156 properties { get; set; }
            }

            public class Properties156
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc9
            {
                public Properties157 properties { get; set; }
            }

            public class Properties157
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v109
            {
                public Properties158 properties { get; set; }
            }

            public class Properties158
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm9
            {
                public Properties159 properties { get; set; }
            }

            public class Properties159
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc9
            {
                public Properties160 properties { get; set; }
            }

            public class Properties160
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf9
            {
                public Properties161 properties { get; set; }
            }

            public class Properties161
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth9
            {
                public Properties162 properties { get; set; }
            }

            public class Properties162
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control9
            {
                public Properties163 properties { get; set; }
            }

            public class Properties163
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc9
            {
                public Properties164 properties { get; set; }
            }

            public class Properties164
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd9
            {
                public Properties165 properties { get; set; }
            }

            public class Properties165
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v129
            {
                public Properties166 properties { get; set; }
            }

            public class Properties166
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick9
            {
                public Properties167 properties { get; set; }
            }

            public class Properties167
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc9
            {
                public Properties168 properties { get; set; }
            }

            public class Properties168
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm9
            {
                public Properties169 properties { get; set; }
            }

            public class Properties169
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip9
            {
                public Properties170 properties { get; set; }
            }

            public class Properties170
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Cartel
            {
                public Fireteam_Dirty_Bomb10 fireteam_dirty_bomb { get; set; }
                public Dom10 dom { get; set; }
                public Dm_Hc10 dm_hc { get; set; }
                public Conf_Hc10 conf_hc { get; set; }
                public Dom10v1010 dom10v10 { get; set; }
                public Dm10 dm { get; set; }
                public Sd_Hc10 sd_hc { get; set; }
                public Conf10 conf { get; set; }
                public Koth10 koth { get; set; }
                public Control10 control { get; set; }
                public Dom_Hc10 dom_hc { get; set; }
                public Sd10 sd { get; set; }
                public War12v1210 war12v12 { get; set; }
                public Dropkick10 dropkick { get; set; }
                public Tdm_Hc10 tdm_hc { get; set; }
                public Tdm10 tdm { get; set; }
                public Vip10 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb10
            {
                public Properties171 properties { get; set; }
            }

            public class Properties171
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10
            {
                public Properties172 properties { get; set; }
            }

            public class Properties172
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc10
            {
                public Properties173 properties { get; set; }
            }

            public class Properties173
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc10
            {
                public Properties174 properties { get; set; }
            }

            public class Properties174
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v1010
            {
                public Properties175 properties { get; set; }
            }

            public class Properties175
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm10
            {
                public Properties176 properties { get; set; }
            }

            public class Properties176
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc10
            {
                public Properties177 properties { get; set; }
            }

            public class Properties177
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf10
            {
                public Properties178 properties { get; set; }
            }

            public class Properties178
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth10
            {
                public Properties179 properties { get; set; }
            }

            public class Properties179
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control10
            {
                public Properties180 properties { get; set; }
            }

            public class Properties180
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc10
            {
                public Properties181 properties { get; set; }
            }

            public class Properties181
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd10
            {
                public Properties182 properties { get; set; }
            }

            public class Properties182
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v1210
            {
                public Properties183 properties { get; set; }
            }

            public class Properties183
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick10
            {
                public Properties184 properties { get; set; }
            }

            public class Properties184
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc10
            {
                public Properties185 properties { get; set; }
            }

            public class Properties185
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm10
            {
                public Properties186 properties { get; set; }
            }

            public class Properties186
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip10
            {
                public Properties187 properties { get; set; }
            }

            public class Properties187
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Tank
            {
                public Fireteam_Dirty_Bomb11 fireteam_dirty_bomb { get; set; }
                public Dom11 dom { get; set; }
                public Dm_Hc11 dm_hc { get; set; }
                public Conf_Hc11 conf_hc { get; set; }
                public Dom10v1011 dom10v10 { get; set; }
                public Dm11 dm { get; set; }
                public Sd_Hc11 sd_hc { get; set; }
                public Conf11 conf { get; set; }
                public Koth11 koth { get; set; }
                public Control11 control { get; set; }
                public Dom_Hc11 dom_hc { get; set; }
                public Sd11 sd { get; set; }
                public War12v1211 war12v12 { get; set; }
                public Dropkick11 dropkick { get; set; }
                public Tdm_Hc11 tdm_hc { get; set; }
                public Tdm11 tdm { get; set; }
                public Vip11 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb11
            {
                public Properties188 properties { get; set; }
            }

            public class Properties188
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom11
            {
                public Properties189 properties { get; set; }
            }

            public class Properties189
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc11
            {
                public Properties190 properties { get; set; }
            }

            public class Properties190
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc11
            {
                public Properties191 properties { get; set; }
            }

            public class Properties191
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v1011
            {
                public Properties192 properties { get; set; }
            }

            public class Properties192
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm11
            {
                public Properties193 properties { get; set; }
            }

            public class Properties193
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc11
            {
                public Properties194 properties { get; set; }
            }

            public class Properties194
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf11
            {
                public Properties195 properties { get; set; }
            }

            public class Properties195
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth11
            {
                public Properties196 properties { get; set; }
            }

            public class Properties196
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control11
            {
                public Properties197 properties { get; set; }
            }

            public class Properties197
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc11
            {
                public Properties198 properties { get; set; }
            }

            public class Properties198
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd11
            {
                public Properties199 properties { get; set; }
            }

            public class Properties199
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v1211
            {
                public Properties200 properties { get; set; }
            }

            public class Properties200
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick11
            {
                public Properties201 properties { get; set; }
            }

            public class Properties201
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc11
            {
                public Properties202 properties { get; set; }
            }

            public class Properties202
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm11
            {
                public Properties203 properties { get; set; }
            }

            public class Properties203
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip11
            {
                public Properties204 properties { get; set; }
            }

            public class Properties204
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Black_Sea
            {
                public Fireteam_Dirty_Bomb12 fireteam_dirty_bomb { get; set; }
                public Dom12 dom { get; set; }
                public Dm_Hc12 dm_hc { get; set; }
                public Conf_Hc12 conf_hc { get; set; }
                public Dom10v1012 dom10v10 { get; set; }
                public Dm12 dm { get; set; }
                public Sd_Hc12 sd_hc { get; set; }
                public Conf12 conf { get; set; }
                public Koth12 koth { get; set; }
                public Control12 control { get; set; }
                public Dom_Hc12 dom_hc { get; set; }
                public Sd12 sd { get; set; }
                public War12v1212 war12v12 { get; set; }
                public Dropkick12 dropkick { get; set; }
                public Tdm_Hc12 tdm_hc { get; set; }
                public Tdm12 tdm { get; set; }
                public Vip12 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb12
            {
                public Properties205 properties { get; set; }
            }

            public class Properties205
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom12
            {
                public Properties206 properties { get; set; }
            }

            public class Properties206
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc12
            {
                public Properties207 properties { get; set; }
            }

            public class Properties207
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc12
            {
                public Properties208 properties { get; set; }
            }

            public class Properties208
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v1012
            {
                public Properties209 properties { get; set; }
            }

            public class Properties209
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm12
            {
                public Properties210 properties { get; set; }
            }

            public class Properties210
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc12
            {
                public Properties211 properties { get; set; }
            }

            public class Properties211
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf12
            {
                public Properties212 properties { get; set; }
            }

            public class Properties212
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth12
            {
                public Properties213 properties { get; set; }
            }

            public class Properties213
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control12
            {
                public Properties214 properties { get; set; }
            }

            public class Properties214
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc12
            {
                public Properties215 properties { get; set; }
            }

            public class Properties215
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd12
            {
                public Properties216 properties { get; set; }
            }

            public class Properties216
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v1212
            {
                public Properties217 properties { get; set; }
            }

            public class Properties217
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick12
            {
                public Properties218 properties { get; set; }
            }

            public class Properties218
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc12
            {
                public Properties219 properties { get; set; }
            }

            public class Properties219
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm12
            {
                public Properties220 properties { get; set; }
            }

            public class Properties220
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip12
            {
                public Properties221 properties { get; set; }
            }

            public class Properties221
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Apocalypse
            {
                public Fireteam_Dirty_Bomb13 fireteam_dirty_bomb { get; set; }
                public Dom13 dom { get; set; }
                public Dm_Hc13 dm_hc { get; set; }
                public Conf_Hc13 conf_hc { get; set; }
                public Dom10v1013 dom10v10 { get; set; }
                public Dm13 dm { get; set; }
                public Sd_Hc13 sd_hc { get; set; }
                public Conf13 conf { get; set; }
                public Koth13 koth { get; set; }
                public Control13 control { get; set; }
                public Dom_Hc13 dom_hc { get; set; }
                public Sd13 sd { get; set; }
                public War12v1213 war12v12 { get; set; }
                public Dropkick13 dropkick { get; set; }
                public Tdm_Hc13 tdm_hc { get; set; }
                public Tdm13 tdm { get; set; }
                public Vip13 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb13
            {
                public Properties222 properties { get; set; }
            }

            public class Properties222
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom13
            {
                public Properties223 properties { get; set; }
            }

            public class Properties223
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc13
            {
                public Properties224 properties { get; set; }
            }

            public class Properties224
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc13
            {
                public Properties225 properties { get; set; }
            }

            public class Properties225
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v1013
            {
                public Properties226 properties { get; set; }
            }

            public class Properties226
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm13
            {
                public Properties227 properties { get; set; }
            }

            public class Properties227
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc13
            {
                public Properties228 properties { get; set; }
            }

            public class Properties228
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf13
            {
                public Properties229 properties { get; set; }
            }

            public class Properties229
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth13
            {
                public Properties230 properties { get; set; }
            }

            public class Properties230
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control13
            {
                public Properties231 properties { get; set; }
            }

            public class Properties231
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc13
            {
                public Properties232 properties { get; set; }
            }

            public class Properties232
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd13
            {
                public Properties233 properties { get; set; }
            }

            public class Properties233
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v1213
            {
                public Properties234 properties { get; set; }
            }

            public class Properties234
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick13
            {
                public Properties235 properties { get; set; }
            }

            public class Properties235
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc13
            {
                public Properties236 properties { get; set; }
            }

            public class Properties236
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm13
            {
                public Properties237 properties { get; set; }
            }

            public class Properties237
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip13
            {
                public Properties238 properties { get; set; }
            }

            public class Properties238
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Sm_Central
            {
                public Fireteam_Dirty_Bomb14 fireteam_dirty_bomb { get; set; }
                public Dom14 dom { get; set; }
                public Dm_Hc14 dm_hc { get; set; }
                public Conf_Hc14 conf_hc { get; set; }
                public Dom10v1014 dom10v10 { get; set; }
                public Dm14 dm { get; set; }
                public Sd_Hc14 sd_hc { get; set; }
                public Conf14 conf { get; set; }
                public Koth14 koth { get; set; }
                public Control14 control { get; set; }
                public Dom_Hc14 dom_hc { get; set; }
                public Sd14 sd { get; set; }
                public War12v1214 war12v12 { get; set; }
                public Dropkick14 dropkick { get; set; }
                public Tdm_Hc14 tdm_hc { get; set; }
                public Tdm14 tdm { get; set; }
                public Vip14 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb14
            {
                public Properties239 properties { get; set; }
            }

            public class Properties239
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom14
            {
                public Properties240 properties { get; set; }
            }

            public class Properties240
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc14
            {
                public Properties241 properties { get; set; }
            }

            public class Properties241
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc14
            {
                public Properties242 properties { get; set; }
            }

            public class Properties242
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v1014
            {
                public Properties243 properties { get; set; }
            }

            public class Properties243
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm14
            {
                public Properties244 properties { get; set; }
            }

            public class Properties244
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc14
            {
                public Properties245 properties { get; set; }
            }

            public class Properties245
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf14
            {
                public Properties246 properties { get; set; }
            }

            public class Properties246
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth14
            {
                public Properties247 properties { get; set; }
            }

            public class Properties247
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control14
            {
                public Properties248 properties { get; set; }
            }

            public class Properties248
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc14
            {
                public Properties249 properties { get; set; }
            }

            public class Properties249
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd14
            {
                public Properties250 properties { get; set; }
            }

            public class Properties250
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v1214
            {
                public Properties251 properties { get; set; }
            }

            public class Properties251
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick14
            {
                public Properties252 properties { get; set; }
            }

            public class Properties252
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc14
            {
                public Properties253 properties { get; set; }
            }

            public class Properties253
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm14
            {
                public Properties254 properties { get; set; }
            }

            public class Properties254
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip14
            {
                public Properties255 properties { get; set; }
            }

            public class Properties255
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Wz_Forest
            {
                public Fireteam_Dirty_Bomb15 fireteam_dirty_bomb { get; set; }
                public Dom15 dom { get; set; }
                public Dm_Hc15 dm_hc { get; set; }
                public Conf_Hc15 conf_hc { get; set; }
                public Dom10v1015 dom10v10 { get; set; }
                public Dm15 dm { get; set; }
                public Sd_Hc15 sd_hc { get; set; }
                public Conf15 conf { get; set; }
                public Koth15 koth { get; set; }
                public Control15 control { get; set; }
                public Dom_Hc15 dom_hc { get; set; }
                public Sd15 sd { get; set; }
                public War12v1215 war12v12 { get; set; }
                public Dropkick15 dropkick { get; set; }
                public Tdm_Hc15 tdm_hc { get; set; }
                public Tdm15 tdm { get; set; }
                public Vip15 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb15
            {
                public Properties256 properties { get; set; }
            }

            public class Properties256
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom15
            {
                public Properties257 properties { get; set; }
            }

            public class Properties257
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc15
            {
                public Properties258 properties { get; set; }
            }

            public class Properties258
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc15
            {
                public Properties259 properties { get; set; }
            }

            public class Properties259
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v1015
            {
                public Properties260 properties { get; set; }
            }

            public class Properties260
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm15
            {
                public Properties261 properties { get; set; }
            }

            public class Properties261
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc15
            {
                public Properties262 properties { get; set; }
            }

            public class Properties262
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf15
            {
                public Properties263 properties { get; set; }
            }

            public class Properties263
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth15
            {
                public Properties264 properties { get; set; }
            }

            public class Properties264
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control15
            {
                public Properties265 properties { get; set; }
            }

            public class Properties265
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc15
            {
                public Properties266 properties { get; set; }
            }

            public class Properties266
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd15
            {
                public Properties267 properties { get; set; }
            }

            public class Properties267
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v1215
            {
                public Properties268 properties { get; set; }
            }

            public class Properties268
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick15
            {
                public Properties269 properties { get; set; }
            }

            public class Properties269
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc15
            {
                public Properties270 properties { get; set; }
            }

            public class Properties270
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm15
            {
                public Properties271 properties { get; set; }
            }

            public class Properties271
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip15
            {
                public Properties272 properties { get; set; }
            }

            public class Properties272
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Raid_Rm
            {
                public Fireteam_Dirty_Bomb16 fireteam_dirty_bomb { get; set; }
                public Dom16 dom { get; set; }
                public Dm_Hc16 dm_hc { get; set; }
                public Conf_Hc16 conf_hc { get; set; }
                public Dom10v1016 dom10v10 { get; set; }
                public Dm16 dm { get; set; }
                public Sd_Hc16 sd_hc { get; set; }
                public Conf16 conf { get; set; }
                public Koth16 koth { get; set; }
                public Control16 control { get; set; }
                public Dom_Hc16 dom_hc { get; set; }
                public Sd16 sd { get; set; }
                public War12v1216 war12v12 { get; set; }
                public Dropkick16 dropkick { get; set; }
                public Tdm_Hc16 tdm_hc { get; set; }
                public Tdm16 tdm { get; set; }
                public Vip16 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb16
            {
                public Properties273 properties { get; set; }
            }

            public class Properties273
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom16
            {
                public Properties274 properties { get; set; }
            }

            public class Properties274
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc16
            {
                public Properties275 properties { get; set; }
            }

            public class Properties275
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc16
            {
                public Properties276 properties { get; set; }
            }

            public class Properties276
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v1016
            {
                public Properties277 properties { get; set; }
            }

            public class Properties277
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm16
            {
                public Properties278 properties { get; set; }
            }

            public class Properties278
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc16
            {
                public Properties279 properties { get; set; }
            }

            public class Properties279
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf16
            {
                public Properties280 properties { get; set; }
            }

            public class Properties280
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth16
            {
                public Properties281 properties { get; set; }
            }

            public class Properties281
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control16
            {
                public Properties282 properties { get; set; }
            }

            public class Properties282
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc16
            {
                public Properties283 properties { get; set; }
            }

            public class Properties283
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd16
            {
                public Properties284 properties { get; set; }
            }

            public class Properties284
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v1216
            {
                public Properties285 properties { get; set; }
            }

            public class Properties285
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick16
            {
                public Properties286 properties { get; set; }
            }

            public class Properties286
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc16
            {
                public Properties287 properties { get; set; }
            }

            public class Properties287
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm16
            {
                public Properties288 properties { get; set; }
            }

            public class Properties288
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip16
            {
                public Properties289 properties { get; set; }
            }

            public class Properties289
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Kgb
            {
                public Fireteam_Dirty_Bomb17 fireteam_dirty_bomb { get; set; }
                public Dom17 dom { get; set; }
                public Dm_Hc17 dm_hc { get; set; }
                public Conf_Hc17 conf_hc { get; set; }
                public Dom10v1017 dom10v10 { get; set; }
                public Dm17 dm { get; set; }
                public Sd_Hc17 sd_hc { get; set; }
                public Conf17 conf { get; set; }
                public Koth17 koth { get; set; }
                public Control17 control { get; set; }
                public Dom_Hc17 dom_hc { get; set; }
                public Sd17 sd { get; set; }
                public War12v1217 war12v12 { get; set; }
                public Dropkick17 dropkick { get; set; }
                public Tdm_Hc17 tdm_hc { get; set; }
                public Tdm17 tdm { get; set; }
                public Vip17 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb17
            {
                public Properties290 properties { get; set; }
            }

            public class Properties290
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom17
            {
                public Properties291 properties { get; set; }
            }

            public class Properties291
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc17
            {
                public Properties292 properties { get; set; }
            }

            public class Properties292
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc17
            {
                public Properties293 properties { get; set; }
            }

            public class Properties293
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v1017
            {
                public Properties294 properties { get; set; }
            }

            public class Properties294
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm17
            {
                public Properties295 properties { get; set; }
            }

            public class Properties295
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc17
            {
                public Properties296 properties { get; set; }
            }

            public class Properties296
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf17
            {
                public Properties297 properties { get; set; }
            }

            public class Properties297
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth17
            {
                public Properties298 properties { get; set; }
            }

            public class Properties298
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control17
            {
                public Properties299 properties { get; set; }
            }

            public class Properties299
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc17
            {
                public Properties300 properties { get; set; }
            }

            public class Properties300
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd17
            {
                public Properties301 properties { get; set; }
            }

            public class Properties301
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v1217
            {
                public Properties302 properties { get; set; }
            }

            public class Properties302
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick17
            {
                public Properties303 properties { get; set; }
            }

            public class Properties303
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc17
            {
                public Properties304 properties { get; set; }
            }

            public class Properties304
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm17
            {
                public Properties305 properties { get; set; }
            }

            public class Properties305
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip17
            {
                public Properties306 properties { get; set; }
            }

            public class Properties306
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Mp_Moscow
            {
                public Fireteam_Dirty_Bomb18 fireteam_dirty_bomb { get; set; }
                public Dom18 dom { get; set; }
                public Dm_Hc18 dm_hc { get; set; }
                public Conf_Hc18 conf_hc { get; set; }
                public Dom10v1018 dom10v10 { get; set; }
                public Dm18 dm { get; set; }
                public Sd_Hc18 sd_hc { get; set; }
                public Conf18 conf { get; set; }
                public Koth18 koth { get; set; }
                public Control18 control { get; set; }
                public Dom_Hc18 dom_hc { get; set; }
                public Sd18 sd { get; set; }
                public War12v1218 war12v12 { get; set; }
                public Dropkick18 dropkick { get; set; }
                public Tdm_Hc18 tdm_hc { get; set; }
                public Tdm18 tdm { get; set; }
                public Vip18 vip { get; set; }
            }

            public class Fireteam_Dirty_Bomb18
            {
                public Properties307 properties { get; set; }
            }

            public class Properties307
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom18
            {
                public Properties308 properties { get; set; }
            }

            public class Properties308
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm_Hc18
            {
                public Properties309 properties { get; set; }
            }

            public class Properties309
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf_Hc18
            {
                public Properties310 properties { get; set; }
            }

            public class Properties310
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom10v1018
            {
                public Properties311 properties { get; set; }
            }

            public class Properties311
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dm18
            {
                public Properties312 properties { get; set; }
            }

            public class Properties312
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd_Hc18
            {
                public Properties313 properties { get; set; }
            }

            public class Properties313
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Conf18
            {
                public Properties314 properties { get; set; }
            }

            public class Properties314
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Koth18
            {
                public Properties315 properties { get; set; }
            }

            public class Properties315
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Control18
            {
                public Properties316 properties { get; set; }
            }

            public class Properties316
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dom_Hc18
            {
                public Properties317 properties { get; set; }
            }

            public class Properties317
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Sd18
            {
                public Properties318 properties { get; set; }
            }

            public class Properties318
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class War12v1218
            {
                public Properties319 properties { get; set; }
            }

            public class Properties319
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Dropkick18
            {
                public Properties320 properties { get; set; }
            }

            public class Properties320
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm_Hc18
            {
                public Properties321 properties { get; set; }
            }

            public class Properties321
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Tdm18
            {
                public Properties322 properties { get; set; }
            }

            public class Properties322
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }

            public class Vip18
            {
                public Properties323 properties { get; set; }
            }

            public class Properties323
            {
                public float avgStat2 { get; set; }
                public float loss { get; set; }
                public float timePlayed { get; set; }
                public float stat2 { get; set; }
                public float wlRatio { get; set; }
                public float gamesPlayed { get; set; }
                public float stat1 { get; set; }
                public float avgStat1 { get; set; }
                public float draw { get; set; }
                public float win { get; set; }
                public float stat1Stat2Ratio { get; set; }
            }
        }

        public class Itemdata
        {
            public Weapon_Sniper weapon_sniper { get; set; }
            public Weapon_Lmg weapon_lmg { get; set; }
            public Weapon_Pistol weapon_pistol { get; set; }
            public Weapon_Assault_Rifle weapon_assault_rifle { get; set; }
            public Weapon_Shotgun weapon_shotgun { get; set; }
            public Weapon_Smg weapon_smg { get; set; }
            public Scorestreak scorestreak { get; set; }
            public Weapon_Marksman weapon_marksman { get; set; }

            public class Weapon_Sniper
            {
                public Sniper_Cannon_T9 sniper_cannon_t9 { get; set; }
                public Sniper_Quickscope_T9 sniper_quickscope_t9 { get; set; }
                public Sniper_Accurate_T9 sniper_accurate_t9 { get; set; }
                public Sniper_Standard_T9 sniper_standard_t9 { get; set; }
                public Sniper_Powersemi_T9 sniper_powersemi_t9 { get; set; }
            }

            public class Sniper_Cannon_T9
            {
                public Properties324 properties { get; set; }
            }

            public class Properties324
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Sniper_Quickscope_T9
            {
                public Properties325 properties { get; set; }
            }

            public class Properties325
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Sniper_Accurate_T9
            {
                public Properties326 properties { get; set; }
            }

            public class Properties326
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Sniper_Standard_T9
            {
                public Properties327 properties { get; set; }
            }

            public class Properties327
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Sniper_Powersemi_T9
            {
                public Properties328 properties { get; set; }
            }

            public class Properties328
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Weapon_Lmg
            {
                public Lmg_Fastfire_T9 lmg_fastfire_t9 { get; set; }
                public Lmg_Light_T9 lmg_light_t9 { get; set; }
                public Lmg_Slowfire_T9 lmg_slowfire_t9 { get; set; }
                public Lmg_Accurate_T9 lmg_accurate_t9 { get; set; }
            }

            public class Lmg_Fastfire_T9
            {
                public Properties329 properties { get; set; }
            }

            public class Properties329
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Lmg_Light_T9
            {
                public Properties330 properties { get; set; }
            }

            public class Properties330
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Lmg_Slowfire_T9
            {
                public Properties331 properties { get; set; }
            }

            public class Properties331
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Lmg_Accurate_T9
            {
                public Properties332 properties { get; set; }
            }

            public class Properties332
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Weapon_Pistol
            {
                public Pistol_Semiauto_T9 pistol_semiauto_t9 { get; set; }
                public Pistol_Burst_T9 pistol_burst_t9 { get; set; }
                public Pistol_Revolver_T9 pistol_revolver_t9 { get; set; }
                public Pistol_Fullauto_T9 pistol_fullauto_t9 { get; set; }
            }

            public class Pistol_Semiauto_T9
            {
                public Properties333 properties { get; set; }
            }

            public class Properties333
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Pistol_Burst_T9
            {
                public Properties334 properties { get; set; }
            }

            public class Properties334
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Pistol_Revolver_T9
            {
                public Properties335 properties { get; set; }
            }

            public class Properties335
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Pistol_Fullauto_T9
            {
                public Properties336 properties { get; set; }
            }

            public class Properties336
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Weapon_Assault_Rifle
            {
                public Ar_Fastfire_T9 ar_fastfire_t9 { get; set; }
                public Ar_Slowfire_T9 ar_slowfire_t9 { get; set; }
                public Ar_Standard_T9 ar_standard_t9 { get; set; }
                public Ar_Fasthandling_T9 ar_fasthandling_t9 { get; set; }
                public Ar_Mobility_T9 ar_mobility_t9 { get; set; }
                public Ar_Slowhandling_T9 ar_slowhandling_t9 { get; set; }
                public Ar_Damage_T9 ar_damage_t9 { get; set; }
                public Ar_Accurate_T9 ar_accurate_t9 { get; set; }
            }

            public class Ar_Fastfire_T9
            {
                public Properties337 properties { get; set; }
            }

            public class Properties337
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Ar_Slowfire_T9
            {
                public Properties338 properties { get; set; }
            }

            public class Properties338
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Ar_Standard_T9
            {
                public Properties339 properties { get; set; }
            }

            public class Properties339
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Ar_Fasthandling_T9
            {
                public Properties340 properties { get; set; }
            }

            public class Properties340
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Ar_Mobility_T9
            {
                public Properties341 properties { get; set; }
            }

            public class Properties341
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Ar_Slowhandling_T9
            {
                public Properties342 properties { get; set; }
            }

            public class Properties342
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Ar_Damage_T9
            {
                public Properties343 properties { get; set; }
            }

            public class Properties343
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Ar_Accurate_T9
            {
                public Properties344 properties { get; set; }
            }

            public class Properties344
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Weapon_Shotgun
            {
                public Shotgun_Semiauto_T9 shotgun_semiauto_t9 { get; set; }
                public Shotgun_Pump_T9 shotgun_pump_t9 { get; set; }
                public Shotgun_Fullauto_T9 shotgun_fullauto_t9 { get; set; }
            }

            public class Shotgun_Semiauto_T9
            {
                public Properties345 properties { get; set; }
            }

            public class Properties345
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Shotgun_Pump_T9
            {
                public Properties346 properties { get; set; }
            }

            public class Properties346
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Shotgun_Fullauto_T9
            {
                public Properties347 properties { get; set; }
            }

            public class Properties347
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Weapon_Smg
            {
                public Smg_Spray_T9 smg_spray_t9 { get; set; }
                public Smg_Capacity_T9 smg_capacity_t9 { get; set; }
                public Smg_Heavy_T9 smg_heavy_t9 { get; set; }
                public Smg_Handling_T9 smg_handling_t9 { get; set; }
                public Smg_Standard_T9 smg_standard_t9 { get; set; }
                public Smg_Burst_T9 smg_burst_t9 { get; set; }
                public Smg_Fastfire_T9 smg_fastfire_t9 { get; set; }
                public Smg_Accurate_T9 smg_accurate_t9 { get; set; }
            }

            public class Smg_Spray_T9
            {
                public Properties348 properties { get; set; }
            }

            public class Properties348
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Smg_Capacity_T9
            {
                public Properties349 properties { get; set; }
            }

            public class Properties349
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Smg_Heavy_T9
            {
                public Properties350 properties { get; set; }
            }

            public class Properties350
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Smg_Handling_T9
            {
                public Properties351 properties { get; set; }
            }

            public class Properties351
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Smg_Standard_T9
            {
                public Properties352 properties { get; set; }
            }

            public class Properties352
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Smg_Burst_T9
            {
                public Properties353 properties { get; set; }
            }

            public class Properties353
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Smg_Fastfire_T9
            {
                public Properties354 properties { get; set; }
            }

            public class Properties354
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Smg_Accurate_T9
            {
                public Properties355 properties { get; set; }
            }

            public class Properties355
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Scorestreak
            {
                public Ac130 ac130 { get; set; }
                public Sig_Lmg sig_lmg { get; set; }
                public Uav uav { get; set; }
                public Counteruav counteruav { get; set; }
                public Napalm_Strike napalm_strike { get; set; }
                public Supplydrop_Marker supplydrop_marker { get; set; }
                public Chopper_Gunner chopper_gunner { get; set; }
                public Jetfighter jetfighter { get; set; }
                public Planemortar planemortar { get; set; }
                public Hoverjet hoverjet { get; set; }
                public Helicopter_Comlink helicopter_comlink { get; set; }
                public Sig_Bow_Flame sig_bow_flame { get; set; }
                public Hero_Pineapplegun hero_pineapplegun { get; set; }
                public Ultimate_Turret ultimate_turret { get; set; }
                public Weapon_Armor weapon_armor { get; set; }
                public Recon_Car recon_car { get; set; }
                public Remote_Missile remote_missile { get; set; }
                public Recon_Plane recon_plane { get; set; }
            }

            public class Ac130
            {
                public Properties356 properties { get; set; }
            }

            public class Properties356
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Sig_Lmg
            {
                public Properties357 properties { get; set; }
            }

            public class Properties357
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Uav
            {
                public Properties358 properties { get; set; }
            }

            public class Properties358
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Counteruav
            {
                public Properties359 properties { get; set; }
            }

            public class Properties359
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Napalm_Strike
            {
                public Properties360 properties { get; set; }
            }

            public class Properties360
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Supplydrop_Marker
            {
                public Properties361 properties { get; set; }
            }

            public class Properties361
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Chopper_Gunner
            {
                public Properties362 properties { get; set; }
            }

            public class Properties362
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Jetfighter
            {
                public Properties363 properties { get; set; }
            }

            public class Properties363
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Planemortar
            {
                public Properties364 properties { get; set; }
            }

            public class Properties364
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Hoverjet
            {
                public Properties365 properties { get; set; }
            }

            public class Properties365
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Helicopter_Comlink
            {
                public Properties366 properties { get; set; }
            }

            public class Properties366
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Sig_Bow_Flame
            {
                public Properties367 properties { get; set; }
            }

            public class Properties367
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Hero_Pineapplegun
            {
                public Properties368 properties { get; set; }
            }

            public class Properties368
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Ultimate_Turret
            {
                public Properties369 properties { get; set; }
            }

            public class Properties369
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Weapon_Armor
            {
                public Properties370 properties { get; set; }
            }

            public class Properties370
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Recon_Car
            {
                public Properties371 properties { get; set; }
            }

            public class Properties371
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Remote_Missile
            {
                public Properties372 properties { get; set; }
            }

            public class Properties372
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Recon_Plane
            {
                public Properties373 properties { get; set; }
            }

            public class Properties373
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Weapon_Marksman
            {
                public Tr_Longburst_T9 tr_longburst_t9 { get; set; }
                public Tr_Damagesemi_T9 tr_damagesemi_t9 { get; set; }
                public Tr_Precisionsemi_T9 tr_precisionsemi_t9 { get; set; }
                public Tr_Powerburst_T9 tr_powerburst_t9 { get; set; }
                public Tr_Fastburst_T9 tr_fastburst_t9 { get; set; }
            }

            public class Tr_Longburst_T9
            {
                public Properties374 properties { get; set; }
            }

            public class Properties374
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Tr_Damagesemi_T9
            {
                public Properties375 properties { get; set; }
            }

            public class Properties375
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Tr_Precisionsemi_T9
            {
                public Properties376 properties { get; set; }
            }

            public class Properties376
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Tr_Powerburst_T9
            {
                public Properties377 properties { get; set; }
            }

            public class Properties377
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Tr_Fastburst_T9
            {
                public Properties378 properties { get; set; }
            }

            public class Properties378
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float ekiadRatio { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float accuracy { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float kdRatio { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Attachmentdata
            {
                public Fastreload fastreload { get; set; }
                public Grip2 grip2 { get; set; }
                public Handle2 handle2 { get; set; }
                public Quickdraw2 quickdraw2 { get; set; }
                public Stalker2 stalker2 { get; set; }
                public Mixunder mixunder { get; set; }
                public Sprintout sprintout { get; set; }
                public Sprintout2 sprintout2 { get; set; }
                public Mixclip mixclip { get; set; }
                public Steadyaim2 steadyaim2 { get; set; }
                public Scope3x scope3x { get; set; }
                public Acog acog { get; set; }
                public Mixbody2 mixbody2 { get; set; }
                public Suppressed suppressed { get; set; }
                public Extclip extclip { get; set; }
                public Reddot reddot { get; set; }
                public Barrel barrel { get; set; }
                public Compensator2 compensator2 { get; set; }
                public Grip grip { get; set; }
                public Fastreload2 fastreload2 { get; set; }
                public Elo3 elo3 { get; set; }
                public Mixstock mixstock { get; set; }
                public Stalker stalker { get; set; }
                public Elo2 elo2 { get; set; }
                public Speedgrip2 speedgrip2 { get; set; }
                public Barrel2 barrel2 { get; set; }
                public Mixhandle mixhandle { get; set; }
                public Reflex3 reflex3 { get; set; }
                public Steadyaim steadyaim { get; set; }
                public Elo elo { get; set; }
                public Mixmuzzle mixmuzzle { get; set; }
                public Reflex2 reflex2 { get; set; }
                public Handle handle { get; set; }
                public Reflex reflex { get; set; }
                public Compensator compensator { get; set; }
                public Heavy heavy { get; set; }
                public Mixbarrel mixbarrel { get; set; }
                public Light light { get; set; }
                public Scope4x scope4x { get; set; }
                public Suppressed2 suppressed2 { get; set; }
                public Holo holo { get; set; }
                public Extclip2 extclip2 { get; set; }
                public Speedgrip speedgrip { get; set; }
                public Heavy2 heavy2 { get; set; }
                public Quickdraw quickdraw { get; set; }
            }

            public class Fastreload
            {
                public Properties379 properties { get; set; }
            }

            public class Properties379
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Grip2
            {
                public Properties380 properties { get; set; }
            }

            public class Properties380
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Handle2
            {
                public Properties381 properties { get; set; }
            }

            public class Properties381
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Quickdraw2
            {
                public Properties382 properties { get; set; }
            }

            public class Properties382
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Stalker2
            {
                public Properties383 properties { get; set; }
            }

            public class Properties383
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Mixunder
            {
                public Properties384 properties { get; set; }
            }

            public class Properties384
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Sprintout
            {
                public Properties385 properties { get; set; }
            }

            public class Properties385
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Sprintout2
            {
                public Properties386 properties { get; set; }
            }

            public class Properties386
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Mixclip
            {
                public Properties387 properties { get; set; }
            }

            public class Properties387
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Steadyaim2
            {
                public Properties388 properties { get; set; }
            }

            public class Properties388
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Scope3x
            {
                public Properties389 properties { get; set; }
            }

            public class Properties389
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Acog
            {
                public Properties390 properties { get; set; }
            }

            public class Properties390
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Mixbody2
            {
                public Properties391 properties { get; set; }
            }

            public class Properties391
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Suppressed
            {
                public Properties392 properties { get; set; }
            }

            public class Properties392
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Extclip
            {
                public Properties393 properties { get; set; }
            }

            public class Properties393
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Reddot
            {
                public Properties394 properties { get; set; }
            }

            public class Properties394
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Barrel
            {
                public Properties395 properties { get; set; }
            }

            public class Properties395
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Compensator2
            {
                public Properties396 properties { get; set; }
            }

            public class Properties396
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Grip
            {
                public Properties397 properties { get; set; }
            }

            public class Properties397
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Fastreload2
            {
                public Properties398 properties { get; set; }
            }

            public class Properties398
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Elo3
            {
                public Properties399 properties { get; set; }
            }

            public class Properties399
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Mixstock
            {
                public Properties400 properties { get; set; }
            }

            public class Properties400
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Stalker
            {
                public Properties401 properties { get; set; }
            }

            public class Properties401
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Elo2
            {
                public Properties402 properties { get; set; }
            }

            public class Properties402
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Speedgrip2
            {
                public Properties403 properties { get; set; }
            }

            public class Properties403
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Barrel2
            {
                public Properties404 properties { get; set; }
            }

            public class Properties404
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Mixhandle
            {
                public Properties405 properties { get; set; }
            }

            public class Properties405
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Reflex3
            {
                public Properties406 properties { get; set; }
            }

            public class Properties406
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Steadyaim
            {
                public Properties407 properties { get; set; }
            }

            public class Properties407
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Elo
            {
                public Properties408 properties { get; set; }
            }

            public class Properties408
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Mixmuzzle
            {
                public Properties409 properties { get; set; }
            }

            public class Properties409
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Reflex2
            {
                public Properties410 properties { get; set; }
            }

            public class Properties410
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Handle
            {
                public Properties411 properties { get; set; }
            }

            public class Properties411
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Reflex
            {
                public Properties412 properties { get; set; }
            }

            public class Properties412
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Compensator
            {
                public Properties413 properties { get; set; }
            }

            public class Properties413
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Heavy
            {
                public Properties414 properties { get; set; }
            }

            public class Properties414
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Mixbarrel
            {
                public Properties415 properties { get; set; }
            }

            public class Properties415
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Light
            {
                public Properties416 properties { get; set; }
            }

            public class Properties416
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Scope4x
            {
                public Properties417 properties { get; set; }
            }

            public class Properties417
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Suppressed2
            {
                public Properties418 properties { get; set; }
            }

            public class Properties418
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Holo
            {
                public Properties419 properties { get; set; }
            }

            public class Properties419
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Extclip2
            {
                public Properties420 properties { get; set; }
            }

            public class Properties420
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Speedgrip
            {
                public Properties421 properties { get; set; }
            }

            public class Properties421
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Heavy2
            {
                public Properties422 properties { get; set; }
            }

            public class Properties422
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }

            public class Quickdraw
            {
                public Properties423 properties { get; set; }
            }

            public class Properties423
            {
                public float kills { get; set; }
                public float challenge7 { get; set; }
                public float challenge4 { get; set; }
                public float timeUsed { get; set; }
                public float challenge3 { get; set; }
                public float challenges { get; set; }
                public float challenge6 { get; set; }
                public float challenge5 { get; set; }
                public float used { get; set; }
                public float deathsDuringUse { get; set; }
                public float ekia { get; set; }
                public float masterCraftCamoProgression { get; set; }
                public float headshots { get; set; }
                public float assists { get; set; }
                public float challenge2 { get; set; }
                public float challenge1 { get; set; }
                public float deaths { get; set; }
                public float killstreak30 { get; set; }
                public float gamesUsed { get; set; }
                public float combatRecordStat { get; set; }
                public float hits { get; set; }
                public float destroyed { get; set; }
                public float backstabberKill { get; set; }
                public float damageDone { get; set; }
                public float shots { get; set; }
            }
        }

        public class Scorestreakdata
        {
            public Scorestreakdata1 scorestreakData { get; set; }
        }

        public class Scorestreakdata1
        {
            public Ac1301 ac130 { get; set; }
            public Sig_Lmg1 sig_lmg { get; set; }
            public Uav1 uav { get; set; }
            public Counteruav1 counteruav { get; set; }
            public Napalm_Strike1 napalm_strike { get; set; }
            public Supplydrop_Marker1 supplydrop_marker { get; set; }
            public Chopper_Gunner1 chopper_gunner { get; set; }
            public Jetfighter1 jetfighter { get; set; }
            public Planemortar1 planemortar { get; set; }
            public Hoverjet1 hoverjet { get; set; }
            public Helicopter_Comlink1 helicopter_comlink { get; set; }
            public Sig_Bow_Flame1 sig_bow_flame { get; set; }
            public Hero_Pineapplegun1 hero_pineapplegun { get; set; }
            public Ultimate_Turret1 ultimate_turret { get; set; }
            public Weapon_Armor1 weapon_armor { get; set; }
            public Recon_Car1 recon_car { get; set; }
            public Remote_Missile1 remote_missile { get; set; }
            public Recon_Plane1 recon_plane { get; set; }
        }

        public class Ac1301
        {
            public Properties424 properties { get; set; }
        }

        public class Properties424
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Sig_Lmg1
        {
            public Properties425 properties { get; set; }
        }

        public class Properties425
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Uav1
        {
            public Properties426 properties { get; set; }
        }

        public class Properties426
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Counteruav1
        {
            public Properties427 properties { get; set; }
        }

        public class Properties427
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Napalm_Strike1
        {
            public Properties428 properties { get; set; }
        }

        public class Properties428
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Supplydrop_Marker1
        {
            public Properties429 properties { get; set; }
        }

        public class Properties429
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Chopper_Gunner1
        {
            public Properties430 properties { get; set; }
        }

        public class Properties430
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Jetfighter1
        {
            public Properties431 properties { get; set; }
        }

        public class Properties431
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Planemortar1
        {
            public Properties432 properties { get; set; }
        }

        public class Properties432
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Hoverjet1
        {
            public Properties433 properties { get; set; }
        }

        public class Properties433
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Helicopter_Comlink1
        {
            public Properties434 properties { get; set; }
        }

        public class Properties434
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Sig_Bow_Flame1
        {
            public Properties435 properties { get; set; }
        }

        public class Properties435
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Hero_Pineapplegun1
        {
            public Properties436 properties { get; set; }
        }

        public class Properties436
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Ultimate_Turret1
        {
            public Properties437 properties { get; set; }
        }

        public class Properties437
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Weapon_Armor1
        {
            public Properties438 properties { get; set; }
        }

        public class Properties438
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Recon_Car1
        {
            public Properties439 properties { get; set; }
        }

        public class Properties439
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Remote_Missile1
        {
            public Properties440 properties { get; set; }
        }

        public class Properties440
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Recon_Plane1
        {
            public Properties441 properties { get; set; }
        }

        public class Properties441
        {
            public float kills { get; set; }
            public float bestAssists { get; set; }
            public float destructions { get; set; }
            public float enemyCarePackageCaptures { get; set; }
            public float bestKillsPerGame { get; set; }
            public float multikillForMedalSpotlight { get; set; }
            public float bestKills { get; set; }
            public float bestDestructions { get; set; }
            public float bestEnemyCarePackageCaptures { get; set; }
            public float assists { get; set; }
            public float bestKillsPerUse { get; set; }
            public float uses { get; set; }
            public float armoredKills { get; set; }
            public float deaths { get; set; }
        }

        public class Weekly
        {
            public All1 all { get; set; }
            public Mode1 mode { get; set; }
            public Map1 map { get; set; }
        }

        public class All1
        {
            public Properties442 properties { get; set; }
        }

        public class Properties442
        {
            public float kills { get; set; }
            public float ekiadRatio { get; set; }
            public float accuracy { get; set; }
            public float losses { get; set; }
            public float avgLifeTime { get; set; }
            public float shotsLanded { get; set; }
            public float highestMultikill { get; set; }
            public float ekia { get; set; }
            public float score { get; set; }
            public float headshots { get; set; }
            public float assists { get; set; }
            public float ekiaPerGame { get; set; }
            public float draws { get; set; }
            public float scorePerMinute { get; set; }
            public float deaths { get; set; }
            public float damageDealt { get; set; }
            public float wins { get; set; }
            public float kdRatio { get; set; }
            public float shotsMissed { get; set; }
            public float multikills { get; set; }
            public float highestStreak { get; set; }
            public float scorePerGame { get; set; }
            public float hits { get; set; }
            public float timePlayed { get; set; }
            public float headshotPercentage { get; set; }
            public float matchesPlayed { get; set; }
            public float suicides { get; set; }
            public float wlRatio { get; set; }
            public float timePlayedAlive { get; set; }
            public float objectives { get; set; }
            public float shots { get; set; }
            public float shotsFired { get; set; }
        }

        public class Mode1
        {
            public Dom_Hc19 dom_hc { get; set; }
        }

        public class Dom_Hc19
        {
            public Properties443 properties { get; set; }
        }

        public class Properties443
        {
            public float kills { get; set; }
            public float ekiadRatio { get; set; }
            public float accuracy { get; set; }
            public float losses { get; set; }
            public float avgLifeTime { get; set; }
            public float shotsLanded { get; set; }
            public float highestMultikill { get; set; }
            public float ekia { get; set; }
            public float score { get; set; }
            public float headshots { get; set; }
            public float assists { get; set; }
            public float ekiaPerGame { get; set; }
            public float draws { get; set; }
            public float scorePerMinute { get; set; }
            public float deaths { get; set; }
            public float damageDealt { get; set; }
            public float wins { get; set; }
            public float kdRatio { get; set; }
            public float shotsMissed { get; set; }
            public float multikills { get; set; }
            public float highestStreak { get; set; }
            public float scorePerGame { get; set; }
            public float hits { get; set; }
            public float timePlayed { get; set; }
            public float headshotPercentage { get; set; }
            public float matchesPlayed { get; set; }
            public float suicides { get; set; }
            public float wlRatio { get; set; }
            public float timePlayedAlive { get; set; }
            public float objectives { get; set; }
            public float shots { get; set; }
            public float shotsFired { get; set; }
        }

        public class Map1
        {
        }
    }

    public class CWMapList : baseResponse
    {
        public new Data data { get; set; }
        public new class Data
        {
            public string[] mp_miami { get; set; }
            public string[] mp_sm_finance { get; set; }
            public string[] wz_ski_slopes { get; set; }
            public string[] mp_sm_berlin_tunnel { get; set; }
            public string[] mp_nuketown6 { get; set; }
            public string[] mp_satellite { get; set; }
            public string[] mp_tundra { get; set; }
            public string[] mp_sm_game_show { get; set; }
            public string[] mp_cartel { get; set; }
            public string[] mp_tank { get; set; }
            public string[] mp_black_sea { get; set; }
            public string[] mp_apocalypse { get; set; }
            public string[] mp_sm_central { get; set; }
            public string[] wz_forest { get; set; }
            public string[] wz_sanatorium { get; set; }
            public string[] mp_raid_rm { get; set; }
            public string[] mp_kgb { get; set; }
            public string[] mp_express_rm { get; set; }
            public string[] mp_moscow { get; set; }
        }
    }

    public class CWDetailedMatchInfo : baseResponse
    {
        public new Data data { get; set; }

        public new class Data
        {
            public Summary summary { get; set; }
            public Match[] matches { get; set; }
            public class Summary
            {
                public All all { get; set; }
                public Control_Cdl control_cdl { get; set; }
                public Dom dom { get; set; }
                public Tdm_Snipe_Bb tdm_snipe_bb { get; set; }
                public Conf_Hc conf_hc { get; set; }
                public Sd_Cdl sd_cdl { get; set; }
                public Conf conf { get; set; }
                public Dom_Snipe_Bb dom_snipe_bb { get; set; }
                public Dom_Hc dom_hc { get; set; }
                public Koth_Cdl koth_cdl { get; set; }
                public class All
                {
                    public float kills { get; set; }
                    public float ekiadRatio { get; set; }
                    public float accuracy { get; set; }
                    public float losses { get; set; }
                    public float avgLifeTime { get; set; }
                    public float shotsLanded { get; set; }
                    public float highestMultikill { get; set; }
                    public float ekia { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float ekiaPerGame { get; set; }
                    public float draws { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                    public float damageDealt { get; set; }
                    public float wins { get; set; }
                    public float kdRatio { get; set; }
                    public float shotsMissed { get; set; }
                    public float multikills { get; set; }
                    public float highestStreak { get; set; }
                    public float scorePerGame { get; set; }
                    public float hits { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float matchesPlayed { get; set; }
                    public float suicides { get; set; }
                    public float wlRatio { get; set; }
                    public float timePlayedAlive { get; set; }
                    public float objectives { get; set; }
                    public float shots { get; set; }
                    public float shotsFired { get; set; }
                }

                public class Control_Cdl
                {
                    public float kills { get; set; }
                    public float ekiadRatio { get; set; }
                    public float accuracy { get; set; }
                    public float losses { get; set; }
                    public float avgLifeTime { get; set; }
                    public float shotsLanded { get; set; }
                    public float highestMultikill { get; set; }
                    public float ekia { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float ekiaPerGame { get; set; }
                    public float draws { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                    public float damageDealt { get; set; }
                    public float wins { get; set; }
                    public float kdRatio { get; set; }
                    public float shotsMissed { get; set; }
                    public float multikills { get; set; }
                    public float highestStreak { get; set; }
                    public float scorePerGame { get; set; }
                    public float hits { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float matchesPlayed { get; set; }
                    public float suicides { get; set; }
                    public float wlRatio { get; set; }
                    public float timePlayedAlive { get; set; }
                    public float objectives { get; set; }
                    public float shots { get; set; }
                    public float shotsFired { get; set; }
                }

                public class Dom
                {
                    public float kills { get; set; }
                    public float ekiadRatio { get; set; }
                    public float accuracy { get; set; }
                    public float losses { get; set; }
                    public float avgLifeTime { get; set; }
                    public float shotsLanded { get; set; }
                    public float highestMultikill { get; set; }
                    public float ekia { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float ekiaPerGame { get; set; }
                    public float draws { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                    public float damageDealt { get; set; }
                    public float wins { get; set; }
                    public float kdRatio { get; set; }
                    public float shotsMissed { get; set; }
                    public float multikills { get; set; }
                    public float highestStreak { get; set; }
                    public float scorePerGame { get; set; }
                    public float hits { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float matchesPlayed { get; set; }
                    public float suicides { get; set; }
                    public float wlRatio { get; set; }
                    public float timePlayedAlive { get; set; }
                    public float objectives { get; set; }
                    public float shots { get; set; }
                    public float shotsFired { get; set; }
                }

                public class Tdm_Snipe_Bb
                {
                    public float kills { get; set; }
                    public float ekiadRatio { get; set; }
                    public float accuracy { get; set; }
                    public float losses { get; set; }
                    public float avgLifeTime { get; set; }
                    public float shotsLanded { get; set; }
                    public float highestMultikill { get; set; }
                    public float ekia { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float ekiaPerGame { get; set; }
                    public float draws { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                    public float damageDealt { get; set; }
                    public float wins { get; set; }
                    public float kdRatio { get; set; }
                    public float shotsMissed { get; set; }
                    public float multikills { get; set; }
                    public float highestStreak { get; set; }
                    public float scorePerGame { get; set; }
                    public float hits { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float matchesPlayed { get; set; }
                    public float suicides { get; set; }
                    public float wlRatio { get; set; }
                    public float timePlayedAlive { get; set; }
                    public float objectives { get; set; }
                    public float shots { get; set; }
                    public float shotsFired { get; set; }
                }

                public class Conf_Hc
                {
                    public float kills { get; set; }
                    public float ekiadRatio { get; set; }
                    public float accuracy { get; set; }
                    public float losses { get; set; }
                    public float avgLifeTime { get; set; }
                    public float shotsLanded { get; set; }
                    public float highestMultikill { get; set; }
                    public float ekia { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float ekiaPerGame { get; set; }
                    public float draws { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                    public float damageDealt { get; set; }
                    public float wins { get; set; }
                    public float kdRatio { get; set; }
                    public float shotsMissed { get; set; }
                    public float multikills { get; set; }
                    public float highestStreak { get; set; }
                    public float scorePerGame { get; set; }
                    public float hits { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float matchesPlayed { get; set; }
                    public float suicides { get; set; }
                    public float wlRatio { get; set; }
                    public float timePlayedAlive { get; set; }
                    public float objectives { get; set; }
                    public float shots { get; set; }
                    public float shotsFired { get; set; }
                }

                public class Sd_Cdl
                {
                    public float kills { get; set; }
                    public float ekiadRatio { get; set; }
                    public float accuracy { get; set; }
                    public float losses { get; set; }
                    public float avgLifeTime { get; set; }
                    public float shotsLanded { get; set; }
                    public float highestMultikill { get; set; }
                    public float ekia { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float ekiaPerGame { get; set; }
                    public float draws { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                    public float damageDealt { get; set; }
                    public float wins { get; set; }
                    public float kdRatio { get; set; }
                    public float shotsMissed { get; set; }
                    public float multikills { get; set; }
                    public float highestStreak { get; set; }
                    public float scorePerGame { get; set; }
                    public float hits { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float matchesPlayed { get; set; }
                    public float suicides { get; set; }
                    public float wlRatio { get; set; }
                    public float timePlayedAlive { get; set; }
                    public float objectives { get; set; }
                    public float shots { get; set; }
                    public float shotsFired { get; set; }
                }

                public class Conf
                {
                    public float kills { get; set; }
                    public float ekiadRatio { get; set; }
                    public float accuracy { get; set; }
                    public float losses { get; set; }
                    public float avgLifeTime { get; set; }
                    public float shotsLanded { get; set; }
                    public float highestMultikill { get; set; }
                    public float ekia { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float ekiaPerGame { get; set; }
                    public float draws { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                    public float damageDealt { get; set; }
                    public float wins { get; set; }
                    public float kdRatio { get; set; }
                    public float shotsMissed { get; set; }
                    public float multikills { get; set; }
                    public float highestStreak { get; set; }
                    public float scorePerGame { get; set; }
                    public float hits { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float matchesPlayed { get; set; }
                    public float suicides { get; set; }
                    public float wlRatio { get; set; }
                    public float timePlayedAlive { get; set; }
                    public float objectives { get; set; }
                    public float shots { get; set; }
                    public float shotsFired { get; set; }
                }

                public class Dom_Snipe_Bb
                {
                    public float kills { get; set; }
                    public float ekiadRatio { get; set; }
                    public float accuracy { get; set; }
                    public float losses { get; set; }
                    public float avgLifeTime { get; set; }
                    public float shotsLanded { get; set; }
                    public float highestMultikill { get; set; }
                    public float ekia { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float ekiaPerGame { get; set; }
                    public float draws { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                    public float damageDealt { get; set; }
                    public float wins { get; set; }
                    public float kdRatio { get; set; }
                    public float shotsMissed { get; set; }
                    public float multikills { get; set; }
                    public float highestStreak { get; set; }
                    public float scorePerGame { get; set; }
                    public float hits { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float matchesPlayed { get; set; }
                    public float suicides { get; set; }
                    public float wlRatio { get; set; }
                    public float timePlayedAlive { get; set; }
                    public float objectives { get; set; }
                    public float shots { get; set; }
                    public float shotsFired { get; set; }
                }

                public class Dom_Hc
                {
                    public float kills { get; set; }
                    public float ekiadRatio { get; set; }
                    public float accuracy { get; set; }
                    public float losses { get; set; }
                    public float avgLifeTime { get; set; }
                    public float shotsLanded { get; set; }
                    public float highestMultikill { get; set; }
                    public float ekia { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float ekiaPerGame { get; set; }
                    public float draws { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                    public float damageDealt { get; set; }
                    public float wins { get; set; }
                    public float kdRatio { get; set; }
                    public float shotsMissed { get; set; }
                    public float multikills { get; set; }
                    public float highestStreak { get; set; }
                    public float scorePerGame { get; set; }
                    public float hits { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float matchesPlayed { get; set; }
                    public float suicides { get; set; }
                    public float wlRatio { get; set; }
                    public float timePlayedAlive { get; set; }
                    public float objectives { get; set; }
                    public float shots { get; set; }
                    public float shotsFired { get; set; }
                }

                public class Koth_Cdl
                {
                    public float kills { get; set; }
                    public float ekiadRatio { get; set; }
                    public float accuracy { get; set; }
                    public float losses { get; set; }
                    public float avgLifeTime { get; set; }
                    public float shotsLanded { get; set; }
                    public float highestMultikill { get; set; }
                    public float ekia { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float ekiaPerGame { get; set; }
                    public float draws { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                    public float damageDealt { get; set; }
                    public float wins { get; set; }
                    public float kdRatio { get; set; }
                    public float shotsMissed { get; set; }
                    public float multikills { get; set; }
                    public float highestStreak { get; set; }
                    public float scorePerGame { get; set; }
                    public float hits { get; set; }
                    public float timePlayed { get; set; }
                    public float headshotPercentage { get; set; }
                    public float matchesPlayed { get; set; }
                    public float suicides { get; set; }
                    public float wlRatio { get; set; }
                    public float timePlayedAlive { get; set; }
                    public float objectives { get; set; }
                    public float shots { get; set; }
                    public float shotsFired { get; set; }
                }
            }

            public class Match
            {
                public int utcStartSeconds { get; set; }
                public int utcEndSeconds { get; set; }
                public string map { get; set; }
                public string mode { get; set; }
                public string matchID { get; set; }
                public int duration { get; set; }
                public object playlistName { get; set; }
                public int version { get; set; }
                public string gameType { get; set; }
                public string result { get; set; }
                public object winningTeam { get; set; }
                public bool gameBattle { get; set; }
                public int team1Score { get; set; }
                public int team2Score { get; set; }
                public bool isPresentAtEnd { get; set; }
                public Player player { get; set; }
                public Playerstats playerStats { get; set; }
                public Weaponstats weaponStats { get; set; }
                public object allPlayers { get; set; }
                public bool arena { get; set; }
                public bool privateMatch { get; set; }
                public class Player
                {
                    public string team { get; set; }
                    public Awards awards { get; set; }
                    public string nemesis { get; set; }
                    public string mostKilled { get; set; }
                    public string platform { get; set; }
                    public object[] loadout { get; set; }
                    public class Awards
                    {
                    }
                }
                public class Playerstats
                {
                    public float kills { get; set; }
                    public float xpAtEnd { get; set; }
                    public float ekiadRatio { get; set; }
                    public float rankAtEnd { get; set; }
                    public float accuracy { get; set; }
                    public float shotsLanded { get; set; }
                    public float highestMultikill { get; set; }
                    public float ekia { get; set; }
                    public float score { get; set; }
                    public float headshots { get; set; }
                    public float assists { get; set; }
                    public float scorePerMinute { get; set; }
                    public float deaths { get; set; }
                    public float damageDealt { get; set; }
                    public float kdRatio { get; set; }
                    public float shotsMissed { get; set; }
                    public float multikills { get; set; }
                    public float highestStreak { get; set; }
                    public float hits { get; set; }
                    public float timePlayed { get; set; }
                    public float suicides { get; set; }
                    public float timePlayedAlive { get; set; }
                    public float objectives { get; set; }
                    public float shots { get; set; }
                    public float shotsFired { get; set; }
                }
                public class Weaponstats
                {
                }
            }
        }
    }

    public class codPoints : baseResponse
    {
        public new Data data { get; set; }
        public new class Data
        {
            public int codPoints { get; set; }
        }
    }

    public enum platforms
    {
        [Description("Xbox")] xbl,
        [Description("Playstation")] psn,
        [Description("Steam")] steam,
        [Description("BattleNET")] battle,
        [Description("Numerical Activision ID")] uno,
        [Description("Activision ID")] acti,
        [Description("All platforms - Fuzzy Search Only")] all
    }

    public enum friendActions
    {
        [Description("Send a friend request")] invite,
        [Description("Revoke a friend request")] uninvite,
        [Description("Remove friend from friendslist")] remove,
        [Description("Block a user")] block,
        [Description("Revoke a block action")] unblock
    }

    public enum friendVisibility
    {
        [Description("Everyone can search for your profile")] all,
        [Description("Noone can search for your profile")] none,
        [Description("Friends can search for your profile")] friends,
        [Description("Friends and Tournament organisers can search for your profile")] friends_tourneys
    }
}