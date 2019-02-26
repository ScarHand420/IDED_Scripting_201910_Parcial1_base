namespace Scripting_201910_Parcial1_base.Logic
{
    public abstract class Part
    {
        protected float speedBonus;

        private float durability = 1;

        public int Level { get; protected set; }
        public abstract VehicleType Type { get; }

        public float SpeedBonus
        {
            get
            {
                //return 0F;
                //return (Durability > 0) ? speedBonus * Durability : speedBonus;
                if (speedBonus >= 0.5f)
                {
                    return speedBonus = 0.5f;
                }
                else
                {
                    if (Durability > 0)
                    {
                        return speedBonus = speedBonus * Durability;
                    }
                    else
                    {
                        return speedBonus;
                    }
                }
            }
            protected set { speedBonus = value; }
        }

        public float Durability { get => durability; /*set => durability = value;*/ }

        public Part()
        {
        }

        public Part(float speedBonus)
        {
            SpeedBonus = speedBonus;
        }

        public void Upgrade()
        {
            if (Level <= 3)
            {
                Level++;
                SpeedBonus = SpeedBonus + (SpeedBonus * 0.03f);
            }
        }
    }
}