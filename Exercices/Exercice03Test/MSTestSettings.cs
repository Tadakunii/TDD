using Exercice03;

[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]

int recherche = 3;
if (recherche > 2)
{
    throw new NotFoundException("re");
}
