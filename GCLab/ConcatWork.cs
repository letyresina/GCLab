using System.Text;

namespace GCLab;

// ===================================
// 4) Concatenação de string ineficiente
// ===================================
static class ConcatWork
{
    public static string Bad()
    {
        StringBuilder sb = new StringBuilder();
        string s = string.Empty;
        for (int i = 0; i < 50_000; i++)
            sb.Append (i);
        return s;
    }    
}
