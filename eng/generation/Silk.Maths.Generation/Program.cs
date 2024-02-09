using CSharpier;
using Silk.Maths.Generation;

const int MIN_VECTOR = 2;
const int MAX_VECTOR = 4;
const int MIN_MATRIX_ROW = 2;
const int MAX_MATRIX_ROW = 5;
const int MIN_MATRIX_COLUMN = 2;
const int MAX_MATRIX_COLUMN = 4;


BaseVector vector = new(MIN_VECTOR, true, MIN_VECTOR, MAX_VECTOR, MIN_MATRIX_ROW, MAX_MATRIX_ROW, MIN_MATRIX_COLUMN, MAX_MATRIX_COLUMN);
VectorStatics statics = new(MIN_VECTOR, true, MIN_VECTOR, MAX_VECTOR, MIN_MATRIX_ROW, MAX_MATRIX_ROW, MIN_MATRIX_COLUMN, MAX_MATRIX_COLUMN);
for (int dim = MIN_VECTOR; dim <= MAX_VECTOR; dim++)
{
    vector.GenerationEnvironment.Clear();
    statics.GenerationEnvironment.Clear();
    vector.FloatType = statics.FloatType = true;
    vector.Dimension = statics.Dimension = dim;
    File.WriteAllText(vector.Name + ".gen.cs", CodeFormatter.Format(vector.TransformText()).Code);
    File.WriteAllText(vector.Name + ".ops.gen.cs", CodeFormatter.Format(statics.TransformText()).Code);
    statics.GenerationEnvironment.Clear();
    vector.GenerationEnvironment.Clear();
    vector.FloatType = statics.FloatType = false;
    File.WriteAllText(vector.Name + ".gen.cs", CodeFormatter.Format(vector.TransformText()).Code);
    File.WriteAllText(vector.Name + ".ops.gen.cs", CodeFormatter.Format(statics.TransformText()).Code);
}
