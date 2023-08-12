using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winuitest2.ViewModels;

public class SomeDataTable
{
    public int Id { get; set; }

    public SomeData[] Data { get; set; } = new SomeData[20]
    {
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
        new SomeData(),
    };
}

public class SomeData
{
    public int Id { get; set; }

    public int Col1 { get; set; }

    public int Col2 { get; set; }

    public int Col3 { get; set; }

    public int Col4 { get; set; }

    public int Col5 { get; set; }

    public int Col6 { get; set; }

    public int Col7 { get; set; }
}

public class TestPageViewModel
{
    public ObservableCollection<SomeDataTable> Tables { get; set; } = new();

    public TestPageViewModel()
    {
        this.Tables.Add(new SomeDataTable());
        this.Tables.Add(new SomeDataTable());
        this.Tables.Add(new SomeDataTable());
    }
}
