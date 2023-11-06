using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitasAppAPI.Entities;
public class Photo
{
    public int Id { get; set; }
    public string Url { get; set; }
    public bool IsMain { get; set; }
    public string PublicId { get; set; }

    public int AppUserId { get; set; }
    public User User { get; set; }
}