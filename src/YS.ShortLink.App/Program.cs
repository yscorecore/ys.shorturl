﻿using YS.Knife.Hosting;
using YS.Sequence.Impl.EFCore.MySql;

namespace YS.ShortLink.App
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            KnifeWebHost.Start(args);
        }
    }
}
