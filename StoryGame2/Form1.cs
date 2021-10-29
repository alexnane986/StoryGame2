using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace StoryGame2
{
    public partial class Form1 : Form
    {
        int page = 1;
        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "You and your friends Mark and Adam, come across a haunted house. Do you enter?";
            optionAOutputLabel.Text = "Yes";
            optionBOutputLabel.Text = "No";
            optionCOutputLabel.Text = "";

        }

        private void optionButtonA_Click(object sender, EventArgs e)
        {
            if (page == 1) { page = 2; }
            else if (page == 2) { page = 4; }
            else if (page == 3) { page = 1; }
            else if (page == 4) { page = 6; }
            else if (page == 5) { page = 9; }
            else if (page == 6) { page = 1; }
            else if (page == 7) { page = 1; }
            else if (page == 8) { page = 11; }
            else if (page == 9) { page = 1; }
            else if (page == 10) { page = 13; }
            else if (page == 11) { page = 15; }
            else if (page == 12) { page = 1; }
            else if (page == 13) { page = 1; }
            else if (page == 14) { page = 17; }
            else if (page == 15) { page = 1; }
            else if (page == 16) { page = 20; }
            else if (page == 17) { page = 1; }
            else if (page == 18) { page = 1; }
            else if (page == 19)
            {
                Random randGen = new Random();

                int randValue = randGen.Next(1, 11);
                if (randValue <= 5)
                {
                    page = 22;
                }
                else
                {
                    page = 23;
                }
            }
            else if (page == 20) { page = 99; }
            else if (page == 21) { page = 99; }
            else if (page == 22) { page = 1; }
            else if (page == 23) { page = 1; }

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You and your friends Mark and Adam, come across a haunted house. Do you enter?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 2:
                    outputLabel.Text = "You walk in. Adam wants to explore upstairs and Mark wants to explore downstairs. Your friends want your vote";
                    optionAOutputLabel.Text = "Downstairs";
                    optionBOutputLabel.Text = "Upstairs";
                    break;
                case 3:
                    outputLabel.Text = "Your friends call you a baby and enter without you. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "You walk downstairs. It's dark, you guys have no light source but continue to explore. You lose track of your friends";
                    optionAOutputLabel.Text = "Call for Mark";
                    optionBOutputLabel.Text = "Call for Adam";
                    optionCOutputLabel.Text = "Go home";
                    break;
                case 5:
                    outputLabel.Text = "You walk upstairs. You guys notice a creepy doll. Do you examine it or ignore it?";
                    optionAOutputLabel.Text = "Examine";
                    optionBOutputLabel.Text = "Ignore";
                    break;
                case 6:
                    outputLabel.Text = "You call for Mark and find him. Turns out it's not Mark and it's a ghost. You die of fear. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    optionCOutputLabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "Mark and Adam are possessed by ghosts and you also become a ghost and forever live in the haunted house. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    optionCOutputLabel.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "You call for Adam and turns out your two friends are already together. Your friends want to keep exploring but you feel really scared";
                    optionAOutputLabel.Text = "Keep exploring";
                    optionBOutputLabel.Text = "Insist on going home";
                    optionCOutputLabel.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "The doll is alive! It scares you and your friends to death. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "You ignore the doll but Adam doesn't follow you guys and looks like he really wants to examine the doll";
                    optionAOutputLabel.Text = "Let him examine";
                    optionBOutputLabel.Text = "Force him to follow";
                    break;
                case 11:
                    outputLabel.Text = "You keep exploring and a ghost appears!";
                    optionAOutputLabel.Text = "Attack";
                    optionBOutputLabel.Text = "Run";
                    break;
                case 12:
                    outputLabel.Text = "Your friends call you a baby and continue to explore without you. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "Adam gets possessed by the doll and stabs you and Mark to death. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 14:
                    outputLabel.Text = "You force Adam to follow you guys. While exploring you guys get hungry. A ghost comes by and offers the following: Apple slices, crackers, and a granola bar";
                    optionAOutputLabel.Text = "Apple slices";
                    optionBOutputLabel.Text = "Granola bars";
                    optionCOutputLabel.Text = "Crackers";
                    break;
                case 15:
                    outputLabel.Text = "The ghost is immune to physical attacks. You and your friends die. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 16:
                    outputLabel.Text = "You run away from the ghost and bump into a stray black cat. Do you pet it?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "The apple slices are rotten and you guys starve to death. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    optionCOutputLabel.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "The crackers are expired and you guys die of food poisoning. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    optionCOutputLabel.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "Yum! The granola bar tastes amazing and you and your friends keep exploring and you guys get tired";
                    optionAOutputLabel.Text = "Stay the night";
                    optionBOutputLabel.Text = "Go home";
                    optionCOutputLabel.Text = "";
                    break;
                case 20:
                    outputLabel.Text = "You pet the cat and the house is no longer haunted! You and your friends go home. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 21:
                    outputLabel.Text = "The cat turns into a tiger and attacks you guys. You die. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 22:
                    outputLabel.Text = "You stay the night. Your friends left the house as you slept. You die of loneliness. Play again? ";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 23:
                    outputLabel.Text = "You and your friends decide to go home. You guys had a great time. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing";
                    optionAOutputLabel.Text = "";
                    optionBOutputLabel.Text = "";
                    optionCOutputLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2500);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void optionButtonB_Click(object sender, EventArgs e)
        {
            if (page == 1) { page = 3; }
            else if (page == 2) { page = 5; }
            else if (page == 3) { page = 99; }
            else if (page == 4) { page = 8; }
            else if (page == 5) { page = 10; }
            else if (page == 6) { page = 99; }
            else if (page == 7) { page = 99; }
            else if (page == 8) { page = 12; }
            else if (page == 9) { page = 99; }
            else if (page == 10) { page = 14; }
            else if (page == 11) { page = 16; }
            else if (page == 12) { page = 99; }
            else if (page == 13) { page = 99; }
            else if (page == 14) { page = 19; }
            else if (page == 15) { page = 99; }
            else if (page == 16) { page = 21; }
            else if (page == 17) { page = 99; }
            else if (page == 18) { page = 99; }
            else if (page == 19)
            {
                Random randGen = new Random();

                int randValue = randGen.Next(1, 11);
                if (randValue <= 5)
                {
                    page = 22;
                }
                else
                {
                    page = 23;
                }
            }
            else if (page == 20) { page = 99; }
            else if (page == 21) { page = 99; }
            else if (page == 22) { page = 99; }
            else if (page == 23) { page = 99; }
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You and your friends Mark and Adam, come across a haunted house. Do you enter?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 2:
                    outputLabel.Text = "You walk in. Adam wants to explore upstairs and Mark wants to explore downstairs. Your friends want your vote";
                    optionAOutputLabel.Text = "Downstairs";
                    optionBOutputLabel.Text = "Upstairs";
                    break;
                case 3:
                    outputLabel.Text = "Your friends call you a baby and enter without you. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "You walk downstairs. It's dark, you guys have no light source but continue to explore. You lose track of your friends";
                    optionAOutputLabel.Text = "Call for Mark";
                    optionBOutputLabel.Text = "Call for Adam";
                    optionCOutputLabel.Text = "Go home";
                    break;
                case 5:
                    outputLabel.Text = "You walk upstairs. You guys notice a creepy doll. Do you examine it or ignore it?";
                    optionAOutputLabel.Text = "Examine";
                    optionBOutputLabel.Text = "Ignore";
                    break;
                case 6:
                    outputLabel.Text = "You call for Mark and find him. Turns out it's not Mark and it's a ghost. You die of fear. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    optionCOutputLabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "Mark and Adam are possessed by ghosts and you also become a ghost and forever live in the haunted house. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    optionCOutputLabel.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "You call for Adam and turns out your two friends are already together. Your friends want to keep exploring but you feel really scared";
                    optionAOutputLabel.Text = "Keep exploring";
                    optionBOutputLabel.Text = "Insist on going home";
                    optionCOutputLabel.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "The doll is alive! It scares you and your friends to death. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "You ignore the doll but Adam doesn't follow you guys and looks like he really wants to examine the doll";
                    optionAOutputLabel.Text = "Let him examine";
                    optionBOutputLabel.Text = "Force him to follow";
                    break;
                case 11:
                    outputLabel.Text = "You keep exploring and a ghost appears!";
                    optionAOutputLabel.Text = "Attack";
                    optionBOutputLabel.Text = "Run";
                    break;
                case 12:
                    outputLabel.Text = "Your friends call you a baby and continue to explore without you. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "Adam gets possessed by the doll and stabs you and Mark to death. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 14:
                    outputLabel.Text = "You force Adam to follow you guys. While exploring you guys get hungry. A ghost comes by and offers the following: Apple slices, crackers, and a granola bar";
                    optionAOutputLabel.Text = "Apple slices";
                    optionBOutputLabel.Text = "Granola bars";
                    optionCOutputLabel.Text = "Crackers";
                    break;
                case 15:
                    outputLabel.Text = "The ghost is immune to physical attacks. You and your friends die. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 16:
                    outputLabel.Text = "You run away from the ghost and bump into a stray black cat. Do you pet it?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "The apple slices are rotten and you guys starve to death. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    optionCOutputLabel.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "The crackers are expired and you guys die of food poisoning. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    optionCOutputLabel.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "Yum! The granola bar tastes amazing and you and your friends keep exploring and you guys get tired";
                    optionAOutputLabel.Text = "Stay the night";
                    optionBOutputLabel.Text = "Go home";
                    optionCOutputLabel.Text = "";
                    break;
                case 20:
                    outputLabel.Text = "You pet the cat and the house is no longer haunted! You and your friends go home. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 21:
                    outputLabel.Text = "The cat turns into a tiger and attacks you guys. You die. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 22:
                    outputLabel.Text = "You stay the night. Your friends left the house as you slept. You die of loneliness. Play again? ";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 23:
                    outputLabel.Text = "You and your friends decide to go home. You guys had a great time. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing";
                    optionAOutputLabel.Text = "";
                    optionBOutputLabel.Text = "";
                    optionCOutputLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2500);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void optionButtonC_Click(object sender, EventArgs e)
        {
            if (page == 4) { page = 7; }
            else if (page == 14) { page = 18; }
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You and your friends Mark and Adam, come across a haunted house. Do you enter?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 2:
                    outputLabel.Text = "You walk in. Adam wants to explore upstairs and Mark wants to explore downstairs. Your friends want your vote";
                    optionAOutputLabel.Text = "Downstairs";
                    optionBOutputLabel.Text = "Upstairs";
                    break;
                case 3:
                    outputLabel.Text = "Your friends call you a baby and enter without you. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 4:
                    outputLabel.Text = "You walk downstairs. It's dark, you guys have no light source but continue to explore. You lose track of your friends";
                    optionAOutputLabel.Text = "Call for Mark";
                    optionBOutputLabel.Text = "Call for Adam";
                    optionCOutputLabel.Text = "Go home";
                    break;
                case 5:
                    outputLabel.Text = "You walk upstairs. You guys notice a creepy doll. Do you examine it or ignore it?";
                    optionAOutputLabel.Text = "Examine";
                    optionBOutputLabel.Text = "Ignore";
                    break;
                case 6:
                    outputLabel.Text = "You call for Mark and find him. Turns out it's not Mark and it's a ghost. You die of fear. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    optionCOutputLabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "Mark and Adam are possessed by ghosts and you also become a ghost and forever live in the haunted house. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    optionCOutputLabel.Text = "";
                    break;
                case 8:
                    outputLabel.Text = "You call for Adam and turns out your two friends are already together. Your friends want to keep exploring but you feel really scared";
                    optionAOutputLabel.Text = "Keep exploring";
                    optionBOutputLabel.Text = "Insist on going home";
                    optionCOutputLabel.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "The doll is alive! It scares you and your friends to death. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 10:
                    outputLabel.Text = "You ignore the doll but Adam doesn't follow you guys and looks like he really wants to examine the doll";
                    optionAOutputLabel.Text = "Let him examine";
                    optionBOutputLabel.Text = "Force him to follow";
                    break;
                case 11:
                    outputLabel.Text = "You keep exploring and a ghost appears!";
                    optionAOutputLabel.Text = "Attack";
                    optionBOutputLabel.Text = "Run";
                    break;
                case 12:
                    outputLabel.Text = "Your friends call you a baby and continue to explore without you. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 13:
                    outputLabel.Text = "Adam gets possessed by the doll and stabs you and Mark to death. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 14:
                    outputLabel.Text = "You force Adam to follow you guys. While exploring you guys get hungry. A ghost comes by and offers the following: Apple slices, crackers, and a granola bar";
                    optionAOutputLabel.Text = "Apple slices";
                    optionBOutputLabel.Text = "Granola bars";
                    optionCOutputLabel.Text = "Crackers";
                    break;
                case 15:
                    outputLabel.Text = "The ghost is immune to physical attacks. You and your friends die. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 16:
                    outputLabel.Text = "You run away from the ghost and bump into a stray black cat. Do you pet it?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 17:
                    outputLabel.Text = "The apple slices are rotten and you guys starve to death. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    optionCOutputLabel.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "The crackers are expired and you guys die of food poisoning. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    optionCOutputLabel.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "Yum! The granola bar tastes amazing and you and your friends keep exploring and you guys get tired";
                    optionAOutputLabel.Text = "Stay the night";
                    optionBOutputLabel.Text = "Go home";
                    optionCOutputLabel.Text = "";
                    break;
                case 20:
                    outputLabel.Text = "You pet the cat and the house is no longer haunted! You and your friends go home. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 21:
                    outputLabel.Text = "The cat turns into a tiger and attacks you guys. You die. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 22:
                    outputLabel.Text = "You stay the night. Your friends left the house as you slept. You die of loneliness. Play again? ";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 23:
                    outputLabel.Text = "You and your friends decide to go home. You guys had a great time. Play again?";
                    optionAOutputLabel.Text = "Yes";
                    optionBOutputLabel.Text = "No";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing";
                    optionAOutputLabel.Text = "";
                    optionBOutputLabel.Text = "";
                    optionCOutputLabel.Text = "";
                    Refresh();
                    Thread.Sleep(2500);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
