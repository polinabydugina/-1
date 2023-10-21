class figyri
{
    public int x;
    public int y;

    public figyri(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

}
class Korol : figyri
{
    public Korol(int x, int y) : base(x, y) { }
    public bool Move(int newx, int newy)
    {
        if ((newx == x + 1 && newy == y) || (newx == x - 1 && newy == y) || (newy == y - 1 && newx == x) || (newy == y + 1 && newx == x) || (newx == x + 1 && newy == y + 1) || (newx == x - 1 && newy == y - 1) || (newy == y - 1 && newx == x + 1) || (newy == y + 1 && newx == x - 1))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
class fers : figyri
{
    public fers(int x, int y) : base(x, y) { }
    public bool Move(int newx, int newy)
    {
        int a = 0;
        if (newx - x == newy - y) { a = newx - x; }
        else if (newx - x == y - newx) { a = newx - x; }
        if ((newx <= x + 7 && newy == y) ||
            (newx >= x - 7 && newy == y) ||
            (newx == x && newy <= y + 7) ||
            (newx == x && y >= y - 7) ||
            (newx == x + a && newy == y + a) ||
            (newx == x - a && newy == y - a) ||
            (newx == x - a && newy == y + a) ||
            (newx == x + a && newy == y - a))
        {
            return true;
        }
        return false;
    }
}
class pescha : figyri
{
    public pescha(int x, int y) : base(x, y) { }
    public bool Move(int newx, int newy)
    {
        if (newx == x && (newy == y + 1 || (newy == y + 2 && y == 2)))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
class ladia : figyri
{
    public ladia(int x, int y) : base(x, y) { }
    public bool Move(int newx, int newy)
    {
        if ((newx <= x + 7 && newy == y) || (newx >= x - 7 && newy == y) || (newx == x && newy <= y + 7) || (newx == x && y >= y - 7))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class slon : figyri
{
    public slon(int x, int y) : base(x, y) { }
    public bool Move(int newx, int newy)
    {
        {
            int a = 0;
            if (newx - x == newy - y) { a = newx - x; }
            else if (newx - x == y - newy) { a = newx - x; }

            if ((newx == x + a && newy == y + a) ||
                (newx == x - a && newy == y - a) ||
                (newx == x - a && newy == y + a) ||
                (newx == x + a && newy == y - a))
            {
                return true;
            }
            return false;
        }
    }
}
class kon : figyri
{
    public kon(int x, int y) : base(x, y) { }
    public bool Move(int newx, int newy)
    {
        if ((newy == y + 2 && newx == x + 1) || (newy == y + 2 && newx == x - 1) || (newy == y - 2 && newx == x + 1) || (newy == y - 2 && newx == x - 1) || (newy == y + 1 && newx == x + 2) || (newy == y + 1 && newx == x - 2) || (newy == y - 1 && newx == x + 2) || (newy == y - 1 && newx == x - 2))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}