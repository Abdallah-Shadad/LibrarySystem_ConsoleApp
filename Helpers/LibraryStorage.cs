using CALibraryManagementSystem.Models;

namespace CALibrary.Helpers
{
    public static class LibraryStorage
    {
        // A single shared Library instance for the whole application
        public static Library SharedLibrary { get; } = new Library();
    }
}
