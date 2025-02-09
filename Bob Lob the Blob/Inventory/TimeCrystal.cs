﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Inventory
{
    public class TimeCrystal : Collectable
    {

        public TimeCrystal(Texture2D texture, Vector2 position)
            : base(texture, position, 1.0f, 0f)
        {
            // Preset to grey to indicate that it is not picked up yet
            colour = Color.Gray;
        }

        public TimeCrystal(Texture2D texture, Vector2 position, float scale, float rotation)
            : base(texture, position, scale, rotation)
        {
            // Preset to grey to indicate that it is not picked up yet
            colour = Color.Gray;
        }

       
        // Used to change the colour of the crystal
        public void ChangeColour(Color color)
        {
            colour = color;
        }

    } //End of Class
} //End of Namespace
