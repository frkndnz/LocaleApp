using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocaleApp.Domain.Abstractions;

namespace LocaleApp.Domain.Tests;
public sealed class TestEntity : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Age { get; set; }


}
