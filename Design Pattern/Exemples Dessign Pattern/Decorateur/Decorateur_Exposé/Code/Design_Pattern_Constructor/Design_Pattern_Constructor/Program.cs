using Text;
using Text.Decorator;


//On instencie nos Objets concrets

Title title = new Title();
Chapters chapters = new Chapters();
Paragraphe paragraphe = new Paragraphe();

//On passe le titre en gras
Bold boldTitle = new Bold(title);
Console.WriteLine(boldTitle.SetText());

//On passe le titre en italic

Italic boldAndItalicTitle = new Italic(boldTitle);

string result = boldAndItalicTitle.SetText();
Console.WriteLine(result);

boldAndItalicTitle.DoItalicThings();