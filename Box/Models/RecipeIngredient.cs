namespace Box.Models
{
  public class RecipeIngredient
  {
    public int RecipeIngredientId { get; set; }
    public int IngredientId { get; set; }
    public int RecipeId { get; set; }
    public Ingredient Ingredient { get; set; }
    public Recipe Recipe { get; set; }
  }
}