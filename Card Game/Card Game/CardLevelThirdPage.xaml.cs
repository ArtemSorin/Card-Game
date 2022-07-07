﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Card_Game
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardLevelThirdPage : ContentPage
    {
        int sorce = 0;
        public CardLevelThirdPage()
        {
            InitializeComponent();

            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("card.mp3");

            bool[] count_correct = new bool[16];
            bool[] count_nonselected = new bool[16];
            for (int i = 0; i < count_correct.Length; i++) { count_correct[i] = false; }
            for (int i = 0; i < count_nonselected.Length; i++) { count_nonselected[i] = true; }

            Sorcepanel.Text = $"Рекорд: {sorce}  / 80";

            change_level.Clicked += (sender, e) => { Navigation.PushAsync(new CardLevelThirdPage()); };
            show_cards.Clicked += (sender, e) => { function_show_cards(); };

            btn_back_1.Clicked += (sender, e) => { player.Play(); function_back_to_front(0, count_nonselected, count_correct, btn_back_1, btn_front_1); };
            btn_front_1.Clicked += (sender, e) => { player.Play(); function_front_to_back(0, count_nonselected, count_correct, btn_front_1, btn_back_1); };
            btn_back_2.Clicked += (sender, e) => { player.Play(); function_back_to_front(1, count_nonselected, count_correct, btn_back_2, btn_front_2); };
            btn_front_2.Clicked += (sender, e) => { player.Play(); function_front_to_back(1, count_nonselected, count_correct, btn_front_2, btn_back_2); };
            btn_back_3.Clicked += (sender, e) => { player.Play(); function_back_to_front(2, count_nonselected, count_correct, btn_back_3, btn_front_3); };
            btn_front_3.Clicked += (sender, e) => { player.Play(); function_front_to_back(2, count_nonselected, count_correct, btn_front_3, btn_back_3); };
            btn_back_4.Clicked += (sender, e) => { player.Play(); function_back_to_front(3, count_nonselected, count_correct, btn_back_4, btn_front_4); };
            btn_front_4.Clicked += (sender, e) => { player.Play(); function_front_to_back(3, count_nonselected, count_correct, btn_front_4, btn_back_4); };
            btn_back_5.Clicked += (sender, e) => { player.Play(); function_back_to_front(4, count_nonselected, count_correct, btn_back_5, btn_front_5); };
            btn_front_5.Clicked += (sender, e) => { player.Play(); function_front_to_back(4, count_nonselected, count_correct, btn_front_5, btn_back_5); };
            btn_back_6.Clicked += (sender, e) => { player.Play(); function_back_to_front(5, count_nonselected, count_correct, btn_back_6, btn_front_6); };
            btn_front_6.Clicked += (sender, e) => { player.Play(); function_front_to_back(5, count_nonselected, count_correct, btn_front_6, btn_back_6); };
            btn_back_7.Clicked += (sender, e) => { player.Play(); function_back_to_front(6, count_nonselected, count_correct, btn_back_7, btn_front_7); };
            btn_front_7.Clicked += (sender, e) => { player.Play(); function_front_to_back(6, count_nonselected, count_correct, btn_front_7, btn_back_7); };
            btn_back_8.Clicked += (sender, e) => { player.Play(); function_back_to_front(7, count_nonselected, count_correct, btn_back_8, btn_front_8); };
            btn_front_8.Clicked += (sender, e) => { player.Play(); function_front_to_back(7, count_nonselected, count_correct, btn_front_8, btn_back_8); };
            btn_back_9.Clicked += (sender, e) => { player.Play(); function_back_to_front(8, count_nonselected, count_correct, btn_back_9, btn_front_9); };
            btn_front_9.Clicked += (sender, e) => { player.Play(); function_front_to_back(8, count_nonselected, count_correct, btn_front_9, btn_back_9); };
            btn_back_10.Clicked += (sender, e) => { player.Play(); function_back_to_front(9, count_nonselected, count_correct, btn_back_10, btn_front_10); };
            btn_front_10.Clicked += (sender, e) => { player.Play(); function_front_to_back(9, count_nonselected, count_correct, btn_front_10, btn_back_10); };
            btn_back_11.Clicked += (sender, e) => { player.Play(); function_back_to_front(10, count_nonselected, count_correct, btn_back_11, btn_front_11); };
            btn_front_11.Clicked += (sender, e) => { player.Play(); function_front_to_back(10, count_nonselected, count_correct, btn_front_11, btn_back_11); };
            btn_back_12.Clicked += (sender, e) => { player.Play(); function_back_to_front(11, count_nonselected, count_correct, btn_back_12, btn_front_12); };
            btn_front_12.Clicked += (sender, e) => { player.Play(); function_front_to_back(11, count_nonselected, count_correct, btn_front_12, btn_back_12); };
            btn_back_13.Clicked += (sender, e) => { player.Play(); function_back_to_front(12, count_nonselected, count_correct, btn_back_13, btn_front_13); };
            btn_front_13.Clicked += (sender, e) => { player.Play(); function_front_to_back(12, count_nonselected, count_correct, btn_front_13, btn_back_13); };
            btn_back_14.Clicked += (sender, e) => { player.Play(); function_back_to_front(13, count_nonselected, count_correct, btn_back_14, btn_front_14); };
            btn_front_14.Clicked += (sender, e) => { player.Play(); function_front_to_back(13, count_nonselected, count_correct, btn_front_14, btn_back_14); };
            btn_back_15.Clicked += (sender, e) => { player.Play(); function_back_to_front(14, count_nonselected, count_correct, btn_back_15, btn_front_15); };
            btn_front_15.Clicked += (sender, e) => { player.Play(); function_front_to_back(14, count_nonselected, count_correct, btn_front_15, btn_back_15); };
            btn_back_16.Clicked += (sender, e) => { player.Play(); function_back_to_front(15, count_nonselected, count_correct, btn_back_16, btn_front_16); };
            btn_front_16.Clicked += (sender, e) => { player.Play(); function_front_to_back(15, count_nonselected, count_correct, btn_front_16, btn_back_16); };
        }
        private async void function_back_to_front(int number, bool[] count_nonselected, bool[] count_correct, ImageButton btn_back, ImageButton btn_front)
        {
            await btn_back.RotateYTo(90, 150);
            await btn_front.RotateYTo(0, 150);
            count_correct[number] = true;
            count_nonselected[number] = false;

            int count = 0;

            for (int i = 0; i < count_correct.Length; i++)
            {
                if (count_correct[i])
                {
                    count++;
                }
            }

            if (count > 1)
            {
                if (count_correct[0] && count_correct[10])
                {
                    btn_front_1.IsEnabled = false;
                    btn_front_11.IsEnabled = false;

                    count_correct[0] = false;
                    count_correct[10] = false;
                    sorce += 10;
                }
                else if (count_correct[1] && count_correct[8])
                {
                    btn_front_2.IsEnabled = false;
                    btn_front_9.IsEnabled = false;

                    count_correct[1] = false;
                    count_correct[8] = false;
                    sorce += 10;
                }
                else if (count_correct[2] && count_correct[12])
                {
                    btn_front_3.IsEnabled = false;
                    btn_front_13.IsEnabled = false;

                    count_correct[2] = false;
                    count_correct[12] = false;
                    sorce += 10;
                }
                else if (count_correct[3] && count_correct[15])
                {
                    btn_front_4.IsEnabled = false;
                    btn_front_16.IsEnabled = false;

                    count_correct[3] = false;
                    count_correct[15] = false;
                    sorce += 10;
                }
                else if (count_correct[4] && count_correct[6])
                {
                    btn_front_5.IsEnabled = false;
                    btn_front_7.IsEnabled = false;

                    count_correct[4] = false;
                    count_correct[6] = false;
                    sorce += 10;
                }
                else if (count_correct[5] && count_correct[14])
                {
                    btn_front_6.IsEnabled = false;
                    btn_front_15.IsEnabled = false;

                    count_correct[5] = false;
                    count_correct[14] = false;
                    sorce += 10;
                }
                else if (count_correct[7] && count_correct[9])
                {
                    btn_front_8.IsEnabled = false;
                    btn_front_10.IsEnabled = false;

                    count_correct[7] = false;
                    count_correct[9] = false;
                    sorce += 10;
                }
                else if (count_correct[11] && count_correct[13])
                {
                    btn_front_12.IsEnabled = false;
                    btn_front_14.IsEnabled = false;

                    count_correct[11] = false;
                    count_correct[13] = false;
                    sorce += 10;
                }
                else
                {
                    await btn_front.RotateYTo(90, 150);
                    await btn_back.RotateYTo(0, 150);

                    count_correct[number] = false;
                    count_nonselected[number] = true;

                    sorce -= 5;
                }
            }

            if (sorce == 80)
            {
                await DisplayAlert("", "Уровень пройден!", "ок");
                change_level.IsEnabled = true;
            }

            Sorcepanel.Text = $"Рекорд: {sorce} / 80";
        }
        private async void function_front_to_back(int number, bool[] count_nonselected, bool[] count_correct, ImageButton btn_front, ImageButton btn_back)
        {
            await btn_front.RotateYTo(90, 150);
            await btn_back.RotateYTo(0, 150);
            count_correct[number] = false;
            count_nonselected[number] = true;

            Sorcepanel.Text = $"Рекорд: {sorce} / 80";
        }
        private async void function_show_cards()
        {
            await btn_back_1.RotateYTo(90, 150);
            await btn_front_1.RotateYTo(0, 150);

            await btn_back_2.RotateYTo(90, 150);
            await btn_front_2.RotateYTo(0, 150);

            await btn_back_3.RotateYTo(90, 150);
            await btn_front_3.RotateYTo(0, 150);

            await btn_back_4.RotateYTo(90, 150);
            await btn_front_4.RotateYTo(0, 150);

            await btn_back_5.RotateYTo(90, 150);
            await btn_front_5.RotateYTo(0, 150);

            await btn_back_6.RotateYTo(90, 150);
            await btn_front_6.RotateYTo(0, 150);

            await btn_back_7.RotateYTo(90, 150);
            await btn_front_7.RotateYTo(0, 150);

            await btn_back_8.RotateYTo(90, 150);
            await btn_front_8.RotateYTo(0, 150);

            await btn_back_9.RotateYTo(90, 150);
            await btn_front_9.RotateYTo(0, 150);

            await btn_back_10.RotateYTo(90, 150);
            await btn_front_10.RotateYTo(0, 150);

            await btn_back_11.RotateYTo(90, 150);
            await btn_front_11.RotateYTo(0, 150);

            await btn_back_12.RotateYTo(90, 150);
            await btn_front_12.RotateYTo(0, 150);

            await btn_back_13.RotateYTo(90, 150);
            await btn_front_13.RotateYTo(0, 150);

            await btn_back_14.RotateYTo(90, 150);
            await btn_front_14.RotateYTo(0, 150);

            await btn_back_15.RotateYTo(90, 150);
            await btn_front_15.RotateYTo(0, 150);

            await btn_back_16.RotateYTo(90, 150);
            await btn_front_16.RotateYTo(0, 150);

            await btn_front_1.RotateYTo(90, 150);
            await btn_back_1.RotateYTo(0, 150);

            await btn_front_2.RotateYTo(90, 150);
            await btn_back_2.RotateYTo(0, 150);

            await btn_front_3.RotateYTo(90, 150);
            await btn_back_3.RotateYTo(0, 150);

            await btn_front_4.RotateYTo(90, 150);
            await btn_back_4.RotateYTo(0, 150);

            await btn_front_5.RotateYTo(90, 150);
            await btn_back_5.RotateYTo(0, 150);

            await btn_front_6.RotateYTo(90, 150);
            await btn_back_6.RotateYTo(0, 150);

            await btn_front_7.RotateYTo(90, 150);
            await btn_back_7.RotateYTo(0, 150);

            await btn_front_8.RotateYTo(90, 150);
            await btn_back_8.RotateYTo(0, 150);

            await btn_front_9.RotateYTo(90, 150);
            await btn_back_9.RotateYTo(0, 150);

            await btn_front_10.RotateYTo(90, 150);
            await btn_back_10.RotateYTo(0, 150);

            await btn_front_11.RotateYTo(90, 150);
            await btn_back_11.RotateYTo(0, 150);

            await btn_front_12.RotateYTo(90, 150);
            await btn_back_12.RotateYTo(0, 150);

            await btn_front_13.RotateYTo(90, 150);
            await btn_back_13.RotateYTo(0, 150);

            await btn_front_14.RotateYTo(90, 150);
            await btn_back_14.RotateYTo(0, 150);

            await btn_front_15.RotateYTo(90, 150);
            await btn_back_15.RotateYTo(0, 150);

            await btn_front_16.RotateYTo(90, 150);
            await btn_back_16.RotateYTo(0, 150);

            show_cards.IsEnabled = false;
        }
    }
}