void SumDigit(){
    while(true){
        string input=Console.ReadLine();
        if(input=="q"){
            break;
        }
    int number;
    if (int.TryParse(input, out number)){
        int sum = 0;
        while(number>0){
            sum+=number%10;
            number/=10;
        }
        if(sum%2==0){
            Console.WriteLine($"{sum} [STOP]");
            break;
        }
    }
    }
}

Console.WriteLine("Enter number or 'q' for exit: ");

SumDigit();