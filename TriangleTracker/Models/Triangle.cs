namespace TriangleTracker
{
  public class Triangle
  {
    public bool AreSidesEqual(int side1, int side2, int side3)
    {
      return ((side1 == side2) && (side2 == side3)) ;
    }
  }
}