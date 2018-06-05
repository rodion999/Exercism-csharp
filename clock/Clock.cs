using System;
using System.Text;

public struct Clock
{
    private int _hours, _minutes;

    public Clock(int hours, int minutes)
    {
        _hours = 0;
        _minutes = 0;
        SetTime(hours, minutes);
    }

    public int Hours
    {
        get
        {
            return _hours;
        }
    }

    public int Minutes
    {
        get
        {
            return _minutes;
        }
    }

    public void SetTime(int hours, int minutes)
    {
        int tempHours = minutes / 60;
        minutes %= 60;
        hours = (hours + tempHours) % 24;

        if (hours < 0)
        {
            _hours = 24 + hours;
        }
        else if (hours == 0)
        {
            _hours = 0;
        }
        else
        {
            _hours = hours;
        }

        if (minutes > 0)
        {
            _minutes = minutes;
        }
        else if (minutes == 0)
        {
            _minutes = 0;
        }
        else
        {
            _hours = _hours == 0 ? 23 : _hours - 1;
            _minutes = 60 + minutes;
        }
    }

    public Clock Add(int minutesToAdd)
    {
        SetTime(_hours, _minutes + minutesToAdd);
        return this;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        SetTime(_hours, _minutes - minutesToSubtract);
        return this;
    }

    public override string ToString()
    {
        StringBuilder tempOut = new StringBuilder("");

        tempOut.Append(_hours < 10 ? "0" + _hours.ToString() : _hours.ToString());
        tempOut.Append(":");
        tempOut.Append(_minutes < 10 ? "0" + _minutes.ToString() : _minutes.ToString());
        return tempOut.ToString();
    }
}