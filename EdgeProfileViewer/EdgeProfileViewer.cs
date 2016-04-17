using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace EdgeProfileViewer
{
    public partial class EdgeProfileViewer : Form
    {
        public EdgeProfileViewer()
        {
            InitializeComponent();
        }

        public static Dictionary<int, object[]> level_list = LoadLevelList();
        public int total_time, total_prisms_collected, total_level_prisms;
        public string[] lang_text = { "法语", "英语", "德语", "西班牙语", "意大利语", "葡萄牙语", "日语" },
            control_text = { "滑动", "重力感应", "虚拟键盘" },
            rank_text = { "D", "C", "B", "A", "S", "S+" };
        public object level_name, splus_time, s_time, a_time, b_time, c_time, level_prisms;

        public void ReadProfile()
        {
            try
            {
                FileStream file = new FileStream(ProfilePath.Text, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(file);
                try
                {
                    int version = reader.ReadInt32();
                    byte control = reader.ReadByte();
                    int unknown_int_1 = reader.ReadInt32();
                    int unknown_int_2 = reader.ReadInt32();
                    int unknown_int_3 = reader.ReadInt32();
                    bool music = reader.ReadBoolean();
                    bool sound = reader.ReadBoolean();
                    bool unknown_bool_1 = reader.ReadBoolean();
                    int best_edge_time = reader.ReadInt32();
                    byte language_index = reader.ReadByte();
                    int unknown_int_4 = reader.ReadInt32();
                    int unknown_int_5 = reader.ReadInt32();

                    int levels_count = reader.ReadInt32();
                    ReadLevelData(reader, levels_count, "Normal");

                    int normal_total_time = total_time,
                        normal_total_prisms_collected = total_prisms_collected,
                        normal_total_level_prisms = total_level_prisms;

                    NormalTotal.Text = "标准关：用时 " + FormatTime(normal_total_time) + "，收集 " +
                        normal_total_prisms_collected + " / " + normal_total_level_prisms + " 个棱柱";

                    int last_normal_level = reader.ReadInt32();
                    int unknown_int_6 = reader.ReadInt32();

                    levels_count = reader.ReadInt32();
                    ReadLevelData(reader, levels_count, "Bonus");

                    int bonus_total_time = total_time,
                        bonus_total_prisms_collected = total_prisms_collected,
                        bonus_total_level_prisms = total_level_prisms;

                    BonusTotal.Text = "奖励关：用时 " + FormatTime(bonus_total_time) + "，收集 " +
                        bonus_total_prisms_collected + " / " + bonus_total_level_prisms + " 个棱柱";

                    AllTotal.Text = "所有关：用时 " + FormatTime(normal_total_time + bonus_total_time) + "，收集 " +
                        (normal_total_prisms_collected + bonus_total_prisms_collected) + " / " + (normal_total_level_prisms + bonus_total_level_prisms) + " 个棱柱";

                    int last_bonus_level = reader.ReadInt32();
                    int unknown_int_7 = reader.ReadInt32();

                    var user_name_length = reader.ReadInt32();
                    UserName.Text += Encoding.UTF8.GetString(reader.ReadBytes(user_name_length));

                    var password_length = reader.ReadInt32();
                    Password.Text = Encoding.UTF8.GetString(reader.ReadBytes(password_length));

                    bool unknown_bool_2 = reader.ReadBoolean();
                    int unknown_int_8 = reader.ReadInt32();
                    int unknown_int_9 = reader.ReadInt32();
                    byte d_pad_side = reader.ReadByte();
                    byte d_pad_side_type = reader.ReadByte();
                    bool turbo = reader.ReadBoolean();
                    bool unknown_bool_3 = reader.ReadBoolean();
                    bool ghost = reader.ReadBoolean();
                    bool unknown_bool_4 = reader.ReadBoolean();
                    int unknown_int_10 = reader.ReadInt32();
                    int orientation = reader.ReadInt32();

                    Music.Checked = music;
                    Sound.Checked = sound;
                    Turbo.Checked = turbo;
                    Ghost.Checked = ghost;

                    Control.Text += control_text[control];
                    BestEdgeTime.Text += FormatTime(best_edge_time);
                    Lang.Text += lang_text[language_index];
                    Orientation.Text += orientation;
                }
                catch
                {
                    MessageBox.Show("存档文件不合法。", "加载失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("找不到指定的存档文件。", "加载失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        public void ReadLevelData(BinaryReader reader, int levels_count, string type)
        {
            total_time = total_prisms_collected = total_level_prisms = 0;
            for (var i = 1; i <= levels_count; i++)
            {
                int level_id = reader.ReadInt32();

                if (level_id == 535)
                    type = "Extended";

                int level_time = reader.ReadInt32();
                int prisms_collected = reader.ReadInt32();
                int rank_index = reader.ReadInt32();

                total_time += level_time;
                total_prisms_collected += prisms_collected;

                level_name = splus_time = s_time = a_time = b_time = c_time = level_prisms = "";
                if (level_list.ContainsKey(level_id))
                {
                    level_name = level_list[level_id][0];
                    splus_time = level_list[level_id][1];
                    s_time = level_list[level_id][2];
                    a_time = level_list[level_id][3];
                    b_time = level_list[level_id][4];
                    c_time = level_list[level_id][5];
                    level_prisms = level_list[level_id][6];
                    total_level_prisms += (int)level_prisms;
                }
                LevelData.Rows.Add(type + " #" + i, level_id, level_name, FormatTime(level_time),
                    splus_time, s_time, a_time, b_time, c_time, prisms_collected + " / " + level_prisms, prisms_collected,
                    rank_text[rank_index], rank_index);
            }
        }

        public static Dictionary<int, object[]> LoadLevelList()
        {
            var level_list = new Dictionary<int, object[]>();

            // normal levels
            level_list.Add(309, new object[] { "1st contact", "9\"", "25\"", "55\"", "1' 25\"", "2' 25\"", 4 });
            level_list.Add(300, new object[] { "training", "29\"", "33\"", "1' 05\"", "1' 35\"", "2' 40\"", 7 });
            level_list.Add(310, new object[] { "playground", "41\"", "46\"", "50\"", "1' 00\"", "1' 20\"", 8 });
            level_list.Add(36, new object[] { "pushing stars", "35\"", "37\"", "55\"", "1' 25\"", "2' 25\"", 7 });
            level_list.Add(201, new object[] { "bump", "21\"", "25\"", "48\"", "1' 50\"", "3' 20\"", 4 });
            level_list.Add(37, new object[] { "city rythm", "41\"", "46\"", "1' 00\"", "1' 45\"", "3' 10\"", 9 });
            level_list.Add(311, new object[] { "speedrun", "39\"", "45\"", "1' 00\"", "1' 20\"", "2' 00\"", 7 });
            level_list.Add(38, new object[] { "milky way", "1' 01\"", "1' 09\"", "1' 32\"", "2' 38\"", "4' 00\"", 4 });
            level_list.Add(59, new object[] { "8-bit", "47\"", "53\"", "1' 10\"", "2' 05\"", "2' 40\"", 10 });
            level_list.Add(301, new object[] { "metro", "51\"", "55\"", "1' 18\"", "2' 00\"", "3' 10\"", 11 });
            level_list.Add(40, new object[] { "mini me", "55\"", "59\"", "1' 20\"", "1' 40\"", "3' 00\"", 9 });
            level_list.Add(43, new object[] { "vertex", "1' 07\"", "1' 11\"", "1' 35\"", "2' 18\"", "4' 10\"", 7 });
            level_list.Add(206, new object[] { "equalizer", "41\"", "50\"", "1' 10\"", "2' 00\"", "3' 20\"", 6 });
            level_list.Add(312, new object[] { "peripherique", "43\"", "56\"", "1' 40\"", "2' 00\"", "2' 40\"", 6 });
            level_list.Add(44, new object[] { "time machine", "1' 04\"", "1' 08\"", "1' 35\"", "2' 20\"", "4' 00\"", 11 });
            level_list.Add(42, new object[] { "mind the gap", "1' 17\"", "1' 26\"", "1' 35\"", "2' 35\"", "4' 10\"", 7 });
            level_list.Add(315, new object[] { "edge code", "39\"", "45\"", "1' 00\"", "1' 20\"", "2' 00\"", 4 });
            level_list.Add(45, new object[] { "edge time", "55\"", "1' 15\"", "2' 00\"", "4' 50\"", "6' 40\"", 20 });
            level_list.Add(46, new object[] { "chase", "1' 15\"", "1' 22\"", "2' 00\"", "4' 50\"", "6' 50\"", 15 });
            level_list.Add(60, new object[] { "landing", "1' 06\"", "1' 13\"", "1' 35\"", "1' 40\"", "1' 58\"", 13 });
            level_list.Add(307, new object[] { "chess", "1' 20\"", "1' 25\"", "2' 00\"", "2' 40\"", "3' 10\"", 13 });
            level_list.Add(48, new object[] { "switch keep", "1' 15\"", "1' 20\"", "1' 50\"", "3' 30\"", "5' 00\"", 20 });
            level_list.Add(202, new object[] { "mecanic", "30\"", "38\"", "1' 05\"", "1' 40\"", "3' 00\"", 5 });
            level_list.Add(305, new object[] { "higher", "1' 39\"", "1' 44\"", "2' 10\"", "3' 00\"", "3' 30\"", 13 });
            level_list.Add(41, new object[] { "squadron", "55\"", "1' 00\"", "1' 17\"", "2' 10\"", "4' 00\"", 9 });
            level_list.Add(303, new object[] { "metronome", "1' 28\"", "1' 35\"", "2' 00\"", "2' 40\"", "3' 20\"", 17 });
            level_list.Add(49, new object[] { "orion", "2' 02\"", "2' 13\"", "3' 20\"", "5' 50\"", "9' 10\"", 18 });
            level_list.Add(302, new object[] { "try again", "1' 47\"", "1' 51\"", "2' 30\"", "3' 30\"", "4' 20\"", 14 });
            level_list.Add(204, new object[] { "hypnozone", "1' 24\"", "1' 30\"", "1' 48\"", "2' 46\"", "4' 42\"", 13 });
            level_list.Add(304, new object[] { "beat", "1' 42\"", "1' 51\"", "2' 31\"", "3' 20\"", "3' 50\"", 12 });
            level_list.Add(52, new object[] { "star castle", "1' 06\"", "1' 10\"", "2' 00\"", "3' 50\"", "5' 50\"", 8 });
            level_list.Add(308, new object[] { "sticker", "1' 58\"", "2' 03\"", "2' 50\"", "3' 30\"", "4' 10\"", 15 });
            level_list.Add(50, new object[] { "sync the wall", "1' 43\"", "1' 50\"", "2' 30\"", "5' 20\"", "9' 00\"", 10 });
            level_list.Add(306, new object[] { "snap", "1' 54\"", "2' 00\"", "2' 40\"", "3' 10\"", "4' 00\"", 12 });
            level_list.Add(51, new object[] { "braintonic", "1' 55\"", "2' 09\"", "2' 40\"", "4' 40\"", "8' 00\"", 15 });
            level_list.Add(313, new object[] { "2nd contact", "35\"", "38\"", "1' 00\"", "1' 50\"", "3' 00\"", 5 });
            level_list.Add(47, new object[] { "jungle fever", "59\"", "1' 05\"", "1' 28\"", "3' 00\"", "6' 20\"", 17 });
            level_list.Add(314, new object[] { "speedrun 2", "1' 00\"", "1' 06\"", "1' 30\"", "2' 10\"", "3' 40\"", 10 });
            level_list.Add(53, new object[] { "edge master", "1' 24\"", "1' 34\"", "1' 58\"", "5' 00\"", "10' 40\"", 14 });
            level_list.Add(54, new object[] { "cube invaders", "2' 35\"", "2' 50\"", "5' 30\"", "8' 50\"", "14' 00\"", 16 });
            level_list.Add(317, new object[] { "starfield", "2' 07\"", "2' 12\"", "2' 42\"", "3' 22\"", "4' 02\"", 18 });
            level_list.Add(319, new object[] { "bonus", "4' 20\"", "4' 30\"", "5' 10\"", "6' 20\"", "6' 40\"", 9 });
            level_list.Add(318, new object[] { "extra cube", "3' 09\"", "3' 19\"", "4' 10\"", "5' 00\"", "5' 50\"", 12 });
            level_list.Add(222, new object[] { "sliced", "1' 40\"", "1' 45\"", "2' 20\"", "4' 10\"", "7' 30\"", 17 });
            level_list.Add(221, new object[] { "earthquake", "3' 22\"", "3' 30\"", "3' 50\"", "5' 50\"", "8' 40\"", 11 });
            level_list.Add(220, new object[] { "vertigo", "2' 35\"", "2' 40\"", "3' 15\"", "4' 00\"", "8' 00\"", 20 });
            level_list.Add(400, new object[] { "push me", "1' 27\"", "1' 33\"", "1' 40\"", "2' 10\"", "2' 55\"", 6 });
            level_list.Add(401, new object[] { "perfect cell", "2' 54\"", "3' 00\"", "3' 25\"", "3' 50\"", "4' 30\"", 18 });

            // bonus levels
            level_list.Add(815, new object[] { "hangout", "48\"", "56\"", "1' 20\"", "2' 20\"", "4' 20\"", 9 });
            level_list.Add(810, new object[] { "hammer", "1' 35\"", "1' 48\"", "2' 04\"", "3' 00\"", "6' 20\"", 15 });
            level_list.Add(805, new object[] { "compost", "1' 30\"", "1' 40\"", "2' 00\"", "3' 00\"", "6' 20\"", 10 });
            level_list.Add(817, new object[] { "babylonian", "53\"", "1' 01\"", "1' 24\"", "2' 20\"", "4' 40\"", 8 });
            level_list.Add(801, new object[] { "swirl", "1' 25\"", "1' 30\"", "1' 40\"", "2' 00\"", "6' 20\"", 14 });
            level_list.Add(806, new object[] { "density", "45\"", "55\"", "1' 05\"", "1' 30\"", "1' 45\"", 5 });
            level_list.Add(811, new object[] { "magic", "55\"", "1' 06\"", "1' 28\"", "1' 51\"", "3' 42\"", 15 });
            level_list.Add(808, new object[] { "cubism", "39\"", "43\"", "52\"", "1' 04\"", "1' 30\"", 6 });
            level_list.Add(813, new object[] { "mystic", "1' 55\"", "2' 00\"", "2' 10\"", "3' 00\"", "6' 20\"", 14 });
            level_list.Add(804, new object[] { "indiana", "2' 33\"", "2' 45\"", "2' 55\"", "3' 30\"", "6' 20\"", 18 });
            level_list.Add(816, new object[] { "chunk", "58\"", "1' 07\"", "1' 15\"", "2' 10\"", "6' 20\"", 10 });
            level_list.Add(812, new object[] { "goliath", "1' 28\"", "1' 39\"", "2' 01\"", "2' 54\"", "4' 00\"", 16 });
            level_list.Add(818, new object[] { "404", "52\"", "1' 02\"", "1' 24\"", "1' 42\"", "2' 54\"", 11 });
            level_list.Add(802, new object[] { "gears", "1' 35\"", "1' 40\"", "2' 10\"", "2' 40\"", "3' 20\"", 15 });
            level_list.Add(800, new object[] { "fireworks", "1' 50\"", "2' 00\"", "2' 20\"", "3' 10\"", "4' 20\"", 16 });
            level_list.Add(850, new object[] { "zias", "4' 40\"", "5' 00\"", "5' 40\"", "7' 00\"", "9' 20\"", 20 });
            level_list.Add(820, new object[] { "winners", "2' 00\"", "2' 10\"", "3' 00\"", "4' 00\"", "6' 50\"", 12 });

            // extended levels
            level_list.Add(535, new object[] { "first step", "15\"", "18\"", "22\"", "25\"", "29\"", 1 });
            level_list.Add(536, new object[] { "climbing", "28\"", "37\"", "46\"", "55\"", "1' 04\"", 4 });
            level_list.Add(537, new object[] { "moving walls", "29\"", "41\"", "52\"", "1' 04\"", "1' 15\"", 5 });
            level_list.Add(538, new object[] { "click", "45\"", "1' 10\"", "1' 35\"", "2' 00\"", "2' 25\"", 5 });
            level_list.Add(539, new object[] { "black robot", "1' 16\"", "1' 44\"", "2' 11\"", "2' 39\"", "3' 06\"", 10 });
            level_list.Add(541, new object[] { "darkcube", "46\"", "1' 10\"", "1' 34\"", "1' 58\"", "2' 22\"", 5 });
            level_list.Add(500, new object[] { "roots", "1' 13\"", "1' 53\"", "2' 34\"", "3' 13\"", "3' 53\"", 10 });
            level_list.Add(548, new object[] { "flick", "36\"", "1' 06\"", "1' 36\"", "2' 06\"", "2' 36\"", 5 });
            level_list.Add(540, new object[] { "lying bridge", "51\"", "1' 24\"", "1' 56\"", "2' 29\"", "3' 01\"", 15 });
            level_list.Add(556, new object[] { "minicube", "1' 14\"", "1' 48\"", "2' 21\"", "2' 55\"", "3' 28\"", 14 });
            level_list.Add(511, new object[] { "crateria", "1' 33\"", "2' 20\"", "3' 08\"", "3' 55\"", "4' 43\"", 7 });
            level_list.Add(555, new object[] { "furious bot", "1' 28\"", "2' 16\"", "3' 03\"", "3' 51\"", "4' 38\"", 10 });
            level_list.Add(512, new object[] { "stratosphere", "2' 56\"", "3' 58\"", "5' 00\"", "6' 02\"", "7' 04\"", 9 });
            level_list.Add(557, new object[] { "vertical way", "56\"", "1' 31\"", "2' 05\"", "2' 40\"", "3' 14\"", 10 });
            level_list.Add(519, new object[] { "tiny road", "2' 02\"", "3' 14\"", "4' 26\"", "5' 38\"", "6' 50\"", 8 });
            level_list.Add(510, new object[] { "cloudy way", "1' 06\"", "1' 55\"", "2' 45\"", "3' 34\"", "4' 24\"", 7 });
            level_list.Add(526, new object[] { "walled up race", "1' 17\"", "1' 47\"", "2' 18\"", "2' 48\"", "3' 19\"", 20 });
            level_list.Add(508, new object[] { "sugar ground", "1' 58\"", "3' 19\"", "4' 41\"", "6' 01\"", "7' 22\"", 8 });
            level_list.Add(558, new object[] { "cargo", "1' 32\"", "2' 20\"", "3' 07\"", "3' 55\"", "4' 42\"", 12 });
            level_list.Add(546, new object[] { "dark edge time", "2' 08\"", "2' 58\"", "3' 48\"", "4' 38\"", "5' 28\"", 11 });
            level_list.Add(507, new object[] { "trench", "1' 47\"", "2' 27\"", "3' 07\"", "3' 47\"", "4' 27\"", 12 });
            level_list.Add(524, new object[] { "paper wall", "3' 02\"", "4' 28\"", "5' 54\"", "7' 20\"", "8' 46\"", 14 });
            level_list.Add(516, new object[] { "claustrophobia", "2' 26\"", "3' 10\"", "3' 55\"", "4' 39\"", "5' 24\"", 11 });
            level_list.Add(553, new object[] { "electric way", "48\"", "1' 11\"", "1' 33\"", "1' 56\"", "2' 18\"", 8 });
            level_list.Add(509, new object[] { "impulsed maze", "1' 00\"", "1' 39\"", "2' 17\"", "2' 56\"", "3' 34\"", 8 });
            level_list.Add(523, new object[] { "far", "2' 50\"", "3' 55\"", "4' 59\"", "6' 05\"", "7' 10\"", 14 });
            level_list.Add(545, new object[] { "deadly race", "2' 16\"", "2' 48\"", "3' 20\"", "3' 52\"", "4' 24\"", 11 });
            level_list.Add(522, new object[] { "don't click!", "2' 27\"", "4' 58\"", "7' 29\"", "10' 00\"", "12' 31\"", 10 });
            level_list.Add(518, new object[] { "white spring", "2' 52\"", "4' 16\"", "5' 40\"", "7' 04\"", "8' 28\"", 7 });
            level_list.Add(533, new object[] { "hurry", "2' 00\"", "3' 07\"", "4' 14\"", "5' 21\"", "6' 28\"", 13 });
            level_list.Add(528, new object[] { "blind", "2' 05\"", "3' 41\"", "5' 18\"", "6' 53\"", "8' 29\"", 14 });
            level_list.Add(542, new object[] { "wire", "3' 00\"", "3' 46\"", "4' 32\"", "5' 18\"", "6' 04\"", 8 });
            level_list.Add(521, new object[] { "hyperphase", "2' 40\"", "3' 52\"", "5' 04\"", "6' 16\"", "7' 28\"", 20 });
            level_list.Add(532, new object[] { "star factory", "2' 46\"", "3' 33\"", "4' 21\"", "5' 08\"", "5' 56\"", 12 });
            level_list.Add(514, new object[] { "star dust", "2' 24\"", "3' 04\"", "3' 43\"", "4' 24\"", "5' 04\"", 20 });
            level_list.Add(531, new object[] { "destructuring", "2' 33\"", "3' 20\"", "4' 07\"", "4' 54\"", "5' 41\"", 10 });
            level_list.Add(520, new object[] { "black hole", "2' 18\"", "3' 16\"", "4' 14\"", "5' 12\"", "6' 10\"", 10 });
            level_list.Add(600, new object[] { "robot sport", "2' 20\"", "2' 30\"", "3' 00\"", "4' 00\"", "4' 40\"", 17 });
            level_list.Add(525, new object[] { "cubefall", "1' 43\"", "2' 33\"", "3' 23\"", "4' 13\"", "5' 03\"", 16 });
            level_list.Add(517, new object[] { "galaxy rail", "2' 03\"", "2' 52\"", "3' 41\"", "4' 30\"", "5' 19\"", 8 });
            level_list.Add(544, new object[] { "voodoo dance", "3' 22\"", "4' 17\"", "5' 11\"", "6' 06\"", "7' 00\"", 11 });
            level_list.Add(530, new object[] { "highest flag", "3' 02\"", "5' 02\"", "7' 03\"", "9' 02\"", "11' 02\"", 20 });
            level_list.Add(515, new object[] { "geometric snake", "2' 04\"", "3' 05\"", "4' 07\"", "5' 08\"", "6' 10\"", 6 });
            level_list.Add(527, new object[] { "rodeo", "1' 33\"", "3' 12\"", "3' 52\"", "5' 00\"", "6' 09\"", 4 });
            level_list.Add(547, new object[] { "final clash", "3' 49\"", "5' 10\"", "6' 31\"", "7' 52\"", "9' 13\"", 10 });
            level_list.Add(534, new object[] { "pushy", "3' 04\"", "4' 00\"", "4' 56\"", "5' 52\"", "6' 48\"", 17 });
            level_list.Add(551, new object[] { "arksecktor", "2' 24\"", "3' 15\"", "4' 05\"", "4' 56\"", "5' 46\"", 6 });
            level_list.Add(550, new object[] { "timorg", "2' 28\"", "4' 14\"", "6' 00\"", "7' 46\"", "9' 32\"", 15 });

            // extended bonus levels
            level_list.Add(574, new object[] { "crystal mine", "1' 50\"", "2' 34\"", "3' 17\"", "4' 01\"", "4' 45\"", 14 });
            level_list.Add(570, new object[] { "remember", "40\"", "1' 08\"", "1' 37\"", "2' 05\"", "2' 33\"", 9 });
            level_list.Add(572, new object[] { "zero", "52\"", "1' 10\"", "1' 27\"", "1' 45\"", "2' 02\"", 6 });
            level_list.Add(560, new object[] { "the wall", "1' 17\"", "2' 29\"", "3' 41\"", "4' 53\"", "6' 05\"", 7 });
            level_list.Add(563, new object[] { "rush", "1' 23\"", "1' 58\"", "2' 34\"", "3' 11\"", "3' 47\"", 19 });
            level_list.Add(564, new object[] { "cubing machine", "1' 12\"", "2' 02\"", "2' 53\"", "3' 43\"", "4' 33\"", 11 });
            level_list.Add(561, new object[] { "the wall 2", "1' 11\"", "1' 42\"", "2' 13\"", "2' 44\"", "3' 15\"", 5 });
            level_list.Add(567, new object[] { "black way", "1' 21\"", "1' 57\"", "2' 33\"", "3' 10\"", "3' 46\"", 15 });
            level_list.Add(568, new object[] { "curious land", "34\"", "53\"", "1' 13\"", "1' 32\"", "1' 51\"", 4 });
            level_list.Add(562, new object[] { "the wall 3", "2' 09\"", "3' 48\"", "5' 46\"", "7' 35\"", "9' 23\"", 11 });
            level_list.Add(575, new object[] { "little seed", "2' 07\"", "2' 35\"", "2' 55\"", "4' 10\"", "5' 00\"", 20 });
            level_list.Add(569, new object[] { "space noise", "1' 36\"", "2' 13\"", "2' 49\"", "3' 26\"", "4' 02\"", 9 });
            level_list.Add(571, new object[] { "magic maze", "1' 09\"", "1' 53\"", "2' 36\"", "3' 20\"", "4' 03\"", 4 });
            level_list.Add(566, new object[] { "piano", "56\"", "1' 34\"", "2' 11\"", "2' 49\"", "3' 26\"", 14 });
            level_list.Add(573, new object[] { "star heart", "1' 43\"", "2' 40\"", "3' 37\"", "4' 34\"", "5' 31\"", 16 });

            return level_list;
        }

        public static string FormatTime(int time)
        {
            var time_temp = Math.Floor(time / 22.0 * 100) / 100;
            var time_temp_2 = string.Format("{0:00.00}", time_temp % 60);
            var time_final = Math.Floor(time_temp / 60) + "' " + time_temp_2.Replace(".", "\" ");
            return time_final;
        }

        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            LevelData.Rows.Clear();
            Control.Text = "控制方式： ";
            BestEdgeTime.Text = "最佳 Edge Time： ";
            Lang.Text = "语言： ";
            Orientation.Text = "游戏内界面旋转角度： ";
            UserName.Text = "用户名： ";
            PasswordLabel.Text = "密码： ";
            Music.Checked = false;
            Sound.Checked = false;
            Ghost.Checked = false;
            Turbo.Checked = false;
            ReadProfile();
        }

        private void lbEnterProfilePath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                ProfilePath.Text = OpenFileDialog.FileName;
        }

        private void LevelData_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Name == "Number")
            {
                string Cell1 = e.CellValue1.ToString(), Cell2 = e.CellValue2.ToString();
                if (Cell1[0] != Cell2[0])
                    e.SortResult = -string.Compare(Cell1, Cell2);

                if (Cell1[0] == Cell2[0])
                {
                    string[] Cell1SplitArray = ((string)e.CellValue1).Split('#'),
                        Cell2SplitArray = ((string)e.CellValue2).Split('#');

                    e.SortResult = Convert.ToInt32(Cell1SplitArray[1]) < Convert.ToInt32(Cell2SplitArray[1]) ? -1 :
                        Convert.ToInt32(Cell1SplitArray[1]) == Convert.ToInt32(Cell2SplitArray[1]) ? 0 : 1;
                }
            }

            if (e.Column.Name == "Time" || e.Column.Name == "SPlusTime" || e.Column.Name == "STime" ||
                e.Column.Name == "ATime" || e.Column.Name == "BTime" || e.Column.Name == "CTime")
            {
                string Cell1Split = "", Cell2Split = "";

                string[] Cell1SplitArray = ((string)e.CellValue1).Split(new char[3] { '\'', '"', ' ' }),
                    Cell2SplitArray = ((string)e.CellValue2).Split(new char[3] { '\'', '"', ' ' });

                foreach (string i in Cell1SplitArray)
                    Cell1Split += i.ToString();
                foreach (string i in Cell2SplitArray)
                    Cell2Split += i.ToString();

                e.SortResult = Convert.ToInt32(Cell1Split) < Convert.ToInt32(Cell2Split) ? -1 :
                    Convert.ToInt32(Cell1Split) == Convert.ToInt32(Cell2Split) ? 0 : 1;
            }

            if (e.Column.Name == "Prisms")
            {
                e.SortResult = Convert.ToInt32(LevelData.Rows[e.RowIndex1].Cells["PrismsCollected"].Value) -
                    Convert.ToInt32(LevelData.Rows[e.RowIndex2].Cells["PrismsCollected"].Value);
            }

            if (e.Column.Name == "Rank")
            {
                e.SortResult = Convert.ToInt32(LevelData.Rows[e.RowIndex1].Cells["RankIndex"].Value) -
                    Convert.ToInt32(LevelData.Rows[e.RowIndex2].Cells["RankIndex"].Value);
            }

            e.Handled = true;
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            Password.Visible = ShowPassword.Checked;
        }

        private void HowToFindProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mygod.tk/misc/edgefans-archive/edgefans.tk/edge/profile-location.html");
        }

        private void ViewLeaderboard_Click(object sender, EventArgs e)
        {
            int sid;
            if (LevelData.CurrentRow.Cells["Number"].Value.ToString()[0] == 'N')
                sid = 1;
            else
                sid = 9;
            Process.Start("http://www.mobigame.net/index.php?id=1&sid=" + sid + "&action=1&lid=" +
                LevelData.CurrentRow.Cells["ID"].Value);
        }
    }

}
