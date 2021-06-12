using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minigame
{
    public class Base
    {
        public Base(int hp, int bullet, int bomb, int bulletdamage, int bombdamage, int movespeed, bool Alive)
        {
            HP = hp;
            bullets = bullet;
            bombs = bomb;
            bulletDamage = bulletdamage;
            bombDamage = bombdamage;
            moveSpeed = movespeed;
            alive = Alive;
        }
        [Range(0, 100), Required]
        public int HP { set; get; }
        [Range(0, 99), Required]
        public int bullets { set; get; }
        [Range(0, 99), Required]
        public int bombs { set; get; }
        [Required]
        public int bulletDamage { set; get; }
        [Required]
        public int bombDamage { set; get; }
        [Required]
        public int moveSpeed { set; get; }
        [Required]
        public static bool alive { set; get; }

    }
}
