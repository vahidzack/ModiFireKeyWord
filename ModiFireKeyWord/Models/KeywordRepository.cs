namespace ModiFireKeyWord.Models
{
    public class KeywordRepository
    {
        protected KeywordRepository()
        {
        }
        

        #region ListOfkeyWords
        public static List<Keyword> GetKeywords()
        {
            return new List<Keyword>
        {
            new Keyword { Name = "break ", Description = "The break statement terminates the closest enclosing iteration statement (that is, for, foreach, while, or do loop) or switch statement. The break statement transfers control to the statement that follows the terminated statement, if any. ." },
            new Keyword { Name = "abstract ", Description = "The abstract modifier indicates that the thing being modified has a missing or incomplete implementation. The abstract modifier can be used with classes, methods, properties, indexers, and events. Use the abstract modifier in a class declaration to indicate that a class is intended only to be a base class of other classes, not instantiated on its own. Members marked as abstract must be implemented by non-abstract classes that derive from the abstract class.." },
            new Keyword { Name = "Char", Description = "The char type keyword is an alias for the .NET System.Char structure type that represents a Unicode UTF-16 character.." },
            new Keyword { Name = "checked ", Description = "The checked and unchecked statements specify the overflow-checking context for integral-type arithmetic operations and conversions. When integer arithmetic overflow occurs, the overflow-checking context defines what happens. In a checked context, a System.OverflowException is thrown; if overflow happens in a constant expression, a compile-time error occurs. In an unchecked context, the operation result is truncated by discarding any high-order bits that don't fit in the destination type." },
            new Keyword { Name = "namespace ", Description = "The namespace keyword is used to declare a scope that contains a set of related objects. You can use a namespace to organize code elements and to create globally unique types.." },

        };
        }
        #endregion

    }
}
