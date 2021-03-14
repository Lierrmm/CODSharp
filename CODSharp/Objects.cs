using System.ComponentModel;

namespace CODSharp
{
    public class baseResponse
    {
        public string status { get; set; }
    }

    public class WZStats : baseResponse
    {
        public Data data { get; set; }

        public class Data
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
        public Data data { get; set; }
        public class Data
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
        public Datum[] data { get; set; }
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
        public Data data { get; set; }
        public class Data
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
        public Datum[] data { get; set; }
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
        public Data data { get; set; }

        public class Data
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
        public Data data { get; set; }

        public class Data
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