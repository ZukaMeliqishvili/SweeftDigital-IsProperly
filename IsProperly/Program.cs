static bool IsProperly(string sequence)
{
    int n = 0;
    foreach (char c in sequence)
    {
        if (n < 0)
        {
            return false;
        }
        int x = (c == '(' ? 1 : -1);
        n += x;
    }
    if (n == 0)
    {
        return true;
    }
    return false;
}
