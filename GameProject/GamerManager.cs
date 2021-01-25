using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IProjectManagerService
    {
        public void Add()
        {
            Console.WriteLine("Oyuncu eklendi");
        }
            public void Delete()
        {
            Console.WriteLine("Oyuncu silindi");
        }

        public void Update()
        {
            Console.WriteLine("Oyuncu bilgileri güncellendi");
        }
    }
}
