# Part 03 — Answers

## BlockedUsers

- **Time complexity before:** O(n × m), where n is the number of blocked IDs and m is the number of requests, because `List.Contains()` performs a linear search for each request.

- **Time (ms) before:** Record the measured time from the original program before applying the optimization.

- **What did you change?** I changed the blocked IDs lookup from a `List<int>` search to a `HashSet<int>`. This makes checking whether an ID is blocked much faster on average.

- **Time complexity after:** O(n + m) on average, including the time required to build the `HashSet`.

- **Time (ms) after:** Record the measured time after applying the optimization. The actual time depends on the machine and runtime environment.

## Students

- **What was the problem?** The `GetAllStudents()` method created and stored one million `Student` objects in a list, even though the program printed only the first three students. This wasted memory and processing time.

- **What did you change?** I changed `GetAllStudents()` to return `IEnumerable<Student>` and used `yield return` to generate students on demand. This allows the program to create only the students it needs. When the loop stops after three students, only three student objects are generated.