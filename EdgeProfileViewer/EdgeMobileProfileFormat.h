struct edge_profile {
        int version;
                // version == 12: Android
                // version == 14: iOS
        char control;
                // control == 0: slide
                // control == 1: tilt
                // control == 2: d-pad
        int unknown_int_1; // 1 or 3
        int unknown_int_2;
        int unknown_int_3;
        bool music;
        bool sound;
        bool unknown_bool_1;
        int best_edge_time;
                // time is saved in frames in profile, the same below
                // time_in_seconds = time_in_frames / 22
        char language;
        int unknown_int_4;
        int unknown_int_5;
        int normal_levels_count;
        level_data *normal_level_data;
        int last_normal_level;
        int unknown_int_6;
        int bonus_levels_count;
        level_data *bonus_level_data;
        int last_bonus_level;
        int unknown_int_7; // always increasing
        int user_name_length;
        char* user_name;
        int password_length;
        char* password;
        bool unknown_bool_2;
        int unknown_int_8;
        int unknown_int_9;
        char d_pad_side;
        /*
                d_pad_side_type == 0:
                        d_pad_side == 0: center
                        d_pad_side == 2: 4 corners
                d_pad_side_type == 1:
                        d_pad_side == 0: left
                        d_pad_side == 1: right
                        d_pad_side == 2: 4 corners
        */
        char d_pad_side_type;
                // orientation == 0 || orientation == 180: 0
                // (orientation == 90 || orientation == 270) && pad side != 0: 1
        bool turbo;
        bool unknown_bool_3;
        bool ghost;
        bool unknown_bool_4;
        int unknown_int_10;
        int orientation;
};

struct level_data {
        int level_id;
        int level_time;
        int prisms_count;
        int rank;
                // rank == 0: D   rank == 1: C   rank == 2: B
                // rank == 3: A   rank == 4: S   rank == 5: S+
}