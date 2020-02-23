using System.Collections.Generic;

enum EnumStrategies
{
    AS_STRING = 0,
    AS_LIST = 1
}

interface IGetData<T>
{

    List<T> Data { get; }

    string getData();
}

class AsListStrategy<T> : IGetData<T>
{
    public List<T> Data { get; }
    public AsListStrategy(List<T> t)
    {
        this.Data = t;
    }
    public string getData()
    {
        return "AsListStrategy";
    }
}

class AsStringStrategy<T> : IGetData<T>
{
    public List<T> Data { get; }

    public AsStringStrategy(List<T> t)
    {
        this.Data = t;
    }
    public string getData()
    {
        return "AsStringStrategy";
    }

}

class StrategyFactory<T>
{
    private List<T> _data;
    public StrategyFactory(List<T> t)
    {
        _data = t;
    }
    public IGetData<T> getStrategy(EnumStrategies strategyType)
    {
        if (strategyType == EnumStrategies.AS_LIST)
        {
            return new AsListStrategy<T>(_data);
        }
        else if (strategyType == EnumStrategies.AS_STRING)
        {
            return new AsStringStrategy<T>(_data);
        }
        else
        {
            throw new System.Exception("wrong strategy passed");
        }
    }
}