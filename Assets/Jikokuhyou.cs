using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jikokuhyou : MonoBehaviour
{

    // sakaihigashi -> tengachaya 6m
    int[][] sakaihigashi_ex = new int[][]
    {
        new int[] {43},
        new int[] {11,21,23,33,35,44,48,54},
        new int[] {3,6,12,14,16,24,26,28,33,36,38,43,46,48,55,58},
        new int[] {3,5,8,15,17,19,27,29,38,40,48,50,57},
        new int[] {2,7,16,18,27,30,36,42,45,54},
        new int[] {0,5,11,18,20,29,34,43,50,55,58},
        new int[] {11,13,20,26,28,41,43,50,56,59},
        new int[] {11,13,20,26,28,35,41,45,50,56,59},
        new int[] {11,13,20,26,28,35,41,45,50,56,59},
        new int[] {11,13,20,16,18,41,43,50,56,59},
        new int[] {11,13,20,16,18,41,43,50,56,59},
        new int[] {11,13,20,26,28,35,43,45,47,56,58},
        new int[] {8,10,19,24,34,36,43,45,53,55,58},
        new int[] {5,7,16,18,26,28,35,37,39,46,48,53,57},
        new int[] {6,8,13,17,23,27,32,36,38,43,49,58},
        new int[] {8,10,12,18,22,32,34,38,45,47,57},
        new int[] {0,10,12,20,24,31,33,38,45,47,55,59},
        new int[] {8,10,12,22,24,33,35,46,50,52},
        new int[] {7,14,25,32},
        new int[] {},
    };

    int[][] sakaihigashi_kakutei = new int[][]
    {
        new int[] {5,29,44,55},
        new int[] {12,24,36,49,57},
        new int[] {7,17,29,39,49,59},
        new int[] {9,21,32,41,51,58},
        new int[] {8,19,31,46,55},
        new int[] {6,21,35,44},
        new int[] {2,14,32,44},
        new int[] {2,14,29,46},
        new int[] {2,14,29,46},
        new int[] {2,14,32,44},
        new int[] {2,14,32,44},
        new int[] {2,14,29,48},
        new int[] {0,11,25,28,37,46,59},
        new int[] {9,21,30,40,49},
        new int[] {0,9,18,28,39,50,59},
        new int[] {13,25,35,48},
        new int[] {1,13,25,34,48},
        new int[] {0,13,25,36,53},
        new int[] {8,26,33,44},
        new int[] {},
    };

    //asakayama -> tengachaya 10m 12m
    int[][] asakayama_ten = new int[][]
    {
        new int[] {7,31,46,57},
        new int[] {14,27,38,51},
        new int[] {0,10,20,32,41,52},
        new int[] {2,11,23,35,44,53},
        new int[] {1,10,21,33,48,58},
        new int[] {9,24,37,47},
        new int[] {4,17,34,46},
        new int[] {5,17,32,48},
        new int[] {5,17,32,48},
        new int[] {5,17,34,47},
        new int[] {5,17,34,47},
        new int[] {5,17,32,51},
        new int[] {2,13,27,30,39,49},
        new int[] {1,12,24,32,43,51},
        new int[] {2,12,21,30,41,52},
        new int[] {2,16,28,37,50},
        new int[] {3,15,27,37,50},
        new int[] {2,13,27,39,55},
        new int[] {10,28,36,46},
        new int[] {},
    };

    //asakayama -> sakaihigashi 3m
    int[][] asakayama_higashi = new int[][]
    {
        new int[] {22,49},
        new int[] {1,18,36,54},
        new int[] {0,13,24,36,43,53},
        new int[] {3,15,25,35,45,56},
        new int[] {6,14,24,33,44,50,58},
        new int[] {9,22,32,44,56},
        new int[] {8,22,35,52},
        new int[] {5,23,36,52},
        new int[] {5,24,36,52},
        new int[] {5,24,36,52},
        new int[] {5,22,36,52},
        new int[] {5,22,36,52},
        new int[] {8,19,32,44,57},
        new int[] {8,18,28,40,50},
        new int[] {1,10,22,30,41,50},
        new int[] {0,9,22,34,44,56},
        new int[] {10,22,32,44,57},
        new int[] {8,22,34,44,57},
        new int[] {8,21,38},
        new int[] {0,16,41}
    };
    //20
    int[][] tengachaya_ex = new int[][]
    {
        new int[] {},
        new int[] {5,21,34,45,57},
        new int[] {0,9,14,19,27,30,40,42,44,50,53,55},
        new int[] {1,3,5,12,14,22,24,26,32,34,43,45,47,52,55},
        new int[] {3,5,12,15,25,31,35,41,45,54},
        new int[] {0,5,7,13,17,23,29,35,41,47,53,59},
        new int[] {7,13,20,22,35,37,43,50,52},
        new int[] {5,7,14,21,23,35,37,43,50,52},
        new int[] {5,7,9,14,21,23,35,37,43,50,52},
        new int[] {5,7,9,14,21,23,35,37,43,50,52},
        new int[] {5,7,14,21,23,35,37,43,50,52},
        new int[] {5,7,14,21,23,35,37,43,50,52},
        new int[] {0,4,10,15,17,23,29,35,40,46,49,53,59},
        new int[] {4,9,13,19,23,29,31,35,41,44,46,52,55},
        new int[] {1,5,11,13,15,21,25,30,32,35,41,45,51,55},
        new int[] {0,5,11,13,17,23,25,29,35,39,41,47,53,55},
        new int[] {1,5,11,13,17,23,29,35,40,46,49,53,59},
        new int[] {5,10,12,17,22,24,29,35,40,42,48,53,59},
        new int[] {5,7,19,21,35,45,52},
        new int[] {15},
    };
    //20
    int[][] tengachaya_kakueki = new int[][]
    {
        new int[] {12,39,51},
        new int[] {8,26,42,50},
        new int[] {3,12,24,33,36,47,59},
        new int[] {9,19,29,40,50},
        new int[] {0,9,18,28,38,48,57},
        new int[] {10,20,32,44,56},
        new int[] {10,25,40,55},
        new int[] {10,26,40,55},
        new int[] {12,26,40,55},
        new int[] {12,26,40,55},
        new int[] {10,26,40,55},
        new int[] {10,26,40,56},
        new int[] {7,20,32,43,56},
        new int[] {6,16,26,38,49,58},
        new int[] {8,18,27,38,48,57},
        new int[] {8,20,32,44,58},
        new int[] {8,20,32,43,56},
        new int[] {8,20,32,45,56},
        new int[] {11,28,48},
        new int[] {6,31}
    };

    public Text jikoku;
    string datetimeStr;
    string datetime_mi;

    void Update()
    {
        datetimeStr = System.DateTime.Now.Hour.ToString();
        datetime_mi = System.DateTime.Now.Minute.ToString();
        jikoku.text = datetimeStr + ":" + datetime_mi;
        //h = System.DateTime.Now.Hour.ToString();
        //print(h);
    }

    string m;
    string h;
    int as_ten_den_time;
    int as_ten_machi_time;
    int as_ten_kakutei = 11;

    int as_higashi_den_time;
    int as_higashi_machi_time;
    int as_higashi_kakutei = 3;

    int higashi_ten_den_time;
    int higashi_ten_machi_time;
    int higashi_ten_ex = 6;

    bool gashi_back;
    bool as_ten_kakutei_flag;
    bool as_higashi_flag;
    bool higashi_ten_flag;
    bool error;

    string kaeri_resolt;
    string money;
    string timemoji;
    public Text bansen;
    public Text train_money;
    public Text time;

    public void OnClick_Kaeri()
    {
        h = System.DateTime.Now.Hour.ToString();
        m = System.DateTime.Now.Minute.ToString();

        int ho = int.Parse(h);
        int mi = int.Parse(m);

        Kaeri(ho, mi);
        if (error)
        {
            kaeri_resolt = "営業時間外です";
        }
        else if (gashi_back == true)
        {
            kaeri_resolt = "1番線";
            timemoji = "発車時刻 " + ho + ":" + as_higashi_den_time;
            money = "電車賃410円";
        }
        else
        {
            kaeri_resolt = "2番線";
            timemoji = "発車時刻 " + ho + ":" + as_ten_den_time;
            money = "電車賃210円";
        }
        print(ho);
        print(mi);
        print(kaeri_resolt);

        bansen.text = kaeri_resolt;
        train_money.text = money;
        time.text = timemoji;
    }

    string timemoji_i;
    string iki_kotoba;
    //public Text iki_text;
    public void OnClik_iki()
    {
        h = System.DateTime.Now.Hour.ToString();
        m = System.DateTime.Now.Minute.ToString();

        int ho = int.Parse(h);
        int mi = int.Parse(m);

        Iki(ho, mi);
        if (error)
        {
            iki_kotoba = "営業時間外です";
        }
        else if (iki_gashiback == true)
        {
            iki_kotoba = "急行 ";
            timemoji_i = "発車時刻 " + ho + ":" + ten_sa_den_time;
            money = "電車賃410円";
        }
        else
        {
            iki_kotoba = "各駅停車 ";
            timemoji_i = "発車時刻 " + ho + ":" + ten_as_den_time;
            money = "電車賃210円";
        }
        print(ho);
        print(mi);
        print(kaeri_resolt);

        bansen.text = iki_kotoba;
        train_money.text = money;
        time.text = timemoji_i;
    }


    public void Kaeri(int hour, int minitu)
    {

        if (hour < 5)
        {
            error = true;
            return;
        }
        else
        {
            hour = hour - 5;
        }

        //askayama kakutei
        for (int i = 0; i < asakayama_ten[hour].Length; i++)
        {
            if (minitu <= asakayama_ten[hour][i])
            {
                as_ten_den_time = asakayama_ten[hour][i];
                as_ten_kakutei_flag = true;
                break;
            }
            else
            {
                as_ten_kakutei_flag = false;
            }
        }
        if (as_ten_kakutei_flag == false && hour + 1 < 20)
        {
            as_ten_den_time = asakayama_ten[hour + 1][0] + 60;
        }

        as_ten_machi_time = as_ten_den_time - minitu;
        //resolt
        as_ten_kakutei = as_ten_kakutei + as_ten_machi_time;

        //higashiback
        //askayama sakaihigashi
        for (int j = 0; j < asakayama_higashi[hour].Length; j++)
        {
            if (minitu <= asakayama_higashi[hour][j])
            {
                as_higashi_den_time = asakayama_higashi[hour][j];
                as_higashi_flag = true;
                break;
            }
            else
            {
                as_higashi_flag = false;
            }
        }
        if (as_higashi_flag == false && hour + 1 < 20)
        {
            as_higashi_den_time = asakayama_higashi[hour + 1][0];
        }
        as_higashi_machi_time = as_higashi_den_time - minitu;
        //resolt
        as_higashi_kakutei = as_higashi_kakutei + as_higashi_machi_time;

        int sum = minitu + as_higashi_kakutei;
        //higashi tengachaya
        for (int k = 0; k < sakaihigashi_ex[hour].Length; k++)
        {
            if (sum <= sakaihigashi_ex[hour][k])
            {
                higashi_ten_den_time = sakaihigashi_ex[hour][k];
                higashi_ten_flag = true;
                break;
            }
            else
            {
                higashi_ten_flag = false;
            }
        }
        if (higashi_ten_flag == false && hour + 1 < 20)
        {
            higashi_ten_den_time = sakaihigashi_ex[hour + 1][0];
        }
        higashi_ten_machi_time = higashi_ten_den_time - minitu - as_higashi_kakutei;
        //resolt
        higashi_ten_ex = higashi_ten_ex + higashi_ten_machi_time;

        //final
        if (as_ten_kakutei < as_higashi_kakutei + higashi_ten_ex)
        {
            gashi_back = false;
        }
        else
        {
            gashi_back = true;
        }

    }

    int ten_sa_den_time;
    int ten_sa_machi_time;
    int ten_sa_ex = 6;
    int ten_sa_sum;
    bool ten_sa_flag;

    int sa_as_den_time;
    int sa_as_machi_time;
    int sa_as_kakutei = 3;
    int sa_as_sum;
    bool sa_as_flag;

    int ten_as_den_time;
    int ten_as_machi_time;
    int ten_as_kakutei = 11;
    int ten_as_sum;
    bool ten_as_flag;

    int iki_gashiback_sum;
    bool iki_gashiback;

    public void Iki(int i_hour, int i_minite)
    {
        if (i_hour < 5)
        {
            error = true;
            return;
        }
        else
        {
            i_hour = i_hour - 5;
        }
        //tengachaya ex
        for (int i = 0; i < tengachaya_ex[i_hour].Length; i++)
        {
            if (i_minite <= tengachaya_ex[i_hour][i])
            {
                ten_sa_den_time = tengachaya_ex[i_hour][i];
                ten_sa_flag = true;
                break;
            }
            else
            {
                ten_sa_flag = false;
            }
        }
        if (ten_sa_flag == false && i_hour + 1 < 20)
        {
            ten_sa_den_time = tengachaya_ex[i_hour + 1][0];
        }
        ten_sa_machi_time = ten_sa_den_time = i_minite;
        //resolt
        ten_sa_sum = ten_sa_ex + ten_sa_machi_time;

        //sakaihigashi kakutei
        for (int j = 0; j < sakaihigashi_kakutei[i_hour].Length; j++)
        {
            if ((i_minite + ten_sa_sum) <= sakaihigashi_kakutei[i_hour][j])
            {
                sa_as_den_time = sakaihigashi_kakutei[i_hour][j];
                sa_as_flag = true;
                break;
            }
            else
            {
                sa_as_flag = false;
            }
        }
        if (sa_as_flag == false && i_hour + 1 < 20)
        {
            sa_as_den_time = sakaihigashi_kakutei[i_hour + 1][0];
        }
        sa_as_machi_time = sa_as_den_time - i_minite - ten_sa_sum;
        //result
        sa_as_sum = sa_as_machi_time + sa_as_kakutei;

        //gashiback time
        iki_gashiback_sum = sa_as_sum + ten_sa_sum;

        for (int k = 0; k < tengachaya_kakueki[i_hour].Length; k++)
        {
            if (i_minite <= tengachaya_kakueki[i_hour][k])
            {
                ten_as_den_time = tengachaya_kakueki[i_hour][k];
                ten_as_flag = true;
                break;
            }
            else
            {
                ten_as_flag = false;
            }
        }
        if (ten_as_flag == false && i_hour + 1 < 20)
        {
            ten_as_den_time = tengachaya_kakueki[i_hour + 1][0];
        }
        ten_as_machi_time = ten_sa_den_time = i_minite;
        //result
        ten_as_sum = ten_sa_machi_time + ten_as_kakutei;

        if (iki_gashiback_sum < ten_as_sum)
        {
            iki_gashiback = true;
        }
        else
        {
            iki_gashiback = false;
        }
    }


}