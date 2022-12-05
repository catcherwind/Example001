int[] FillingArray(int n){
    Random rnd = new Random();
    int[] arr = new int[n];
    for(int i = 0; i < n; i++){
        arr[i] = rnd.Next(0,2);
    }
    return arr;
}

int[] arr = FillingArray(8);
Console.WriteLine(String.Join(" ", arr));