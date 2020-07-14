namespace TriangleTracker
{
  public class Triangle
  {
    public bool IsEqualateral(int side1, int side2, int side3)
    {
      return  ((side1 == side2) && (side2 == side3));
    }
    public bool IsIsosceles(int side1, int side2, int side3)
    {
    return ((side1 == side2 || side1 == side3 || side2 == side3));
    }
    public bool IsScalene(int side1, int side2, int side3)
    {
      return false;
    }

  }
}