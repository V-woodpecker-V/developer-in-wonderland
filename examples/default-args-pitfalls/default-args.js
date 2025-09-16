// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Functions/Default_parameters#evaluated_at_call_time

function collectNumbers(n, result = []) {
    if (n <= 0) {
        return result;
    }
    
    result.push(n);
    return collectNumbers(n - 1, result);
}

console.log("First call:", collectNumbers(3));
console.log("Second call:", collectNumbers(2));
console.log("Third call:", collectNumbers(4));