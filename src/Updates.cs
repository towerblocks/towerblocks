﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TowerBlocks
{
    class Updates
    {
        #region Fields
        /// <summary>
        /// Level system for the game
        /// </summary>
        public int speedlevel {get; set; }
        public int blocklevel { get; set; }
        public int level { get; set; }
        private const string path = "data.txt";

        #endregion

        /// <summary>
        /// Set everything to default for first time players
        /// </summary>
        public Updates()
        {
            speedlevel = 1;
            blocklevel = 1;
            level = 0;
        }
        
        public bool Load()
        {
            if(File.Exists(path))
            {
                string[] dat = File.ReadAllLines(path);
                string[] splited = dat[0].Split(';');
                try
                {
                    speedlevel = int.Parse(splited[0]);
                    blocklevel = int.Parse(splited[1]);
                    level = int.Parse(splited[2]);
                    return true;
                }
                catch
                {
                    dat[0] = speedlevel.ToString() + ";" + blocklevel.ToString() + ";" + level.ToString();
                    File.WriteAllLines(path, dat);
                    return false;
                }
            }
            else
            {
                StreamWriter w = new StreamWriter(path);
                w.WriteLine(speedlevel.ToString() + ";" + blocklevel.ToString() + ";" + level.ToString());
                w.Close();
                return true;
            }
        }
        public bool save()
        {
            try
            {
                string[] dat = File.ReadAllLines(path);
                dat[0] = speedlevel.ToString() + ";" + blocklevel.ToString() + ";" + level.ToString();
                File.WriteAllLines(path, dat);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
