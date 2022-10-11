namespace EfficiencyOfAlgorithms; 

public class ArrayParam {
    private string name;
    public int[] array { get; }
    public ArrayParam(string name, int[] array) {
        this.name = name;
        this.array = array;
    }

    public override string ToString() {
        return this.name;
    }
}