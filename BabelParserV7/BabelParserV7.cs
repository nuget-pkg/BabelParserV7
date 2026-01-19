//using static Global.EasyObject;

// ReSharper disable once CheckNamespace
namespace Global;

public class BabelParserV7
{
#pragma warning disable CA1822
    public string Parse(string code, bool includeLocation = false)
#pragma warning restore CA1822
    {
        var assembly = typeof(BabelParserV7).Assembly;
        //Log(assembly.GetManifestResourceNames());
        var text = Sys.ResourceAsText(assembly, "BabelParserV7:https_cdn.jsdelivr.net_npm_@babel_parser@7.28.5_lib_index.js");
        //Echo(text, "text");
        var engine = new EasyScript();
        engine.Execute(text);
        EasyObject result = engine.EvaluateAsEasyObject(
            """
                var ast = parse($1, { plugins: ["typescript"] });
                // Option to turn off start/end/loc on AST @babel/parser produced
                // https://github.com/babel/babel/issues/11239
                const removeASTLocation = ast => {
                   if (ast == null) return;
                   if (Array.isArray(ast)) {
                      ast.forEach(a => removeASTLocation(a));
                   } else if (typeof ast === 'object') {
                      delete ast['loc'];
                      delete ast['start'];
                      delete ast['end'];
                      const values = Object.values(ast).filter(v => Array.isArray(v) || typeof v === 'object');
                      removeASTLocation(values);
                   }
                };

                if (!$2) removeASTLocation(ast);
                
                return ast;
                
                """, code, includeLocation);
        return result.ToJson(indent: true);
    }
}
