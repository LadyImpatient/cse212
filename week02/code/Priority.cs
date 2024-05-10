public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Queue two things with different priority then dequeue. 
        // Expected Result: Higher priority item will be dequeued first
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("Item 1", 3);
        priorityQueue.Enqueue("Item 2", 1);
        Console.WriteLine($"Queue after enqueue: {priorityQueue}");
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}");
        Console.WriteLine($"Queue after dequeue: {priorityQueue}");

        Console.WriteLine("---------");

        // Defect(s) Found: doesn't dequeue item with highest priority

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Enqueue three items with the same priority then dequeue.
        // Expected Result: The item enqueued first should be dequeued first.
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Item 3", 2);
        priorityQueue.Enqueue("Item 4", 2);
        priorityQueue.Enqueue("Item 5", 2);
        Console.WriteLine($"Queue after enqueue: {priorityQueue}");
        Console.WriteLine($"Dequeued item: {priorityQueue.Dequeue()}"); // Defect: Does not properly dequeue the item with the highest priority
        Console.WriteLine($"Queue after dequeue: {priorityQueue}");

        // Defect(s) Found: didn't dequeue first item

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}