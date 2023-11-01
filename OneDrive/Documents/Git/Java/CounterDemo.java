public class CounterDemo 
{
    public static void main(String[]args)
    {
        Counter counter = new Counter();
        counter.increment();
        counter.increment(3);
        int temp=counter.getCount();
        counter.reset();
        Counter counter2 =new Counter(5);
        counter2.increment();
        Counter counter3=counter2;
        temp=counter3.getCount();
        System.out.println(temp);
        counter3.increment();
        System.out.println(counter2.getCount());
        counter2 = new Counter(80);
        System.out.println(counter3.getCount());
        System.out.println(counter2.getCount());

        
    }
    
}
