using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlappyBirdDemo.Web.Models
{
    public class BirdModel
    {
        public int DistanceFromGound { get; set; } = 100;
        public int JumpStrength { get; private set; } = 50;

        public bool IsOnGround()
        {
            return DistanceFromGound <= 0;
        }

        public void Fall(int gravity)
        {
            DistanceFromGound -= Math.Min(gravity, DistanceFromGound);
        }

        public void Jump()
        {
            if (DistanceFromGound <= 530)
            {

                DistanceFromGound += JumpStrength;

            }
        }
    }
}
