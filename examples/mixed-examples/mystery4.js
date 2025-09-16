function mystery() {
    const scores = {"Alice": 85, "Bob": 92, "Charlie": 78, "Diana": 96};
    let highest = "";
    let maxScore = 0;
    
    for (let student in scores) {
        if (scores[student] > maxScore) {
            maxScore = scores[student];
            highest = student;
        }
    }
    
    return highest;
}

console.log(mystery());