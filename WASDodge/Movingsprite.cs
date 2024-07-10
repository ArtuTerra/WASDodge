﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WASDodge
{
    internal class Movingsprite : ScaledSprite
    {
        private float speed;
        public Movingsprite(Texture2D texture, Vector2 position, float speed) : base(texture, position)
        {
            this.speed = speed;
        }
        public override void Update()
        {
            base.Update();
            position.X += speed;
        }
    }
}
