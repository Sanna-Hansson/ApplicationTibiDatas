﻿

using System.ComponentModel.DataAnnotations;

namespace ApplicationTibiDatas.Entities;

public class CategoryEntity
{
    [Key]
    public int Id { get; set; }
    public string CategoryName { get; set; } = null!;


}
