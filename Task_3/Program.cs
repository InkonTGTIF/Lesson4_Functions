int [] CreateArray(int minNum, int maxNum, int size){

    int [] array = new int [size];
    for(int i = 0; i<size; i++){
        array[i] = new Random().Next(minNum, maxNum+1);
    }
    return array;
}

void ShowArray(int [] array){
    
    for(int i=0; i<array.Length; i++){
        Console.Write(array[i]+" ");
    }
}

void ShowArrayReverse(int [] array){
    for(int i=array.Length-1; i>=0; i--){
        Console.Write(array[i] + " ");
    }
}

int minNum = 1;
int maxNum = 20;
int size = 10;

int [] array = CreateArray(minNum, maxNum, size);
ShowArray(array);
Console.Write($"=> ");
ShowArrayReverse(array);