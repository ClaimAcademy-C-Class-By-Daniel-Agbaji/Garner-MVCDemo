using AudioMVC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioMVC.Data
{
    public class AudioInfo : DbContext
    {
        public AudioInfo(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Audio> tblAudioDevices { get; set; }
    }
}
